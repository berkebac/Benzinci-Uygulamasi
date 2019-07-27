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
using WpfApplication1.Models;

namespace WpfApplication1.Pages
{
    /// <summary>
    /// Interaction logic for StokDurumuPage.xaml
    /// </summary>
    public partial class StokDurumuPage : Page
    {
        public StokDurumuPage()
        {
            InitializeComponent();
            Listele();
        }
        private void Listele()
        {
            dg.ItemsSource = Veriler.Db.Pompalar.ToArray();    
        }
    }
}
