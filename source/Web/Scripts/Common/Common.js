﻿var Common;
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
        },

        /** 
         * ページ遷移.
         * 
         * @param {Object} Url       遷移先Url
         */
        Send: function (Url) {
            location.href = Url;
        },

        /** 
         * ヘッダーのイベント定義.
         * 
         */
        HeaderSetEvent: function () {
            // 休暇一覧押下.

            $("#vacationList").click(function () {
                alert("休暇一覧");
            });

            // 有給休暇申請押下.
            $("#vacationApply").click(function () {
                alert("有給休暇申請");
            });

            // ログアウト押下.
            $("#btnLogout").click(function () {
                Common.Send(CommonConst.PAGE_URL.M01);
            });
        }
    };

    CommonConst = {
        /**
         * 遷移URL.
         */
        PAGE_URL: {

            /**
             * ログイン画面.
             */
            M01: "/M01/M01",

           /**
             * ログイン画面.
             */
            M02: "/M02/M02",
        }
    };
});