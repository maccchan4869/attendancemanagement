
var M05 = null;

$(function () {

    M05 = {

        /**
         * 読込完了時イベント
         */
        OnReady: function () {
            Common.CommonSetEvent();
            M05.SetEvent();
        },

        /**
         * イベント設定.
         */
        SetEvent: function () {
        },

        /**
         * 休暇申請.
         */
        onClickApply: function () {
            var param = {
                VacationDay: $("#applyVacationDay").val(),
                TypeCd: $("#applyVacationType").val()
                //Memo: $("#CalcValue2").val()
            };
            Common.Post("/M05/Apply", param, M05.onSuccess, M05.onError);
        },

        onSuccess: function () {
            $('.popup').removeClass("show");
            alert("登録しました");
        },

        onError: function () {
            alert("失敗しました");
        }

    };

    M05.OnReady();
});