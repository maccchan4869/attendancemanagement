﻿
var M02 = null;

$(function () {

    M02 = {

        /**
         * 読込完了時イベント
         */
        OnReady: function () {
            Common.HeaderSetEvent();
            Common.CommonSetEvent();
        },

        /**
         * イベント設定.
         */
        SetEvent: function () {
        },
    };

    M02.OnReady();
});