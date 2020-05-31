
var M04 = null;

$(function () {

    M04 = {

        /**
         * 読込完了時イベント
         */
        OnReady: function () {
            Common.HeaderSetEvent();
            Common.CommonSetEvent();
        },

        /**
         * イベント設定.
         */
        SetEvent: function () {
        },

        /**
         * 取消申請.
         */
        onClickCancel: function () {
            $('.popupM06').addClass('show').fadeIn();
        }
    };

    M04.OnReady();
});