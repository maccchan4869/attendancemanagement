
var M01 = null;

$(function () {

    M01 = {

        /**
         * 読込完了時イベント
         */
        OnReady: function () {
        },

        /**
         * イベント設定.
         */
        SetEvent: function () {
        },

        /**
         * ログイン処理.
         */
        onClickLogin: function () {
            $("#btnLogin").click(Common.Send(CommonConst.PAGE_URL.M02));
        }
    };

    M01.OnReady();
});