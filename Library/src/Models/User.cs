using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src.Models
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        [EmailAddressAttribute]
        public string Email { get; set; }
    }
}

