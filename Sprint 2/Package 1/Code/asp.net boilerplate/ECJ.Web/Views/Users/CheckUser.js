$(function () {
    $("form").submit(function (e) {
        var email = $("#email").val();
        var uname = $("#uname").val();
        var event = e;
        $.ajax({
            method: "POST",
            url: abp.appPath + "Users/CheckUser",
            data: { uname: uname, email: email },
            success: function (data) {
                if (data != "1") {
                    alert(data);
                    event.preventDefault();
                }
            },
            error: function () {
                alert("N'a pas pu vérifier avec le serveur");
                event.preventDefault();
            }
        })
    });
});