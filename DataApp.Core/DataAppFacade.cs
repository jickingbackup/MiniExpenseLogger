using DataApp.Core.Abstracts;
using DataApp.Core.Factories;
using DataApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core
{
    /// <summary>
    /// Data App facade.
    /// </summary>
    public class DataAppCore
    {
        public IUserController UserController { get; set; }
        public IController<Check> CheckController { get; set; }
        public IController<Company> CompanyController { get; set; }
        public IController<Expense> ExpenseController { get; set; }
        public IController<Project> ProjectController { get; set; }

        private ControllerFactory controllerFactory = null;

        public DataAppCore(string dbpath = null)
        {
            if(string.IsNullOrEmpty(dbpath) == false)
                this.controllerFactory = new ControllerFactory(dbpath);
            else
                this.controllerFactory = new ControllerFactory();

            this.UserController = controllerFactory.CreateIUserController();
            this.CheckController = controllerFactory.CreateCheckController();
            this.CompanyController = controllerFactory.CreateCompanyController();
            this.ExpenseController = controllerFactory.CreateExpenseController();
            this.ProjectController = controllerFactory.CreateProjectController();

            Seed();
        }

        private void Seed()
        {
            //set default data here
            User rootUser = new User() { 
                Id = 999, 
                IsActive = true, 
                Username = "root",
                Password = "toor",
                Token = ""
            };

            Company company = new Company()
            {
                Id = 1,
                Name = "NA",
                Description = "NA",
                Email = "NA",
                IsHidden = false,
                Contact = "NA"
            };

            Project project = new Project()
            {
                Id = 1,
                Name = "NA",
                Description = "NA",
                IsHidden = false
            };

            Check check = new Check()
            {
                Id = 1,
                IsHidden = false,
                IssuedOn = DateTime.Now,
                VoucherNumber = "NA",
                Amount = 0,
                CompanyId = 1
            };

            Expense expense = new Expense()
            {
                Id = 1,
                IsHidden = false,
                Date = DateTime.Now,
                Amount = 0,
                ProjectId=1,
                CompanyId = 1,
                CheckId=1,
                ORNUmber = "xxx",
                Description = "NA"
            };

            if (this.UserController.Get(rootUser.Id) == null)
                this.UserController.Add(rootUser);
            
            if (this.CompanyController.Get(company.Id) == null)
                this.CompanyController.Add(company);

            if (this.ProjectController.Get(project.Id) == null)
                this.ProjectController.Add(project);

            //if (this.ProjectController.Get(project2.Id) == null)
            //    this.ProjectController.Add(project2);

            if (this.CheckController.Get(check.Id) == null)
                this.CheckController.Add(check);

            if (this.ExpenseController.Get(expense.Id) == null)
                this.ExpenseController.Add(expense);


            //for (int i = 0; i < 9999; i++)
            //{
            //    this.ProjectController.Add( new Project(){
            //        Name = "NA",
            //        Description = "NA",
            //        IsHidden = false
            //    });

            //    Console.WriteLine(i.ToString());
            //}
        }
    }
}
