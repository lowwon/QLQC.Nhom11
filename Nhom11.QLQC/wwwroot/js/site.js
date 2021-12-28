// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

const { data } = require("jquery");

// Write your JavaScript code.
function openKH(id) {
    if (id != null) {
        $('#divModal').modal('show');
        $("#spanMaKH").text(id);
        var item = null;
        for (var i = 0; i < dataKH.length; i++) {
            item = dataKH[i];
            if (item.MaKH == id) {
                console.log(item);
                break;
            }
        }
       
        $("#txtTenKH").val(item.TenKH);
        $("#txtGT").val(item.GT);
        $("#txtEmailKH").val(item.Email);
    }
    else {
        $('#divModal').modal('show');
        $("#spanMaKH").text("[Thêm mới]");
        $("#txtMaKH").val("");
        $("#txtTenKH").val("");
        $("#txtGT").val("");
        $("#txtEmailKH").val("");
    }
    
}

function saveKH() {
    //Thêm
    if (($("#spanMaKH").text()) == "[Thêm mới]") {
        var item = {};
        item.MaKH = ($("#txtMaKH").val());
        item.TenKH = $("#txtTenKH").val();
        item.GT = $("#txtGT").val();
        item.Email = $("#txtEmailKH").val();
        var str = JSON.stringify(item);
        console.log(str);
        $.ajax({
            type: "POST",
            url: "/DoiTac?handler=Add",
            beforeSend: function (xhr) {
                xhr.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());
            },
            data: { KH: str },
            dataType: "json",
            success: function (res) {
                console.log(res);
                if (res.success === true || res.success == true) {
                    console.log("Them moi thanh cong");
                    alert("Thêm mới thành công!");
                    location.reload();
                }
            },
            error: function (jqXHR, textStatus, errorThrow) {
                alert("Thêm mới thất bại!");
            }
        });
    }
    else {
        //sửa
        var item = {};
        item.MaKH = ($("#spanMaKH").text());
        item.TenKH = $("#txtTenKH").val();
        item.GT = $("#txtGT").val();
        item.Email = $("#txtEmailKH").val();

        var str = JSON.stringify(item);
        console.log(str);
        $.ajax({
            type: "POST",
            url: "/DoiTac?handler=Update",
            beforeSend: function (xhr) {
                xhr.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());
            },
            data: { KH: str },
            dataType: "json",
            success: function (res) {
                console.log(res);
                if (res.success === true || res.success == true) {
                    console.log("Cap nhat thanh cong");
                    alert("Cập nhật thành công!");
                    location.reload();
                }
            },
            error: function (jqXHR, textStatus, errorThrow) {
                alert("Cập nhật thất bại!");
            }
        });
    }
    
}

function deleteKH(id) {
    $.ajax({
        type: "POST",
        url: "/DoiTac?handler=Delete",
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { KHid: id },
        dataType: "json",
        success: function (res) {
            console.log(res);
            if (res.success === true || res.success == true) {
                alert("Xóa thành công!");
                location.reload();
            }
        },
        error: function (jqXHR, textStatus, errorThrow) {
            alert("Xóa thất bại!");
        }
    });
}