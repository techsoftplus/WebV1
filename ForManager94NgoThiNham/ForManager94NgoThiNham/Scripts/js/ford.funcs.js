/* Constants */
const TrangThaiSanPham = {
    Nhap: 0,
    ConHang: 1,
    HetHang: 2,
    HangSapVe: 3
};

const TrangThaiBaiViet = {
    Nhap: 0,
    HoatDong: 1
};

const PhanLoaiChuyenMuc = {
    SanPham: 1,
    TinTuc: 10
};

const LoaiTag = {
    TagSanPham: 1,
    TagTinTuc: 10,
    TagCauHoi: 20
};

function log(message) {
    console.log(message);
}

// Số thứ tự
var rowNumber = 0;
function resetRowNumber() {
    rowNumber = 0;
}

function renderRowNumber(grid) {
    ++rowNumber;
    var page = parseInt($("#" + grid).data("kendoGrid").dataSource.page()) - 1;
    var pagesize = $("#" + grid).data("kendoGrid").dataSource.pageSize();
    return parseInt(rowNumber + (parseInt(page) * parseInt(pagesize)));
}

// Selection checkbox all
function onDataBoundSelection() {
    // Xử lý checkbox select all
    const grid = $(this.table.context).data().kendoGrid;
    const data = grid.dataSource.data();
    const result = $.grep(data, function (a) { return a.IsSelected === true; });

    if (result.length === data.length) {
        $(this.table.context).find("th input[type=checkbox]").prop("checked", "checked");
    } else {
        $(this.table.context).find("th input[type=checkbox]").removeAttr("checked");
    }
}

function onSelectAll(e) {
    const state = $(e).is(":checked");
    const grid = $(e).closest(".k-grid").data().kendoGrid;
    const data = grid.dataSource.data();

    $.each(data, function () {
        if (this.IsSelected !== state) {
            this.dirty = true;
        }

        this.IsSelected = state;
    });

    grid.refresh();
}

function onSelectRow(e) {
    // Set selected row
    const checked = $(e).is(":checked");
    const grid = $(e).closest(".k-grid").data().kendoGrid;
    const dataItem = grid.dataItem($(e).closest("tr"));

    dataItem.dirty = true;
    dataItem.IsSelected = checked;

    // Xử lý checkbox select all
    const data = grid.dataSource.data();
    const result = $.grep(data, function (a) { return a.IsSelected === true; });

    if (result.length === data.length) {
        $(e).closest(".k-grid").find("th input[type=checkbox]").prop("checked", "checked");
    } else {
        $(e).closest(".k-grid").find("th input[type=checkbox]").removeAttr("checked");
    }

    // Xử lý sau cuối
    grid.refresh();
}

function clearSelection(idGrid) {
    const state = false;
    const grid = $(idGrid).data().kendoGrid;
    const data = grid.dataSource.data();

    $.each(data, function () {
        if (this.IsSelected !== state) {
            this.dirty = true;
        }

        this.IsSelected = state;
    });

    grid.refresh();
}

function getSelectedIds(idGrid) {
    const selectedIds = [];
    const grid = $(idGrid).data().kendoGrid;
    const data = grid.dataSource.data();
    const result = $.grep(data, function (a) { return a.IsSelected === true; });
    $.each(result,
        function () {
            selectedIds.push(this.Id);
        });

    return selectedIds.join();
}

// Thông báo
function showAlertMessageError(message) {

    if (message) {
        $("#message .content").html(message);
    }

    $("#message").removeClass("hidden")
        .removeClass("alert-success")
        .addClass("alert-danger");
}

function showAlertMessageSuccess(message) {

    if (message) {
        $("#message .content").html(message);
    }

    $("#message").removeClass("hidden")
       .removeClass("alert-danger")
       .addClass("alert-success");
}

function hideAlertMessage() {
    $("#message").addClass("hidden");
}

// FormatMoney
function formatMoney(value) {
   var result = accounting.formatMoney(value,
                {
                    symbol: "đ",
                    precision: 0,
                    thousand: ",",
                    format: {
                        pos: "%v%s",
                        neg: "(%v)%s",
                        zero: "_%s"
                    }
                });

    return result;
}

// Notify Errors - Common
function errorGridHandler(args, gridName) {

    if (args.errors) {
        var grid = $(`#${gridName}`).data("kendoGrid");
        grid.one("dataBinding", function (e) {
            e.preventDefault();   // cancel grid rebind if error occurs                             

            for (let error in args.errors) {
                if (args.errors.hasOwnProperty(error)) {
                    showMessage(grid.editable.element, error, args.errors[error].errors);
                }
            }
        });
    }
}

