using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreCRUD.Data;
using AspCoreCRUD.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace aspCoreCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public EmployerController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet("{id}")]
        [EnableCors("_myAllowSpecificOrigins")]
        public IActionResult GetEmployers([FromRoute] int id)
        {
            List<Employer> list = new List<Employer>();
            foreach (var emp in _db.Employers)
            {
                if (emp.orderid == id)
                    list.Add(emp);
            }
            return Ok(list);
        }

        [HttpGet]
        [EnableCors("_myAllowSpecificOrigins")]
        public IActionResult GetEmployers()
        {
            //if(_db.Employees.ToList().Count == 0)
            //    return new JsonResult("No employee here");

            return Ok(_db.Employers.ToList());
        }



        [HttpPost]
        [EnableCors("_myAllowSpecificOrigins")]
        public async Task<IActionResult> AddEmployee([FromBody] Employer objEmployer)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult("Error While Creating New Employer");
            }
            _db.Employers.Add(objEmployer);
            await _db.SaveChangesAsync();
            return new JsonResult("Employer Created Successfully");

        }
    }
}
