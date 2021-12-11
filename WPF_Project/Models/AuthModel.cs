using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Project.Models
{
    public class AuthModel : INotifyPropertyChanged, IDataErrorInfo
    {
        public string this[string columnName] => throw new NotImplementedException();

        public int ID_Person { get; set; }
        public int ID_Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public byte[] Password { get; set; }
        public DateTime RowInsertTime { get; set; }
        public DateTime RowUpdateTime { get; set; }
        public Guid Salt { get; set; }

        public string Error => throw new NotImplementedException();

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
