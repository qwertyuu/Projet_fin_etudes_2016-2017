(function ($) {

    //Notification handler
    abp.event.on('abp.notifications.received', function (userNotification) {
        abp.notifications.showUiNotifyForUserNotification(userNotification);
    });

    //serializeFormToObject plugin for jQuery
    $.fn.serializeFormToObject = function () {
        //serialize to array
        var data = $(this).serializeArray();

        //add also disabled items
        $(':disabled[name]', this).each(function () {
            data.push({ name: this.name, value: $(this).val() });
        });

        //map to object
        var obj = {};
        data.map(function (x) { obj[x.name] = x.value; });

        return obj;
    };

    //Configure blockUI
    if ($.blockUI) {
        $.blockUI.defaults.baseZ = 2000;
    }

    $("[title=\"Supprimer\"]").click(function (e) {
        if (!confirm("Êtes-vous sur de vouloir supprimer cet élément?")) {
            e.preventDefault();
        }
    });

    $("[title=\"SupprimerAppel\"]").click(function (e) {
        if (!confirm("Si vous supprimez cet appel d'offre il sera suprimé definitivement ou son statut tombera à Annulé en fonction de son statut présent.\nÊtes-vous sur de vouloir le faire?")) {
            e.preventDefault();
        }
    });

    $(".dp").datepicker({ dateFormat: 'yy/mm/dd' });

    //désactiver le lien 
    $("#AppelComplete").click(function (event) {
        return false;
    });

    //validation des champs
    $(".valid").closest("form").submit(function (e) {
        if (!validerChamps(this)) {
            return false;
        }
        else {
            Sanitariser(this);
        }
        return true;
    });




})(jQuery);

function Sanitariser(f) {
    var ins = $(f).find("input,textarea").not("[type=\"hidden\"],[type=\"file\"]");
    ins.each(function () {
        var e = $(this);
        if (e.hasClass("cp")) {
            e.val(formatCodePostal($(this).val().trim()));
        }
        else if (e.hasClass("dp")) {
            e.val(trimChar($(this).val().trim(), "/"));
        }
        else if (e.hasClass("tel")) {
            e.val(formatTel($(this).val().trim()));
        }
        else {
            e.val($(this).val().trim());
        }
    });
}

function trimChar(string, charToRemove) {
    while (string.charAt(0) == charToRemove) {
        string = string.substring(1);
    }

    while (string.charAt(string.length - 1) == charToRemove) {
        string = string.substring(0, string.length - 1);
    }

    return string;
}

function formatCodePostal(code) {
    var charAccepte = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".split('');
    var codePostFinal = [];
    var i = code.length;
    while (i--) {
        if (charAccepte.indexOf(code[i].toUpperCase()) != -1) {
            codePostFinal.push(code[i].toUpperCase());
        }
    }
    return codePostFinal.reverse().join('');
}

function formatTel(tel) {
    var charAccepte = "0123456789".split('');
    var noTelFinal = [];
    var i = tel.length;
    while (i--) {
        if (charAccepte.indexOf(tel[i]) != -1) {
            noTelFinal.push(tel[i]);
        }
    }
    return noTelFinal.reverse().join('');
}

function validerDates(form) {
    var dates = $(form).find("input.dp");
    var toReturn = true;
    dates.each(function () {
        var date = $(this).val().trim();
        if (!date) {
            return true;
        }
        if (!isFinite(new Date(date))) {
            alert("La date n'a pas le bon format!\nAAAA/MM/JJ");
            toReturn = false;
            return;
        }
    });
    if (!toReturn) {
        return false;
    }
    return true;
}

function validerNoTel(form) {
    var noTels = $(form).find("input.tel");
    var valide = true;
    noTels.each(function () {
        var noTel = $(this).val().trim();
        if (!noTel) {
            return true;
        }
        var charAccepte = "0123456789".split('');
        var noTelFinal = [];
        var i = noTel.length;
        while (i--) {
            if (charAccepte.indexOf(noTel[i]) != -1) {
                noTelFinal.push(noTel[i]);
            }
        }
        if (noTelFinal.length != 10) {
            alert("Le numéro de téléphone est invalide.\nN'oubliez pas l'indicatif régional.");
            valide = false;
            return;
        }
    });
    if (!valide) {
        return false;
    }
    return true;
}

function validerCodePostal(form) {
    var codePosts = $(form).find("input.cp");
    var valide = true;
    codePosts.each(function () {
        var codePost = $(this).val().trim();
        if (!codePost) {
            return true;
        }
        var charAccepte = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".split('');
        var codePostFinal = [];
        var i = codePost.length;
        while (i--) {
            if (charAccepte.indexOf(codePost[i].toUpperCase()) != -1) {
                codePostFinal.push(codePost[i].toUpperCase());
            }
        }
        if (codePostFinal.length == 6) {
            if (!/[A-Z][0-9][A-Z][0-9][A-Z][0-9]/g.test(codePostFinal.reverse().join(''))) {
                alert("Le code postal est invalide.");
                valide = false;
                return;
            }
        }
        else {
            alert("Le code postal est invalide.");
            valide = false;
            return;
        }
    });
    if (!valide) {
        return false;
    }
    return true;
}

