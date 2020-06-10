using Model.M04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace BusinessLogic.M04
{
    public class M04BusinessLogic
    {
        /// <summary>
        /// 休暇一覧画面 BusinessLogic
        /// </summary>
        private readonly M04BusinessLogic biz;

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public M04BusinessLogic()
        {
            //this.biz = new M04BusinessLogic();
        }
        #endregion

        /// <summary>
        /// 初期表示
        /// </summary>
        /// <returns></returns>
        public M04ViewModel Ready()
        {
            var ret = new M04ViewModel()
            {
                M04VacationModel = SetM04VacationModel()
            };

            return ret;
        }

        private List<M04VacationModel> SetM04VacationModel()
        {
            var ret = new List<M04VacationModel>();
            ret.Add(new M04VacationModel()
            {
                VacationDay = "2020年5月31日",
                ApplyDay = "2020年5月31日",
                ApproveDay = "2020年5月31日",
                ApplyStatus = "承認済み",
                ApplyStatusCSS = ""
            });

            return ret;
        }

    }
}
