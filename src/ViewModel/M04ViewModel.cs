using Model.M04;
using System.Web.Mvc;
using Model.M05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ViewModel
{
    public class M04ViewModel
    {
        public List<M04VacationModel> M04VacationModel { get; set; } =  new List<M04VacationModel>();

        public List<SelectListItem> DropDownListModel { get; set; } = new List<SelectListItem>();

        /// <summary>
        /// 取込結果コード
        /// </summary>
        public string TORIKOMI_CODE { get; set; }

        /// <summary>
        /// 休暇取得予定日
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy年MM月dd日}")]
        [Display(Name = "日付を入力")]
        public DateTime VacationDay { get; set; }
    }
}
