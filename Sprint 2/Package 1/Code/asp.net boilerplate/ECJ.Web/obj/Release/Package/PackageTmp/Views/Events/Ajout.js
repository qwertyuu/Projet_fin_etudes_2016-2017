$(function () {
    $(".dp[name=\"dateDebut\"]").datepicker('option', 'onClose', function () {
        $(".dp[name=\"datefin\"]").datepicker(
        "change",
        {
            minDate: new Date($(".dp[name=\"dateDebut\"]").val())
        }
        );
    });
    $(".dp[name=\"datefin\"]").datepicker('option', 'onClose', function () {
        $(".dp[name=\"dateDebut\"]").datepicker(
        "change",
        {
            maxDate: new Date($(".dp[name=\"datefin\"]").val())
        }
        );
    });

    $(".valid").closest("form").submit(function (e) {
        if ($(".dp[name=\"datefin\"]").val() < $(".dp[name=\"dateDebut\"]").val()) {
            alert("Veuillez entrer une date de début antérieure à la date de fin");
            return false;
        }
        return true;
    });
});