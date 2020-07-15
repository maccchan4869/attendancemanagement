
var M05 = null;

$(function () {

    M05 = {

        /**
         * 読込完了時イベント
         */
        OnReady: function () {
            Common.CommonSetEvent();
            M05.setIntiVal();
            M05.setEvent();

            // datepickerを定義
            $('.datepicker').datepicker({
                language: 'ja',
                format: 'yyyy年mm月dd日',
                autoclose: 'true'
            });
        },

        /**
         * 初期値設定.
         */
        setIntiVal: function () {
            $('#applyVacationDay').val("");
            $('#applyVacationType').val("");
            //$('#Memo').val("");
        },

        /**
         * イベント設定.
         */
        setEvent: function () {
        },

        /**
         * 休暇申請.
         */
        onClickApply: function () {
            var param = {
                VacationDay: $("#applyVacationDay").val(),
                TypeCd: $("#applyVacationType").val()
                //Memo: $("#Memo").val()
            };
            Common.Post("/M05/Apply", param, M05.onSuccess, M05.onError);
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

    M05.OnReady();
});