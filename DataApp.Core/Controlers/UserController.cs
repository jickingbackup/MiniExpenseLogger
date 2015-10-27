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
    class UserController : AbstractController<User>, IUserController
    {
        public UserController(string collectionName, LiteDatabase dbContext)
            :base(collectionName, dbContext)
        {

        }

        public User Login(string username, string password)
        {
            try
            {
                User user = null;

                user = this.collection.FindOne(
                    Query.And(
                        Query.EQ("Username", username),
                        Query.EQ("Password", password))
                        );

                //set token
                if (user != null)
                {
                    if (String.IsNullOrEmpty(user.Token))
                        user.Token = Guid.NewGuid().ToString();

                    this.collection.Update(user);
                }

                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Logout(int id)
        {
            try
            {
                User user = null;

                user = collection.FindById(id);

                //remove token
                if (user != null)
                {
                    if (String.IsNullOrEmpty(user.Token) == false)
                        user.Token = string.Empty;

                    collection.Update(user);
                }
            }
            catch (Exception)
            {


                throw;
            }
        }

        //for security reasons
        public override List<User> Get()
        {
            try
            {
                var users = base.Get();

                foreach (var item in users)
                {
                    item.Password = "xxx";
                }

                return users;
            }
            catch (Exception)
            {


                throw;
            }
        }

        public override User Get(object id)
        {
            try
            {
                var user = base.Get(id);

                if (user != null)
                    user.Password = "xxx";

                return user;
            }
            catch (Exception)
            {


                throw;
            }
        }


    }
}
