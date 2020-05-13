using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace newApi.Models
{
    public class User
  {
        //this is comment

        [Key]

            public int Id { get; set; }

            [Required]
            [Column(TypeName = "nvarchar(100)")]
            public string FirstName { get; set; }

            [Required]
            [Column(TypeName = "varchar(16)")]
            public string LastName { get; set; }

            [Required]
            [Column(TypeName = "int")]
            public int Age { get; set; }
    }
    
}
