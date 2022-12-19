// -------------------------------------------------------------------------
// <copyright file="FileEmployeeRepository.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------

namespace Test.Components;

public class FileEmployeeRepository : IEmployeeRepository
{
    private const string FilePath = "./Repository.json";
    
    private List<Employee> _employees = new List<Employee>()
    {
        new Employee(10, "David Pokluda", "david@pokluda.cz", "Engineering", false, true),
        new Employee(20, "Michal Pokluda", "mpokluda@outlook.com", "Marketing", true, false),
        new Employee(11, "Katerina Pokludova", "katka@pokluda.cz", "LWSD", false, true),
        new Employee(12, "Vendula Pokludova", "vendula.pokludova@outlook.com", "CUNI", false, true),
        new Employee(13, "David Pokluda", "davidpokluda@outlook.com", "CVUT", false, true),
    };
    
    public List<Employee> GetEmployees()
    {
        return _employees;
    }
}