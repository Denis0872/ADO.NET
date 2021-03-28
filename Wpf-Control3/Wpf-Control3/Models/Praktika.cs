using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Control3.Models
{
    public class Praktika
    {
        public int PropId { get; set; }
        public int nCanonId { get; set; }
        public DateTime dtReportDate { get; set; }
        public int nTerOtdelenie { get; set; }
        public int nTerPodrazdel { get; set; }
        public int vProcent { get; set; }
    }
 
    public class MobileContext : DbContext
    {
            
        public MobileContext() : base("DefaultConnection")
        {

        }
    public DbSet<Praktika> Praktikas { get; set; }
    }
}
