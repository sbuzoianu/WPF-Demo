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

namespace WPF_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
	        String FullName = "MAC";
            String EmailAdress = "andrei@cncn.ro";
            Console.WriteLine("test");

            var checkIsEnable = isEnable(true);
            Console.WriteLine("app is "+checkIsEnable.ToString();
            InitializeComponent();

        }

        public bool isEnable(Boolean argument)
        {
            return true;
        }
    }
}
