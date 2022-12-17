// -------------------------------------------------------------------------
// <copyright file="AddNew.cshtml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleEmployeeWeb.Pages;

public class AddNewModel : PageModel
{
    private readonly ILogger<AddNewModel> _logger;

    public AddNewModel(ILogger<AddNewModel> logger)
    {
        _logger = logger;
    }
    public void OnGet()
    {
        
    }
}