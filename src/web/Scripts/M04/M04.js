
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
         * 
         * @param  {Object} aObj       クリックされたDOM
         */
        onClickCancel: function (aObj) {
            $('#cancelTypeName').val(aObj.typename);
            $('#cancelVacationDay').val(aObj.vacationday);
            $('#cancelTypeCd').val(aObj.type);
            $('#cancelUpdateDt').val(aObj.updatedt);
            $('.popupM06').addClass('show').fadeIn();
        }
    };

    M04.OnReady();
});