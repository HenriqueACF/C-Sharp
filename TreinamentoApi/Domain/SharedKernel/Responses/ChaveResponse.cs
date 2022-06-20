namespace TreinamentoApi.Domain.SharedKernel.Responses
{
    public struct ChaveResponse
    {
         public ChaveResponse(dynamic obj)
        {
            this.indice = obj.indice;
            this.chave = obj.chave; 
            this.dataCriacao = obj.dataCriacao;
        }
        public int indice { get; private set; }
        public string chave { get; private set; }
        public DateTime dataCriacao { get; private set; }
    }
}
