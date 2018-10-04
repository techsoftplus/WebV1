//List sản phẩm 
function filterTimKiem(chuyenMucId, tuKhoa) {
    // Bỏ đi mặc định tham số đầu tiên của lưới
    if (chuyenMucId && chuyenMucId.pageSize) {
        chuyenMucId = null;
    }

    chuyenMucId = chuyenMucId || $("#cmbLocChuyenMuc").data("kendoComboBox").value();
    tuKhoa = tuKhoa || $("#txtTuKhoa").val();

    return {
        chuyenMucId: chuyenMucId,
        tuKhoa: tuKhoa
    };
}

function filterLocChuyenMuc() {
    return {
        tuKhoa: $("#cmbLocChuyenMuc").data("kendoComboBox").text()
    };
}

function selectLocChuyenMuc(e) {
    var value = "";

    if (e.item) {
        const dataItem = this.dataItem(e.item);

        value = dataItem.Id;
    }

    $(".list-sanpham #gridSanPham")
       .data("kendoGrid")
       .dataSource.read(filterTimKiem(value, null));
}

//Add Or Update sản phẩm 
function filterChuyenMuc() {
    var tuKhoa = $("#msChuyenMucs").data("kendoMultiSelect").input.val();

    if ($("#msChuyenMucs").data("kendoMultiSelect").input.val().includes("Chọn chuyên mục")) {
        tuKhoa = null;
    }

    return {
        tuKhoa: tuKhoa
    };
}

function filterMauSac() {
    var tuKhoa = $("#msMauSacs").data("kendoMultiSelect").input.val();

    if ($("#msMauSacs").data("kendoMultiSelect").input.val().includes("Chọn màu sắc")) {
        tuKhoa = null;
    }

    return {
        tuKhoa: tuKhoa
    };
}

function filterTag() {
    var tuKhoa = $("#msTags").data("kendoMultiSelect").input.val();

    if ($("#msTags").data("kendoMultiSelect").input.val().includes("Chọn Tag")) {
        tuKhoa = null;
    }

    return {
        tuKhoa: tuKhoa
    };
}

//Tag sản phẩm - Add Or Update
function filterSanPhamTag() {
    return {
        tuKhoa: $("#TagId").data("kendoComboBox").text()
    };
}

function selectTagSanPham(e) {
    if (e.item) {
        const dataItem = this.dataItem(e.item);
        $("#TagName").val(dataItem.Ten).trigger("change");
    }
}

//Ảnh video - Add Or Update
function anhVideoImageChanged(value) {
    $("#imgAnhVideo").attr("src", value);

    $("#btnChonAnhVideo").addClass("hidden");
    $("#btnXoaAnhVideo").removeClass("hidden");
}

//Ảnh đại diện diện sản phẩm - Add Or Update
function anhDaiDienImageChanged(value) {
    $("#imgAnhDaiDien").attr("src", value);

    $("#btnChonAnhDaiDien").addClass("hidden");
    $("#btnXoaAnhDaiDien").removeClass("hidden");
}

function anhSanPhamImageChanged(value) {
    $("#imgSanPham").attr("src", value);

    $("#UrlPhoto").val(value).trigger("change");

    $("#btnChonAnhSanPham").addClass("hidden");
    $("#btnXoaAnhSanPham").removeClass("hidden");
}

function xoaAnhSanPham() {
    $("#imgSanPham").attr("src", "/images/no_image.png");

    $("#UrlPhoto").val("/images/no_image.png").trigger("change");

    $("#btnChonAnhSanPham").removeClass("hidden");
    $("#btnXoaAnhSanPham").addClass("hidden");
}

function eventPopupEditAnhSanPham(e) {
    if (e.model.isNew()) {
        $("#btnChonAnhCondotel").removeClass("hidden");
        $("#btnXoaAnhCondotel").addClass("hidden");
    }

    if (!e.model.isNew()) {
        $("#btnChonAnhSanPham").addClass("hidden");
        $("#btnXoaAnhSanPham").removeClass("hidden");
    }
}

function setGiaCu() {
    var value = $("#txtGiaCu").val();
    var result = formatMoney(value);

    $("#lblGiaCu").text(result);
}

function setGiaMoi() {
    var value = $("#txtGiaMoi").val();
    var result = formatMoney(value);

    $("#lblGiaMoi").text(result);
}

$(function () {
    //List sản phẩm 
    $(".list-sanpham #btnTimKiem")
        .click(function (e) {
            e.preventDefault();

            $(".list-sanpham #gridSanPham").data("kendoGrid").dataSource.page(1);
        });

    //Add sản phẩm
    $(".add-san-pham #btnAddSanPham")
        .click(function(e) {
            e.preventDefault();

            Api.addSanPham();
        });

    //Edit sản phẩm
    $(".edit-san-pham #btnUpdateSanPham")
    .click(function (e) {
        e.preventDefault();

        Api.updateSanPham();
    });

    //Format giá sản phẩm
    $("#txtGiaCu").on("input", function () {
        setGiaCu();
    });

    $("#txtGiaMoi").on("input", function () {
        setGiaMoi();
    });

    // Set url video
    $("#txtUrlVideo").on("input", function () {
        var value = $(this).val() || "javascript:void(0);";

        $(".play-video").attr("href", value);
    });

    //Event chọn ảnh video...
    $("#btnChonAnhVideo, #imgAnhVideo").click("click", function (e) {
        e.preventDefault();

        window.showPopupBoSuuTap(anhVideoImageChanged);
    });

    $("#btnXoaAnhVideo").click("click", function (e) {
        e.preventDefault();

        $("#imgAnhVideo").attr("src", "/images/no_image.png");
        $("#btnChonAnhVideo").removeClass("hidden");
        $("#btnXoaAnhVideo").addClass("hidden");
    });

    //Event chọn ảnh đại diện sản phẩm...
    $("#btnChonAnhDaiDien, #imgAnhDaiDien").click("click", function (e) {
        e.preventDefault();

        window.showPopupBoSuuTap(anhDaiDienImageChanged);
    });

    $("#btnXoaAnhDaiDien").click("click", function (e) {
        e.preventDefault();

        $("#imgAnhDaiDien").attr("src", "/images/no_image.png");
        $("#btnChonAnhDaiDien").removeClass("hidden");
        $("#btnXoaAnhDaiDien").addClass("hidden");
    });

    // Set giá cũ, giá mới
    setGiaCu();
    setGiaMoi();
});