using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Notifications;

public class Notifies
{
    public Notifies()
    {
        Notifications = new List<Notifies>();
    }
    
    [NotMapped]
    public string NomePropriedade  { get; set; }
    [NotMapped]
    public string Mensagem { get; set; }
    [NotMapped]
    public List<Notifies> Notifications;

    public bool ValidarPropString(string valor, string nomePropriedade)
    {
        if (string.IsNullOrEmpty(valor) || string.IsNullOrEmpty(nomePropriedade))
        {
            Notifications.Add(new Notifies
            {
                Mensagem = "Campo obrigatorio",
                NomePropriedade = nomePropriedade
            });
            return false;
        }
        return true;
    }

    public bool ValidarPropInt(int valor, string nomePropriedade)
    {
        if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
        {
            Notifications.Add(new Notifies
            {
                Mensagem = "O valor deve ser maior do que 0",
                NomePropriedade = nomePropriedade,
            });
            return false;
        }
        return true;
    }

    public bool ValidarPropDecimal(decimal valor, string nomePropriedade)
    {
        if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
        {
            Notifications.Add(new Notifies
            {
                Mensagem = "O valor deve ser maior do que 0",
                NomePropriedade = nomePropriedade
            });
            return false;
        }
        return true;
    }
}