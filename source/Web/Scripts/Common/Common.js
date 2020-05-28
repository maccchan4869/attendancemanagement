var Common;
var CommonConst;

// 共通関数.
$(function () {
    Common = {

        /** 
         * POST関数.
         * 
         * @param {Object} Url       送信先URL
         * @param {Object} Parameter パラメータ
         * @param {Object} onSuccess 成功時のコールバック関数
         * @param {Object} onError   失敗時のコールバック関数
         */
        Post: function (Url, Parameter, onSuccess, onError) {
            $.ajax({
                type: "POST",
                url: Url,
                data: JSON.stringify(Parameter),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (jsonData) {
                    onSuccess(jsonData.result);
                },
                error: function () {
                    onError(jsonData);
                },
                complete: function () {

                }
            });
        }
    };

    CommonConst = {
    };
});