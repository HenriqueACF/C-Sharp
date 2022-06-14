using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Notifications;

namespace Entities.Entities
{
    [Table("Product")]
    public class Product: Notifies
    {
        [Column("PRD_ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }
        
        [Column("PRD_NAME")]
        [Display(Name = "Name")]
        public string Nome { get; set; }
        
        [Column("PRD_VALOR")]
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }
        
        [Column("PRD_STATE")]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }
    }
}