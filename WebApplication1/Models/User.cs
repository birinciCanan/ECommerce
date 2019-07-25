using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        //SDK=hazır freamwork gelir. 


        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        [MaxLength(150)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(64)]
        public string Email { get; set; }
        [Required]
        [MaxLength(150)]
        public string Password { get; set; }

        public List<Address> Address { get; set; }

    }
}
