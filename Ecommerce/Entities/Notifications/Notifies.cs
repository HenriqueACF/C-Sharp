using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Notifications
{
    public class Notifies
    {
        public Notifies()
        {
            Notifications = new List<Notifies>();
        }
        
        [NotMapped]
        public string NomePropriedade { get; set; }
            
        [NotMapped]
        public string Mensagem { get; set; }
            
        [NotMapped]
        public List<Notifies> Notifications;

        public bool ValidarPropriedadeString(string valor, string nomePropriedade)
        {
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                Notifications.Add(new Notifies
                {
                    Mensagem = "Campo is required",
                    NomePropriedade = "Nome da propriedade is required" 
                });
                return false;
            }
            return true;
        }
        
        public bool ValidarPropriedadeInt(int valor, string nomePropriedade)
        {
            if (valor < 1|| string.IsNullOrWhiteSpace(nomePropriedade))
            {
                Notifications.Add(new Notifies
                {
                    Mensagem = "Campo is required",
                    NomePropriedade = "Nome da propriedade is required" 
                });
                return false;
            }
            return true;
        }
        
        public bool ValidarPropriedadeDecimal(decimal valor, string nomePropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                Notifications.Add(new Notifies
                {
                    Mensagem = "Campo is required",
                    NomePropriedade = "Nome da propriedade is required" 
                });
                return false;
            }
            return true;
        }
    }
}