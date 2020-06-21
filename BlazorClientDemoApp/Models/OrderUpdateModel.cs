using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerDemoApp.Models
{
    public class OrderUpdateModel
    {
        public int Id { get; set; }

        [DisplayName("Customer's name")]
        [MaxLength(20, ErrorMessage = "Max name 20 characters.")]
        [MinLength(3, ErrorMessage = "You need at least 3 characters.")]
        [Required]
        public string OrderName { get; set; }
    }
}
