var nbBillet;
var nbBilletVIP;
var TotalBillet;
var prixBillets;
var prixBilletsVIP;
var PrixMoyen;
var billetMax;
var VIPMax;
var totalFinal;
var coutTotal;

this.onload = function () { setCout(coutTot), setBillet(maxBillet, maxVIP), setForfait(chkSalle, chkAge, chkRed), LoadingDesDonnes(), revenuTotal() };

function calculTotalBillet() {
    if ($("#nbBillet").val() != 0) {
        TotalBillet = parseInt($("#nbBillet").val()) + parseInt($("#nbBilletVIP").val());
        return true;
    }
    else {
        alert("Vous devez entrer un nombre de billet avant de continuer")
        return false;
    }
} //Met a jour le nombre de billet entré et le retourne // Vérifie aussi qu'il y a un nombre entré

function calculMoyenne() {
    PrixMoyen = prixBillets + prixBilletsVIP;
    PrixMoyen = PrixMoyen / TotalBillet;
} //Calcule la moyenne des billets pour le calcul des âges

function calculBillet() {

    var prixBillet;

    nbBillet = $("#nbBillet").val();
    prixBillet = $("#prixBillet").val();

    if (calculTotalBillet() == true) {
        var total = nbBillet * prixBillet;
        prixBillets = total;
        $("#totalBillet").val(round_argent(total) + "$");

        return total;
    }
    else {
        return 0;
    }
} //Calcule le prix des billets normaux

function calculBilletVIP() {

    var prixBilletVIP;

    nbBilletVIP = $("#nbBilletVIP").val();
    prixBilletVIP = $("#prixBilletVIP").val();

    var total = nbBilletVIP * prixBilletVIP;
    prixBilletsVIP = total;
    $("#totalBilletVIP").val(round_argent(total) + "$");

    return total;
} //Calcule le prix des billets VIP

function calculSouperSpectacle() {

    var totalSouper = 0;

    if ($("#nbBilletSouper").val() == "") {
        return 0;
    }
    if ($("#nbBilletSouper").val() <= TotalBillet && TotalBillet != "") {
        totalSouper = parseInt($("#nbBilletSouper").val()) * parseInt($("#prixSouper").val());

        $("#totalSouper").val(round_argent(totalSouper) + "$");
        return totalSouper;
    }

    if ($("#nbBilletSouper").val() <= TotalBillet) {
        $("#nbBilletSouper").val(TotalBillet);
        return TotalBillet;
    }
    else {
        $("#nbBilletSouper").val(0);
        return 0;
    }
} //Calcule le prix des soupers spectacles après avoir vérifié que les données entrées soient bonnes

function calculRabaisAge() {

    if (ratioCheck() == true) {

        pourcentCheck();

        var jeune = parseFloat($("#JeunePourcent").val()) / 100;
        var adulte = parseFloat($("#AdultePourcent").val()) / 100;
        var aine = parseFloat($("#AinePourcent").val()) / 100;

        var ratioJeune = parseFloat($("#RatioJeune").val()) / 100;
        var ratioAdulte = parseFloat($("#RatioAdulte").val()) / 100;
        var ratioAine = parseFloat($("#RatioAine").val()) / 100;

        calculBillet();
        calculBilletVIP();
        calculMoyenne();

        var totBilletJeune = $("#nbBilletJeune").val(Math.round(TotalBillet * ratioJeune)).val();
        var totBilletAdulte = $("#nbBilletAdulte").val(Math.round(TotalBillet * ratioAdulte)).val();
        var totBilletAine = $("#nbBilletAine").val(Math.round(TotalBillet * ratioAine)).val();

        var totRabaisJeune = $("#rabaisBilletJeune").val(round_argent(PrixMoyen * jeune)).val();
        var totRabaisAdulte = $("#rabaisBilletAdulte").val(round_argent(PrixMoyen * adulte)).val();
        var totRabaisAine = $("#rabaisBilletAine").val(round_argent(PrixMoyen * aine)).val();

        var total;
        total = (totBilletJeune * totRabaisJeune) + (totBilletAdulte * totRabaisAdulte) + (totBilletAine * totRabaisAine);

        return total;
    }
    else {
        return 0;
    }
}//Calcule les rabais après avoir vérifié les données

