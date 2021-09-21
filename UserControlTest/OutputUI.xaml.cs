using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserControlTest
{
    /// <summary>
    /// Interaction logic for OutputUI.xaml
    /// </summary>
    public partial class OutputUI : UserControl
    {
        public OutputUI()
        {
            this.DataContext = MainWindow.data;
            InitializeComponent();
        }
    }
}
