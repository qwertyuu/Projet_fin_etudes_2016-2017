var nbBillet;
var nbBilletVIP;
var TotalBillet;
var PrixMoyen;

function calculTotalBillet() {
    return TotalBillet = parseInt(nbBillet) + parseInt(nbBilletVIP);
} //Met a jour le nombre de billet entré et le retourne 

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
    }
} //Calcule le prix des billets normaux

function calculBilletVIP() {

    var prixBilletVIP;

    if (positifBilletCheck() == true) {
        nbBilletVIP = $("#nbBilletVIP").val();
        prixBilletVIP = $("#prixBilletVIP").val();

        var total = nbBilletVIP * prixBilletVIP;

        $("#totalBilletVIP").val(round_argent(total));
    }
} //Calcule le prix des billets VIP

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

function positifBilletCheck() {
    if ($("#nbBillet").val() <= -1 || $("#nbBilletVIP").val() <= -1) {
        alert("Veuiller entrer un nombre de billet valide.");

        return false
    }
    else {
        return true
    }
} //Vérifie que le nombres de billets et billets VIP entrés soient positifs et retourne un bool

function calculSouperSpectacle() {

    var TotalBillet = calculTotalBillet();

    if ($("#nbBilletSouper").val() > TotalBillet || TotalBillet == undefined) {
        alert("Il doit y avoir un nombre de billets plus petit que le nombre total de billet");
    }
    else {
        var totalSouper = parseInt($("#nbBilletSouper").val()) * parseInt($("#prixSouper").val());

        $("#totalSouper").val(round_argent(totalSouper));
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

        $("#nbBilletJeune").val(Math.round(TotalBillet * ratioJeune));
        $("#nbBilletAdulte").val(Math.round(TotalBillet * ratioAdulte));
        $("#nbBilletAine").val(Math.round(TotalBillet * ratioAine));

        $("#rabaisBilletJeune").val(round_argent(PrixMoyen * jeune));
        $("#rabaisBilletAdulte").val(round_argent(PrixMoyen * adulte));
        $("#rabaisBilletAine").val(round_argent(PrixMoyen * aine));
    }
}//Calcule les rabais après avoir vérifié les données

function round_argent(value) {
    var decimals = 2
    return Number(Math.round(value + 'e' + decimals) + 'e-' + decimals).toFixed(decimals);
}//Aroundie les valeurs avec 2 décimales