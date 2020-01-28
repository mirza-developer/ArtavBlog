function PaginationHandler() {
    /*
     * event handler برای .page-item[move-value] کلیک آن است
     *  برای اجرای صفحه بندی اطلاعات می بایست کلاس بندی زیر رعایت شود
     *  .page-item[move-value] : آیتم های قبلی و بعدی که با فشردن آنها می بایست این متد عمل کند
     *  .master-table-row : ردیف های جدول داده ای مورد نظر
     *  #data-periods : محدوده ی شماره ردیف هایی که هم اکنون visible اند
     *  این المنت دارای دو attribute  است با نام from-row  و to-row که در اولی شماره ی اولین ردیف نمایش داده شده و در دومی شماره ی آخرین ردیف نمایش داده شده ذخیره می شود
     *  #current-page : شماره صفحه ی فعلی در این attribute page-value و در محتوای داخل آن ذخیره می شود
     *
     */
    if ($(this).attr('move-value') == 1 ) { //نشان دادن 10 ردیف بعدی
        var allRows = $('.master-table-row'); // تمام ردیف های جدول را بدست می آورد
        var unHiddenFromRowNumber = parseInt($('#data-periods').attr('from-row')) + 10;// محدوده ای را که باید توسط برنامه قابل دیدن شود را مشخص می کند
        var unHiddenToRowNumber = unHiddenFromRowNumber + 9;// محدوده ای را که باید توسط برنامه قابل دیدن شود را مشخص می کند
        var lastIndex = 0;
        if (unHiddenToRowNumber - allRows.length >= 10) {
            return;
        }
        for (var i = 1; i < allRows.length + 1; i++) {// اقدام به قابل دیدن کردن ردیف ها می کند
            allRows[i - 1].setAttribute('hidden', 'hidden');
            if (allRows[i - 1].getAttribute('row-number') >= unHiddenFromRowNumber
                && allRows[i - 1].getAttribute('row-number') <= unHiddenToRowNumber) {// چک کردن در محدوده بودن
                allRows[i - 1].removeAttribute('hidden');
                lastIndex = i;
            }
        }
        $('#data-periods').attr('from-row', unHiddenFromRowNumber); // مشخص کردن محدوده ای که در اکنون قابل دیدن است
        $('#data-periods').attr('to-row', lastIndex);// مشخص کردن محدوده ای که در اکنون قابل دیدن است

        if (unHiddenFromRowNumber == 1) { // اگر جدول به ابتدا یا انتها رسیده باشد اقدام به غیرفعال کردن دکمه قبل یا بعد می کند
            $('[move-value="-1"]').attr('disabled', 'disabled');
        } else {
            $('[move-value="-1"]').removeAttr('disabled');
        }
        if (lastIndex == allRows.length) {
            $('[move-value="1"]').attr('disabled', 'disabled');
        }
        else {
            $('[move-value="1"]').removeAttr('disabled');
        }
        // تعیین شماره صفحه کنونی
        var numberNew = parseInt($('#current-page').attr('page-value')) + 1;
        $('#current-page').attr('page-value', numberNew);
        $('#current-page').html(numberNew);
    } else {//نشان دادن 10 ردیف قبلی
        var allRows = $('.master-table-row');
        var unHiddenFromRowNumber = parseInt($('#data-periods').attr('from-row')) - 10;
        var unHiddenToRowNumber = unHiddenFromRowNumber + 9;
        var lastIndex = 0;
        if (unHiddenFromRowNumber < 1) {
            return;
        }
        for (var i = 1; i < allRows.length + 1; i++) {// اقدام به قابل دیدن کردن ردیف ها می کند
            allRows[i - 1].setAttribute('hidden', 'hidden');
            if (allRows[i - 1].getAttribute('row-number') >= unHiddenFromRowNumber
                && allRows[i - 1].getAttribute('row-number') <= unHiddenToRowNumber) {// چک کردن در محدوده بودن
                allRows[i - 1].removeAttribute('hidden');
                lastIndex = i;
            }
        }
        $('#data-periods').attr('from-row', unHiddenFromRowNumber);// مشخص کردن محدوده ای که در اکنون قابل دیدن است
        $('#data-periods').attr('to-row', lastIndex);// مشخص کردن محدوده ای که در اکنون قابل دیدن است

        if (unHiddenFromRowNumber == 1) { // اگر جدول به ابتدا یا انتها رسیده باشد اقدام به غیرفعال کردن دکمه قبل یا بعد می کند
            $('[move-value="-1"]').attr('disabled', 'disabled');
        } else {
            $('[move-value="-1"]').removeAttr('disabled');
        }
        if (lastIndex == allRows.length) {
            $('[move-value="1"]').attr('disabled', 'disabled');
        }
        else {
            $('[move-value="1"]').removeAttr('disabled');
        }
        // تعیین شماره صفحه کنونی
        var numberNew = parseInt($('#current-page').attr('page-value')) - 1;
        $('#current-page').attr('page-value', numberNew);
        $('#current-page').html(numberNew);
    }
};