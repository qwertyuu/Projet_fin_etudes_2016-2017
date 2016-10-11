$(
    function () {
        $("#envoyerMemo").click(function (e) {
            $.ajax({
                type: "POST",
                url: 'CMemo/FirstAjax/',
                data: { expediteur: 'testing', destinataire: 'testing', message: 'lol haha' },
                success: function (data) {
                    console.log(data);
                    //afficherSucces();
                    afficherErreur();
                },
                error: function (a) { console.log(a); }
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