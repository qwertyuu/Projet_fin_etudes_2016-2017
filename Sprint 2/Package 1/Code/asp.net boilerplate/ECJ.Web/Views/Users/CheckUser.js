$(function () {
    $("form").submit(function (e) {
        var email = $("#email").val();
        var uname = $("#uname").val();
        var event = e;
        $.ajax({
            method: "POST",
            url: abp.appPath + "Users/CheckUser",
            data: { uname: uname, email: email },
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
    });
});