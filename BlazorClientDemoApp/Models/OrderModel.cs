using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClientDemoApp.Models
{
    public class OrderModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Max name 20 characters.")]
        [MinLength(3, ErrorMessage = "You need at least 3 characters.")]
        [DisplayName("Customer's name")]
        public string OrderName { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        [DisplayName("Meal")]
        [Range(1, int.MaxValue, ErrorMessage = "Select a meal from the list.")]
        public int FoodId { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "You can purchase up to 10 meals.")]
        public int Quantity { get; set; }
        public decimal Total { get; set; }

        //fyi you just copied this from the Library project.
        //since we're not referencing that project in this app,
        //we still need the models, so we're copying them here.
    }
}
