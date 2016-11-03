$(function() {
    $("#calendrier-inner").zabuto_calendar({
        language: "fr", data: dates_calendrier
    });
    $('body').on('DOMNodeInserted', '.event-styled', function () {
        $(this).data("container", "body");
        $(this).data("html", "true");
        $(this).tooltip({ placement: "top" });
    });
    $(".event-styled").each(function () {
        $(this).data("container", "body");
        $(this).data("html", "true");
        $(this).tooltip({ placement: "top" });
    });
});