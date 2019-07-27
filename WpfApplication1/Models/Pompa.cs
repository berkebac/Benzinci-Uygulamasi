using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfApplication1.Models
{
    public class Pompa
    {
        public Pompa()
        {

            YakıtAlımları = new HashSet<YakıtAlımı>();
        }
        public int Id { get; set; }
        public int PompaNo { get; set; }

        [ForeignKey("YakıtTürü")]
        public int YakıtTürüId { get; set; }
        public virtual YakıtTürü YakıtTürü { get; set; }
        public virtual ICollection<YakıtAlımı> YakıtAlımları { get; set; }

        public BitmapSource Logo
        {
            get
            {
                if (YakıtTürü.YakıtTürüAdı == "LPG")
                {
                    return new BitmapImage(new Uri("/WpfApplication1;component/resim/lpg.png", UriKind.Relative));
                }
                else if (YakıtTürü.YakıtTürüAdı == "Benzin")
                {
                    return new BitmapImage(new Uri("/WpfApplication1;component/resim/benzin.png", UriKind.Relative));
                }
                else if (YakıtTürü.YakıtTürüAdı == "Dizel")
                {
                    return new BitmapImage(new Uri("/WpfApplication1;component/resim/dizel.png", UriKind.Relative));
                }
                else
                {
                    return null;
                }
            }

        }
        }
    }
