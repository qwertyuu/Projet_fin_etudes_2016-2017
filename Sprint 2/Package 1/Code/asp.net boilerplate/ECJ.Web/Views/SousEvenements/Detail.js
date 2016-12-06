$(function () {
    $("#calendrier-inner").zabuto_calendar({
        language: "fr", data: dates_calendrier,
        action: function () {
            var pagesAOuvrir = ids_calendrier[$(this).data("date")];
            var nouvelle_page = pagesAOuvrir.length > 1;
            pagesAOuvrir.forEach(function (element) {
                var chemin = abp.appPath + "Activite/Detail/" + element.toString() + "?" + return_url;
                if (nouvelle_page) {
                    window.open(chemin, '_blank');
                }
                else {
                    location.href = chemin;
                }
            });
        }
    });
    $('body').on('DOMNodeInserted', '.event-styled', function () {
        SetEventsCalendar(this);
    });
    $(".event-styled").each(function(){
        SetEventsCalendar(this);
    });
    $("[name$=\"delete_salle\"]").click(function (e) {
        if (!confirm("Ajouter ce service supprimera la salle couramment liée au sous-événement, car elle n'offre pas ce service: " + $(this).parent().siblings().text() + ".\nVoulez-vous tout de même ajouter ce service?")) {
            e.preventDefault();
        }
    });
});

function SetEventsCalendar(e) {
    $(e).data("container", "body");
    $(e).data("html", "true");
    $(e).tooltip({ placement: "top" });
}