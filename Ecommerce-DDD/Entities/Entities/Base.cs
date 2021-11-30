using System.ComponentModel.DataAnnotations;
using Entities.Notifications;

namespace Entities.Entities
{
    public class Base:Notifies
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        
        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}