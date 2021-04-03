using Online_shop_mvc.DAL;
using Online_shop_mvc.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_shop_mvc.Models.Home
{
    public class HomeModelView
    {
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        public IEnumerable<Tbl_Product> ListOfproducts { get; set; }

        public HomeModelView HomeModel()
        {
            return new HomeModelView()
            {
                ListOfproducts = _unitOfWork.GetRepositoryInstance<Tbl_Product>().GetAllRecords()
            };
        }
    }
}