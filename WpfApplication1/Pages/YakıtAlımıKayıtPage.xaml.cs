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
    /// Interaction logic for YakıtAlımıKayıtPage.xaml
    /// </summary>
    public partial class YakıtAlımıKayıtPage : Page
    {
        public YakıtAlımıKayıtPage()
        {
            InitializeComponent();
            cmbaraç.ItemsSource = Veriler.Db.Araçlar.ToArray();
            cmbpompa.ItemsSource = Veriler.Db.Pompalar.ToArray();
        }

        private void btnkayıt_Click(object sender, RoutedEventArgs e)
        {
            Araç seçılıaraç = cmbaraç.SelectedItem as Araç;
            if (seçılıaraç == null)
            {
                seçılıaraç = new Araç() { Plaka = cmbaraç.Text };
                Veriler.Db.Araçlar.Add(seçılıaraç);
            }

            Pompa seçılıpompa = cmbpompa.SelectedItem as Pompa;
            
            if (cmbpompa.SelectedItem!=null)
            {

                YakıtAlımı yeniya = new YakıtAlımı()
                {
                    Araç = seçılıaraç,
                    Pompa = seçılıpompa,
                    Miktar = Convert.ToDecimal(tbmiktar.Text),
                    Zaman = DateTime.Now,
                    BirimFiyat = seçılıpompa.YakıtTürü.BirimFiyat
                };

                Veriler.Db.YakıtAlımları.Add(yeniya);
                seçılıpompa.YakıtTürü.Stok -= yeniya.Miktar;
                Veriler.Db.SaveChanges();
                NavigationService.Navigate(new YakıtAlımıPage());
            }
            else
            {
                MessageBox.Show("Pompa No Seçılmelidir...");
            }
           
        }
    }
}