function validerPoste(form) {
    var postes = $(form).find("input.poste");
    var valide = true;
    postes.each(function () {
        var poste = $(this).val().trim();
        if (!poste) {
            return true;
        }
        var charAccepte = "0123456789".split('');
        var posteFinal = [];
        var i = poste.length;
        while (i--) {
            if (charAccepte.indexOf(poste[i].toUpperCase()) != -1) {
                posteFinal.push(poste[i].toUpperCase());
            }
        }
        if (posteFinal.length > 5) {
            valide = false;
            alert("Le poste est trop long");
            return;
        }
    });
    if (!valide) {
        return false;
    }
    return true;
}

function validerCourriel(form) {
    var courriels = $(form).find("input.courriel");
    var valide = true;
    courriels.each(function () {
        var courriel = $(this).val().trim();
        if (!courriel) {
            return true;
        }
        if (!/^[a-z0-9_\-\.]{2,}@[a-z0-9_\-\.]{2,}\.[a-z]{2,}$/i.test(courriel)) {
            valide = false;
            alert("Le courriel n'est pas valide");
            return;
        }
    });
    if (!valide) {
        return false;
    }
    return true;
}

function validerURL(form) {
    var URLs = $(form).find("input.url");
    var valide = true;
    URLs.each(function () {
        var URL = $(this).val().trim();
        if (!URL) {
            return true;
        }
        if (!/(http(s)?:\/\/.)?(www\.)?[-a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)/i.test(URL)) {
            valide = false;
            alert("Le lien entré n'est pas valide");
            return;
        }
    });
    if (!valide) {
        return false;
    }
    return true;
}

function validerIntPositif(form) {
    var entiers = $(form).find("input.positif");
    var valide = true;
    entiers.each(function () {
        var entier = $(this).val().trim();
        if (!entier) {
            return true;
        }
        var entierParsed = parseInt(entier);
        if (!entierParsed || entierParsed < 0) {
            valide = false;
            alert("Le champ doit être positif");
            return;
        }
    });
    if (!valide) {
        return false;
    }
    return true;
}

function validerSelect(form) {
    var selects = $(form).find("select.select");
    var valide = true;
    selects.each(function () {
        var select = $(this).find("option:selected");
        if (select.length == 0) {
            alert("Vous devez choisir au moins un item dans la liste");
            valide = false;
            return;
        }
    });
    if (!valide) {
        return false;
    }
    return true;
}

function validerChamps(f) {
    var req = $(f).find("[required]");
    var toReturn = true;
    req.each(function () {
        if (!$(this).val().trim()) {
            alert("Veuillez entrer une valeur dans les champs obligatoires");
            toReturn = false;
            return;
        }
    });
    if (!toReturn) {
        return false;
    }
    if (!validerDates(f)) {
        return false;
    }
    if (!validerNoTel(f)) {
        return false;
    }
    if (!validerCodePostal(f)) {
        return false;
    }
    if (!validerPoste(f)) {
        return false;
    }
    if (!validerCourriel(f)) {
        return false;
    }
    if (!validerURL(f)) {
        return false;
    }
    if (!validerIntPositif(f)) {
        return false;
    }
    if (!validerSelect(f)) {
        return false;
    }
    return true;
}



(function (factory) {
    if (typeof define === "function" && define.amd) {

        // AMD. Register as an anonymous module.
        define(["../widgets/datepicker"], factory);
    } else {

        // Browser globals
        factory(jQuery.datepicker);
    }
}(function (datepicker) {

    datepicker.regional.fr = {
        closeText: "Fermer",
        prevText: "Précédent",
        nextText: "Suivant",
        currentText: "Aujourd'hui",
        monthNames: ["Janvier", "Février", "Mars", "Avril", "Mai", "Juin",
            "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"],
        monthNamesShort: ["janv.", "févr.", "mars", "avr.", "mai", "juin",
            "juil.", "août", "sept.", "oct.", "nov.", "déc."],
        dayNames: ["dimanche", "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi"],
        dayNamesShort: ["dim.", "lun.", "mar.", "mer.", "jeu.", "ven.", "sam."],
        dayNamesMin: ["D", "L", "M", "M", "J", "V", "S"],
        weekHeader: "Sem.",
        dateFormat: "dd/mm/yy",
        firstDay: 1,
        isRTL: false,
        showMonthAfterYear: false,
        yearSuffix: ""
    };
    datepicker.setDefaults(datepicker.regional.fr);

    return datepicker.regional.fr;

}));