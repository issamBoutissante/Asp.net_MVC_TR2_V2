using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;

namespace Boutissante_Issam_TDI201_B_TR2_V2
{
    public class EntitiesContext:DbContext
    {
        public DbSet<Ville> Villes { get; set; }
        public DbSet<Volontaire> Volontaires { get; set; }
        public DbSet<Association> Associations { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Demande_Inscription> Demande_Inscriptions { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}