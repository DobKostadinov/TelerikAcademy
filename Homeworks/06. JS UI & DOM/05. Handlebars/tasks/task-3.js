function solve() {
    return function () {
        $.fn.listview = function (data) {
            var $this = $(this),
                hbTemplate = handlebars.compile($(
                    '#' +
                    $this.attr('data-template'))
                    .html()
                );

            for (var element of data) {
                $this.append(hbTemplate(element));
            }
        };
    };
}

module.exports = solve;

