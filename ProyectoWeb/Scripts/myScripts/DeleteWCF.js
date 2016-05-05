$(document).ready(function () {
    $("button").click(function () {
        alert("clicked");
        var data = $("#txt").val();
        data = { Nombre: "jennnnn", Phone: "23153" };
        var postdata = {};
        var data_obj = {"BoolValue" : "true" , "StringValue": data}
        postdata["value"] =  data_obj; 

        var url_Delete = "http://localhost:3541/ServiceCustomer.svc/Delete";
        $.ajax({
            type: "DELETE",
            url: url_Delete + "/id",
            error: function (a, b, c) { console.log(a); }
        });
    });
});