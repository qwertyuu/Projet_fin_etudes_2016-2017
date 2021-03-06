var nbBillet;
var nbBilletVIP;
var TotalBillets;
var prixBillets;
var prixBilletVIP;
var PrixMoyen;
var billetMax;
var VIPMax;

this.onload = function () { setBillet(maxBillet, maxVIP), setForfait(chkSalle, chkAge, chkRed), LoadingDesDonnes() };

function calculTotalBillet() {
    if (nbBillet == "0" || nbBilletVIP == "0") {
        alert("Vous devez entrer un nombre de billet avant de continuer")
    }
    else {
        return TotalBillet = parseInt(nbBillet) + parseInt(nbBilletVIP);
    }
} //Met a jour le nombre de billet entr� et le retourne // V�rifie aussi qu'il y a un nombre entr�

function calculMoyenne() {
    PrixMoyen = prixBillets + prixBilletVIP;
    PrixMoyen = PrixMoyen / calculTotalBillet();
} //Calcule la moyenne des billets pour le calcul des �ges

function calculBillet() {

    var prixBillet;

    if (billetMaxCheck() == true) {
        nbBillet = $("#nbBillet").val();
        prixBillet = $("#prixBillet").val();

        var total = nbBillet * prixBillet;
        prixBillets = total;
        $("#totalBillet").val(round_argent(total)+"$");

        return total;
    }
    else {
        return 0;
    }
} //Calcule le prix des billets normaux

function calculBilletVIP() {

    var prixBilletVIP;

    if (billetMaxCheck() == true) {
        nbBilletVIP = $("#nbBilletVIP").val();
        prixBilletVIP = $("#prixBilletVIP").val();

        var total = nbBilletVIP * prixBilletVIP;
        prixBilletVIP = total;
        $("#totalBilletVIP").val(round_argent(total) + "$");

        return total;
    }
    else {
        return 0;
    }
} //Calcule le prix des billets VIP

function calculSouperSpectacle() {

    var TotalBillet = calculTotalBillet();
    var totalSouper = 0;

    if ($("#nbBilletSouper").val() == "") {
        return 0;
    }
    if ($("#nbBilletSouper").val() < TotalBillet && TotalBillet != "") {
        totalSouper = parseInt($("#nbBilletSouper").val()) * parseInt($("#prixSouper").val());

        $("#totalSouper").val(round_argent(totalSouper)+"$");
        return totalSouper;
    }
    else {
        $("#nbBilletSouper").val(0);
        return 0;
    }
} //Calcule le prix des soupers spectacles apr�s avoir v�rifi� que les donn�es entr�es soient bonnes

