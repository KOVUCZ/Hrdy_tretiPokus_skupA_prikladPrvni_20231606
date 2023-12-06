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

namespace Hrdy_tretiPokus_skupA_prikladPrvni_20231606
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateClick_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c;
            double v_valce;
            double v_kvadru;
            double objem;



            a = double.Parse(inputA.Text);
            b = double.Parse(inputB.Text);
            c = double.Parse(inputC.Text);
            v_kvadru = (a * b * c);
            v_valce = Math.PI * (a * a) * c;
            objem = v_kvadru - v_valce;
            Output.Content = $"Objem kvádru je {v_kvadru} \r\n Objem válce je {v_valce} \r\n Objem kvádru mínus válce {objem}";

        }
    }
}