function calculPrixReduit() {
    var TotBilletGratuit, TotBilletPreVente, TotBilletRabaisCustom1, TotBilletRabaisCustom2, total, totalBilletReduit

    calculMoyenne();
    // checkNbBilletReduction();
    totalBilletReduit = 0;

    if ($("#nbBilletGratuit").val() != 0) {
        var nbBilletGratuit = parseFloat($("#nbBilletGratuit").val());
        TotBilletGratuit = (nbBilletGratuit * PrixMoyen);
        totalBilletReduit = totalBilletReduit + nbBilletGratuit;
    }
    else {
        TotBilletGratuit = 0;
    }

    if ($("#nbBilletPreVente").val() != 0) {
        var nbBilletPreVente = parseFloat($("#nbBilletPreVente").val());
        TotBilletPreVente = ((nbBilletPreVente * PrixMoyen) * 0.25);
        totalBilletReduit = totalBilletReduit + nbBilletPreVente;
    }
    else {
        TotBilletPreVente = 0;
    }

    if (checkRabaisCustom1() == true) {
        NbBilletRabaisCustom1 = parseFloat($("#NbBilletRabaisCustom1").val());
        TotBilletRabaisCustom1 = (NbBilletRabaisCustom1 * (parseFloat($("#PourcentRabaisCustom1").val()) / 100));
        totalBilletReduit = totalBilletReduit + NbBilletRabaisCustom1;
    }

    else {
        TotBilletRabaisCustom1 = 0;
    }

    if (checkRabaisCustom2() == true) {
        var NbBilletRabaisCustom2 = parseFloat($("#NbBilletRabaisCustom2").val());
        TotBilletRabaisCustom2 = (NbBilletRabaisCustom2 * (parseFloat($("#PourcentRabaisCustom2").val()) / 100));
        totalBilletReduit = totalBilletReduit + NbBilletRabaisCustom2;
    }

    else {
        TotBilletRabaisCustom2 = 0;
    }

    if (parseInt(totalBilletReduit) > TotalBillet) {
        alert("Vous ne pouvez pas entrer une quantitée plus grande de billet à prix réduit que le nombre total de billets. Les Billets réduits ne seront pas calculés.")
        return 0;
    }
    else {
        if (nbBilletGratuit != "0" || TotBilletPreVente != "0" || TotBilletRabaisCustom1 != 0 || TotBilletRabaisCustom2 != 0) {
            total = TotBilletGratuit + TotBilletPreVente + TotBilletRabaisCustom1 + TotBilletRabaisCustom2;
            round_argent(total);
            return total;
        }
        else {
            return 0;
        }
    }
}  //Calcule la section des prix réduits

function Calcultotal() {

    var total;

    if (calculTotalBillet() == true) {
        do {
            checkPositif();
            billetMaxCheck();
            billetVIPMaxCheck();
        }
        while (checkPositif() == false && billetMaxCheck() == false && billetVIPMaxCheck() == false)

        total = calculBillet() + calculBilletVIP() + calculSouperSpectacle() - calculRabaisAge() - calculPrixReduit();

        $("#Recette").text(round_argent(total) + "$");

        totalFinal = total;
        revenuTotal(totalFinal);
    }
} //Calcule le montant total et l'envoie 

function pourcentCheck() {

    if ($("#JeunePourcent").val() > 101) {
        $("#JeunePourcent").val(100);
    }
    if ($("#AdultePourcent").val() > 101) {
        $("#AdultePourcent").val(100);
    }
    if ($("#AinePourcent").val() > 101) {
        $("#AinePourcent").val(100);
    }
} //Vérifie que les % des âges sont Positif et moins que 100

function ratioCheck() {
    if ($("#RatioJeune").val() == "0" && $("#RatioAdulte").val() == "0" && $("#RatioAine").val() == "0" && chkAge == true) {
        return false;
    }
    else if ($("#RatioJeune").val() > 0 && $("#RatioJeune").val() < 101 || $("#RatioAdulte").val() > 0 && $("#RatioAdulte").val() < 101 || $("#RatioAine").val() > 0 && $("#RatioAine").val() < 101) {
        if (parseInt($("#RatioJeune").val()) + parseInt($("#RatioAdulte").val()) + parseInt($("#RatioAine").val()) == 100) {
            return true
        }
        else if ($("#RatioAdulte").val() != "" && $("#RatioAine").val() != "" && chkAge == true)//un check pour s'assurer que les cases ne sont pas vides.. ça évite le spam inutile
        {
            alert("Veuiller entrer un ratio total de 100");
            return false;
        }
    }
    else if (chkAge == true) {
        alert("Veuiller entrer un ratio entre 0 et 100 seulement");
        return false
    }
} //Vérifie que les ratios entrés soient entre 0 et 100 pour ensuite vérifier si additionnés ils égalent 100 ensuite retourne un bool

