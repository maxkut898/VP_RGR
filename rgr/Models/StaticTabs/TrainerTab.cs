using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rgr.Models.Database;

namespace rgr.Models.StaticTabs
{
    public class TrainerTab : StaticTab
    {
        public TrainerTab(DbSet<Trainer>? dBS = null)
        {
            Header = "Trainer";
            DBS = dBS;
            DataColumns = new List<string>();
  
            DataColumns.Add("TrainerName");
            DataColumns.Add("HorseName");
  
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Trainer>? DBS { get; set; }
    }
}
