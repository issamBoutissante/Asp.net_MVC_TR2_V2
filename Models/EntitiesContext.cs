using System.Data.Entity;

namespace Boutissante_Issam_TDI201_B_TR2_V2
{
    public class EntitiesContext:DbContext
    {
        public virtual DbSet<Association> Associations { get; set; }
        public virtual DbSet<Demande_Inscription> Demande_Inscription { get; set; }
        public virtual DbSet<Stage> Stages { get; set; }
        public virtual DbSet<Ville> Villes { get; set; }
        public virtual DbSet<Volontaire> Volontaires { get; set; }
    }
}