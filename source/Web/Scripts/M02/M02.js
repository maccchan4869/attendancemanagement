
var M02 = null;
var WEEKS = ["日", "月", "火", "水", "木", "金", "土"];
var DISP_WEEKS = 5;

$(function () {

    M02 = {

        /**
         * 読込完了時イベント
         */
        OnReady: function () {
            Common.HeaderSetEvent();
            Common.CommonSetEvent();
            M02.SetCalendar();
            M02.SetEvent();
        },

        /**
         * イベント設定.
         */
        SetEvent: function () {

            // 作業入力画面へ遷移
            $(".nowMonth").click(function () {
                $('.popupM03').addClass('show').fadeIn();
            });
        },

        /**
         * カレンダー描画.
         */
        SetCalendar: function () {
            var today = new Date();
            var year = today.getFullYear();
            var month = today.getMonth();
            var dispMonth = month + 1;
            var dayCount = 1;

            //  今月の情報
            /** 今月の月初日 */
            var firstDate = new Date(year, month, 1);
            /** 今月の月末日 */
            var endDate = new Date(year, dispMonth, 0);
            /** 今月の日数 */
            var endDayCount = endDate.getDate();
            /** 今月の月初日の曜日 */
            var firstDay = firstDate.getDay();

            //  先月の情報
            /** 先月の月末日 */
            var lastMonthEndDate = new Date(year, month, 0);
            /** 先月の日数 */
            var lastMonthendDayCount = lastMonthEndDate.getDate();

            // カレンダーを構成するHTML
            var calendarHtml = "";

            calendarHtml += "<h1>" + year + "/" + dispMonth + "</h1>";
            calendarHtml += "<table class=table>";

            // 曜日の行を作成
            calendarHtml += '<thead class="thead-light"><tr>';
            for (var i = 0; i < WEEKS.length; i++) {
                calendarHtml += "<td>" + WEEKS[i] + "</td>";
            }
            calendarHtml += "</tr></thead>";

            // カレンダーを描画
            calendarHtml += "<tbody>";
            for (var w = 0; w < DISP_WEEKS; w++) {
                calendarHtml += "<tr>";
                for (var d = 0; d < WEEKS.length; d++) {
                    if (w === 0 && d < firstDay) {
                        // 先月描画
                        var lastMonthDay = lastMonthendDayCount - firstDay + d + 1;
                        calendarHtml += '<td>' + lastMonthDay + "</td>";
                    } else if (dayCount > endDayCount) {
                        // 来月描画
                        var nextMonthDay = dayCount - endDayCount;
                        calendarHtml += '<td>' + nextMonthDay + "</td>";
                        dayCount++;
                    } else {
                        // 今月描画
                        calendarHtml += '<td class="nowMonth">' + dayCount + "</td>";
                        dayCount++;
                    }
                }
                calendarHtml += "</tr>";
            }
            calendarHtml += "</tbody></table>";

            $("#calendar").html(calendarHtml);            
        },

        /**
         * プルダウン選択イベント.
         */
        onChangeTargetYaerMonth: function () {
            alert("変更");
        }
    };

    M02.OnReady();
});