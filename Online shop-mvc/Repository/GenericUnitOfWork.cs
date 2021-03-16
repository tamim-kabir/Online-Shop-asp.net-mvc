using Online_shop_mvc.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_shop_mvc.Repository
{
    public class GenericUnitOfWork : IDisposable
    {
        private DB_OnlineShopEntities1 DBEntity = new DB_OnlineShopEntities1();

        public IRepository<Tbl_EntityType> GetRepositoryInstance<Tbl_EntityType>() where Tbl_EntityType : class
        {
            return new GenericRepository<Tbl_EntityType>(DBEntity);
        }
        public void SaveChanges()
        {
            DBEntity.SaveChanges();
        }
        private bool dispose = false;
        protected virtual void Dispose(bool disposing)
        {
            if(!this.dispose)
            {
                if(dispose)
                {
                    DBEntity.Dispose();
                }
            }
            this.dispose = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}