$(function () {
    $("[name=\"service_delete_salle\"]").click(function (e) {
        if (!confirm("Ce service est requis pour les sous-événements suivants: " + $(this).data("evenements") + ".\n\nSi vous continuez, la " + $("#nomSalle").get(0).innerText + " sera déliée de ces sous-événements.")) {
            e.preventDefault();
        }
    });
});
