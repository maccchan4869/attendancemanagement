using DataAccess.M04;
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
        /// 休暇一覧画面 M04DataAccess
        /// </summary>
        private readonly M04DataAccess dac;

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public M04BusinessLogic()
        {
            this.dac = new M04DataAccess();
        }
        #endregion

        /// <summary>
        /// 初期表示
        /// </summary>
        /// <returns></returns>
        public M04ViewModel Ready(string UserId)
        {
            var ret = new M04ViewModel()
            {
                M04VacationModel = SetM04VacationModel(UserId)
            };

            return ret;
        }

        /// <summary>
        /// 初期表示
        /// </summary>
        /// <returns></returns>
        private List<M04VacationModel> SetM04VacationModel(string UserId)
        {
            var ret = new List<M04VacationModel>();
            using (var dr = dac.GetReadyInfo(UserId))
            {
                while (dr.Read())
                {
                    ret.Add(new M04VacationModel()
                    {
                        VacationDay = (dr["VacationDay"] as DateTime?).Value.ToString("yyyy/MM/dd"),
                        TypeCd = dr["TypeCd"] as string,
                        TypeName = dr["TypeName"] as string,
                        ApplyStatus = dr["ApplyStatus"] as string,
                        StatusName = dr["StatusName"] as string,
                        ApplyStatusCSS = SetApplyStatusCSS(dr["ApplyStatus"] as string),
                        Memo = dr["Memo"] as string,
                    });
                }
            }
            return ret;
        }

        /// <summary>
        /// ステータスCSSを設定
        /// </summary>
        /// <returns></returns>
        private string SetApplyStatusCSS(string applyStatus)
        {
            var ret = string.Empty;
            return ret;
        }
    }
}
