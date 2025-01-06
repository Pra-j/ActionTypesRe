using ActionResultTypes.Models;
using System.Collections.Generic;

namespace ActionResultTypes.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public List<string> Categories { get; set; } = new List<string> { "Electronics", "Books", "Clothin", "Home Appliances", "Slave" };
    }
}

