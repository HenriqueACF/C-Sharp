namespace TreinamentoApi.Domain.UseCase.CadastrarChave.CadastrarChaveRequest
{
    public record CadastrarChaveRequest
    {
        public int indice { get; set; }
        public string chave  { get; set; }
        
    }
}
