using Model.M04;
using Model.M05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class M04ViewModel
    {
        public List<M04VacationModel> M04VacationModel { get; set; } =  new List<M04VacationModel>();

        public List<VacationTypeModel> DropDownListModel { get; set; } = new List<VacationTypeModel>();
    }
}
