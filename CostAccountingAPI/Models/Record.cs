namespace CostAccountingAPI.Models;

public class Record
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int CategoryId { get; set; }
    public DateTime Date { get; set; }
    public decimal Costs { get; set; }
}