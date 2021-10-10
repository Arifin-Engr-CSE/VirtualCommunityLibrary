function ShowBorrowView(bookId) {

    var url = "/Book/BookBorrow?bookId=" + bookId;

    $("#borrowModalBody").load(url, function () {
        $("#borrowModal").modal("show");

    });
}

function ShowReturnView(bookId) {

    var url = "/Book/BookReturn?bookId=" + bookId;

    $("#returnModalBody").load(url, function () {
        $("#returnModal").modal("show");

    });
}

function ShowHistoryView(bookId) {

    var url = "/Book/BookHistory?bookId=" + bookId;

    $("#historyModalBody").load(url, function () {
        $("#historyModal").modal("show");

    });
}