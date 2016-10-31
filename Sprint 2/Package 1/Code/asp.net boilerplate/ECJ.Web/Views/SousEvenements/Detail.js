$(function() {
    $("#calendrier-inner").zabuto_calendar({ language: "fr", data: dates_calendrier });

    $("[name$=\"delete_salle\"]").click(function (e) {
        if (!confirm("Ajouter ce service supprimera la salle couramment liée au sous-événement, car elle n'offre pas ce service: " + $(this).parent().siblings().text() + ".\nVoulez-vous tout de même ajouter ce service?")) {
            e.preventDefault();
        }
    });
});