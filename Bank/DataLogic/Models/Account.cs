using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic.Models
{
    class Account
    {
        public int IdAccount { get; set; }
        public int IdClient { get; set; }
        public string Iban { get; set; }
        public string AccName { get; set; }
        public decimal Amount { get; set; }
        public decimal Overdraft { get; set; }
        public bool Active { get; set; }
    }
}
