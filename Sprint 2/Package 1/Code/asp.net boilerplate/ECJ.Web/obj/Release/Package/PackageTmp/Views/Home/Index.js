$(function () {
    $(".sommaireMemo tbody tr.warning").on("click", function () {
        var moi = $(this);
        if (moi.hasClass("warning")) {
            $.ajax({
                method: "POST",
                data: { id: moi.data("id") },
                url: "/Lire",
                success: function () {
                    var sorting = $(".sommaireMemo").get(0).config.sortList;
                    moi.removeClass("warning");
                    var etatcell = moi.find(".etatCell");
                    etatcell.data("sort-value", 1);
                    etatcell.text("Lu");
                    var resort = "",
                    cb = function (u) { };
                    $(".sommaireMemo").trigger("updateCell", [etatcell.get(0), resort, cb]);
                }
            });
        }

    });
    $(".sommaireMemo").trigger("sorton", [[[4, 0], [2, 1]]]);
});