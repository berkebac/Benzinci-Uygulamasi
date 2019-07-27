using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Models
{
    public class Araç
    {
        public Araç()
        {
            YakıtAlımları = new HashSet<YakıtAlımı>();
            
        }

        public int Id { get; set; }
        public string Plaka { get; set; }

        public virtual ICollection<YakıtAlımı> YakıtAlımları { get; set; }

    }
}
