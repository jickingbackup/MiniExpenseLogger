using DataApp.Core.Abstracts;
using DataApp.Core.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core.Controlers
{
    class ExpenseController:AbstractController<Expense>
    {
        public ExpenseController(string collectionName , LiteDatabase dbcontext)
            :base(collectionName,dbcontext)
        {
        }

        public override List<Expense> Get()
        {
            try
            {
                var expenses = base.Get();

                foreach (var expense in expenses)
                {
                    expense.Check = this.db.GetCollection<Check>("checks").FindById(expense.CheckId);
                    expense.Company = this.db.GetCollection<Company>("companies").FindById(expense.CompanyId);
                    expense.Project = this.db.GetCollection<Project>("projects").FindById(expense.ProjectId);
                }

                return expenses;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override Expense Get(object id)
        {
            try
            {
                var expense = base.Get(id);

                if (expense != null)
                {
                    expense.Check = this.db.GetCollection<Check>("checks").FindById(expense.CheckId);
                    expense.Company = this.db.GetCollection<Company>("companies").FindById(expense.CompanyId);
                    expense.Project = this.db.GetCollection<Project>("projects").FindById(expense.ProjectId);
                }

                return expense;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override bool Add(Expense entity)
        {
            entity.Check = null;
            entity.Company = null;
            entity.Project = null;
            
            return base.Add(entity);
        }

        public override bool Update(Expense entity)
        {
            entity.Check = null;
            entity.Company = null;
            entity.Project = null;
            
            return base.Update(entity);
        }
    }
}

