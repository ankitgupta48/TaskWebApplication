// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$("#kk").keyup(function () {
    debugger
    var typevalue = $(this).val();
    $("tbody tr").each(function () {
        if ($(this).text().search(new RegExp(typevalue, "i")) < 0) {
            $(this).fadeOut();
        }
        else {
            $(this).show();
        }
    })
})