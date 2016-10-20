var nbBillet;
var nbBilletVIP;
var TotalBillet;
var PrixMoyen;

function calculTotalBillet() {
    if (nbBillet == "" || nbBillet == "") {
        alert("Vous devez entrer un nombre de billet avant de continuer")
    }
    else {
        return TotalBillet = parseInt(nbBillet) + parseInt(nbBilletVIP);
    }
} //Met a jour le nombre de billet entré et le retourne // Vérifie aussi qu'il y a un nombre entré

function calculMoyenne() {
    PrixMoyen = parseInt($("#totalBillet").val()) + parseInt($("#totalBilletVIP").val());
    PrixMoyen = PrixMoyen / calculTotalBillet();
} //Calcule la moyenne des billets pour le calcul des âges

function calculBillet() {

    var prixBillet;

    if (positifBilletCheck() == true) {
        nbBillet = $("#nbBillet").val();
        prixBillet = $("#prixBillet").val();

        var total = nbBillet * prixBillet;

        $("#totalBillet").val(round_argent(total));

        return total;
    }
    else {
        return 0;
    }
} //Calcule le prix des billets normaux

function calculBilletVIP() {

    var prixBilletVIP;

    if (positifBilletCheck() == true) {
        nbBilletVIP = $("#nbBilletVIP").val();
        prixBilletVIP = $("#prixBilletVIP").val();

        var total = nbBilletVIP * prixBilletVIP;

        $("#totalBilletVIP").val(round_argent(total));

        return total;
    }
    else {
        return 0;
    }
} //Calcule le prix des billets VIP

function calculSouperSpectacle() {

    var TotalBillet = calculTotalBillet();
    var totalSouper = null;

    if ($("#nbBilletSouper").val() > TotalBillet || TotalBillet == null) {
        alert("Il doit y avoir un nombre de billets plus petit que le nombre total de billet");
    }
    else {
        totalSouper = parseInt($("#nbBilletSouper").val()) * parseInt($("#prixSouper").val());

        $("#totalSouper").val(round_argent(totalSouper));
        return totalSouper;
    }
} //Calcule le prix des soupers spectacles après avoir vérifié que les données entrées soient bonnes

