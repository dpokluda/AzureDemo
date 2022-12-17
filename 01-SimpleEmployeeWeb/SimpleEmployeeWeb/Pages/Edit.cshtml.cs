// -------------------------------------------------------------------------
// <copyright file="Edit.cshtml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleEmployeeWeb.Pages;

public class EditModel : PageModel
{
    private readonly ILogger<EditModel> _logger;

    public EditModel(ILogger<EditModel> logger)
    {
        _logger = logger;
    }

    public void OnGet(int id)
    {
        Id = id;
    }
    
    public int Id { get; private set; }
}