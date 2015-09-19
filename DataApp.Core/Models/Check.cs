using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core.Models
{
    public class Check
    {
        public int Id { get; set; }
        public String VoucherNumber { get; set; }
        public Decimal Amount { get; set; }
        public DateTime EntryOn{ get; set; }
        public DateTime IssuedOn { get; set; }
        public DateTime DueOn { get; set; }        
        public bool IsHidden{ get; set; }
        public string Notes { get; set; }
        
        //relations
        public int  PayeeId{ get; set; }

        //Navigation Properties
        public Company Payee { get; set; }

        [BsonIgnoreAttribute]
        public IEnumerable<Expense> Expenses { get; set; }
    }
}
