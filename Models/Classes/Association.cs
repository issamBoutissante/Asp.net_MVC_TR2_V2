using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Boutissante_Issam_TDI201_B_TR2_V2
{
    public class Association
    {
        public Association()
        {
            this.Stages = new HashSet<Stage>();
        }
        [Key]
        public int Id_Ass { get; set; }
        public string Nam_Ass { get; set; }
        public string RaisonSocial { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public Nullable<int> Id_Ville { get; set; }
        public virtual Ville Ville { get; set; }

        public virtual ICollection<Stage> Stages { get; set; }
    }
}