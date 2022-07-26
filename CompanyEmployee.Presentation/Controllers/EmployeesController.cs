﻿using Microsoft.AspNetCore.Mvc;
using Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployee.Presentation.Controllers
{
    [Route("api/companies/{companyId}/employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly IServiceManager _service;
        public EmployeesController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetEmployeesForCompany(Guid companyId)
        {
            var employees = _service.EmployeeService.GetEmployees(companyId, trackChanges: false);
            return Ok(employees);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetEmployee(Guid companyId, Guid id)
        {
            var employee = _service.EmployeeService.GetEmployee(companyId, id, trackChanges: false);
            return Ok(employee);
        }

    }
}
