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
    $(".event-styled").each(function () {
        SetEventsCalendar(this);
    });
});

function SetEventsCalendar(e) {
    $(e).data("container", "body");
    $(e).data("html", "true");
    $(e).tooltip({ placement: "top" });

}