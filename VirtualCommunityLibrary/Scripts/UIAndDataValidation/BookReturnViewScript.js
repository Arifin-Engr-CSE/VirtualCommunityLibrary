$(document).ready(function () {
    $('#ActualReturnDate').val(new Date().toDateInputValue());

    $('#ActualReturnDate').datepicker({
        dateFormat: "yy-mm-dd",
        changeMonth: true,
        changeYear: false,
        yearRange: "-60:+0"
    });

    //formatBorrowDate
    DisplayFormattedBorrowDate();
});

Date.prototype.toDateInputValue = (function () {
    var local = new Date(this);
    local.setMinutes(this.getMinutes() - this.getTimezoneOffset());
    return local.toJSON().slice(0, 10);
});


function DisplayFormattedBorrowDate() {
    var date1 = $("#BorrowDate").val();

    if (date1.length>7) {

        var date2 = date1.split(" ")[0];

        var dd = date2.split("/")[0];
        if (dd < 10) dd = '0' + dd;
        var mm = date2.split("/")[1];
        //if (mm < 10) mm = '0' + mm;
        var y = date2.split("/")[2];

        console.log(date2);

        var formattedBorrowDate = y + '-' + mm + '-' + dd;

        //CalculatedReturnDate
        $('#BorrowDate').val(formattedBorrowDate);

        console.log(formattedBorrowDate);
    } else {
        alert("Invalid Date");
    }
}