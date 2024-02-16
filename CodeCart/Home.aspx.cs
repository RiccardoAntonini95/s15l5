using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeCart
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string htmlContent = "";

            for (int i = 0; i < Product.ProductsList.Count; i++)
            {
                htmlContent += $@"<div class='col py-3'>
                            <div class='card h-100'>
                              <img src='{Product.ProductsList[i].ImageUrl}' class='card-img-top' alt='{Product.ProductsList[i].Description}'>
                              <div class='card-body'>
                                <h5 class='card-title'>{Product.ProductsList[i].Name}</h5>
                                <p class='card-text'><span class='badge bg-success'>{Product.ProductsList[i].Price}$</span></p>
                                <a href='DetailsPage.aspx?product={Product.ProductsList[i].Id}' class='btn btn-primary'>Dettagli</a>
                              </div>
                            </div>
                        </div>";
            }
            CardContainer.InnerHtml = htmlContent;
        }
    }
}