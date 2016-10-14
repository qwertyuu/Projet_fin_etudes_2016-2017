// JavaScript source code
var TotalBillet
function CalculTotalBillet() {

}
function calculBillet() {
    var nbBillet;
    var prixBillet;

    nbBillet = $("#nbBillet").val();
    prixBillet = $("#prixBillet").val();

    var total = nbBillet * prixBillet;

    $("#totalBillet").val(total);
}
function calculBilletVIP() {
    var nbBilletVIP;
    var prixBilletVIP;

    nbBilletVIP = $("#nbBilletVIP").val();
    prixBilletVIP = $("#prixBilletVIP").val();

    var total = nbBilletVIP * prixBilletVIP;

    $("#totalBilletVIP").val(total);
}
function PourcentCheck() {
    if ($("#JeunePourcent").val() >= 101 || $("#AdultesPourcent").val() >= 101 || $("#AinePourcent").val() >= 101) {
        alert("Veuiller entrer un pourcentage de rabais valide.");
    }
}