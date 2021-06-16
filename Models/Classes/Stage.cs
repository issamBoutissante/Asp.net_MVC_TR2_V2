using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Boutissante_Issam_TDI201_B_TR2_V2
{
    public class Stage
    {
        //Stage (Id_Stage,Date_Debut,Date_Fin,#Id_Ass)
        public int Id_Stage { get; set; }
        [Column(TypeName ="date")]
        public DateTime Date_Debut { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date_Fin { get; set; }
        public int Id_Ass { get; set; }
        [ForeignKey("Id_Ass")]
        public Association Association { get; set; }
    }
}