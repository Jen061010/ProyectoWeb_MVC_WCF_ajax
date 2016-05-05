$(document).ready(function () {
    $("button").click(function () {
        alert("clicked");
        var data =$("#txt").val();
          data={Nombre: "jennnnn", Phone: "23153"};
        var postdata = {};
        var data_obj = { "BoolValue": "true", "StringValue": data }
        postdata["value"] = data_obj;
        var url = "http://localhost:3541/ServiceCustomer.svc/Add";
        $.ajax({
            type: "POST",
            url: url,
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(postdata),
            dataType: "json",
            success: function (data) { console.log(data); },
            error: function (a, b, c) { console.log(a); }
        });
    });
});