using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Notifications;

namespace Entities.Entities;

    [Table("Product")]
    public class Product: Notifies
    {
        [Column("PRD_ID")]
        [Display(Name = "Codigo")]
        public int Id { get; set; }
        
        [Column("PRD_NAME")]
        [Display(Name = "Nome")]
        public int Name { get; set; }
        
        [Column("PRD_VALUE")]
        [Display(Name = "Valor")]
        public decimal Value { get; set; }
        
        [Column("PRD_ESTADO")]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }
    }