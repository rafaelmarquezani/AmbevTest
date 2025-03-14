namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Venda
{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public string Cliente { get; set; }
    public decimal ValorTotal { get; set; }
    public string Filial { get; set; }
    public List<Product> Itens { get; set; } = new List<Product>();
    public bool Cancelada { get; set; }
}