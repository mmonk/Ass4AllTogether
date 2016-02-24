using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinishedAssignment4.Models
{
    public class OrderDetails
    {
        public int OrderDetailsID { get; set; }

        [ForeignKey("Orders")]
        public int OrderID { get; set; }
        public virtual Orders Orders { get; set; }

        [ForeignKey("Products")]
        public int ProductID { get; set; }
        public virtual Products Products { get; set; }

        public int Quantity { get; set; }

        public int LineNumber { get; set; }
    }
}