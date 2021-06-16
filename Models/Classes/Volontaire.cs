using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Boutissante_Issam_TDI201_B_TR2_V2
{
    public class Volontaire
    {
        public int Id_Vlt { get; set; }
        public string Nom_Vlt { get; set; }
        public string Prenom_Vlt { get; set; }
        public string Mail { get; set; }
        public string Mot_Passe { get; set; }
        public int Id_Ville { get; set; }
        [ForeignKey("Id_Ville")]
        public Ville Ville { get; set; }
        public bool Actif { get; set; }
    }
}