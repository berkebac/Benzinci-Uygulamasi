using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfApplication1.Models
{
    public class YakıtAlımı
    {
        public int Id { get; set; }
        public DateTime Zaman { get; set; }
        public decimal Miktar { get; set; }
        public decimal BirimFiyat { get; set; }

        public decimal OdenicekTutar { get { return BirimFiyat * Miktar; } }


        [ForeignKey("Araç")]
        public int AraçId { get; set; }
        public virtual Araç Araç { get; set; }

        [ForeignKey("Pompa")]
        public int PompaId { get; set; }
        public virtual Pompa Pompa { get; set; }

        public BitmapSource Logo {get { return new BitmapImage(new Uri("/WpfApplication1;component/resim/Benzinci.jpg", UriKind.Relative)); }


        }
    }
}
