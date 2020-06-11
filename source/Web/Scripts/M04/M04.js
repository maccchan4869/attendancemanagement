
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
            var tbodyHtml = "";
            for (var i = 0; i < aData.M04VacationModel.length; i++) {
                tbodyHtml += '<tr>';
                tbodyHtml += '<td class="planDay">' + aData.M04VacationModel[i].VacationDay + '</td >';
                tbodyHtml += '<td class="applyDay">' + aData.M04VacationModel[i].ApplyDay + '</td >';
                tbodyHtml += '<td class="approveDay">' + aData.M04VacationModel[i].ApproveDay + '</td >';
                tbodyHtml += '<td class="approveStatus">' + aData.M04VacationModel[i].ApplyStatus + '</td >';
                tbodyHtml += '<td class="applyCancels"><input class="btn btn-danger onClickCancel" type="button" value="申請取消"/></td>';
                tbodyHtml += '</tr>';
            }
            $('.M04_tbody').append(tbodyHtml);
        }
    };

    M04.OnReady();
});