(function ($) {

    //Notification handler
    abp.event.on('abp.notifications.received', function (userNotification) {
        abp.notifications.showUiNotifyForUserNotification(userNotification);
    });

    //serializeFormToObject plugin for jQuery
    $.fn.serializeFormToObject = function () {
        //serialize to array
        var data = $(this).serializeArray();

        //add also disabled items
        $(':disabled[name]', this).each(function () {
            data.push({ name: this.name, value: $(this).val() });
        });

        //map to object
        var obj = {};
        data.map(function (x) { obj[x.name] = x.value; });

        return obj;
    };

    //Configure blockUI
    if ($.blockUI) {
        $.blockUI.defaults.baseZ = 2000;
    }

    $("[title=\"Supprimer\"]").click(function (e) {
        if (!confirm("Êtes-vous sur de vouloir supprimer cet élément?")) {
            e.preventDefault();
        }
    });

    $("[title=\"SupprimerAppel\"]").click(function (e) {
        if (!confirm("Si vous supprimez cet appel d'offre il sera suprimé definitivement ou son statut tombera à Annulé en fonction de son statut présent.n\ Êtes-vous sur de vouloir le faire?")) {
            e.preventDefault();
        }
    });

    $(".dp").datepicker({ dateFormat: 'yy/mm/dd' });

    //désactiver le lien 
    $("#AppelComplete").click(function (event) {
        return false;
    });

})(jQuery);