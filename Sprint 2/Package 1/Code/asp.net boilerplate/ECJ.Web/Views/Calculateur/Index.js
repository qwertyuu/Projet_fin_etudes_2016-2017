var nbBillet;
var nbBilletVIP;
var TotalBillet;
var PrixMoyen;
var billetMax;
var VIPMax;

this.onload = function () { setBillet(maxBillet, maxVIP), setForfait(chkSalle, chkAge, chkRed), remiseAZero() };

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

    if (billetMaxCheck() == true) {
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

    if (billetMaxCheck() == true) {
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
    var totalSouper = 0;

    if ($("#nbBilletSouper").val() == "") {
        return 0;
    }
    if ($("#nbBilletSouper").val() < TotalBillet && TotalBillet != "") {
        totalSouper = parseInt($("#nbBilletSouper").val()) * parseInt($("#prixSouper").val());

        $("#totalSouper").val(round_argent(totalSouper));
        return totalSouper;
    }
    else {
        $("#nbBilletSouper").val(0);
        return 0;
    }
} //Calcule le prix des soupers spectacles après avoir vérifié que les données entrées soient bonnes

function calculRabaisAge() {
    if (ratioCheck() == true) {

        calculMoyenne();
        calculTotalBillet();

        if ($("#nbBilletJeune").val() == 0 && $("#nbBilletAdulte").val() == 0 && $("#nbBilletAine").val() == 0) {
            var jeune = 0;
            var adulte = 0;
            var aine = 0;
        }
        else {
            var totBilletJeune = $("#nbBilletJeune").val(Math.round(TotalBillet * ratioJeune)).val();
            var totBilletAdulte = $("#nbBilletAdulte").val(Math.round(TotalBillet * ratioAdulte)).val();
            var totBilletAine = $("#nbBilletAine").val(Math.round(TotalBillet * ratioAine)).val();
        }
        if ($("#RatioJeune").val() == 0 && $("#RatioAdulte").val() == 0 && $("#RatioAine").val() == 0) {
            var ratioJeune = 0;
            var ratioAdulte = 0;
            var ratioAine = 0;
        }
        else {
            var totRabaisJeune = $("#rabaisBilletJeune").val(round_argent(PrixMoyen * jeune)).val();
            var totRabaisAdulte = $("#rabaisBilletAdulte").val(round_argent(PrixMoyen * adulte)).val();
            var totRabaisAine = $("#rabaisBilletAine").val(round_argent(PrixMoyen * aine)).val();
        }

        var total;
        total = (totBilletJeune * totRabaisJeune) + (totBilletAdulte * totRabaisAdulte) + (totBilletAine * totRabaisAine);

        alert(total);

        if (total === NaN) {
            return 0;
        }
        return total;
    }
    else {
        return 0;
    }
}//Calcule les rabais après avoir vérifié les données

function calculPrixReduit() {
    var nbBilletGratuit, nbBilletPreVente, TotBilletRabaisCustom1, TotBilletRabaisCustom2, total

    calculMoyenne();

    if ($("#nbBilletGratuit").val() != "") {
        nbBilletGratuit = parseFloat($("#nbBilletGratuit").val());
        checkNbBilletReduction();
    }
    else {
        nbBilletGratuit = 0;
    }

    if ($("#nbBilletPreVente").val() != "") {
        nbBilletPreVente = parseFloat($("#nbBilletPreVente").val());
        checkNbBilletReduction();
    }
    else {
        nbBilletPreVente = 0;
    }

    if (checkRabaisCustom1 == true) {
        TotBilletRabaisCustom1 = parseFloat($("#NbBilletRabaisCustom1").val());
        TotBilletRabaisCustom1 = (TotBilletRabaisCustom1 * (PourcentRabaisCustom1 / 100));
        checkNbBilletReduction();
    }
    else {
        TotBilletRabaisCustom1 = 0;
    }

    if (checkRabaisCustom2 == true) {
        TotBilletRabaisCustom2 = parseFloat($("#NbBilletRabaisCustom2").val());
        TotBilletRabaisCustom2 = (TotBilletRabaisCustom2 * (PourcentRabaisCustom2 / 100));
        checkNbBilletReduction();
    }
    else {
        TotBilletRabaisCustom2 = 0;
    }

    var TotBilletGratuit = (nbBilletGratuit * PrixMoyen)
    var TotBilletPreVente = (nbBilletPreVente * PrixMoyen) * 0.25

    total = TotBilletGratuit + TotBilletPreVente
    round_argent(total);
    return total;
}  //Calcule la section des prix réduits

function Calcultotal() {

    var total

    total = calculBillet() + calculBilletVIP() + calculSouperSpectacle() - calculRabaisAge() - calculPrixReduit();

    $("#TotFinal").text(round_argent(total));
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
} //Vérifie que les % des âges sont Positif et moins que 100

function ratioCheck() {
    if ($("#RatioJeune").val() > -1 && $("#RatioJeune").val() < 101 || $("#RatioAdulte").val() > -1 && $("#RatioAdulte").val() < 101 || $("#RatioAine").val() > -1 && $("#RatioAine").val() < 101) {
        if (parseInt($("#RatioJeune").val()) + parseInt($("#RatioAdulte").val()) + parseInt($("#RatioAine").val()) == 100) {
            return true
        }
        else if ($("#RatioJeune").val() == 0 && $("#RatioAdulte").val() == 0 && $("#RatioAine").val() == 0) {
            return true;
        }// s'ils ont été mis à 0 le code va permettre le calcul quand même, ça évite les blocages lorsque tout à été remis à 0 et que la fenêtre est cachée

        else if ($("#RatioAdulte").val() != "" && $("#RatioAine").val() != "")//un check pour s'assurer que les cases ne sont pas vides.. ça évite le spam inutile
        {
            alert("Veuiller entrer un ratio total de 100");
            return false;
        }
    }
    else {
        alert("Veuiller entrer un ratio entre 0 et 100 seulement");
        return false
    }
} //Vérifie que les ratios entrés soient entre 0 et 100 pour ensuite vérifier si additionnés ils égalent 100 ensuite retourne un bool

function checkRabaisCustom1() {
    if ($("#NomRabaisCustom1").val() != "" && $("#NbBilletRabaisCustom1").val() != "" && $("#PourcentRabaisCustom1").val() != "") {
        if ($("#PourcentRabaisCustom1").val() < 101 || $("#PourcentRabaisCustom1").val() > -1) {
            return true;
        }
        else {
            alert("Veuiller entrer un pourcentage de rabais valide.")
        }
    }
    return false;
}// vérifie si le rabais custom #1 est rempli et ensuite vérifie le %

function checkRabaisCustom2() {
    if ($("#NomRabaisCustom2").val() != "" && $("#NbBilletRabaisCustom2").val() != "" && $("#PourcentRabaisCustom2").val() != "") {
        if ($("#PourcentRabaisCustom2").val() < 101 || $("#PourcentRabaisCustom2").val() > -1) {
            return true;
        }
        else {
            alert("Veuiller entrer un pourcentage de rabais valide.")
        }
    }
    return false;
}// vérifie si le rabais custom #2 est rempli et ensuite vérifie le %

function positifBilletCheck() {
    if ($("#nbBillet").val() <= -1) {
        alert("Veuiller entrer un nombre de billet valide.");

        $("#nbBillet").val(0);
    }
    if (($("#nbBilletVIP").val() <= -1)) {
        $("#nbBilletVIP").val(0);
    }
    return true;
} //Vérifie que le nombres de billets et billets VIP entrés soient positifs et retourne un bool

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
}//Vérifie le nombre de billets dans les cases de réduction

function billetMaxCheck() {

    if (parseInt($("#nbBillet").val()) >= billetMax) {
        $("#nbBillet").val(billetMax);
    }
    if ($("#nbBilletVIP").val() >= VIPMax) {
        $("#nbBilletVIP").val(VIPMax);
    }
    return true;
}//Vérifie que les nombres de billets et billets VIP entrés soient inférieur ou égaux au nombre de places dans la salle.

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

function remiseAZero() {

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
    $("#rabaisBilletAine").val(0);
    $("#rabaisBilletAdulte").val(0);
    $("#rabaisBilletJeune").val(0);
}