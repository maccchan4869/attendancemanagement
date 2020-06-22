
var M04 = null;

$(function () {

    M04 = {

        /**
         * 読込完了時イベント
         */
        OnReady: function () {
            Common.CommonSetEvent();
            M04.setEvent();
        },

        /**
         * イベント設定.
         */
        setEvent: function () {
            // 有給休暇申請押下.
            $("#vacationApply").click(function () {
                M04.onClickApply();
            });

            // 取消申請押下
            $(".onClickCancel").click(function () {
                M04.onClickCancel($(this).data());
            });
        },

        /**
         * 休暇申請.
         */
        onClickApply: function () {
            M05.setIntiVal();
            $('.popupM05').addClass('show').fadeIn();
        },

        /**
         * 取消申請.
         */
        onClickCancel: function (obj) {
            $('#cancelTypeName').val(obj.typename);
            $('#cancelVacationDay').val(obj.vacationday);
            $('#cancelTypeCd').val(obj.type);
            $('.popupM06').addClass('show').fadeIn();
        }
    };

    M04.OnReady();
});