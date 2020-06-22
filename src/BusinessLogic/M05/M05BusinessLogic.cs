using DataAccess.M05;
using Model.Common;
using Model.M05;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static Const.Const;

namespace BusinessLogic.M05
{
    public class M05BusinessLogic
    {
        /// <summary>
        /// 休暇一覧画面 M05DataAccess
        /// </summary>
        private readonly M05DataAccess dac;

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public M05BusinessLogic()
        {
            this.dac = new M05DataAccess();
        }
        #endregion

        /// <summary>
        /// 有給休暇申請登録
        /// </summary>
        /// <returns></returns>
        public ResultModel RegisterVacation(ApplyVacationModel Model)
        {
            var ret = new ResultModel();
            if (!dac.RegisterVacation(Model))
            {
                ret.ResultCd = RESULT_CD.FAILED;
                ret.ErrorMessage = "登録に失敗しました";
                return ret;
            }
            return ret;
        }
    }
}