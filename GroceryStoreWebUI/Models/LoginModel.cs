using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreWebUI.Models
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }
        public string PassWord { get; set; }

    }
}
