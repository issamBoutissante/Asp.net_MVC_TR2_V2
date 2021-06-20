using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Boutissante_Issam_TDI201_B_TR2_V2
{
    public class Demande_Inscription
    {
        [Key]
        public int Id_Inscription { get; set; }
        [Column(TypeName ="date")]
        public Nullable<System.DateTime> Date_Demande { get; set; }
        public string Etat { get; set; }
        public Nullable<int> Id_Vlt { get; set; }
        public virtual Volontaire Volontaire { get; set; }
        public Nullable<int> Id_Stage { get; set; }
        public virtual Stage Stage { get; set; }
    }
}