function calculRabaisAge() {
    if (ratioCheck() == true) {

        var jeune = parseFloat($("#JeunePourcent").val()) / 100;
        var adulte = parseFloat($("#AdultePourcent").val()) / 100;
        var aine = parseFloat($("#AinePourcent").val()) / 100;

        var ratioJeune = parseFloat($("#RatioJeune").val()) / 100;
        var ratioAdulte = parseFloat($("#RatioAdulte").val()) / 100;
        var ratioAine = parseFloat($("#RatioAine").val()) / 100;

        calculBillet();
        calculBilletVIP();
        calculMoyenne();
        calculTotalBillet();

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
}//Calcule les rabais apr�s avoir v�rifi� les donn�es

function calculPrixReduit() {
    var nbBilletGratuit, nbBilletPreVente, TotBilletRabaisCustom1, TotBilletRabaisCustom2, total

    calculMoyenne();

    if ($("#nbBilletGratuit").val() != 0) {
        nbBilletGratuit = parseFloat($("#nbBilletGratuit").val());
        checkNbBilletReduction();
    }
    else {
        nbBilletGratuit = 0;
    }

    if ($("#nbBilletPreVente").val() != 0) {
        nbBilletPreVente = parseFloat($("#nbBilletPreVente").val());
        checkNbBilletReduction();
    }
    else {
        nbBilletPreVente = 0;
    }

    if (checkRabaisCustom1() == true) {
        TotBilletRabaisCustom1 = parseFloat($("#NbBilletRabaisCustom1").val());
        TotBilletRabaisCustom1 = (TotBilletRabaisCustom1 * (PourcentRabaisCustom1 / 100));
        checkNbBilletReduction();
    }
    else {
        TotBilletRabaisCustom1 = 0;
    }

    if (checkRabaisCustom2() == true) {
        TotBilletRabaisCustom2 = parseFloat($("#NbBilletRabaisCustom2").val());
        TotBilletRabaisCustom2 = (TotBilletRabaisCustom2 * (PourcentRabaisCustom2 / 100));
        checkNbBilletReduction();
    }
    else {
        TotBilletRabaisCustom2 = 0;
    }
    if (nbBilletGratuit != "0" && TotBilletPreVente != "0") {
        var TotBilletGratuit = (nbBilletGratuit * PrixMoyen)
        var TotBilletPreVente = (nbBilletPreVente * PrixMoyen) * 0.25

        total = TotBilletGratuit + TotBilletPreVente
        round_argent(total);
        return total;
    }
    else {
        return 0;
    }

}  //Calcule la section des prix r�duits

function Calcultotal() {

    var total

    checkPositif();

    total = calculBillet() + calculBilletVIP() + calculSouperSpectacle() - calculRabaisAge() - calculPrixReduit();

    $("#TotFinal").text(round_argent(total) + "$");

    $("#TotFinal").focus(); // ne fonctionne pas
} //Calcule le montant total et l'envoie 

function pourcentCheck() {
    if ($("#JeunePourcent").val() < -1) {
        $("#JeunePourcent").val(0);
    }
    if ($("#AdultePourcent").val() < -1) {
        $("#AdultePourcent").val(0);
    }
    if ($("#AinePourcent").val() < -1) {
        $("#AinePourcent").val(0);
    }
    if ($("#JeunePourcent").val() > 101) {
        $("#JeunePourcent").val(100);
    }
    if ($("#AdultePourcent").val() > 101) {
        $("#AdultePourcent").val(100);
    }
    if ($("#AinePourcent").val() > 101) {
        $("#AinePourcent").val(100);
    }
} //V�rifie que les % des �ges sont Positif et moins que 100

function ratioCheck() {
    if ($("#RatioJeune").val() == "0" && $("#RatioAdulte").val() == "0" && $("#RatioAine").val() == "0" && chkAge == true) {
        return false;
    }
    else if ($("#RatioJeune").val() > 0 && $("#RatioJeune").val() < 101 || $("#RatioAdulte").val() > 0 && $("#RatioAdulte").val() < 101 || $("#RatioAine").val() > 0 && $("#RatioAine").val() < 101) {
        if (parseInt($("#RatioJeune").val()) + parseInt($("#RatioAdulte").val()) + parseInt($("#RatioAine").val()) == 100) {
            return true
        }
        else if ($("#RatioAdulte").val() != "" && $("#RatioAine").val() != "" && chkAge == true)//un check pour s'assurer que les cases ne sont pas vides.. �a �vite le spam inutile
        {
            alert("Veuiller entrer un ratio total de 100");
            return false;
        }
    }
    else if (chkAge == true) {
        alert("Veuiller entrer un ratio entre 0 et 100 seulement");
        return false
    }
} //V�rifie que les ratios entr�s soient entre 0 et 100 pour ensuite v�rifier si additionn�s ils �galent 100 ensuite retourne un bool

function checkRabaisCustom1() {
    if ($("#NomRabaisCustom1").val() != "" && $("#NbBilletRabaisCustom1").val() != 0 && $("#PourcentRabaisCustom1").val() != 0) {
        if ($("#PourcentRabaisCustom1").val() < 101 || $("#PourcentRabaisCustom1").val() > 0) {
            return true;
        }
        else {
            alert("Veuiller entrer un pourcentage de rabais valide.")
            return false;
        }
    }
    return false;
}// v�rifie si le rabais custom #1 est rempli et ensuite v�rifie le %

function checkRabaisCustom2() {
    if ($("#NomRabaisCustom2").val() != "" && $("#NbBilletRabaisCustom2").val() != 0 && $("#PourcentRabaisCustom2").val() != 0) {
        if ($("#PourcentRabaisCustom2").val() < 101 || $("#PourcentRabaisCustom2").val() > -1) {
            return true;
        }
        else {
            alert("Veuiller entrer un pourcentage de rabais valide.")
        }
    }
    return false;
}// v�rifie si le rabais custom #2 est rempli et ensuite v�rifie le %

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
    if (parseInt($("#nbBilletGratuit").val()) < 0) {
        $("#nbBilletGratuit").val(0);
    }
    if (parseInt($("#nbBilletPreVente").val()) < 0) {
        $("#nbBilletPreVente").val(0);
    }
    if (parseInt($("#NbBilletRabaisCustom1").val()) < 0) {
        $("#nbBilletGratuit").val(0);
    }
    if (parseInt($("#NbBilletRabaisCustom2").val()) < 0) {
        $("#nbBilletGratuit").val(0);
    }
}//V�rifie le nombre de billets dans les cases de r�duction

