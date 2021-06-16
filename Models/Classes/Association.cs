using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Boutissante_Issam_TDI201_B_TR2_V2
{
    public class Association
    {
        public int Id_Ass { get; set; }
        public string Nom_Ass { get; set; }
        public string RaisonSocial { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public int Id_Ville { get; set; }
        [ForeignKey("Id_Ville")]
        public Ville Ville { get; set; }
    }
}