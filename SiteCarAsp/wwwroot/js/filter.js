// Активные фильтры
activeFilters = []

/*При нажатии на фильтр*/
$(".filter").on("click", function () {
    var parent = $(this).parent();
    var body = parent.parent();
    var filterType = parent.attr("field");
    var filterUrl = body.attr("filter-url");
    var filterId = body.attr("filter-id");

    var elem = $(this);
    var filter = { "field": filterType, "val": elem.html() };

    if (elem.hasClass('filter-active')) {
        elem.removeClass('filter-active');
        /*Здесь пересоздаётся массив с фильтром, выбрасывая старый фильтр, если его отключить на странице*/
        activeFilters = activeFilters.filter(function (x) { return x["field"] != filter["field"] || x["val"] != filter["val"]; });

    } else {
        elem.addClass('filter-active');
        activeFilters.push(filter);
    }

    applyFilters(filterUrl, filterId);
});

/**
 * Применить фильтр надо отправить запрос на сервер и результат отрисовать
 * @param {any} url
 * @param {any} id
 */
function applyFilters(url, id) {
    $.ajax({
        url: url,
        data: JSON.stringify(activeFilters),
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        success: function (data) {
            $("#" + id).html(data);
            initSliders()
        }
    });
}