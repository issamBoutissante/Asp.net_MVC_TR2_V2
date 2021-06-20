using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Boutissante_Issam_TDI201_B_TR2_V2
{
    public class Volontaire
    {
        public Volontaire()
        {
            this.Demande_Inscription = new HashSet<Demande_Inscription>();
        }

        [Key]
        public int Id_Vlt { get; set; }
        [Required]
        public string Nom_Vlt { get; set; }
        [Required]
        public string Prenom_Vlt { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="invalid Email Adresse")]
        public string Mail { get; set; }
        [Required]
        public string Mot_Passe { get; set; }
        public Nullable<bool> Actif { get; set; }
        
        public Nullable<int> Id_Ville { get; set; }
        public virtual Ville Ville { get; set; }

        public virtual ICollection<Demande_Inscription> Demande_Inscription { get; set; }
    }
}