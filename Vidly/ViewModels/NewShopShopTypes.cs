using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
namespace Vidly.ViewModels
{
    public class NewShopShopTypesViewModel
    {
        public Eshop Eshop { get; set; }
        public IEnumerable<EshopType> EshopTypeList { get; set; }
    }
}