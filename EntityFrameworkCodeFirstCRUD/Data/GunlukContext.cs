using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstCRUD.Data
{
    public class GunlukContext: DbContext
    {
        public GunlukContext() : base("server=.;database=GunlukDb;uid=sa;pwd=123")
        {

        }
        public DbSet<Yazi> Yazilar { get; set; }
    }
}
