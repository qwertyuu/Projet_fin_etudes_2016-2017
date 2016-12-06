$(function () {
    $(".valid").closest("form").submit(function (e) {
        if ($(".PasswordChange").val() != $(".PasswordChange2").val()) {
            alert("Veuillez entrer le même mot de passe.");
            return false;
        }
        else if ($(".PasswordChange").val().match(/^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])([a-zA-Z0-9]{8,})$/)){
            return true;
        } else {
            alert("Veuillez entrer un mot de passe contenant 8 caractères ou plus et comportant une lettre minuscule, une lettre majuscule et un nombre");
            return false;
        }
        });
});