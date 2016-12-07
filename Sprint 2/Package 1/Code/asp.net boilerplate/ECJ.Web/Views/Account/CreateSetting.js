$(function () {
    var Pass = $('.PasswordChange').val();

    $(".valid").closest("form").submit(function (e) {
        if ($(".PasswordChange").val() != $(".PasswordChange2").val()) {
            alert("Veuillez entrer le même mot de passe.");
            return false;
        }
        else if (Pass.length >= 8) {
            var AUneMinuscule = false;
            var AUneMajuscule = false;
            var AUnChiffre = false;
            Pass.split("").forEach(function (c) {
                if ($.inArray(c, ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"]) >= 0) {
                    AUneMinuscule = true;
                }
                else if ($.inArray(c, "ABCDEFGHIJKLMNOPQRSTUVWXYZ") >= 0) {
                    AUneMajuscule = true;
                }
                else if ($.inArray(c, "1234567890") >= 0) {
                    AUnChiffre = true;
                }
            });
            if (!(AUneMajuscule && AUneMajuscule && AUnChiffre)) {
                MauvaisPass();
                event.preventDefault();
            }
        } else if (Pass.length != 0) {
            MauvaisPass();
            event.preventDefault();
        }
    });
});

function MauvaisPass() {
    alert("Veuillez entrer un mot de passe contenant 8 caractères ou plus et comportant une lettre minuscule, une lettre majuscule et un nombre");
}