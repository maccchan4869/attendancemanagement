
var M02 = null;
var WEEKS = ["日", "月", "火", "水", "木", "金", "土"];
var DISP_WEEKS = 5;

$(function () {

    M02 = {

        /**
         * 読込完了時イベント
         */
        OnReady: function () {
            Common.CommonSetEvent();
            M02.SetCalendarIntiVal();
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
         * カレンダーの初期値設定.
         */
        SetCalendarIntiVal: function () {
            var today = new Date();
            var year = today.getFullYear();
            var month = today.getMonth();
            M02.SetCalendar(year, month);
        },

        /**
         * カレンダー描画.
         * 
         * @param  {Object} pYear  年
         * @param  {Object} pMonth 月
         */
        SetCalendar: function (pYear, pMonth) {
            var dispMonth = pMonth + 1;
            var dayCount = 1;

            //  今月の情報
            /** 今月の月初日 */
            var firstDate = new Date(pYear, pMonth, 1);
            /** 今月の月末日 */
            var endDate = new Date(pYear, dispMonth, 0);
            /** 今月の日数 */
            var endDayCount = endDate.getDate();
            /** 今月の月初日の曜日 */
            var firstDay = firstDate.getDay();

            //  先月の情報
            /** 先月の月末日 */
            var lastMonthEndDate = new Date(pYear, pMonth, 0);
            /** 先月の日数 */
            var lastMonthendDayCount = lastMonthEndDate.getDate();

            // カレンダーを構成するHTML
            var calendarHtml = "";

            calendarHtml += "<h1>" + pYear + "/" + dispMonth + "</h1>";
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

            M02.SetEvent();
        },

        /**
         * プルダウン選択イベント.
         * @param  {Object} obj プルダウン選択DOM
         */
        onChangeTargetYaerMonth: function (obj) {
            var idx = obj.selectedIndex;
            var value = obj.options[idx].value.split(",");
            var year = Number(value[0]);
            var month = Number(value[1]);
            M02.SetCalendar(Number(year), Number(month));
        }
    };

    M02.OnReady();
});