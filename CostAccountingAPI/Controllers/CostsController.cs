using CostAccountingAPI.Models;
using CostAccountingAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CostAccountingAPI.Controllers;

[Route("[controller]/[action]")]
[ApiController]
public class CostsController : ControllerBase
{
    private readonly IDataService _dataService; 
    public CostsController(IDataService dataService)
    {
        _dataService = dataService;
    }
}