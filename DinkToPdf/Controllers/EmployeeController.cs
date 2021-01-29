using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf.Helper;
using DinkToPdf.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DinkToPdf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult ExportEmployees()
        {
            var result = EmployeeRepository.EmployeesData();
            string htmlContent = ExportPDFHelper.ExportEmployees(result);
            string filePath = Path.Combine(Environment.CurrentDirectory, "Exports", DateTime.Now.ToString("ddMMyyyyHHmmss.pdf"));
            // add

        }
    }
}
