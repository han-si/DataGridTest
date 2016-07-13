using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PropertyChanged;

namespace DataGridTest.viewmodel
{
    
    [ImplementPropertyChanged]
    class MainViewModel
    {
        public MainViewModel()
        {

        }

        public ICommand ClickCommand { get; set; }
    }
}
