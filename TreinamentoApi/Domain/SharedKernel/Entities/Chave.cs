using TreinamentoApi.Domain.SharedKernel.Responses;

namespace TreinamentoApi.Domain.SharedKernel.Entities
{
    public record Chave
    {
        public int indice { get; private set; }
        public string chave { get; private set; }
        public DateTime dataCriacao { get; private set; }

        public Chave(ChaveResponse request)
        {
            this.indice = request.indice;
            this.chave = request.chave;
            this.dataCriacao = DateTime.Now;
        }
    }
}
