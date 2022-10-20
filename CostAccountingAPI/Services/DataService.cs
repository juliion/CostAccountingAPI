using CostAccountingAPI.Models;

namespace CostAccountingAPI.Services;

public class DataService : IDataService
{
    private List<User> _users = new List<User>();
    private List<Category> _categories = new List<Category>();
    private List<Record> _records = new List<Record>();
    
    public List<User> Users => _users;
    public List<Category> Categories => _categories;
    public List<Record> Records => _records;
}