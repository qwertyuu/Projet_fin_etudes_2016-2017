$(
    function () {
        $("#envoyerMemo").click(function (e) {
            $.ajax({
                type: "POST",
                url: '/CMemo/Send/',
                data: { expediteur: $("#expediteur").val(), destinataire: $("#destinataire").val(), message: $("#message").val(), lien: $("#lien").val() },
                success: function (data) {
                    console.log(data);
                    afficherSucces();
                },
                error: function (data) {
                    afficherErreur();
                }
            });
        });

    }
);

function afficherSucces() {
    $(".modal-footer button").prop('disabled', true);
    $("#messageSucces").fadeIn();
    setTimeout(function () {
        $(".modal-footer button").prop('disabled', false);
        $("#messageSucces").hide();

        $("#MemoCreateModal").modal('toggle');
    }, 3000);
}

function afficherErreur() {
    $("#messageErreur").fadeIn();
    setTimeout(function () {
        $("#messageErreur").fadeOut();
    }, 5000);
}