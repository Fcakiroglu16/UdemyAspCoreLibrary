using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }

        public string Isim { get; set; }

        public string Eposta { get; set; }
        public int Yas { get; set; }
    }
}