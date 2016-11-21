function IsAgenceSelect(btn) {

    var agence = $("#agencePub");
    var select = false;
    if (agence.val() == null) {
        select = false;
    }
    else {
        select = agence.val().length > 0;
    }

    if (btn.value == "Save") {
        if (select) {
            alert("Vous ne pouvez pas sélectionner une agence de publcité lorsque l'appel d'ofrre est en création.");
        }
    }
    else {
        if (!select) {
            alert("Veuillez sélectionner au moins une agence de publicité pour soumettre l'appel d'offre");
        }
    }
    return select;
}