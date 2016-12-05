$(function () {
    $(".valid").closest("form").submit(function (e) {
        if ($(".PasswordChange").val() != $(".PasswordChange2").val()) {
            alert("Veuillez entrer le même mot de passe.");
            return false;
        }
        return true;
    });
});