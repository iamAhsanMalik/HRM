﻿


$(document).ready(function () {


    $('a[data-toggle="tab"]').on('shown.bs.tab', function (e) {
        if (e.target.hash == '#SubmitedACRS') {
            table.columns.adjust().draw()
        }
    })
    var table = $('#ACRSsubmitted_tbl').DataTable({
        scrollY: 300,
        scrollX: true,
        scrollCollapse: true,
        paging: false,
        fixedColumns: true
    });

    $('button#increaseLeft').on('click', function () {
        var currLeft = table.fixedColumns().left();
        if (currLeft < 9) {
            table.fixedColumns().left(currLeft + 1);
            $('#click-output').prepend(
                '<div>New Left: ' + (+currLeft + 1) + '</div>'
            );
        }
    })

    $('button#decreaseLeft').on('click', function () {
        var currLeft = table.fixedColumns().left();
        if (currLeft > 0) {
            table.fixedColumns().left(currLeft - 1);
            $('#click-output').prepend(
                '<div>New Left: ' + (+currLeft - 1) + '</div>'
            );
        }
    })

    $('button#increaseRight').on('click', function () {
        var currRight = table.fixedColumns().right();
        if (currRight < 9) {
            table.fixedColumns().right(currRight + 1);
            $('#click-output').prepend(
                '<div>New Right: ' + (+currRight + 1) + '</div>'
            );
        }
    })

    $('button#decreaseRight').on('click', function () {
        var currRight = table.fixedColumns().right();
        if (currLeft > 0) {
            table.fixedColumns().right(currRight - 1);
            $('#click-output').prepend(
                '<div>New Right: ' + (+currRight - 1) + '</div>'
            );
        }
    })
});

