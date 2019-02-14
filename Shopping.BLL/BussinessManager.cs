using Shopping.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shopping.REP.Repositories;

namespace Shopping.BLL
{
    public class BussinessManager
    {
        public class CategoriesManager : CategoriesRepository
        {
            public List<CategoriesDTOs> KategoriListele()
            {
                return GenelListe().Select(x => new CategoriesDTOs {
                    CategoryId=x.CategoryID,
                    CategoryName=x.CategoryName

                }).ToList();
            }

        }
        public class ProductsManager : ProductsRepository
        {
            public List<ProductsDTO> UrunListele() {

                return GenelListe().Select(x=>new ProductsDTO {
                    ProductsId=x.ProductID,
                    CategoryId=(int)x.CategoryID,
                    ProductName=x.ProductName,
                    UnitPrice=(decimal)x.UnitPrice
                    
                }).ToList();
               
            }

        }

    }
}
