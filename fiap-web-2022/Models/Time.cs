using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiapweb2022.Models
{
    public class Time
    {
        [HiddenInput]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Bandeira { get; set; }
        public string MyProperty { get; set; }
    }
}