function checkRabaisCustom1() {
    if ($("#NomRabaisCustom1").val() != "" && $("#NbBilletRabaisCustom1").val() != "0" && $("#PourcentRabaisCustom1").val() != "0") {
        if ($("#PourcentRabaisCustom1").val() < 101 && $("#PourcentRabaisCustom1").val() > 0) {
            return true;
        }
        else {
            alert("Veuiller entrer un pourcentage de rabais valide.")
            return false;
        }
    }
}// vérifie si le rabais custom #1 est rempli et ensuite vérifie le %

function checkRabaisCustom2() {
    if ($("#NomRabaisCustom2").val() != "" && $("#NbBilletRabaisCustom2").val() != "0" && $("#PourcentRabaisCustom2").val() != "0") {
        if ($("#PourcentRabaisCustom2").val() < 101 && $("#PourcentRabaisCustom2").val() > -1) {
            return true;
        }
        else {
            alert("Veuiller entrer un pourcentage de rabais valide.")
            return false;
        }
    }
}// vérifie si le rabais custom #2 est rempli et ensuite vérifie le %

function checkNbBilletReduction() {
    if (parseInt($("#nbBilletGratuit").val()) > TotalBillet) {
        $("#nbBilletGratuit").val(TotalBillet);
    }
    if (parseInt($("#nbBilletPreVente").val()) > TotalBillet) {
        $("#nbBilletPreVente").val(TotalBillet);
    }
    if (parseInt($("#NbBilletRabaisCustom1").val()) > TotalBillet) {
        $("#NbBilletRabaisCustom1").val(TotalBillet);
    }
    if (parseInt($("#NbBilletRabaisCustom2").val()) > TotalBillet) {
        $("#NbBilletRabaisCustom2").val(TotalBillet);
    }
}//Vérifie le nombre de billets dans les cases de réduction

function billetMaxCheck() {

    if ($("#nbBillet").val() >= billetMax) {
        $("#nbBillet").val(billetMax);
        return false;
    }
    if ($("#nbBilletVIP").val() >= VIPMax) {
        $("#nbBilletVIP").val(VIPMax);
        return false;
    }
    return true;
}//Vérifie que les nombres de billets et billets VIP entrés soient inférieur ou égaux au nombre de places dans la salle.

function billetVIPMaxCheck() {
    if ($("#nbBilletVIP").val() >= VIPMax) {
        $("#nbBilletVIP").val(VIPMax);
        return false;
    }
    return true;
}//Vérifie que les nombres de billets VIP entrés soient inférieur ou égaux au nombre de places dans la salle.

function round_argent(value) {
    var decimals = 2
    return Number(Math.round(value + 'e' + decimals) + 'e-' + decimals).toFixed(decimals);
}//Aroundie les valeurs avec 2 décimale

function setBillet(maxbillet, maxvip) {
    billetMax = parseInt(maxbillet);
    VIPMax = parseInt(maxvip);
} //Reçoit et set le maximum des billets et billets VIP

function setForfait(chkSalle, chkAge, chkRed) {

    if (chkAge == false) {
        $("#age").attr("hidden", "true");
    }
    if (chkSalle == false) {
        $("#souper").attr("hidden", "true");
    }
    if (chkRed == false) {
        $("#reduction").attr("hidden", "true");
    }
} //Reçoit les bool a propos des forfaits du sous-event et enlève ceux qui sont a "false"

function LoadingDesDonnes() {

    if ($("#nbBillet").val() == "") {
        $("#nbBillet").val(0);
    }
    if ($("#nbBilletVIP").val() == "") {
        $("#nbBilletVIP").val(0);
    }
    if ($("#prixBillet").val() == "") {
        $("#prixBillet").val(0);
    }
    if ($("#prixBilletVIP").val() == "") {
        $("#prixBilletVIP").val(0);
    }
    if ($("#nbBilletSouper").val() == "") {
        $("#nbBilletSouper").val(0);
    }
    if ($("#prixSouper").val() == "") {
        $("#prixSouper").val(0);
    }
    if ($("#JeunePourcent").val() == "") {
        $("#JeunePourcent").val(0);
    }
    if ($("#AdultePourcent").val() == "") {
        $("#AdultePourcent").val(0);
    }
    if ($("#AinePourcent").val() == "") {
        $("#AinePourcent").val(0);
    }
    if ($("#RatioJeune").val() == "") {
        $("#RatioJeune").val(0);
    }
    if ($("#RatioAdulte").val() == "") {
        $("#RatioAdulte").val(0);
    }
    if ($("#RatioAine").val() == "") {
        $("#RatioAine").val(0);
    }
    if ($("#nbBilletGratuit").val() == "") {
        $("#nbBilletGratuit").val(0);
    }
    if ($("#nbBilletPreVente").val() == "") {
        $("#nbBilletPreVente").val(0);
    }
    if ($("#NbBilletRabaisCustom1").val() == "") {
        $("#NbBilletRabaisCustom1").val(0);
    }
    if ($("#NbBilletRabaisCustom2").val() == "") {
        $("#NbBilletRabaisCustom2").val(0);
    }
    if ($("#PourcentRabaisCustom1").val() == "") {
        $("#PourcentRabaisCustom1").val(0);
    }
    if ($("#PourcentRabaisCustom2").val() == "") {
        $("#PourcentRabaisCustom2").val(0);
    }
}//load les données et met 0 ou "" aux champs sans donnés

