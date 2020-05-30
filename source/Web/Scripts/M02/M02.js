
var M02 = null;

$(function () {

    M02 = {

        /**
         * 読込完了時イベント
         */
        OnReady: function () {
            $("#nav-btn").css("visibility", "visible");
        },

        /**
         * イベント設定.
         */
        SetEvent: function () {
        },
    };

    M02.OnReady();
});