// -------------------------------------------------------------------------
// <copyright file="Edit.cshtml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

    public void OnGet(int id)
    {
        if (id != 0)
        {
            Id = id;
            Employee = _repository.GetEmployees().FirstOrDefault(e => e.Id == id);
        }
    }

    public IActionResult OnPost()
    {
        this.Employee.Name = Request.Form["inputName"];
        this.Employee.Department = Request.Form["inputDepartment"];
        this.Employee.Email = Request.Form["inputEmail"];
        // this.Employee.IsMacUser = Request.Form["checkboxMac"];
        // this.Employee.IsWindowsUser = Request.Form["checkboxWindows"];

        return RedirectToPage("~/");
    }
    
    public int Id { get; private set; }
    public Employee Employee { get; private set; }
}