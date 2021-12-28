// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

const { data, error } = require("jquery");

// Write your JavaScript code.
function openModalQuangCao(id) {
    $("#divModal").modal("show");
    $("#spanid").text(id);
    var i = 0;
    for (i = 0; i < dataQc.length; i++) {
        if (dataQc[i].MaQc == id) {
            break;
        }
    }
    var qc = dataQc[i];
    console.log(qc);
    $("#txtnbd").val(qc.NgBd);
    $("#txtntt").val(qc.NgKt);
    $("#txtTt").val(qc.SoTien);
    $("#txtNth").val(qc.MaNhom);
    $("#txtKh").val(qc.MaKh);
    $("#txtyc").val(qc.YeuCau);
}
function openModalQuangCaoAdd() {
    $("#divModalAdd").modal("show");
    $("#spanidA").text("Thêm mới");
    $("#txtmqcA").val();
    $("#txtnbdA").val();
    $("#txtnttA").val();
    $("#txtTtA").val();
    $("#txtNthA").val();
    $("#txtKhA").val();
    $("#txtycA").val();
}
function saveQuangCao() {
    var item = {};
    item.MaQc = $("#spanid").text();
    item.MaKh = $("#txtKh").val();
    item.MaNhom = $("#txtNth").val();   
    item.NgBd = $("#txtnbd").val();
    item.NgKt = $("#txtntt").val();
    item.YeuCau = $("#txtyc").val();
    item.SoTien = $("#txtTt").val();
    
    var str = JSON.stringify(item);
    console.log(str);
    $.ajax({
        type: "POST",
        url: "/QuangCao?handler=Update",
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { qc: str },
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
function deleteQuangCao(mqc) {
    $.ajax({
        type: "POST",
        url: "/QuangCao?handler=Delete",
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { mqc: mqc },
        dataType: "json",
        success: function (res) {
            console.log(res);
             if (res.success === true || res.success == true) {
                alert("Xoá thành công!");
                location.reload();
            }
        },
        error: function (jqXHR, textStatus, errorThrow) {
            alert("Xoá thất bại!");
        }
    });
}
function addQuangCao() {
    var item = {};
    item.MaQc = $("#txtmqcA").val();
    item.MaKh = $("#txtKhA").val();
    item.MaNhom = $("#txtNthA").val();
    item.NgBd = $("#txtnbdA").val();
    item.NgKt = $("#txtnttA").val();
    item.YeuCau = $("#txtycA").val();
    item.SoTien = $("#txtTtA").val();
    var str = JSON.stringify(item);
    console.log(str);
    $.ajax({
        type: "POST",
        url: "/QuangCao?handler=Add",
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { qc: str },
        dataType: "json",
        success: function (res) {
            console.log(res);
            if (res.success === true || res.success == true) {
                console.log("Thêm mới thanh cong");
                alert("Thêm mới thành công!");
                location.reload();
            }
        },
        error: function (jqXHR, textStatus, errorThrow) {
            alert("Thêm mới thất bại!");
        }
    });
}
function openModalLoaiQuangCao(id) {

    $("#divModal").modal("show");
    $("#spanid").text(id);
    var i = 0;
    for (i = 0; i < dataLqc.length; i++) {
        if (dataLqc[i].MaLoai == id) {
            break;
        }
    }
    var lqc = dataLqc[i];
    console.log(lqc);
    $("#txtht").val(lqc.HinhThuc);
    $("#txtmt").val(lqc.MoTa);
}
function saveLoaiQuangCao() {
    var item = {};
    item.Maloai = $("#spanid").text();
    item.HinhThuc = $("#txtht").val();
    item.MoTa = $("#txtmt").val();

    var str = JSON.stringify(item);
    console.log(str);
    $.ajax({
        type: "POST",
        url: "/LoaiQuangCao?handler=Update",
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { lqc: str },
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
function deleteLoaiQuangCao(mlqc) {
    $.ajax({
        type: "POST",
        url: "/LoaiQuangCao?handler=Delete",
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { mlqc: mlqc },
        dataType: "json",
        success: function (res) {
            console.log(res);
            if (res.success === true || res.success == true) {
                alert("Xoá thành công!");
                location.reload();
            }
        },
        error: function (jqXHR, textStatus, errorThrow) {
            alert("Xoá thất bại!");
        }
    });
}
function openModalLoaiQuangCaoAdd() {
    $("#divModalAdd").modal("show");
    $("#spanidA").text("Thêm mới");
    $("#txtmlqcA").val();
    $("#txthtA").val();
    $("#txtmtA").val();
}
function addLoaiQuangCao() {
    var item = {};
    item.Maloai = $("#txtmlqcA").val();
    item.HinhThuc = $("#txthtA").val();
    item.MoTa = $("#txtmtA").val();

    var str = JSON.stringify(item);
    console.log(str);
    $.ajax({
        type: "POST",
        url: "/LoaiQuangCao?handler=Add",
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { lqc: str },
        dataType: "json",
        success: function (res) {
            console.log(res);
            if (res.success === true || res.success == true) {
                console.log("Thêm mới thanh cong");
                alert("Thêm mới thành công!");
                location.reload();
            }
        },
        error: function (jqXHR, textStatus, errorThrow) {
            alert("Thêm mới thất bại!");
        }
    });
}
function openModalQuangCao_LoaiQuangCao(mqc, mlqc) {
    $("#divModal").modal("show");
    $("#spanid1").text(mqc);
    $("#spanid2").text(mlqc);
    var i = 0;
    for (i = 0; i < dataQc_Lqc.length; i++) {
        if (dataQc_Lqc[i].MaQc == mqc && dataQc_Lqc[i].MaLoai == mlqc) {
            break;
        }
    }
    var qc = dataQc_Lqc[i];
    console.log(qc);
    $("#txtmqc").val(qc.MaQc);
    $("#txtmlqc").val(qc.MaLoai);
}
function saveQuangCao_LoaiQuangCao() {
    var item = {};
    var temp = {};
    temp.MaQc = $("#spanid1").text();
    temp.MaLoai = $("#spanid2").text();
    item.MaQc = $("#txtmqc").val();
    item.MaLoai = $("#txtmlqc").val();
    var temps = JSON.stringify(temp);
    var str = JSON.stringify(item);
    $.ajax({
        type: "POST",
        url: "/QuangCaoVaLoaiQuangCao?handler=Update",
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: {
            qclqctemp: temps,
                qclqc: str
        },
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
function deleteModalQuangCao_LoaiQuangCao(mqc, mlqc) {
    $.ajax({
        type: "POST",
        url: "/QuangCaoVaLoaiQuangCao?handler=Delete",
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: {
            mqc: mqc,
            mlqc: mlqc
        },
        dataType: "json",
        success: function (res) {
            console.log(res);
            if (res.success === true || res.success == true) {
                alert("Xoá thành công!");
                location.reload();
            }
        },
        error: function (jqXHR, textStatus, errorThrow) {
            alert("Xoá thất bại!");
        }
    });
}
function openModalQuangCao_LoaiQuangCaoAdd() {
    $("#divModalAdd").modal("show");    
    $("#txtmqcA").val();
    $("#txtmlqcA").val();
}
function addQuangCao_LoaiQuangCao() {
    var item = {};
    item.MaQc = $("#txtmqcA").val();
    item.MaLoai =$("#txtmlqcA").val();

    var str = JSON.stringify(item);
    console.log(str);
    $.ajax({
        type: "POST",
        url: "/QuangCaoVaLoaiQuangCao?handler=Add",
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { a: str },
        dataType: "json",
        success: function (res) {
            console.log(res);
            if (res.success === true || res.success == true) {
                console.log("Thêm mới thanh cong");
                alert("Thêm mới thành công!");
                location.reload();
            }
        },
        error: function (jqXHR, textStatus, errorThrow) {
            alert("Thêm mới thất bại!");
        }
    });
}