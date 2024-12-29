namespace DomainExpansion.Communication.Responses
{
    public class ResponseTransacaoJson
    {
        //public string Descricao { get; set; } = string.Empty;
        //public decimal Preco { get; set; }
        //public string Categoria { get; set; } = string.Empty;

        public List<ResponseShortTransacaoJson> transactions { get; set; } = [];
    }
}
