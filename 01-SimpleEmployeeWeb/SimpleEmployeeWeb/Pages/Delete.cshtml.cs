// -------------------------------------------------------------------------
// <copyright file="Delete.cshtml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleEmployeeWeb.Pages;

public class DeleteModel : PageModel
{
    private readonly ILogger<DeleteModel> _logger;

    public DeleteModel(ILogger<DeleteModel> logger)
    {
        _logger = logger;
    }

    public void OnGet(int id)
    {
        Id = id;
    }

    public int Id { get; private set; }
}