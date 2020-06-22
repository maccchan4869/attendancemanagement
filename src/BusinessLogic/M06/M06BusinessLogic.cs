using DataAccess.M06;
using Model.Common;
using Model.M06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Const.Const;

namespace BusinessLogic.M06
{
    public class M06BusinessLogic
    {
        /// <summary>
        /// 休暇一覧画面 M06DataAccess
        /// </summary>
        private readonly M06DataAccess dac;

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public M06BusinessLogic()
        {
            this.dac = new M06DataAccess();
        }
        #endregion

        /// <summary>
        /// 有給休暇取消登録
        /// </summary>
        /// <returns></returns>
        public ResultModel DeleteVacation(CancelVacationModel Model)
        {
            var ret = new ResultModel();
            if (!dac.DeleteVacation(Model))
            {
                ret.ResultCd = RESULT_CD.FAILED;
                ret.ErrorMessage = "他端末で更新されました";
                return ret;
            }
            return ret;
        }
    }
}
