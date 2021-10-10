$(document).ready(function () {
    $('#BorrowDate').val(new Date().toDateInputValue());

    $('#CalculatedReturnDate').val(new Date().toDateInputValue());
    //CalculatedReturnDate

    $('#BorrowDate').datepicker({
        dateFormat: "yy-mm-dd",
        changeMonth: true,
        changeYear: false,
        yearRange: "-60:+0"
    });
});

Date.prototype.toDateInputValue = (function () {
    var local = new Date(this);
    local.setMinutes(this.getMinutes() - this.getTimezoneOffset());
    return local.toJSON().slice(0, 10);
});


$('#BorrowedForHowManyDays').change(function () {
    GetCalculatedReturnDate();
});

$('#BorrowDate').change(function () {
    GetCalculatedReturnDate();
});

function GetCalculatedReturnDate() {
    var date1 = new Date($("#BorrowDate").val());
    var days = parseInt($('#BorrowedForHowManyDays :selected').text());

    //console.log(days);

    if (!isNaN(date1.getTime())) {
        date1.setDate(date1.getDate() + days);

        var dd = date1.getDate();
        if (dd < 10) dd = '0' + dd;
        var mm = date1.getMonth() + 1;
        if (mm < 10) mm = '0' + mm;
        var y = date1.getFullYear();

        //console.log(date1);

        var calculatedReturnDate = y + '-' + mm + '-' + dd;

        //CalculatedReturnDate
        $('#CalculatedReturnDate').val(calculatedReturnDate);

    } else {
        alert("Invalid Date");
    }
}