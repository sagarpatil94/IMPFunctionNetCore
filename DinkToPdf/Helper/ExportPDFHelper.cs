using DinkToPdf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinkToPdf.Helper
{
    public class ExportPDFHelper
    {
        public static string ExportEmployees(List<Employee> employees)
        {
            StringBuilder result = new StringBuilder();
            result.Append(@"
            <!DOCTYPE html>
<html lang='en'>
<head>
  <title> Bootstrap Example </ title>
  <meta charset = 'utf-8'>
  <meta name = 'viewport' content = 'width=device-width, initial-scale=1'>
  <link rel = 'stylesheet' href = 'https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css'>
  <script src = 'https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js'></ script>
  <script src = 'https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js'></ script>
</ head>
<body>
<div class='container'>
  <h2>Basic Table</h2>
  <table class='table'>
  <thead>
    <tr>
    <th scope='col'>#</th>
      <th scope='col'> Name </th>
        <th scope='col'>PhoneNumber</th>
      <th scope='col'> Age </th>
      <th scope='col'> Add </th>
    </tr>
  </thead>
  <tbody>
");
            employees.ForEach(c =>
            {
                result.Append(@"<tr>");
                result.Append(String.Format("<td>{0}</td>", c.Id));
                result.Append(String.Format("<td>{0}</td>", c.Name));
                result.Append(String.Format("<td>{0}</td>", c.PhoneNumber));
                result.Append(String.Format("<td>{0}</td>", c.Age));
                result.Append(String.Format("<td>{0}</td>", c.Add));
                result.Append(@"</tr>");
            });
            result.Append(@" </tbody>
                </table>
                </div>

                </body>
                </html>");
            return result.ToString();
        }
    }
}
