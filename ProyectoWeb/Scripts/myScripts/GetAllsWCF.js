$(document).ready(function () {
    $("button").click(function () {
        alert("clicked");
        var data = $("#txt").val();
        var postdata = {};
        var data_obj = { "BoolValue": "true", "StringValue": data }
        postdata["value"] = data_obj;

        var url = "http://localhost:3541/ServiceCustomer.svc/getalls";
        $.ajax({
            type: "GET",
            url: url,
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(postdata),
            dataType: "json",
            success: function (data) { console.log(data); },
            error: function (a, b, c) { console.log(a); }
        });
    });
});