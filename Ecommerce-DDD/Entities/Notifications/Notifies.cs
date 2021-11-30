using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Notifications
{
    public class Notifies
    {
        public Notifies()
        {
            Notificacoes = new List<Notifies>();
        }
        
        [NotMapped]
        public string NomePropriedade { get; set; }
            
        [NotMapped]
        public string Menssagem { get; set; }

        [NotMapped] public List<Notifies> Notificacoes;

        public bool ValidarPropriedadeString(string valor, string nomepropriedade)
        {
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomepropriedade))
            {
                Notificacoes.Add(new Notifies
                {
                    Menssagem = "Campo Obrigatorio",
                    NomePropriedade = nomepropriedade
                });
                return false;
            }
            return true;
        }

        public bool ValidarPropriedadeInt(int valor, string nomepropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomepropriedade))
            {
                Notificacoes.Add(new Notifies
                {
                    Menssagem = "o Valor deve ser maior do que 0",
                    NomePropriedade = nomepropriedade
                });
                return false;
            }
            return true;
        }

        public bool ValidarPropriedadeDecimal(decimal valor, string nomepropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomepropriedade))
            {
                Notificacoes.Add(new Notifies
                {
                    Menssagem = "O valor dever ser maior do que 0",
                    NomePropriedade = nomepropriedade
                });
                return false;
            }

            return true;
        }
    }
}