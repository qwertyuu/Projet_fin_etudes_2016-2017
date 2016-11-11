$(
    function () {
        $("#envoyerMemo").click(function (e) {
            if ($("#destinataire").val() != null) {
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
            }
            else {
                afficherErreur();
            }
        });
        $("#filtreUsers").bind('input', function () {
            var filtre = $("#filtreUsers").val();
            $("#destinataire > option").each(function () {
                if ($(this).text().toUpperCase().search(filtre.toUpperCase()) > -1) {
                    $(this).show();
                }
                else {
                    $(this).hide();
                }
            });
            if ($("#destinataire > option:visible").length > 0) {
                $("#destinataire").val($("#destinataire option:visible:first").val());
            }
            else {
                $("#destinataire").val([]);
            }
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