$(function () {
    $("form").submit(function (e) {
        var email = $("#email").val();
        var uname = $("#uname").val();
        var event = e;
        $.ajax({
            method: "POST",
            url: abp.appPath + "Users/CheckUser",
            data: { uname: uname, email: email, exclu_id:$('[name="Id"]').val() },
            async:false,
            success: function (data) {
                if (data != "1") {
                    event.preventDefault();
                    alert(data);
                }
            },
            error: function () {
                event.preventDefault();
                alert("N'a pas pu vérifier avec le serveur");
            }
        })
        var Pass = $('[name="PasswordChange"]').val();

        if (Pass.length >= 8) {
            var AUneMinuscule = false;
            var AUneMajuscule = false;
            var AUnChiffre = false;
            Pass.split("").forEach(function (c) {
                if($.inArray(c, ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"]) >= 0){
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
        } else if(Pass.length != 0) {
            MauvaisPass();
            event.preventDefault();
        }
    });
});

function MauvaisPass() {
    alert("Veuillez entrer un mot de passe contenant 8 caractères ou plus et comportant une lettre minuscule, une lettre majuscule et un nombre");
}