function billetMaxCheck() {

    if (parseInt($("#nbBillet").val()) >= billetMax) {
        $("#nbBillet").val(billetMax);
    }
    if ($("#nbBilletVIP").val() >= VIPMax) {
        $("#nbBilletVIP").val(VIPMax);
    }
    return true;
}//V�rifie que les nombres de billets et billets VIP entr�s soient inf�rieur ou �gaux au nombre de places dans la salle.

function round_argent(value) {
    var decimals = 2
    return Number(Math.round(value + 'e' + decimals) + 'e-' + decimals).toFixed(decimals);
}//Aroundie les valeurs avec 2 d�cimale

function setBillet(maxbillet, maxvip) {
    billetMax = parseInt(maxbillet);
    VIPMax = parseInt(maxvip);
} //Re�oit et set le maximum des billets et billets VIP

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
} //Re�oit les bool a propos des forfaits du sous-event et enl�ve ceux qui sont a "false"

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
}//load les donn�es et met 0 ou "" aux champs sans donn�s

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
    $("#TotFinal").val(0);
}//Met tout a 0 ou "" partout

function checkPositif() {

    if ($("#nbBillet").val() < 0) {
        $("#nbBillet").val(0);
    }
    if ($("#nbBilletVIP").val() < 0) {
        $("#nbBilletVIP").val(0);
    }
    if ($("#prixBillet").val() < 0) {
        $("#prixBillet").val(0);
    }
    if ($("#prixBilletVIP").val() < 0) {
        $("#prixBilletVIP").val(0);
    }
    if ($("#nbBilletSouper").val() < 0) {
        $("#nbBilletSouper").val(0);
    }
    if ($("#prixSouper").val() < 0) {
        $("#prixSouper").val(0);
    }
    if ($("#JeunePourcent").val() < 0) {
        $("#JeunePourcent").val(0);
    }
    if ($("#AdultePourcent").val() < 0) {
        $("#AdultePourcent").val(0);
    }
    if ($("#AinePourcent").val() < 0) {
        $("#AinePourcent").val(0);
    }
    if ($("#RatioJeune").val() < 0) {
        $("#RatioJeune").val(0);
    }
    if ($("#RatioAdulte").val() < 0) {
        $("#RatioAdulte").val(0);
    }
    if ($("#RatioAine").val() < 0) {
        $("#RatioAine").val(0);
    }
    if ($("#nbBilletGratuit").val() < 0) {
        $("#nbBilletGratuit").val(0);
    }
    if ($("#nbBilletPreVente").val() < 0) {
        $("#nbBilletPreVente").val(0);
    }
    if ($("#NbBilletRabaisCustom1").val() < 0) {
        $("#NbBilletRabaisCustom1").val(0);
    }
    if ($("#NbBilletRabaisCustom2").val() < 0) {
        $("#NbBilletRabaisCustom2").val(0);
    }
    if ($("#PourcentRabaisCustom1").val() < 0) {
        $("#PourcentRabaisCustom1").val(0);
    }
    if ($("#PourcentRabaisCustom2").val() < 0) {
        $("#PourcentRabaisCustom2").val(0);
    }
}// Regarde toute les valeures et si elles sont n�gaive les remets � 0