function remiseAZero() {
    $("#nbBillet").val(0);
    $("#nbBilletVIP").val(0);
    $("#totalBillet").val(0);
    $("#totalBilletVIP").val(0);
    $("#prixBillet").val(0);
    $("#prixBilletVIP").val(0);
    $("#nbBilletSouper").val(0);
    $("#prixSouper").val(0);
    $("#totalSouper").val(0);
    $("#JeunePourcent").val(0);
    $("#AdultePourcent").val(0);
    $("#AinePourcent").val(0);
    $("#RatioJeune").val(0);
    $("#RatioAdulte").val(0);
    $("#RatioAine").val(0);
    $("#nbBilletGratuit").val(0);
    $("#nbBilletPreVente").val(0);
    $("#NbBilletRabaisCustom1").val(0);
    $("#NbBilletRabaisCustom2").val(0);
    $("#PourcentRabaisCustom1").val(0);
    $("#PourcentRabaisCustom2").val(0);
    $("#rabaisBilletAine").val(0);
    $("#rabaisBilletAdulte").val(0);
    $("#rabaisBilletJeune").val(0);
    $("#nbBilletJeune").val(0);
    $("#nbBilletAdulte").val(0);
    $("#nbBilletAine").val(0);
    $("#NomRabaisCustom1").val("");
    $("#NomRabaisCustom2").val("");
    $("#Revenu").text(0 - coutTotal + "$");
    $("#Recette").text(0, 00 + "$");
}//Met tout a 0 ou "" partout

function checkPositif() {

    if ($("#nbBillet").val() < 0) {
        $("#nbBillet").val(0);
        return false;
    }
    if ($("#nbBilletVIP").val() < 0) {
        $("#nbBilletVIP").val(0);
        return false;
    }
    if ($("#prixBillet").val() < 0) {
        $("#prixBillet").val(0);
        return false;
    }
    if ($("#prixBilletVIP").val() < 0) {
        $("#prixBilletVIP").val(0);
        return false;
    }
    if ($("#nbBilletSouper").val() < 0) {
        $("#nbBilletSouper").val(0);
        return false;
    }
    if ($("#prixSouper").val() < 0) {
        $("#prixSouper").val(0);
        return false;
    }
    if ($("#JeunePourcent").val() < 0) {
        $("#JeunePourcent").val(0);
        return false;
    }
    if ($("#AdultePourcent").val() < 0) {
        $("#AdultePourcent").val(0);
        return false;
    }
    if ($("#AinePourcent").val() < 0) {
        $("#AinePourcent").val(0);
        return false;
    }
    if ($("#RatioJeune").val() < 0) {
        $("#RatioJeune").val(0);
        return false;
    }
    if ($("#RatioAdulte").val() < 0) {
        $("#RatioAdulte").val(0);
        return false;
    }
    if ($("#RatioAine").val() < 0) {
        $("#RatioAine").val(0);
        return false;
    }
    if ($("#nbBilletGratuit").val() < 0) {
        $("#nbBilletGratuit").val(0);
        return false;
    }
    if ($("#nbBilletPreVente").val() < 0) {
        $("#nbBilletPreVente").val(0);
        return false;
    }
    if ($("#NbBilletRabaisCustom1").val() < 0) {
        $("#NbBilletRabaisCustom1").val(0);
        return false;
    }
    if ($("#NbBilletRabaisCustom2").val() < 0) {
        $("#NbBilletRabaisCustom2").val(0);
        return false;
    }
    if ($("#PourcentRabaisCustom1").val() < 0) {
        $("#PourcentRabaisCustom1").val(0);
        return false;
    }
    if ($("#PourcentRabaisCustom2").val() < 0) {
        $("#PourcentRabaisCustom2").val(0);
        return false;
    }
    else {
        return true;
    }
}// Regarde toute les valeures et si elles sont négaive les remets à 0

function revenuTotal() {
    if (totalFinal != null) {
        $("#Revenu").text(round_argent(totalFinal - coutTotal) + "$");
    }
    else {
        $("#Revenu").text(round_argent(0 - coutTotal) + "$");
    }
}

function setCout(couttot) {
    coutTotal = parseInt(couttot);
}