using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Boutissante_Issam_TDI201_B_TR2_V2
{
    public class Stage
    {
        public Stage()
        {
            this.Demande_Inscription = new HashSet<Demande_Inscription>();
        }
        [Key]
        public int Id_Stage { get; set; }
        [Column(TypeName = "date")]
        public Nullable<DateTime> Date_Debut { get; set; }
        [Column(TypeName = "date")]
        public Nullable<DateTime> Date_Fin { get; set; }
        public Nullable<int> Id_Ass { get; set; }
        public virtual Association Association { get; set; }
        public virtual ICollection<Demande_Inscription> Demande_Inscription { get; set; }
    }
}