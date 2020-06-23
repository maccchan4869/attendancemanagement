
var M06 = null;

$(function () {

    M06 = {

        /**
         * 読込完了時イベント
         */
        OnReady: function () {
            Common.CommonSetEvent();
            M06.setIntiVal();
            M06.setEvent();
        },

        /**
         * 初期値設定.
         */
        setIntiVal: function () {
            $('#cancelTypeName').val("");
            $('#cancelVacationDay').val("");
            $('#cancelTypeCd').val("");
            $('#cancelUpdateDt').val("");
        },

        /**
         * イベント設定.
         */
        setEvent: function () {
        },

        /**
         * 休暇取消申請.
         */
        onClickCancel: function () {
            var param = {
                VacationDay: $("#cancelVacationDay").val(),
                TypeCd: $("#cancelTypeCd").val(),
                UpdateDateTime: $("#cancelUpdateDt").val()
            };
            Common.Post("/M06/Cancel", param, M06.onSuccess, M06.onError);
        },

        onSuccess: function () {
            $('.popup').removeClass("show");
            window.location.reload();
            alert("登録しました");
        },

        onError: function () {
            alert("失敗しました");
        }

    };

    M06.OnReady();
});