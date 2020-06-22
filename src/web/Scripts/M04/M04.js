
var M04 = null;

$(function () {

    M04 = {

        /**
         * 読込完了時イベント
         */
        OnReady: function () {
            Common.CommonSetEvent();
            M04.SetEvent();
        },

        /**
         * イベント設定.
         */
        SetEvent: function () {
            // 有給休暇申請押下.
            $("#vacationApply").click(function () {
                M04.onClickApply();
            });

            // 取消申請押下
            $(".onClickCancel").click(function () {
                M04.onClickCancel();
            });
        },

        /**
         * 休暇申請.
         */
        onClickApply: function () {
            $('.popupM05').addClass('show').fadeIn();
        },

        /**
         * 取消申請.
         */
        onClickCancel: function () {
            var a = $(this).data('vacationDay');
            var hiddenVal = a.children('td')[0];
            var nameVal = $(this).children('td')[1].innerText;
            alert('No: ' + hiddenVal + ' name: ' + nameVal);
            $('.popupM06').addClass('show').fadeIn();
        }
    };

    M04.OnReady();
});