//Add the validation message to the form
function showMessage(container, name, errors) {
    const validationMessageTmpl = kendo.template('<div class="k-widget k-tooltip k-tooltip-validation k-invalid-msg field-validation-error text-left" ' +
                                                    'style="margin: 0.5em; display: block;" data-for="#=field#" data-valmsg-for="#=field#" id="#=field#_validationMessage">' +
                                                    '<span class="k-icon k-warning"></span>#=message#' +
                                                    '<div class="k-callout k-callout-n"></div>' +
                                                '</div>');

    container.find("[data-valmsg-for=" + name + "],[data-val-msg-for=" + name + "]")
        .replaceWith(validationMessageTmpl({ field: name, message: errors[0] }));
}

// Check FullScreen
function isFullScreen() {
    if (!document.fullscreenElement &&
        !document.mozFullScreenElement && !document.webkitFullscreenElement && !document.msFullscreenElement) {
        if (document.documentElement.requestFullscreen) {
            document.documentElement.requestFullscreen();
        } else if (document.documentElement.msRequestFullscreen) {
            document.documentElement.msRequestFullscreen();
        } else if (document.documentElement.mozRequestFullScreen) {
            document.documentElement.mozRequestFullScreen();
        } else if (document.documentElement.webkitRequestFullscreen) {
            document.documentElement.webkitRequestFullscreen(Element.ALLOW_KEYBOARD_INPUT);
        }
        return true;
    } else {
        if (document.exitFullscreen) {
            document.exitFullscreen();
        } else if (document.msExitFullscreen) {
            document.msExitFullscreen();
        } else if (document.mozCancelFullScreen) {
            document.mozCancelFullScreen();
        } else if (document.webkitExitFullscreen) {
            document.webkitExitFullscreen();
        }
        return false;
    }
}

// onFullScreen
function onFullScreen(nameEdtior, height) {
    var editor = $("#" + nameEdtior).data("kendoEditor");

    if (isFullScreen()) {
        editor.wrapper.css({
            "width": $("body").width(),
            "height": $(document).height(),
            "position": "fixed",
            "left": 0,
            "top": 0,
            "z-index": 999999
        });
    } else {
        editor.wrapper.css({
            "width": "100%",
            "height": height,
            "position": "relative",
            "z-index": 0
        });
    }
}

// httpGet
function httpGet(url, params, loading) {

    if (navigator.onLine) {
        hideAlertMessage();

        return new Promise(
            function (resolve, reject) {
                $.ajax({
                    url: url,
                    type: "get",
                    dateType: "json",
                    global: !loading ? loading : true,
                    cache: false,
                    data: params,
                    beforeSend: function () {
                        $("body").loadingModal({ text: "" });
                        $("body").loadingModal("animation", "threeBounce");
                    },
                    complete: function () {
                        $("body").loadingModal("destroy");
                    },
                    success: function (result) {
                        hideAlertMessage();

                        if (result
                            && result.MaLoi !== 0) {
                            showAlertMessageError(result.ThongDiep);
                        } else {
                            resolve(result);
                        }
                    },
                    statusCode: {
                        500: function (error) {
                            log(error);
                            
                            //showAlertMessageError("Lỗi không thể kết nối đến máy chủ. Vui lòng liên hệ với Người quản trị!");
                            showAlertMessageError(error.responseText.replace("body", ""));
                        },
                        999: function (error) {
                            log(error);
                            
                            showAlertMessageError(error.responseText.replace("body" , ""));
                        }
                    },
                    error: function (error) {
                        log(error);
                    }
                });
            });
    } else {
        showAlertMessageError("Lỗi không thể kết nối đến máy chủ. Vui lòng kiểm tra kết nối mạng và Nhấn vào nút Refresh trên trình duyệt!");
    }

    return null;
}

// httpPost
function httpPost(url, params, loading) {
    log("url: " + url);
    log("params:" + JSON.stringify(params));

    if (navigator.onLine) {
        hideAlertMessage();

        return new Promise(
            function (resolve, reject) {
                $.ajax({
                    url: url,
                    type: "post",
                    dateType: "json",
                    global: !loading ? loading : true,
                    cache: false,
                    data: params,
                    beforeSend: function () {
                        $("body").loadingModal({ text: "" });
                        $("body").loadingModal("animation", "threeBounce");
                    },
                    complete: function () {
                        $("body").loadingModal("destroy");
                    },
                    success: function (result) {
                        hideAlertMessage();

                        if (result
                            && result.MaLoi !== 0) {
                            showAlertMessageError(result.ThongDiep);
                        } else {
                            resolve(result);   
                        }
                    },
                    statusCode: {
                        500: function (error) {
                            //showAlertMessage("Lỗi không thể kết nối đến máy chủ. Vui lòng liên hệ với Người quản trị!");
                            log(error);

                            showAlertMessageError(error.responseText.replace("body" , ""));
                        },
                        999: function (error) {
                            log(error);
                            showAlertMessageError(error.responseText.replace("body" , ""));
                        }
                    },
                    error: function (error) {
                        log(error);
                    }
                });
            });
    } else {
        showAlertMessageError("Lỗi không thể kết nối đến máy chủ. Vui lòng kiểm tra kết nối mạng và Nhấn vào nút Refresh trên trình duyệt!");
    }

    return null;
}