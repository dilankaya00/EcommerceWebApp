// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function sortByName(direction) {
    var mylist = $('.products');
    var listitems = mylist.children('.product').get();
    listitems.sort(function (a, b) {
        var compA = $(a).find('.name').text().toUpperCase();
        var compB = $(b).find('.name').text().toUpperCase();
        return getOrderDirection(compA, compB, direction);
    });
    $.each(listitems, function (idx, itm) { mylist.append(itm); });
}

function sortByPrice(direction) {
    var mylist = $('.products');
    var listitems = mylist.children('.product').get();
    listitems.sort(function (a, b) {
        var valueA = parseFloat($(a).data('price'));
        var valueB = parseFloat($(b).data('price'));
        return getOrderDirection(valueA, valueB, direction);
    });
    $.each(listitems, function (idx, itm) { mylist.append(itm); });
}

function getOrderDirection(compA, compB, direction) {
    if (direction == 0) {
        return (compA < compB) ? 1 : (compA > compB) ? -1 : 0;
    }
    else {
        return (compA < compB) ? -1 : (compA > compB) ? 1 : 0;
    }

}