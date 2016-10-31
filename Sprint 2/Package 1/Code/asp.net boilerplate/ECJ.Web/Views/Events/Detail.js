$(function() {
    $("#calendrier-inner").zabuto_calendar({
        language: "fr", data: dates_calendrier
    });
    $('body').on('DOMNodeInserted', '.event-styled', function () {
        $(this).data("container", "body");
        $(this).tooltip({ placement: "top" });
    });
});