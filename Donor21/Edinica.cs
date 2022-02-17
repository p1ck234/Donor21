namespace Donor21
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Edinica")]
    public partial class Edinica
    {
        [Key]
        public int ID_Edinica { get; set; }

        [Required]
        [StringLength(10)]
        public string GUID_Donor { get; set; }

        [Required]
        [StringLength(6)]
        public string Component { get; set; }

        public string ComponentActual
        {
            get
            {
                bool k = true;
                if (Component == "Plazma")
                    k = false;

                return (k) ? "Кровь" : "Плазма";
            }
        }


        public int FK_Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date_Sbora { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date_Freeze { get; set; }

        [Required]
        [StringLength(1)]
        public string Group { get; set; }

        public bool Rh { get; set; }

        public string RhActual 
        {
            get 
            {
                return (Rh) ? "Положительный" : "Отрицательный";
            }
        }

        public virtual Status Status { get; set; }

        public string dateFiltered
        { get => Date_Sbora.ToShortDateString(); }
        public string dateFiltered2
        { get => Date_Freeze.ToShortDateString(); }
        
    }
}
