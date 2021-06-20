using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Boutissante_Issam_TDI201_B_TR2_V2
{
    public class Ville
    {
        public Ville()
        {
            this.Associations = new HashSet<Association>();
            this.Volontaires = new HashSet<Volontaire>();
        }
        [Key]
        public int Id_ville { get; set; }
        public string Nom_Ville { get; set; }
        public string Pays { get; set; }

        public virtual ICollection<Volontaire> Volontaires { get; set; }
        public virtual ICollection<Association> Associations { get; set; }
    }
}