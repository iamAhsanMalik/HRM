$(document).ready(function () {
    //table.reload();


    $('a[data-toggle="tab"]').on('shown.bs.tab', function (e) {
        if (e.target.hash == '#ApprovedCanidates') {
            table.columns.adjust().draw()
        }
    })

    var table = $('#ApprovedCandidates_tbl').DataTable({
        scrollY: 300,
        scrollX: true,
        scrollCollapse: true,
        paging: false,
        fixedColumns: true,

    });

    //$('#shortlisted_tbl').data.reload();



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

    $(".add").click(function () {
        $(".block:last").before(
            ' <div class="row">'
            + '     <div class="col-md-4 col-12">'
            + '         <div class="form-group">'
            + '             <label>Deparmtnet</label>'
            + '             <select class="form-control" id="Deparmtnet">'
            + '                 <option value="0">Deparment</option>'
            + '                 <option value="1">React Js</option>'
            + '                 <option value="2">Frontend Department</option>'
            + '             </select>'
            + '         </div>'
            + '     </div>'
            + '     <div class="col-md-4 col-12">'
            + '         <div class="form-group">'
            + '             <label>Role</label>'
            + '             <select class="form-control" id="Role">'
            + '                 <option value="0">Manager</option>'
            + '                 <option value="1">Team Lead</option>'
            + '                 <option value="2">Sr Developer</option>'
            + '             </select>'
            + '         </div>'
            + '     </div>'
            + '     <div class="col-md-4 col-12">'
            + '         <div class="form-group">'
            + '             <label>User</label>'
            + '             <div class="wd-100">'
            + '                 <select class="form-control wd-80" id="User">'
            + '                     <option value="0">Usman Liaquat</option>'
            + '                     <option value="1">Abdul Muneeb</option>'
            + '                     <option value="2">Ahmed Sherwani</option>'
            + '                 </select>'
            + '                 <div class="wd-20 text-center">'
            + '                     <span class="remove"><i class="fas fa-minus"></i></span>'
            + '                 </div>'
            + '                 <div class="clearfix"></div>'
            + '             </div>'
            + '         </div>'
            + '     </div>'
            + ' </div>'
        );
    });
    $(".optionBox").on("click", ".remove", function () {
        $(this).parent().parent().parent().parent().parent().remove();
    });



    $('input[type="file"]').change(function (e) {
        var imgupload = e.target.files[0].name;
    });
});