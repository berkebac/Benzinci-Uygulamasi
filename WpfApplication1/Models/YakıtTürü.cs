using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Models
{
    public class YakıtTürü
    {
        public YakıtTürü()
        {
            Pompalar = new HashSet<Pompa>();
        }
        public int Id { get; set; }
        public string YakıtTürüAdı { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Stok { get; set; }

        public virtual ICollection<Pompa> Pompalar { get; set; }
    }
}
