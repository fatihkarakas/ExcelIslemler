using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelIslemler
{
    public class dtoContext  :DbContext
    {
        public dtoContext()
            : base("BaglanString")
        {

        }

        public DbSet<HastaneBilgi> HastaneBilgi { get; set; }   
    }
}
