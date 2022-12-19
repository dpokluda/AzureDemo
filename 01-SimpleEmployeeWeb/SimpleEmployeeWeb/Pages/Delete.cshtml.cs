// -------------------------------------------------------------------------
// <copyright file="Delete.cshtml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc.RazorPages;
using Test.Components;

namespace SimpleEmployeeWeb.Pages;

public class DeleteModel : PageModel
{
    private readonly IEmployeeRepository _repository;
    private readonly ILogger<DeleteModel> _logger;

    public DeleteModel(IEmployeeRepository repository, ILogger<DeleteModel> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public void OnGet(int id)
    {
        Id = id;
        Employee = _repository.GetEmployees().FirstOrDefault(e => e.Id == id);
    }

    public int Id { get; private set; }
    public Employee Employee { get; private set; }
}