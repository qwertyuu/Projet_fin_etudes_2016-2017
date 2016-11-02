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
            Sanitariser();
        }
        return true;
    });


})(jQuery);

function validerDates(form) {
    var dates = $(form).find("input.dp");
    var toReturn = true;
    dates.each(function () {
        var date = $(this).val().trim();
        if (!isFinite(new Date(date))) {
            alert("La date n'a pas le bon format!");
            toReturn = false;
        }
    });
    if (!toReturn) {
        return false;
    }
    return true;
}

function validerNoTel(form) {
    var noTels = $(form).find("input.tel");
    noTels.each(function () {
        var noTel = $(this).val().trim();
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
            return false;
        }
    });
    return true;
}

function validerChamps(f) {
    var req = $(f).find("[required]");
    var toReturn = true;
    req.each(function () {
        if (!$(this).val()) {
            alert("Veuillez entrer une valeur dans les champs obligatoires");
            toReturn = false;
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
    return true;
}