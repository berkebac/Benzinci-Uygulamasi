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
using WpfApplication1.Pages;

namespace WpfApplication1.Windows
{
    /// <summary>
    /// Interaction logic for YakitTürüPage.xaml
    /// </summary>
    public partial class YakitTürüPage : Page
    {
        public YakitTürüPage()
        {
            InitializeComponent();
        }

        private void btnkayıt_Click(object sender, RoutedEventArgs e)
        {
            YakıtTürü yeniyakıttürü = new YakıtTürü() { YakıtTürüAdı = tbyakıttür.Text, BirimFiyat = Convert.ToDecimal(tbbirimf.Text), Stok = Convert.ToDecimal(tbstok.Text) };

            Veriler.Db.YakıtTürleri.Add(yeniyakıttürü);
            Veriler.Db.SaveChanges();
            NavigationService.Navigate(new PompaKayıtPage());

        }
    }
}
