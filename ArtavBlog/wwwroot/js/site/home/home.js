$(document).ready(function () {
    $('#button-savenumber').click(function () {
        var number = $('#input-phonenumber').val();
        if (toString(number) === '') {
            return;
        }
        if (!$.isNumeric(number)) {
            $('#input-phonenumber').val('');
            $('#div-textvalidation').removeAttr('hidden');
            setTimeout(function () {
                $('#div-textvalidation').attr('hidden', 'hidden');
            },
                5000);
            return;
        }
        if (number.length != 11) {
            $('#input-phonenumber').val('');
            $('#div-textvalidation').removeAttr('hidden');
            setTimeout(function () {
                $('#div-textvalidation').attr('hidden', 'hidden');
            },
                5000);
            return;
        }
        $('#button-savenumber').attr('disabled', 'disabled');
        $('#div-wait').removeAttr('hidden');
        $.post('/home/addphone', 'phoneNumber=' + number, function (result) {
            if (result) {
                $('#div-wait').attr('hidden', 'hidden');
                $('#button-savenumber').removeAttr('disabled');
                $('#input-phonenumber').val('');
                $('#div-thanks').removeAttr('hidden');
                setTimeout(function () {
                    $('#div-thanks').attr('hidden', 'hidden');
                },
                    5000);
            } else {
                $('#div-unsuccess').removeAttr('hidden');
                setTimeout(function () {
                    $('#div-unsuccess').attr('hidden', 'hidden');
                },
                    5000);
            }
        });
    });
});