namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Produto { get; set; }
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
    public decimal Desconto { get; set; }
    public decimal ValorTotal { get; set; }
}