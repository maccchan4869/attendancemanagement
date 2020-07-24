
var A05 = null;

$(function () {

    A05 = {

        /**
         * 読込完了時イベント
         */
        OnReady: function () {
            Common.CommonSetEvent();
            A05.setEvent();
        },

        /**
         * イベント設定.
         */
        setEvent: function () {
            // 承認処理
            $(".onClickApprove").click(function () {
                A05.onClickrRegister($(this).data());
            });

            // 却下処理
            $(".onClickReject").click(function () {
                A05.onClickrRegister($(this).data());
            });
        },

        /**
         * 更新処理.
         * 
         * @param  {Object} aObj    クリックされたDOM
         */
        onClickrRegister: function (aObj) {
            var param = {
                UserId: aObj.userid,
                VacationDay: aObj.vacationday,
                ApplyStatus: aObj.applystatus,
                UpdateDateTime: aObj.updatedate + ' ' + aObj.updatetime
            };
            Common.Post("/A05/Register", param, A05.onSuccess, A05.onError);
        },

        onSuccess: function () {
            window.location.reload();
            alert("登録しました");
        },

        onError: function () {
            alert("失敗しました");
        }
    };

    A05.OnReady();
});