using DataApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Winforms.ViewModels.DataGridViewModels
{
    public class CompanyViewModel
    {
        private Company company = null;

        public int Id { get { return company.Id; } }
        public string Name { get { return company.Name; } }
        public string Description { get { return company.Description; } }
        public string Contact { get { return company.Contact; } }
        public string Email { get { return company.Email; } }
        public string Hidden { get { return company.IsHidden ? "yes" : "no"; } }

        //Navigation Properties
        
        //public IEnumerable<Check> Checks { get; set; }
        //public IEnumerable<Expense> Expenses { get; set; }
        public int Checks { get { return company.Checks == null ? 0 : company.Checks.Count(); } }
        public int Expenses { get { return company.Expenses == null ? 0 : company.Expenses.Count(); } }

        public CompanyViewModel(Company company)
        {
            this.company = company;
        }
    }
}
