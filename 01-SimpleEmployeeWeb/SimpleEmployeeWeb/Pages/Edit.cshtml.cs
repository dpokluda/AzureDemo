// -------------------------------------------------------------------------
// <copyright file="Edit.cshtml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;
using Test.Components;

namespace SimpleEmployeeWeb.Pages;

public class EditModel : PageModel
{
    private readonly IEmployeeRepository _repository;
    private readonly ILogger<EditModel> _logger;

    public EditModel(IEmployeeRepository repository, ILogger<EditModel> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public IActionResult OnGet(int id)
    {
        Id = id.ToString();
        var employee = _repository.GetEmployees().FirstOrDefault(e => e.Id == id);
        if (employee == null)
        {
            return RedirectToPage("Error", new { message = "Unknown employee id."});
        }
        
        Name = employee.Name;
        Department = employee.Department;
        Email = employee.Email;
        IsMacUser = employee.IsMacUser;
        IsWindowsUser = employee.IsWindowsUser;
        return null;
    }

    public IActionResult OnPost()
    {
        if (!Int32.TryParse(Id, out int id))
        {
            return RedirectToPage("Error", new { message = "Unknown employee id."});
        }

        var employee = _repository.GetEmployees().FirstOrDefault(e => e.Id == id);
        if (employee == null)
        {
            return RedirectToPage("Error", new { message = "Unknown employee."});
        }
        employee.Name = Name;
        employee.Department = Department;
        employee.Email = Email;
        employee.IsMacUser = IsMacUser;
        employee.IsWindowsUser = IsWindowsUser;

        return RedirectToPage("Index");
    }
    
    [BindProperty(SupportsGet= true )]
    public string Id { get; set; }
    
    [BindProperty]
    public string Name { get; set; }
    
    [BindProperty]
    public string Department { get; set; }
    
    [BindProperty]
    public string Email { get; set; }
    
    [BindProperty]
    public bool IsMacUser { get; set; }
    
    [BindProperty]
    public bool IsWindowsUser { get; set; }
}