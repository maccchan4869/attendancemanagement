
var M02 = null;

$(function () {

    M02 = {

        /**
         * 読込完了時イベント
         */
        OnReady: function () {
            Common.HeaderSetEvent();
            Common.CommonSetEvent();
            M02.SetCalendar();
        },

        /**
         * イベント設定.
         */
        SetEvent: function () {
        },

        /**
         * カレンダー描画.
         */
        SetCalendar: function () {
            const WEEKS = ["日", "月", "火", "水", "木", "金", "土"];
            const TODAY = new Date();
            const YEAR = TODAY.getFullYear();
            const MONTH = TODAY.getMonth() + 1;

            // 月の最初の日を取得
            var firstDate = new Date(YEAR, MONTH - 1, 1);
            // 月の最後の日を取得
            var endDate = new Date(YEAR, MONTH, 0);
            // 月の末日
            var endDayCount = endDate.getDate();
            // 前月の最後の日の情報
            var lastMonthEndDate = new Date(YEAR, MONTH - 1, 0);
            // 前月の末日
            var lastMonthendDayCount = lastMonthEndDate.getDate();
            // 月の最初の日の曜日を取得
            var startDay = firstDate.getDay();
            // 日にちのカウント
            var dayCount = 1;

             // HTMLを組み立てる変数
            var calendarHtml = "";

            calendarHtml += "<h1>" + YEAR + "/" + MONTH + "</h1>";
            calendarHtml += "<table>";

            // 曜日の行を作成
            for (let i = 0; i < WEEKS.length; i++) {
                calendarHtml += "<td>" + WEEKS[i] + "</td>";
            }

            for (let w = 0; w < 5; w++) {
                calendarHtml += "<tr>";

                for (let d = 0; d < 7; d++) {
                    if (w === 0 && d < startDay) {
                        // 1行目で1日の曜日の前
                        let num = lastMonthendDayCount - startDay + d + 1;
                        calendarHtml += '<td class="is-disabled">' + num + "</td>";
                    } else if (dayCount > endDayCount) {
                        // 末尾の日数を超えた
                        let num = dayCount - endDayCount;
                        calendarHtml += '<td class="is-disabled">' + num + "</td>";
                        dayCount++;
                    } else {
                        calendarHtml += "<td>" + dayCount + "</td>";
                        dayCount++;
                    }
                }
                calendarHtml += "</tr>";
            }
            calendarHtml += "</table>";

            $("#calendar").innerHTML = calendarHtml;            
        }
    };

    M02.OnReady();
});