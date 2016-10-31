$(function () {
    $(".sommaireMemo tbody tr.warning").on("click", function () {
        var moi = $(this);
        $.ajax({
            method: "POST",
            data: { id: moi.data("id") },
            url: "Lire",
            success: function () {
                moi.removeClass("warning");
            }
        });
    });
});