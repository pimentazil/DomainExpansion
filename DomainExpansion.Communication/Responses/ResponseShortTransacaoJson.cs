namespace DomainExpansion.Communication.Responses
{
    public class ResponseShortTransacaoJson
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public DateTime Data { get; set; }
    }
}
