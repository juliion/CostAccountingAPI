using CostAccountingAPI.Models;

namespace CostAccountingAPI.Services;

public interface IDataService
{
    public List<User> Users { get; }
    public List<Category> Categories { get; }
    public List<Record> Records { get; }
}