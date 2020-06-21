using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClientDemoApp.Models
{
    public class FoodModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        //fyi you just copied this from the Library project.
        //since we're not referencing that project in this app,
        //we still need the models, so we're copying them here.
    }
}
