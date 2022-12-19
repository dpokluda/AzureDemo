// -------------------------------------------------------------------------
// <copyright file="AddNew.cshtml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc.RazorPages;
using Test.Components;

namespace SimpleEmployeeWeb.Pages;

public class AddNewModel : PageModel
{
    private readonly IEmployeeRepository _repository;
    private readonly ILogger<AddNewModel> _logger;

    public AddNewModel(IEmployeeRepository repository, ILogger<AddNewModel> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public void OnGet()
    {
        
    }
}