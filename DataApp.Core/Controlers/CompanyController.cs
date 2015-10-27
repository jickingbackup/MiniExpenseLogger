using DataApp.Core.Abstracts;
using DataApp.Core.Factories;
using DataApp.Core.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core.Controlers
{
    class CompanyController:AbstractController<Company>
    {
        public CompanyController(string collectionName , LiteDatabase dbcontext)
            :base(collectionName,dbcontext)
        {
        }

        public override List<Company> Get()
        {
            try
            {
                var companies = base.Get();

                foreach (var company in companies)
                {
                    company.Checks = this.db.GetCollection<Check>("checks").FindAll().Where(x => x.PayeeId == company.Id);
                    company.Expenses = this.db.GetCollection<Expense>("expenses").FindAll().Where(x => x.CompanyId == company.Id);

                    if (company.Checks== null)
                        company.Checks = new List<Check>();

                    if (company.Expenses == null)
                        company.Expenses = new List<Expense>();

                }

                return companies;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override Company Get(object id)
        {
            try
            {
                var company = base.Get(id);

                if(company != null)
                {
                    company.Checks = this.db.GetCollection<Check>("checks").FindAll().Where(x => x.PayeeId == company.Id);
                    company.Expenses = this.db.GetCollection<Expense>("expenses").FindAll().Where(x => x.CompanyId == company.Id);

                    if (company.Checks == null)
                        company.Checks = new List<Check>();

                    if (company.Expenses == null)
                        company.Expenses = new List<Expense>();
                }

                return company;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public override bool Add(Company entity)
        {
            entity.Checks = null;
            entity.Expenses = null;

            return base.Add(entity);
        }

        public override bool Update(Company entity)
        {
            entity.Expenses = null;
            entity.Checks = null;
            
            return base.Update(entity);
        }


    }
}
