using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ManuBar.Models;

namespace ManuBar.Controllers
{
    public class NavController : Controller
    {
        // GET: Nav
        EFDBContext db= new EFDBContext();
        public PartialViewResult Menu()
        {
            List<CatagoryView> list= new List<CatagoryView>();
            var categoryList = db.Category.OrderBy(x => x.CategoryName);
            var subcategoryList = db.SubCategory;
            foreach (Category category in categoryList)
            {
               CatagoryView aView=new CatagoryView();

                aView.CategoryName = category.CategoryName;

                var subcategories = from x in subcategoryList
                    where x.CategoryID == category.CategoryID
                    select x.SubCategoryName;
                     
                aView.SubCatagoryList = subcategories.ToList();
                aView.SubCatagoryList.Sort();
              list.Add(aView);

            }

            return PartialView(list);

        }
    }
}