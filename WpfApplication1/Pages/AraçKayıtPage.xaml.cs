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
    /// Interaction logic for AraçKayıtPage.xaml
    /// </summary>
    public partial class AraçKayıtPage : Page
    {
        public AraçKayıtPage()
        {
            InitializeComponent();
        }

        private void btnkayıt_Click(object sender, RoutedEventArgs e)
        {
            Araç yeniaraç = new Araç() { Plaka = tbplaka.Text };
            Veriler.Db.Araçlar.Add(yeniaraç);
            Veriler.Db.SaveChanges();
            NavigationService.Navigate(new YakıtAlımıKayıtPage());
        }
    }
}
