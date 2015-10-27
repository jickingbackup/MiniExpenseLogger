using DataApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Winforms.ViewModels.DataGridViewModels
{
    public class ChecksViewModel
    {
        Check check = null;

        public ChecksViewModel(Check check)
        {
            this.check = check;
        }

        public int Id { get { return check.Id; } }
        public String VoucherNumber { get { return check.VoucherNumber; } }
        public Decimal Amount { get { return check.Amount; } }
        public string EntryOn { get { return check.EntryOn.ToShortDateString(); } }
        public string IssuedOn { get { return check.IssuedOn.ToShortDateString(); } }
        public string DueOn { get { return check.DueOn.ToShortDateString(); } }
        public string Hidden { get { return (check.IsHidden) ? "yes":"no" ; } }
        public string Notes { get { return check.Notes; } }
        public string Payee { get { return (check.Payee != null) ? check.Payee.Name : ""; } }
    }
}
