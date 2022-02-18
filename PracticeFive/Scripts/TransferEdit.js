
$('.upl').change(function () {
    var file = $('.upl')[0].files[0];
    var reader = new FileReader;
    reader.onload = function (e) {
        $('#preview').attr('src', e.target.result);
    };
    reader.readAsDataURL(file);
    $('.preview').show();
    $('.img').addClass('active');
    $('.viewBox').addClass('active');
});