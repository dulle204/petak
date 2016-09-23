$(document).ready(function () {
    $.ajax({
        url: "http://localhost:56470/api/country",
        type: "Get",
        success: function (data) {
            $.each(data, function (index, item) {
                $('#ddCountry').append($('<option></option>').val(item.Name).html(item.Name));
            })
        },
        error: function (msg) { alert(msg); }
    });
});