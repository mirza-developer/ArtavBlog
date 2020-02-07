$(document).ready(function () {
    $('#ContentHtml').summernote();
    $('#button-uploadfile').click(function (event) {
        event.preventDefault();
        $('#inputpicture').trigger('click');
    });
    $('#inputpicture').on('change', function (event) {
        event.preventDefault();
        var data = new FormData();
        data.append('file', $('#inputpicture')[0].files[0]);
        data.append('postId', $('#ID').val());
        $.ajax({
            type: "POST",
            url: '/blog/uploadmainpicture',
            data: data,
            processData: false,
            contentType: false,
            success: function (result) {
                if (result === false) {
                    alert('در انجام عملیات مشکلی بوجود آمده است');
                    $('#PostPictureName').val('');
                } else {
                    alert('عملیات با موفقیت انجام شد');
                    $('#PostPictureName').val($('#inputpicture')[0].files[0].name);
                }
            }
        });
    });
});