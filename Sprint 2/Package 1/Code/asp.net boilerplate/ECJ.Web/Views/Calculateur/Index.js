// JavaScript source code


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