$(
    function () {
        $("#envoyerMemo").click(function (e) {
            var a_tout_les_destinataires = true;

            if ($('.destinataire').map(function(){ return $(this).val() != null; }).toArray().reduce(function(final, elem){ return final && elem }, true)) {
                var lienAEnvoyer = $("#lien").val().replace(abp.appPath, "");
                lienAEnvoyer = lienAEnvoyer.replace(abp.appPath.slice(0, -1), "");
                if (lienAEnvoyer.charAt(0) == "/") {
                    lienAEnvoyer = lienAEnvoyer.substring(1);
                }
                $.ajax({
                    type: "POST",
                    url: abp.appPath + 'CMemo/Send/',
                    data: { expediteur: $("#expediteur").val(), destinataire: JSON.stringify($('.destinataire-group select option:selected').map(function () { return this.value; }).toArray()), message: $("#message").val(), lien: lienAEnvoyer },
                    success: function (data) {
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
        $('#ajout_dest').click(function () {
            var dest_group = $('.destinataire-group');
            var a_cloner = $(dest_group.get(0)).clone(true);
            var sous_filtre = a_cloner.find(".filtreUsers");
            sous_filtre.val("");
            sous_filtre.trigger("input");
            var sous_dest = a_cloner.find(".destinataire");
            sous_dest.val(sous_dest.find("option:first").val());

            a_cloner.appendTo(dest_group.parent());
        });
        $('#suppr_dest').click(function () {

            var dest_group = $('.destinataire-group');
            if (dest_group.length > 1)
                dest_group.last().remove();
        });
        $(".filtreUsers").on('input', function () {
            var filtre = $(this).val();
            $(this).next().children().each(function () {
                if ($(this).text().toUpperCase().search(filtre.toUpperCase()) > -1) {
                    //$(this).show();
                    $(this).removeAttr('disabled');
                }
                else {
                    //$(this).hide();
                    $(this).attr('disabled', 'disabled');
                }
            });
            if ($(this).next().children().not("[disabled]").length > 0) {
                $(this).next().val($(this).next().children().not("[disabled]").first().val());
            }
            else {
                $(this).next().val([]);
            }
        });
        $("#MemoCreateModal").on('hidden.bs.modal', function () {
            $(".filtreUsers,#message").val("");
            $(".filtreUsers").trigger("input");
            $(".destinataire").val($(".destinataire option:first").val());
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