using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Store_Inventory.Models
{
    public class StoreItems
    {
        [Key]
        public int ItemId { get; set; }
        [Display(Name ="Item Name")]
        public String ItemName { get; set; }
        [Display(Name = "Item Quantity")]
        public int? ItemQuantity { get; set; }
        [Display(Name = "Item Price")]
        public double ItemPrice { get; set; }

    }
}
