using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegformFormcontrol.Models
{
    public class Register
    {

        [Required(ErrorMessage = "please prove name")]
        [StringLength(10, ErrorMessage = "name shoud be on 10 char")]

        public string Name { get; set; }
        [Required]
        public string Id{ get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Prpfession { get; set; }
        [Required]

        public string[] Hobbies { get; set; }
        [Required]

        public DateTime Date { get; set; }


    }
}