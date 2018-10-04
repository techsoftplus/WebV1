class Api {
    /* Sản phẩm */
    static addSanPham() {

        var params = {
            Id: null,
            SanPhamId: null,
            Ma: $("#txtMa").val(),
            TieuDe: $("#txtTieuDe").val(),
            UrlAlias: null,
            UrlPhoto: $("#imgAnhDaiDien").attr("src"),
            DacDiem: $("#txtDacDiem").data("kendoEditor").value(),
            GioiThieu: $("#txtGioiThieu").data("kendoEditor").value(),
            ThongSoKyThuat: $("#txtThongSoKyThuat").data("kendoEditor").value(),
            BaoHanh: $("#txtBaoHanh").data("kendoEditor").value(),
            ChuyenMucs: $("#msChuyenMucs").data("kendoMultiSelect").value().toString(),
            MauSacs: $("#msMauSacs").data("kendoMultiSelect").value().toString(),
            Tags: $("#msTags").data("kendoMultiSelect").value().toString(),
            GiamTru: $("#txtGiamTru").val(),
            GiaCu: $("#txtGiaCu").val(),
            GiaMoi: $("#txtGiaMoi").val(),
            AnhVideo: $("#imgAnhVideo").attr("src"),
            UrlVideo: $("#txtUrlVideo").val(),
            MotaVideo: $("#txtMotaVideo").val(),
            TitleMeta: $("#txtTitleMeta").val(),
            DescriptionMeta: $("#txtDescriptionMeta").val(),
            KeywordMeta: $("#txtKeywordMeta").val(),
            TuKhoa: $("#txtTuKhoa").val(),
            NgayDang: kendo.toString($("#dpNgayDang").data("kendoDateTimePicker").value(), "yyyy/MM/dd HH:mm"),
            NgayTao: null,
            NguoiTaoId: null,
            NgaySua: null,
            NguoiSuaId: null,
            TrangThai: $("#cmbTrangThai").data("kendoComboBox").value()
        }

        httpPost("/SanPham/AddSanPham", params).then(function (result) {
            window.location.href = result.Data;
        });
    }

    static updateSanPham() {
        var params = {
            Id: $("#hidId").val(),
            SanPhamId: $("#hidSanPhamId").val(),
            Ma: $("#txtMa").val(),
            TieuDe: $("#txtTieuDe").val(),
            UrlAlias: $("#txtUrlAlias").val(),
            UrlPhoto: $("#imgAnhDaiDien").attr("src"),
            DacDiem: $("#txtDacDiem").data("kendoEditor").value(),
            GioiThieu: $("#txtGioiThieu").data("kendoEditor").value(),
            ThongSoKyThuat: $("#txtThongSoKyThuat").data("kendoEditor").value(),
            BaoHanh: $("#txtBaoHanh").data("kendoEditor").value(),
            ChuyenMucs: $("#msChuyenMucs").data("kendoMultiSelect").value().toString(),
            MauSacs: $("#msMauSacs").data("kendoMultiSelect").value().toString(),
            Tags: $("#msTags").data("kendoMultiSelect").value().toString(),
            GiamTru: $("#txtGiamTru").val(),
            GiaCu: $("#txtGiaCu").val(),
            GiaMoi: $("#txtGiaMoi").val(),
            AnhVideo: $("#imgAnhVideo").attr("src"),
            UrlVideo: $("#txtUrlVideo").val(),
            MotaVideo: $("#txtMotaVideo").val(),
            TitleMeta: $("#txtTitleMeta").val(),
            DescriptionMeta: $("#txtDescriptionMeta").val(),
            KeywordMeta: $("#txtKeywordMeta").val(),
            TuKhoa: $("#txtTuKhoa").val(),
            NgayDang: kendo.toString($("#dpNgayDang").data("kendoDateTimePicker").value(), "yyyy/MM/dd HH:mm"),
            NgayTao: $("#hidNgayTao").val(),
            NguoiTaoId: $("#hidNguoiTaoId").val(),
            NgaySua: null,
            NguoiSuaId: null,
            TrangThai: $("#cmbTrangThai").data("kendoComboBox").value()
        }

        httpPost("/SanPham/UpdateSanPham", params).then(function (result) {
            $("#txtMa").val(result.Data.Ma);

            showAlertMessageSuccess(result.ThongDiep);
        });
    }

    static deleteSanPham(id) {
        var params = {
            Id: id
        }

        httpPost("/SanPham/DeleteSanPham", params).then(function (result) {
            $("#gridSanPham").data("kendoGrid").dataSource.read();
            $("#gridSanPham").data("kendoGrid").refresh();

            showAlertMessageSuccess(result.ThongDiep);
        });
    }

    // Sản phẩm bộ lọc
    static addSanPhamBoLoc(sanPhamId, boLocIds) {
        if (!boLocIds) {
            alert("Bạn chưa chọn bộ lọc nào?");

            return;
        }

        const params = {
            SanPhamId: sanPhamId,
            BoLocIds: boLocIds
        };

        httpPost("/SanPhamBoLoc/AddSanPhamBoLoc", params).then(function (result) {
            alert("Thêm bộ lọc thành công");
            clearSelection("#gridBoLocSelection");
            $("#gridSanPhamBoLoc").data("kendoGrid").dataSource.read();
        });
    }

    static deleteSanPhamBoLoc(id) {
        const params = {
            Id: id
        }

        httpPost("/SanPhamBoLoc/DeleteSanPhamBoLoc", params).then(function (result) {
            $("#gridSanPhamBoLoc").data("kendoGrid").dataSource.read();
            $("#gridSanPhamBoLoc").data("kendoGrid").refresh();

            showAlertMessageSuccess(result.ThongDiep);
        });
    }

    /* Tin tức */
    static addTinTuc() {
        var params = {
            Id: null,
            BaiVietId: null,
            ChuyenMucId: $("#cmbChuyenMuc").data("kendoComboBox").value(),
            Tags: $("#msTags").data("kendoMultiSelect").value().toString(),
            Ma: $("#txtMa").val(),
            TieuDe: $("#txtTieuDe").val(),
            UrlAlias: null,
            UrlPhoto: $("#imgAnhDaiDien").attr("src"),
            DiaChi: $("#txtDiaChi").val(),
            ViDo: $("#txtViDo").val(),
            KinhDo: $("#txtKinhDo").val(),
            MoTa: $("#txtMoTa").data("kendoEditor").value(),
            NoiDung: $("#txtNoiDung").data("kendoEditor").value(),
            DanhGia: $("#txtDanhGia").val(),
            TitleMeta: $("#txtTitleMeta").val(),
            DescriptionMeta: $("#txtDescriptionMeta").val(),
            KeywordMeta: $("#txtKeywordMeta").val(),
            TuKhoa: $("#txtTuKhoa").val(),
            NgayDang: kendo.toString($("#dpNgayDang").data("kendoDateTimePicker").value(), "yyyy/MM/dd HH:mm"),
            NgayTao: null,
            NguoiTaoId: null,
            NgaySua: null,
            NguoiSuaId: null,
            TrangThai: $("#cmbTrangThai").data("kendoComboBox").value()
        }

        httpPost("/TinTuc/AddTinTuc", params).then(function (result) {
            window.location.href = result.Data;
        });
    }

    static updateTinTuc() {
        var params = {
            Id: $("#hidId").val(),
            BaiVietId: $("#hidBaiVietId").val(),
            ChuyenMucId: $("#cmbChuyenMuc").data("kendoComboBox").value(),
            Tags: $("#msTags").data("kendoMultiSelect").value().toString(),
            Ma: $("#txtMa").val(),
            TieuDe: $("#txtTieuDe").val(),
            UrlAlias: $("#txtUrlAlias").val(),
            UrlPhoto: $("#imgAnhDaiDien").attr("src"),
            MoTa: $("#txtMoTa").data("kendoEditor").value(),
            NoiDung: $("#txtNoiDung").data("kendoEditor").value(),
            TitleMeta: $("#txtTitleMeta").val(),
            DescriptionMeta: $("#txtDescriptionMeta").val(),
            KeywordMeta: $("#txtKeywordMeta").val(),
            TuKhoa: $("#txtTuKhoa").val(),
            NgayDang: kendo.toString($("#dpNgayDang").data("kendoDateTimePicker").value(), "yyyy/MM/dd HH:mm"),
            NgayTao: $("#hidNgayTao").val(),
            NguoiTaoId: $("#hidNguoiTaoId").val(),
            NgaySua: null,
            NguoiSuaId: null,
            TrangThai: $("#cmbTrangThai").data("kendoComboBox").value()
        }

        httpPost("/TinTuc/UpdateTinTuc", params).then(function (result) {
            showAlertMessageSuccess(result.ThongDiep);
        });
    }

    static deleteTinTuc(id) {
        var params = {
            Id: id
        }

        httpPost("/TinTuc/DeleteTinTuc", params).then(function (result) {
            $("#gridTinTuc").data("kendoGrid").dataSource.read();
            $("#gridTinTuc").data("kendoGrid").refresh();

            showAlertMessageSuccess(result.ThongDiep);
        });
    }

    /* Cache */
    // Delete cache all
    static deleteCacheAll() {
        var params = {
        }

        httpPost("/Cache/DeleteCacheAll", params).then(function (result) {
            $("#gridCache").data("kendoGrid").dataSource.read();
            $("#gridCache").data("kendoGrid").refresh();

            showAlertMessageSuccess(result.ThongDiep);
        });
    }
}
