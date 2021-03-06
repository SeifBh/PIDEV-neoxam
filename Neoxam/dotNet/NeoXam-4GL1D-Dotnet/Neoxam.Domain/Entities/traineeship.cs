namespace Neoxam.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("neoxamdb.traineeship")]
    public partial class traineeship
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public DateTime? End_date { get; set; }

        public DateTime? Start_date { get; set; }

        [StringLength(255)]
        public string Type { get; set; }

        [Column(TypeName = "bit")]
        public bool isValid { get; set; }

        public int? employe_Id { get; set; }

        public int? stagiaire_Id { get; set; }
    }
}
