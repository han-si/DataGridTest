using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common.CommandTrees;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using PropertyChanged;

namespace DataGridTest.viewmodel
{
    
    [ImplementPropertyChanged]
    public class MainViewModel : ViewModelBase
    {

        public ObservableCollection<Abteilungen> Abteilungen { get; set; }

        
        
        public MainViewModel()
        {
            var db = new DataGridTestEntities();
            db.Abteilungen.Load();
            Abteilungen = db.Abteilungen.Local;
        }

        public ICommand ClickCommand { get; set; }
    }
}
