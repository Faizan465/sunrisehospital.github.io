using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sunrisehospital.Models;

namespace sunrisehospital.Controllers
{
    public class Appointment : Controller
    {
       public int Id { get; set; }

       public string Department   { get; set; }

       public string  Doctor { get; set; }

       public string  Haveuvisitbefore { get; set; }

        public string Name { get; set; }

         public string  Email { get; set; }

         public DateTime Date { get; set; }

         public  Decimal Number { get; set; }

         public string Message { get; set; }



         public string  EmailId { get; set; }


      
    }
}
