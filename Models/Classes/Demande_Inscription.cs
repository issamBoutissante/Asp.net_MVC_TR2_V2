using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Boutissante_Issam_TDI201_B_TR2_V2
{
    public class Demande_Inscription
    {
        //Demande_Inscription(Id_Inscription, Date_Demande,#Id_Vlt,#Id_Stage,Etat)
        public int Id_Inscription { get; set; }
        [Column(TypeName ="date")]
        public DateTime Date_Demande { get; set; }
        public int Id_Vlt { get; set; }
        [ForeignKey("Id_Vlt")]
        public Volontaire Volontaire { get; set; }
        public int Id_Stage { get; set; }
        [ForeignKey("Id_Stage")]
        public Stage Stage { get; set; }
        public string Etat { get; set; }
    }
}