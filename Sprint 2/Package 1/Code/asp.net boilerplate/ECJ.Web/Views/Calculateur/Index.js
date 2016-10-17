var nbBillet;
var nbBilletVIP;
var TotalMontant;
var TotalBillet;

function calculTotalBillet() {
    return TotalBillet = parseInt(nbBillet) + parseInt(nbBilletVIP);
} //Met a jour le nombre de billet entré et le retourne 

function calculTotalMontant(montantAdditionel) {
    TotalMontant = TotalMontant + montantAdditionel;
} //n'est pas utilisé ce n'est pas un bon moyen finalement je doit trouver une alternative

function calculBillet() {

    var prixBillet;

    if (positifBilletCheck() == true) {
        nbBillet = $("#nbBillet").val();
        prixBillet = $("#prixBillet").val();

        var total = nbBillet * prixBillet;

        $("#totalBillet").val(total);
    }
} //Calcule le prix des billets normaux

function calculBilletVIP() {

    var prixBilletVIP;

    if (positifBilletCheck() == true) {
        nbBilletVIP = $("#nbBilletVIP").val();
        prixBilletVIP = $("#prixBilletVIP").val();

        var total = nbBilletVIP * prixBilletVIP;

        $("#totalBilletVIP").val(total);
    }
} //Calcule le prix des billets VIP

function pourcentCheck() {
    if ($("#JeunePourcent").val() >= 101 || $("#JeunePourcent").val() <= -1 || $("#AdultesPourcent").val() >= 101 || $("#AdultesPourcent").val() <= -1 || $("#AinePourcent").val() >= 101 || $("#AinePourcent").val() <= -1) {
        alert("Veuiller entrer un pourcentage de rabais valide.");

        return false
    }
    else {
        return true
    }
} //Vérifie que les % des âges sont Positif et moins que 100 et retourne un bool

function positifBilletCheck() {
    if ($("#nbBillet").val() <= -1 || $("#nbBilletVIP").val() <= -1) {
        alert("Veuiller entrer un nombre de billet valide.");

        return false
    }
    else {
        return true
    }
} //Vérifie que le nombres de billet et billet VIP entrés soient positifs et retourne un bool

function calculSouperSpectacle() {

    var TotalBillet = calculTotalBillet();

    if ($("#nbBilletSouper").val() > TotalBillet || TotalBillet == undefined) {
        alert("Il doit y avoir un nombre de billets plus petit que le nombre total de billet");
    }
    else {
        var totalSouper = parseInt($("#nbBilletSouper").val()) * parseInt($("#prixSouper").val());

        $("#totalSouper").val(totalSouper);
    }
} //Calcule le prix des souper spectacle après avoir vérifier que les données entrées soient bonnes

function calculRabaisAge() {
    if (pourcentCheck() == true && $("#nbBilletJeune").val() > TotalBillet) {
        var Jeune = parseFloat($("#JeunePourcent").val()) / -100 + 1;

        $("#totalPourcentRabaisJeune").val(jeune * parseInt($("#totalBillet").val()))
    }
}//Calcule les rabais après avoir vérifié les données