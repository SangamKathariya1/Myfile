using EDental.Data.Enums;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDental.Infrastructure.Data.Models
{
    public class Treatment
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        public DateTime Date { get; set; }
        public Decimal cost { get; set; }
        public string Description { get; set; }

    }
}
