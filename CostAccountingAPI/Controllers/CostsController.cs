﻿using CostAccountingAPI.Models;
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
    
    [HttpPost]
    public IActionResult CreateUser(User user)
    {
        _dataService.Users.Add(user);
        return new JsonResult(Ok(user.Id));
    }
    
    [HttpPost]
    public IActionResult CreateCategory(Category category)
    {
        _dataService.Categories.Add(category);
        return new JsonResult(Ok(category.Id));
    }
    
    [HttpPost]
    public IActionResult CreateRecord(Record record)
    {
        _dataService.Records.Add(record);
        return new JsonResult(Ok(record.Id));
    }
}