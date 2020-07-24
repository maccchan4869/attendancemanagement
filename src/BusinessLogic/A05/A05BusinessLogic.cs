﻿using System;
using System.Collections.Generic;
using ViewModel;
using Model.A05;
using DataAccess.Common;

namespace BusinessLogic.A05
{
    public class A05BusinessLogic
    {
        /// <summary>
        /// 休暇一覧画面 A05DataAccess
        /// </summary>
        private readonly A05DataAccess dac;

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public A05BusinessLogic()
        {
            this.dac = new A05DataAccess();
        }
        #endregion

        /// <summary>
        /// 初期表示
        /// </summary>
        /// <returns></returns>
        public A05ViewModel Ready()
        {
            var ret = new A05ViewModel()
            {
                A05VacationModel = A05VacationModel(),
            };

            return ret;
        }

        /// <summary>
        /// 初期表示
        /// </summary>
        /// <returns></returns>
        private List<A05VacationModel> A05VacationModel()
        {
            var ret = new List<A05VacationModel>();
            using (var dr = dac.GetReadyInfo())
            {
                while (dr.Read())
                {
                    ret.Add(new A05VacationModel()
                    {
                        VacationDay = (dr["VacationDay"] as DateTime?).Value.ToString("yyyy/MM/dd"),
                        TypeCd = dr["TypeCd"] as string,
                        TypeName = dr["TypeName"] as string,
                        ApplyStatus = dr["ApplyStatus"] as string,
                        StatusName = dr["StatusName"] as string,
                        ApplyStatusCSS = SetApplyStatusCSS(dr["ApplyStatus"] as string),
                        Memo = dr["Memo"] as string,
                        UpdateDate = (dr["UpdateDateTime"] as DateTime?).Value.ToString("yyyy/MM/dd"),
                        UpdateTime = (dr["UpdateDateTime"] as DateTime?).Value.ToString("HH:mm:ss.fff")
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
