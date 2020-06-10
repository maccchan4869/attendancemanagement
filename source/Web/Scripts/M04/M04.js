
var M04 = null;

$(function () {

    M04 = {

        /**
         * 読込完了時イベント
         */
        OnReady: function () {
            Common.HeaderSetEvent();
            Common.CommonSetEvent();
            M04.SetEvent();
            Common.Post("/M04/Ready", '', M04.SetView);
        },

        /**
         * イベント設定.
         */
        SetEvent: function () {
            $(".onClickCancel").click(function () {
                M04.onClickCancel();
            });
        },

        /**
         * 取消申請.
         */
        onClickCancel: function () {
            $('.popupM06').addClass('show').fadeIn();
        },

        /**
         * 初期データ表示.
         * @param  {Object} aData 取得データ
         */
        SetView: function (aData) {
            alert("確認");
        }
    };

    M04.OnReady();
});