function calculRabaisAge() {
    if (pourcentCheck() == true && ratioCheck() == true) {
        var jeune = parseFloat($("#JeunePourcent").val()) / 100;
        var adulte = parseFloat($("#AdultePourcent").val()) / 100;
        var aine = parseFloat($("#AinePourcent").val()) / 100;

        var ratioJeune = parseFloat($("#RatioJeune").val()) / 100;
        var ratioAdulte = parseFloat($("#RatioAdulte").val()) / 100;
        var ratioAine = parseFloat($("#RatioAine").val()) / 100;

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
}//Calcule les rabais après avoir vérifié les données

function calculPrixReduit() {
    var nbBilletGratuit, nbBilletPreVente, total, TotBilletRabaisCustom1, TotBilletRabaisCustom2

    TotBilletGratuit = parseFloat($("#nbBilletSouper").val());
    TotBilletPreVente = parseFloat($("#nbBilletPreVente").val());

    if (checkRabaisCustom1 == true) {
        TotBilletRabaisCustom1 = parseFloat($("#NbBilletRabaisCustom1").val());

        TotBilletRabaisCustom1 = (TotBilletRabaisCustom1 * (PourcentRabaisCustom1 / 100));
    }
    if (checkRabaisCustom2 == true) {
        TotBilletRabaisCustom2 = parseFloat($("#NbBilletRabaisCustom2").val());

        TotBilletRabaisCustom2 = (TotBilletRabaisCustom2 * (PourcentRabaisCustom2 / 100));
    }

    TotBilletGratuit = (TotBilletGratuit * PrixMoyen)
    TotBilletPreVente = (TotBilletPreVente * PrixMoyen) * 0.25

    if (checkRabaisCustom1 == true && checkRabaisCustom2 == true) {
        total = TotBilletGratuit + TotBilletPreVente + TotBilletRabaisCustom1 + TotBilletRabaisCustom2
        round_argent(total);
        return total;
    }
    else if (checkRabaisCustom1 == true) {
        total = TotBilletGratuit + TotBilletPreVente + TotBilletRabaisCustom1
        round_argent(total);
        return total;
    }
    else if (checkRabaisCustom2 == true) {
        total = TotBilletGratuit + TotBilletPreVente + TotBilletRabaisCustom2
        round_argent(total);
        return total;
    }
    else {
        total = TotBilletGratuit + TotBilletPreVente
        round_argent(total);
        return total;
    }
}  //Calcule la section des prix réduits

function Calcultotal() {

    var total

    total = calculBillet() + calculBilletVIP() + calculSouperSpectacle() - calculRabaisAge() - calculPrixReduit();

    $("#TotFinal").text(round_argent(total));
} //Calcule le montant total et l'envoie 

function pourcentCheck() {
    if ($("#JeunePourcent").val() > 101 || $("#JeunePourcent").val() < -1 || $("#AdultePourcent").val() > 101 || $("#AdultePourcent").val() < -1 || $("#AinePourcent").val() > 101 || $("#AinePourcent").val() < -1) {
        alert("Veuiller entrer un pourcentage de rabais valide.");

        return false
    }
        //if (parseInt($("#RatioJeune").val()) + parseInt($("#RatioAdulte").val()) + parseInt($("#RatioAine").val()) == 100) {

        //}
    else {
        return true
    }
} //Vérifie que les % des âges sont Positif et moins que 100 et retourne un bool

function ratioCheck() {
    if ($("#RatioJeune").val() > -1 && $("#RatioJeune").val() < 101 || $("#RatioAdulte").val() > -1 && $("#RatioAdulte").val() < 101 || $("#RatioAdulte").val() > -1 && $("#RatioAine").val() < 101) {
        if (parseInt($("#RatioJeune").val()) + parseInt($("#RatioAdulte").val()) + parseInt($("#RatioAine").val()) == 100) {
            return true
        }
        else if ($("#RatioAdulte").val() != "" && $("#RatioAine").val() != "")//un check pour s'assurer que les cases ne sont pas vide.. ça évite le spam inutile
        {
            alert("Veuiller entrer un ratio total de 100");
        }
    }
    else {
        alert("Veuiller entrer un ratio entre 0 et 100 seulement");
        return false
    }
} //Vérifie que les ratios entrés soient entre 0 et 100 pour ensuite vérifier si additionnés ils égalent 100 ensuite retourne un bool

function checkRabaisCustom1() {
    if ($("#NomRabaisCustom1" != "") && $("#NbBilletRabaisCustom1") != "" && $("#PourcentRabaisCustom1") != "") {
        if ($("#PourcentRabaisCustom1") < 101 || $("#PourcentRabaisCustom1").val() > -1) {
            return true;
        }
        else {
            alert("Veuiller entrer un pourcentage de rabais valide.")
        }
    }
    return false;
}// vérifie si le rabais custom #1 est rempli et ensuite vérifie le %

function checkRabaisCustom2() {
    if ($("#NomRabaisCustom2" != "") && $("#NbBilletRabaisCustom2") != "" && $("#PourcentRabaisCustom2") != "") {
        if ($("#PourcentRabaisCustom2") < 101 || $("#PourcentRabaisCustom2").val() > -1) {
            return true;
        }
        else {
            alert("Veuiller entrer un pourcentage de rabais valide.")
        }
    }
    return false;
}// vérifie si le rabais custom #2 est rempli et ensuite vérifie le %

function positifBilletCheck() {
    if ($("#nbBillet").val() <= -1 || $("#nbBilletVIP").val() <= -1) {
        alert("Veuiller entrer un nombre de billet valide.");

        return false
    }
    else {
        return true
    }
} //Vérifie que le nombres de billets et billets VIP entrés soient positifs et retourne un bool

function round_argent(value) {
    var decimals = 2
    return Number(Math.round(value + 'e' + decimals) + 'e-' + decimals).toFixed(decimals);
}//Aroundie les valeurs avec 2 décimales