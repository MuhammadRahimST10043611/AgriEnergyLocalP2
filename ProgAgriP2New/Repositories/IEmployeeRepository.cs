﻿using ProgAgriP2New.Models;

namespace ProgAgriP2New.Repositories
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetByIdAsync(int employeeId);
        Task<Employee> GetByEmailAsync(string email);
        Task<IEnumerable<Employee>> GetAllAsync();
        Task AddAsync(Employee employee);
        Task<bool> ValidateCredentialsAsync(string email, string password);
    }
}