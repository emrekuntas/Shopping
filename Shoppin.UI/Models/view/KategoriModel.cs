using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shopping.BLL.DTOs;
namespace Shoppin.UI.Models.view
{
    public class KategoriModel
    {
        public List<CategoriesDTOs> clist { get; set; }
        public List<ProductsDTO> plist { get; set; }

        public KategoriModel()
        {
            this.plist = new List<ProductsDTO>(); 
            
        }

    }
}