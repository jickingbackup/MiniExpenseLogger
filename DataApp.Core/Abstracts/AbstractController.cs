using DataApp.Core.Factories;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core.Abstracts
{
    internal abstract class AbstractController<T> : IController<T> where T : class,new()
    {
        protected string collectionName = string.Empty;
        protected LiteDatabase db = null;
        protected LiteCollection<T> collection = null;
        protected ControllerFactory controllerFactory = null;

        public AbstractController( string collectionName, LiteDatabase dbcontext )
        {
            this.collectionName = collectionName;
            db = dbcontext;
            collection = db.GetCollection<T>(collectionName);
            //collection.EnsureIndex("Id");
            controllerFactory = new ControllerFactory();
        }

        #region IController

        #region READ
        public virtual List<T> Get()
        {
            try
            {
                return this.collection.FindAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual T Get(object id)
        {
            try
            {
                return collection.FindById((int)id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Update
        /// <summary>
        /// TODO: add checking|validation on child classes
        /// </summary>
        public virtual bool Add(T entity)
        {
            try
            {
                if (this.collection.Insert(entity) != null)
                    return true;

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// TODO: add checking|validation on child classes
        /// </summary>
        public virtual bool Delete(object id)
        {
            try
            {
                if (this.collection.Delete((int)id))
                    return true;

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// TODO: add checking|validation on child classes
        /// </summary>
        public virtual bool Update(T entity)
        {
            try
            {
                return this.collection.Update(entity);
            }
            catch (Exception)
            {

                throw;
            }
        } 
        #endregion

        #endregion

    }
}
