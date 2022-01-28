// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function openModalQuangCao(id) {
    $("#divModal").modal("show");
    $("#spanid").text(id);
    var i = 0;
    for (i = 0; i < dataQc.length; i++) {
        if (dataQc[i].MaQc == id) {
            console.log(dataQc[i]);
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
            if (res.success === true || res.success == true) {
                console.log(res);
                alert("Thêm mới thành công!");
                var obj = res.qc;
                console.log(obj);
                item.MaQc = obj.MaQc;
                dataQc.push(item);
                var htmlStr = '<tr style="text-align:center" id="trNv' + obj.maQc + '">';
                htmlStr = htmlStr + '<td>' + obj.maQc + '</td>';
                htmlStr = htmlStr + '<td>' + obj.ngBd + '</td>';
                htmlStr = htmlStr + '<td>' + obj.ngKt + '</td>';
                htmlStr = htmlStr + '<td>' + obj.soTien + '</td>';
                htmlStr = htmlStr + '<td>' + obj.maNhom + '</td>';
                htmlStr = htmlStr + '<td>' + obj.maKh + '</td>';
                htmlStr = htmlStr + '<td>' + obj.yeuCau + '</td>';
                htmlStr = htmlStr + '<td> <button type="submit" class="btn btn-outline-primary" > <a href="/QuangCaoVaLoaiQuangCao">Chi tiết</a></button> </td>';
                htmlStr = htmlStr + '<td> <button style="margin-bottom:5px" type="button" onclick="openModalQuangCao((' + "'" + obj.maQc + "'" + ');" class="btn btn-outline-primary">Sửa</button>';
                htmlStr = htmlStr + '<button type="button"  onclick="deleteQuangCao(' + "'" + obj.maQc + "'" + ');" class="btn btn-outline-danger">Xoá</button> </td>';
                htmlStr = htmlStr + '</tr>';
                $("#tblQc").append(htmlStr);
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
    item.MaLoai = $("#txtmlqcA").val();

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
function goPrevQuangCao() {
    if (curPageQC == 1) {
        alert("Bạn đang ở trang đầu!");
    }
    else {
        curPageQC = curPageQC - 1;
        getDataPageQC(curPageQC);
    }
}
function goNextQuangCao() {
    if (curPageQC == totalPageQC) {
        alert("Bạn đang ở trang cuối!");
    }
    else {
        curPageQC = curPageQC + 1;
        getDataPageQC(curPageQC);
    }
}
function getDataPageQC(page) {
    var filter = {
        Page: page,
        Size: 5
    };
    var str = JSON.stringify(filter);
    console.log(str);
    $.ajax({
        type: "POST",
        url: "/QuangCao?handler=List",
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { filter: str },
        dataType: "json",
        success: function (res) {
            if (res.success === true || res.success == true) {
                console.log(res.data);
                var data = res.data;
                dataQcx = data.data;
                totalPageQC = data.totalPage;
                $('#tbodyQc').html("");
                $('#QcTemplate').tmpl(dataQcx).appendTo("#tbodyQc");
                $('#spanCurrentPageQC').text(curPageQC)
            }
        },
        error: function (jqXHR, textStatus, errorThrow) {
            alert("Cập nhật thất bại!");
        }
    });
}
function goPrevQuangCao_LoaiQuangCao() {
    if (curPageQC_Lqc == 1) {
        alert("Bạn đang ở trang đầu!");
    }
    else {
        curPageQC_Lqc = curPageQC_Lqc - 1;
        getDataPageQuangCao_LoaiQuangCao(curPageQC_Lqc);
    }
}
function goNextQuangCao_LoaiQuangCao() {
    if (curPageQC_Lqc == totalPageQC_Lqc) {
        alert("Bạn đang ở trang cuối!");
    }
    else {
        curPageQC_Lqc = curPageQC_Lqc + 1;
        getDataPageQuangCao_LoaiQuangCao(curPageQC_Lqc);
    }
}
function getDataPageQuangCao_LoaiQuangCao(page) {
    var filter = {
        Page: page,
        Size: 5
    };
    var str = JSON.stringify(filter);
    console.log(str);
    $.ajax({
        type: "POST",
        url: "/QuangCaoVaLoaiQuangCao?handler=List",
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { filter: str },
        dataType: "json",
        success: function (res) {
            if (res.success === true || res.success == true) {
                console.log(res.data);
                var data = res.data;
                dataQc_Lqcx = data.data;
                totalPageQC_Lqc = data.totalPage;
                $('#tbodyQc_Lqc').html("");
                $('#Qc_LqcTemplate').tmpl(dataQc_Lqcx).appendTo("#tbodyQc_Lqc");
                $('#spanCurrentQuangCao_LoaiQuangCao').text(curPageQC_Lqc)
            }
        },
        error: function (jqXHR, textStatus, errorThrow) {
            alert("Cập nhật thất bại!");
        }
    });
}
//Khách hàng
function openKH(id) {
    if (id != null) {
        $('#divModal').modal('show');
        $("#spanMaKH").text(id);
        var item = null;
        console.log("text : " + id);
        for (var i = 0; i < dataKH.length; i++) {
            if (dataKH[i].MaKH == id) {
                console.log(dataKH[i].MaKH);
                break;
            }
        }
        $("#txtMaKH").val(dataKH[i].MaKH);
        $("#txtTenKH").val(dataKH[i].TenKH);
        $("#txtGT").val(dataKH[i].GT);
        $("#txtEmailKH").val(dataKH[i].Email);
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
    console.log(id),
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
//phan trang KH
function goPrevKH() {
    if (curPageKH == 1) {
        alert("Bạn đang ở trang đầu!")
    }
    else {

        curPageKH = curPageKH - 1;
        getDataPageKH(curPageKH);
    }
}
function goNextKH() {
    if (curPageKH == totalPageKH) {
        alert("Bạn đang ở trang cuối!")
    }
    else {
        curPageKH = curPageKH + 1;
        getDataPageKH(curPageKH);
    }
}
function getDataPageKH(page) {
    var filter = {
        Page: page,
        Size: 5
    };
    var str = JSON.stringify(filter);
    console.log(str);
    $.ajax({
        type: "POST",
        url: "/DoiTac?handler=List",
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { filter: str },
        dataType: "json",
        success: function (res) {
            if (res.success === true || res.success == true) {
                console.log(res.data);
                var data = res.data;
                dataKH1 = data.data;
                
                totalPageKH = data.totalPage;
                $('#tbodyKH').html("");
                $('#khTemplate').tmpl(dataKH1).appendTo("#tbodyKH");
                $('#spanCurPageKH').text(curPageKH);
            }
        },
        error: function (jqXHR, textStatus, errorThrow) {
            alert("Không thể qua trang!");
        }
    });
}
// Bảng nhân viên 
function openModalNV(id) {
    $('#divModalNV').modal('show');
    if (id != null) {
        $('#spanIdNv').text(id);
        var item = null;
        for (var i = 0; i < dataNv.length; i++) {
            item = dataNv[i];
            if (item.MaNv == id) {
                console.log(item);
                break;
            }
        }
        var nv = dataNv[i];
        console.log(nv);
        $("#txtMaNv").val(nv.MaNv);
        $("#txtTenNv").val(nv.TenNv);
        $("#txtMaNhom").val(nv.MaNhom);
        $("#txtEmail").val(nv.Email);
        $("#txtNgSinh").val(nv.NgSinh);
        $("#txtNgVaoLam").val(nv.NgVaoLam);
        $("#txtGt").val(nv.Gt);
    }
    else {
        $('#spanIdNv').text("Thêm mới");
        $("#txtMaNv").val("");
        $("#txtTenNv").val("");
        $("#txtMaNhom").val("");
        $("#txtEmail").val("");
        $("#txtNgSinh").val("");
        $("#txtNgVaoLam").val("");
        $("#txtGt").val("");
    }
}
function saveNhanVien() {
    if ($('#spanIdNv').text() == "Thêm mới") {

        var item = {};
        item.MaNv = $("#txtMaNv").val();
        item.TenNv = $("#txtTenNv").val();
        item.MaNhom = $("#txtMaNhom").val();
        item.Email = $("#txtEmail").val();
        item.NgSinh = $("#txtNgSinh").val();
        item.Gt = $("#txtGt").val();
        item.NgVaoLam = $("#txtNgVaoLam").val();
        var str = JSON.stringify(item);
        $.ajax({
            type: "POST",
            url: "/NhanVien?handler=Add",
            //data: item
            beforeSend: function (xhr) {
                xhr.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());
            },
            data: { nv: str },
            dataType: "json",
            success: function (res) {
                console.log(res);
                if (res.success === true || res.success == true) {
                    console.log(res.nv);
                    var obj = res.nv;
                    item.MaNv = obj.maNv;
                    alert("Thêm mới thành công!");
                    dataNv.push(item);
                    $('#spanIdNv').text(obj.maNv);
                    var htmlStr = '<tr style="text-align:center" id="trNv_' + obj.maNv + '">';
                    htmlStr = htmlStr + '<td>' + obj.maNv + '</td>';
                    htmlStr = htmlStr + '<td>' + obj.tenNv + '</td>';
                    htmlStr = htmlStr + '<td>' + obj.maNhom + '</td>';
                    htmlStr = htmlStr + '<td>' + obj.ngSinh + '</td>';
                    htmlStr = htmlStr + '<td>' + obj.ngVaoLam + '</td>';
                    htmlStr = htmlStr + '<td>' + obj.email + '</td>';
                    htmlStr = htmlStr + '<td>' + obj.gt + '</td>';
                    htmlStr = htmlStr + '<td> <button style="margin-bottom:5px" type="button" onclick="openModalNV(' + "'" + obj.maNv + "'" + ');" class="btn btn-outline-primary">Sửa</button>';
                    htmlStr = htmlStr + '<button type="button"  onclick="deleteNhanVien(' + "'" + obj.maNv + "'" + ');" class="btn btn-outline-danger">Xoá</button> </td>';
                    htmlStr = htmlStr + '</tr>';
                    $("#tbNV").append(htmlStr);
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus, errorThrown);
            }
        });
    }
    else {
        var item = {};
        item.MaNv = ($("#spanIdNv").text());
        item.MaNv = $("#txtMaNv").val();
        item.TenNv = $("#txtTenNv").val();
        item.MaNhom = $("#txtMaNhom").val();
        item.Email = $("#txtEmail").val();
        item.NgSinh = $("#txtNgSinh").val();
        item.Gt = $("#txtGt").val();
        item.NgVaoLam = $("#txtNgVaoLam").val();
        var str = JSON.stringify(item);
        //console.log(str);
        $.ajax({
            type: "POST",
            url: "/NhanVien?handler=Update",
            //data: item
            beforeSend: function (xhr) {
                xhr.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());
            },
            data: { nv: str },
            dataType: "json",
            success: function (res) {
                console.log(res);
                if (res.success === true || res.success == true) {
                    console.log("Cap nhat thanh cong");
                    alert("Cập nhật thành công!");
                    location.reload();
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus, errorThrown);
            }
        });
    }
}
function deleteNhanVien(id) {
    //console.log(id);
    $.ajax({
        type: "POST",
        url: "/NhanVien?handler=Delete",
        //data: item
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { idnv: id },
        dataType: "json",
        success: function (res) {
            console.log(res);
            if (res.success === true || res.success == true) {
                alert("Xóa thành công!");
                location.reload();
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(textStatus, errorThrown);
            alert("Nhân viên hợp đồng với khách hàng nên không xóa được");
        }
    });

}
function goPrevNv() {
    if (curPageNv == 1) {
        alert("Bạn đang ở trang đầu!")
    }
    else {
        curPageNv = curPageNv - 1;
        getDataPageNv(curPageNv);
    }
}
function goNextNv() {
    if (curPageNv == totPageNv) {
        alert("Bạn đang ở trang cuối!")
    }
    else {
        curPageNv = curPageNv + 1;
        getDataPageNv(curPageNv);
    }
}
function getDataPageNv(page) {
    var filter = {
        Page: page,
        Size: 10
    };
    var str = JSON.stringify(filter);
    $.ajax({
        type: "POST",
        url: "/NhanVien?handler=List",
        //data: item
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { filter: str },
        dataType: "json",
        success: function (res) {
            console.log(res);
            if (res.success === true || res.success == true) {
                console.log(res.data);
                var data = res.data;
                dataNvx = data.data;
                totPageNv = data.totalPageNv;
                $("#tbodyNv").html("");
                $("#nvTemplate").tmpl(dataNvx).appendTo("#tbodyNv");
                $("#spanCurrentPageNv").text(curPageNv);
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(textStatus, errorThrown);
        }
    });
}

//Hop dong
function openHopDong(id)
{
    if (id != null)
    {
        $('#divModal').modal('show');
        $('#spanid').text(id);
        var i = 0;
        for (i = 0; i < dataHD.length; i++)
        {
            if (dataHD[i].MaHD == id)
            {
                console.log(dataHD[i]);
                break;
            }
        }
        var hd = dataHD[i];
        console.log(hd);
        $('#txtmhd').val(hd.MaHD);
        $('#txtnk').val(hd.NgayKy);
        $('#txtmnv').val(hd.MaNV);
        $('#txtmkh').val(hd.MaKH);
    }
    else
    {
        $('#divModalAdd').modal('show');
        $('#spanidA').text("[Thêm mới]");
        $('#txtmhdA').val();
        $('#txtnkA').val();
        $('#txtmnvA').val();
        $('#txtmkhA').val();
    }
}
function saveHopDong()
{
    var item = {};
    item.MaHd = $("#spanid").text();
    item.NgayKy = $("#txtnk").val();
    item.MaNv = $("#txtmnv").val();
    item.MaKh = $("#txtmkh").val();

    var str = JSON.stringify(item);
    console.log(str);
    $.ajax
    ({
        type: "POST",
        url: "/HopDong?handler=Update",
        beforeSend: function (xhr)
        {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { hd: str },
        dataType: "json",
        success: function (res)
        {
            console.log(res);
            if (res.success === true || res.success == true)
            {
                console.log("Cap nhat thanh cong!");
                alert("Cập nhật thành công!");
                location.reload();
            }
        },
        error: function (jqXHR, textStatus, errorThrow)
        {
            alert("Cập nhật thất bại!");
        }
    });
}
function deleteHopDong(mhd)
{
    $.ajax
    ({
        type: "POST",
        url: "/HopDong?handler=Delete",
        beforeSend: function (xhr)
        {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { mhd: mhd },
        dataType: "json",
        success: function (res)
        {
            console.log(res);
            if (res.success === true || res.success == true) {
                alert("Xoá thành công!");
                location.reload();
            }
        },
        error: function (jqXHR, textStatus, errorThrow)
        {
            alert("Xoá thất bại!");
        }
    });
}
function addHopDong()
{
    var item = {};
    item.MaHD = $('#txtmhdA').val();
    item.MaKH = $('#txtmkhA').val();
    item.MaNV = $('#txtmnvA').val();
    item.NgayKy = $('#txtnkA').val();
    var str = JSON.stringify(item);
    console.log(str);
    $.ajax
    ({
        type: "POST",
        url: "/HopDong?handler=Add",
        beforeSend: function (xhr)
        {
            xhr.setRequestHeader("XSRF-TOKEN", $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { Hd: str },
        dataType: "json",
        success: function (res)
        {
            console.log(res);
            if (res.success === true || res.success == true)
            {
                console.log("Them moi thanh cong!");
                alert("Thêm mới thành công!");
                location.reload();
            }
        },
        error: function (jqXHR, textStatus, errorThrow)
        {
            alert("Thêm mới thất bại!");
        }
    });
}
function goPrevHD()
{
    if (curPageHD == 1)
    {
        alert("Bạn đang ở trang đầu!");
    }
    else
    {
        curPageHD = curPageHD - 1;
        getDataPageHD(curPageHD);
    }
}
function goNextHD()
{
    if (curPageHD == totalPageHD) {
        alert("Bạn đang ở trang cuối!")
    }
    else
    {
        curPageHD = curPageHD + 1;
        getDataPageHD(curPageHD);
    }
}
function getDataPageHD(page)
{
    var filter =
    {
        Page: page,
        Size: 5
    };
    var str = JSON.stringify(filter);
    console.log(str);
    $.ajax
    ({
        type: "POST",
        url: "/HopDong?handler=List",
        beforeSend: function (xhr)
        {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { filter: str },
        dataType: "json",
        success: function (res)
        {
            if (res.success === true || res.success == true)
            {
                console.log(res.data);
                var data = res.data;
                dataHdx = data.data;
                totalPageHD = data.totalPage;
                $('#tbodyHD').html("");
                $('#hdTemplate').tmpl(dataHdx).appendTo("#tbodyHD");
                $('#spanCurPageHD').text(curPageHD);
            }
        },
        error: function (jqXHR, textStatus, errorThrow)
        {
            alert("Cập nhật thất bại!");
        }
    });
}
//nhom nhan vien
function openModalNNV(id) {
    $('#divModalNNV').modal('show');
    if (id != null) {
        $('#spanIdNNv').text(id);
        var item = null;
        for (var i = 0; i < dataNNv.length; i++) {
            item = dataNNv[i];
            if (item.MaNhom == id) {
                console.log(item);
                break;
            }
        }
        $("#txtMaNhom").val(item.MaNhom);
        $("#txtTenNhom").val(item.TenNhom);
        $("#txtMaNT").val(item.MaNT);
    }
    else {
        $('#spanIdNNv').text("Thêm mới");
        $("#txtMaNhom").val("");
        $("#txtMaNT").val("");
        $("#txtTenNhom").val("");
    }
}
function saveNhomNhanVien() {
    if ($('#spanIdNNv').text() == "Thêm mới") {
        // Create
        var item = {};
        item.MaNhom = $("#txtMaNhom").val();
        item.MaNT = $("#txtMaNT").val();
        item.TenNhom = $("#txtTenNhom").val();
        var str = JSON.stringify(item);
        $.ajax({
            type: "POST",
            url: "/NhomNhanVien?handler=Add",
            //data: item
            beforeSend: function (xhr) {
                xhr.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());
            },
            data: { nnv: str },
            dataType: "json",
            success: function (res) {
                if (res.success === true || res.success == true) {
                    console.log(res.nnv);
                    var obj = res.nnv;
                    item.MaNhom = obj.maNhom;
                    alert("Thêm mới thành công!");
                    dataNNv.push(item);
                    $('#spanIdNNv').text(obj.maNhom);
                    var htmlStr = '<tr style="text-align:center" id="trNNv_' + obj.maNhom + '">';
                    htmlStr = htmlStr + '<td>' + obj.maNhom + '</td>';
                    htmlStr = htmlStr + '<td>' + obj.tenNhom + '</td>';
                    htmlStr = htmlStr + '<td>' + obj.maNT + '</td>';
                    htmlStr = htmlStr + '<td> <button style="margin-bottom:5px" type="button" onclick="openModalNNV(' + "'" + obj.maNhom + "'" + ');" class="btn btn-outline-primary">Sửa</button>';
                    htmlStr = htmlStr + '<button type="button"  onclick="deleteNhomNhanVien(' + "'" + obj.maNhom + "'" + ');" class="btn btn-outline-danger">Xoá</button> </td>';
                    htmlStr = htmlStr + '</tr>';
                    $("#tbNNV").append(htmlStr);
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus, errorThrown);
            }
        });
    }
    else {
        // Update
        var item = {};
        item.MaNhom = ($("#spanIdNNv").text());
        item.TenNhom = $("#txtTenNhom").val();
        item.MaNT = $("#txtMaNT").val();
        var str = JSON.stringify(item);
        //console.log(str);
        $.ajax({
            type: "POST",
            url: "/NhomNhanVien?handler=Update",
            //data: item
            beforeSend: function (xhr) {
                xhr.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());
            },
            data: { nnv: str },
            dataType: "json",
            success: function (res) {
                console.log(res);
                if (res.success === true || res.success == true) {
                    console.log("Cap nhat thanh cong");
                    alert("Cập nhật thành công!");
                    location.reload();
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus, errorThrown);
            }
        });
    }
}
function deleteNhomNhanVien(id) {
    //console.log(id);
    $.ajax({
        type: "POST",
        url: "/NhomNhanVien?handler=Delete",
        //data: item
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { idnnv: id },
        dataType: "json",
        success: function (res) {
            console.log(res);
            if (res.success === true || res.success == true) {
                //console.log("Xóa thành công");
                location.reload();
                //$("#trNNv_" + id).remove();
                var i = 0;
                for (var i = 0; i < dataNNv.length; i++) {
                    var nhomnhanvien = dataNNv[i];
                    if (nhomnhanvien.MaNhom == item.MaNhom) {
                        break;
                    }
                }
                dataNNv.splice(i, 1);
                alert("Xóa thành công!");
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(textStatus, errorThrown);
            alert("Xóa thất bại !!! ");
        }
    });

}
function goPrevNnv() {
    if (curPageNnv == 1) {
        alert("Bạn đang ở trang đầu!")
    }
    else {

        curPageNnv = curPageNnv - 1;
        getDataPageNnv(curPageNnv);
    }
}
function goNextNnv() {
    if (curPageNnv == totalPageNnv) {
        alert("Bạn đang ở trang cuối!")
    }
    else {
        curPageNnv = curPageNnv + 1;
        getDataPageNnv(curPageNnv);
    }
} function getDataPageNnv(page) {
    var filter = {
        Page: page,
        Size: 5
    };
    var str = JSON.stringify(filter);
    $.ajax({
        type: "POST",
        url: "/NhomNhanVien?handler=Update",
        //data: item
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { nnv: str },
        dataType: "json",
        success: function (res) {
            console.log(res);
            if (res.success === true || res.success == true) {
                console.log(res.data);
                var data = res.data;
                dataNnv = data.data;
                totPageNnv = data.totalPage;
                $("#tbodyNnv").html("");
                $("#NnvTemplate").tmpl(dataNnv).appendTo("#tbodyNnv");
                $("#spanCurrentPageNnv").text(curPageNnv);
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(textStatus, errorThrown);
        }
    });
}
