using Cafeteria.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

public class OrderCreateViewModel
{
    public List<Product> Products { get; set; } = new List<Product>();
    public IEnumerable<SelectListItem>? ProductsSelectList { get; set; } = new List<SelectListItem>();
    public int SelectedProductId { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
    public string? Message { get; set; }
}