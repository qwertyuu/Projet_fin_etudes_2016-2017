var nbBillet;
var nbBilletVIP;
var TotalBillet;
var PrixMoyen;
function calculTotalBillet() {
    return TotalBillet = parseInt(nbBillet) + parseInt(nbBilletVIP);
} //Met a jour le nombre de billet entr� et le retourne 

function calculMoyenne() {
    PrixMoyen = parseInt($("#totalBillet").val()) + parseInt($("#totalBilletVIP").val());
    PrixMoyen = PrixMoyen / calculTotalBillet();
} //Calcule la moyenne des billets pour le calcul des �ges

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
    if ($("#JeunePourcent").val() > 101 || $("#JeunePourcent").val() < -1 || $("#AdultePourcent").val() > 101 || $("#AdultePourcent").val() < -1 || $("#AinePourcent").val() > 101 || $("#AinePourcent").val() < -1) {
        alert("Veuiller entrer un pourcentage de rabais valide.");

        return false
    }
    //if (parseInt($("#RatioJeune").val()) + parseInt($("#RatioAdulte").val()) + parseInt($("#RatioAine").val()) == 100) {
        
    //}
    else {
        return true
    }
} //V�rifie que les % des �ges sont Positif et moins que 100 et retourne un bool

function ratioCheck() {
    if ($("#RatioJeune").val() > -1 && $("#RatioJeune").val() < 101 || $("#RatioAdulte").val() > -1 && $("#RatioAdulte").val() < 101 || $("#RatioAdulte").val() > -1 && $("#RatioAine").val() < 101) {
        if (parseInt($("#RatioJeune").val()) + parseInt($("#RatioAdulte").val()) + parseInt($("#RatioAine").val()) == 100) {
            return true
        }
    }
    alert("Veuiller entrer un ratio entre 0 et 100 seulement");
    return false
} //V�rifie que les ratios entr�s soient entre 0 et 100 pour ensuite v�rifier si additionn�s ils = 100 ensuite retourne un bool

function positifBilletCheck() {
    if ($("#nbBillet").val() <= -1 || $("#nbBilletVIP").val() <= -1) {
        alert("Veuiller entrer un nombre de billet valide.");

        return false
    }
    else {
        return true
    }
} //V�rifie que le nombres de billet et billet VIP entr�s soient positifs et retourne un bool

function calculSouperSpectacle() {

    var TotalBillet = calculTotalBillet();

    if ($("#nbBilletSouper").val() > TotalBillet || TotalBillet == undefined) {
        alert("Il doit y avoir un nombre de billets plus petit que le nombre total de billet");
    }
    else {
        var totalSouper = parseInt($("#nbBilletSouper").val()) * parseInt($("#prixSouper").val());

        $("#totalSouper").val(totalSouper);
    }
} //Calcule le prix des souper spectacle apr�s avoir v�rifier que les donn�es entr�es soient bonnes

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

        $("#nbBilletJeune").val(TotalBillet * ratioJeune);
        $("#nbBilletAdulte").val(TotalBillet * ratioAdulte);
        $("#nbBilletAine").val(TotalBillet * ratioAine);

        $("#rabaisBilletJeune").val(PrixMoyen * jeune);
        $("#rabaisBilletAdulte").val(PrixMoyen * adulte);
        $("#rabaisBilletAine").val(PrixMoyen * aine);
    }
}//Calcule les rabais apr�s avoir v�rifi� les donn�es