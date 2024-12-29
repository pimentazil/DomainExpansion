namespace DomainExpansion.Communication.Requests
{
    public class RequestTransacaoJson
    {
        public string Descricao { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public DateTime Data { get; set; }
    }
}
