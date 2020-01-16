using System;
using System.Collections.Generic;

namespace FoundryView.Data.DataAccess.Models
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
