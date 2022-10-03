$(document).ready(function () {
    //$('#shortlisted_tbl').resize()
    //$('a[data-toggle="tab"]').on('shown.bs.tab', function (e) {
    //    $.fn.dataTable.tables({ visible: true, api: true }).columns.adjust();
    //});
    //$('a[data-toggle="tab"]').on('shown.bs.tab', function (e) {
    //    $.fn.dataTable
    //        .tables({ visible: true, api: true })
    //        .columns.adjust();
    //})
    //$('a[data-toggle="tab"]').on('shown.bs.tab', function (e) { $($.fn.dataTable.tables(true)).DataTable().columns.adjust(); });
    var CURRENT_URL = window.location.href.split('#')[0].split('?')[0],
        $SIDEBAR_MENU = $('#menu');
    // check active menu
    $SIDEBAR_MENU.find('a[href="' + CURRENT_URL + '"]').parent('li').addClass('current-page').siblings()
        .removeClass('current-page');
    $SIDEBAR_MENU.find('a').filter(function () {
        return this.href == CURRENT_URL;
    }
    ).parent('li').addClass('current-page').siblings().removeClass('current-page').parents('ul')
        .slideDown().parent().addClass('active');



    $('#detailbtn').on('click', function () {

        $('#DetailsView').css('display', 'block');

    });

    $('.cross_icon, #Reject_btn').on('click', function () {

        $('#DetailsView').css('display', 'none');

    });




    $('#Shortlistedbtn').on('click', function () {

        $('#DetailsViewShortlisted').css('display', 'block');
    });

    $('#ShortlistedcrossIcon, #ShortlistedcrossIconReject_btn').on('click', function () {

        $('#DetailsViewShortlisted').css('display', 'none');
    });



    $('#ApprovedCandidatesInitiates').on('click', function () {

        $('#CandidatesInitiates').css('display', 'block');
    });
    $('#ApprovedInitiatesReject_btn, #ApprovedCandidatesInitiatesCross').on('click', function () {

        $('#CandidatesInitiates').css('display', 'none');
    });


    $('#MinuteSheetDetail').on('click', function () {

        $('#MinuteSheetView').css('display', 'block');
    });
    $('#MinuteSheetView_btn, #MinuteSheetViewCross').on('click', function () {

        $('#MinuteSheetView').css('display', 'none');
    });


    $('#MinuteSheetStatusDetail').on('click', function () {

        $('#MinuteSheetStatusView').css('display', 'block');

    });
    $('#MinuteSheetStatusView_btn, #MinuteSheetStatusViewCross').on('click', function () {

        $('#MinuteSheetStatusView').css('display', 'none');
    });



    $('#Add_btn_id').on('click', function () {

        $('#NewEmplsView').css('display', 'block');

    });
    $('#NewEmpCross, #Cancel_btn').on('click', function () {

        $('#NewEmplsView').css('display', 'none');
    });



    $('#Add_btn_EMPDetail').on('click', function () {

        $('#EmpDetailView').css('display', 'block');

    });
    $('#DetailEmpCross, #Cancel_btn-EMPDetail').on('click', function () {

        $('#EmpDetailView').css('display', 'none');
    });

    $('#View_details').on('click', function () {

        $('#AttendenceDetailsView').css('display', 'block');
        $('#mainAttendence').css('display', 'none');

    });
    $('#back_btn').on('click', function () {

        $('#AttendenceDetailsView').css('display', 'none');
        $('#mainAttendence').css('display', 'block');
    });



})

//MemberSHip
//function getMemberSHip() {
//    App.AjaxPartail("/T_R/MemberShip/NewMemberShip", "Load_Partial");
//}

    
 function function1() {
        $('#form_1').css('display', 'none');
        $('#form_2').css('display', 'block');
    }
function function2() {
    $('#form_1').css('display', 'none');
    $('#form_2').css('display', 'none');
    $('#form_3').css('display', 'block');
}

function function3() {
    $('#formsub_1').css('display', 'none');
    $('#formsub_2').css('display', 'block');
}
function function4() {
    $('#formsub_1').css('display', 'none');
    $('#formsub_2').css('display', 'none');
    $('#formsub_3').css('display', 'block');
}