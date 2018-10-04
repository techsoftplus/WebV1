$(function () {
    // Kendo set language
    kendo.culture("vi-VN");

    // ImageBrowser remove url encode
    $(document).on("click", ".k-imagebrowser > ul.k-tiles > li.k-tile", function(e) {
        var input = $("#k-editor-image-url")[0];
        if (input && /%2F/.test(input.value)) {
          input.value = input.value.replace(/%2F/g, "/");
        }
    });
});