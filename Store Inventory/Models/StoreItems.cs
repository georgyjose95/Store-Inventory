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

            public String ItemName { get; set; }
            public int? ItemQuantity { get; set; }
            public double ItemPrice { get; set; }

    }
}
