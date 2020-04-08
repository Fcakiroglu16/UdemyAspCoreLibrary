using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.Models
{
    public class CreditCard
    {
        public string Number { get; set; }
        public DateTime ValidDate { get; set; }
    }
}