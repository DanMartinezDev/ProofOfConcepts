namespace ProofOfConcepts.Scriban.Models;

public class QuoteModel
{
    public List<LineItem> LineItems { get; set; } = new List<LineItem>();
    public decimal DiscountPercent { get; set; } = 0;
    public decimal DiscountAmount => PreDiscountTotal * (DiscountPercent / 100);
    public decimal PreDiscountTotal => LineItems.Sum(x => x.Amount);
    public decimal QuoteTotal => PreDiscountTotal - DiscountAmount;
}

public class QuoteFooterModel
{
    public string Signed { get; set; } = string.Empty;
}

public class LineItem(string description, int quantity, decimal cost)
{
    public string Description { get; set; } = description;
    public int Quantity { get; set; } = quantity;
    public decimal Cost { get; set; } = cost;
    public decimal Amount => Quantity * Cost;
}
