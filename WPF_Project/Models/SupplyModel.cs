using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Project.Models
{
    public class SupplyModel : INotifyPropertyChanged, IDataErrorInfo
    {
        public string this[string columnName] => throw new NotImplementedException();

        public int ID_Supply { get; set; }
        public int ID_Person { get; set; }
        public int ID_Category { get; set; }
        public string NameGoods { get; set; }
        public int Number { get; set; }
        public int PriceUnit { get; set; }
        public DateTime RowInsertTime { get; set; }
        public DateTime RowUpdateTime { get; set; }

        public string Error => throw new NotImplementedException();

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
