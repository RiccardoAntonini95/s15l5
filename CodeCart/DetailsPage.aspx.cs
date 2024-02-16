using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeCart
{
    public partial class DetailsPage : System.Web.UI.Page
    {
        public static List<ProductItem> CartList { get; } = new List<ProductItem>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string idProduct = Request.QueryString["product"];
            int idDetail = Convert.ToInt32(idProduct) - 1;


            DetailPic.Src = Product.ProductsList[idDetail].ImageUrl;
            DetailName.InnerText = Product.ProductsList[idDetail].Name;
            DetailPrice.InnerText = Product.ProductsList[idDetail].Price.ToString() + "$";
            DetailDescription.InnerText = Product.ProductsList[idDetail].Description;

        }

        protected void AddToCart(object sender, EventArgs e)
        {
            string idProduct = Request.QueryString["product"];
            int idDetail = Convert.ToInt32(idProduct) - 1;

            Product.Cart.Add(Product.ProductsList[idDetail]);
        }
    }
}