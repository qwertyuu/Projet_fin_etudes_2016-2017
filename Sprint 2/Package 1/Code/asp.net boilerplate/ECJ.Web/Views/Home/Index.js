$(function () {
    $(".sommaireMemo tbody tr.warning").on("click", function (e) {
        console.log(!$(e.target).is('a'));
        var moi = $(this);
        if (moi.hasClass("warning")) {
            $.ajax({
                method: "POST",
                data: { id: moi.data("id") },
                url: abp.appPath + "Lire",
                success: function () {
                    var sorting = $(".sommaireMemo").get(0).config.sortList;
                    moi.removeClass("warning");
                    var etatcell = moi.find(".etatCell");
                    etatcell.data("sort-value", 1);
                    etatcell.text("Lu");
                    var resort = "",
                    cb = function (u) { };
                    $(".sommaireMemo").trigger("updateCell", [etatcell.get(0), resort, cb]);
                },
                async: !$(e.target).is('a'),
                timeout: 3000
            });
        }

    });
    $(".sommaireMemo").trigger("sorton", [[[4, 0], [2, 1]]]);
});