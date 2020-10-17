$(function () {
    $('#main-content').on('click', '.container a', function () {
        var url = $(this).attr('href');
        $('#main-content-data').load(url);

        return false;
    })
});