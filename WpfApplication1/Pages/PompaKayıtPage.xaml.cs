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
    /// Interaction logic for PompaKayıtPage.xaml
    /// </summary>
    public partial class PompaKayıtPage : Page
    {
        public PompaKayıtPage()
        {
            InitializeComponent();
            cmbyakittürü.ItemsSource = Veriler.Db.YakıtTürleri.ToArray();

        }

        private void btnkayıt_Click(object sender, RoutedEventArgs e)
        {
            Pompa yenipompa = new Pompa() { PompaNo = Convert.ToInt32(tbpompano.Text), YakıtTürü = cmbyakittürü.SelectedItem as YakıtTürü };
            Veriler.Db.Pompalar.Add(yenipompa);
            Veriler.Db.SaveChanges();
            NavigationService.Navigate(new AraçKayıtPage());

        }
    }
}
