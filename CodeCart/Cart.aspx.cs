using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeCart
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string htmlContent = "";

            for (int i = 0; i < Product.Cart.Count; i++)
            {
                Button deleteButton = new Button();
                deleteButton.ID = "deleteButton_" + i;
                deleteButton.Click += BtnRemove;
                deleteButton.Text = "Remove from Cart";
                deleteButton.CssClass = "btn btn-danger mb-2";
                htmlContent = $@" <p class='fw-bold m-0'>Prodotto:<span class='text-secondary'>{Product.Cart[i].Name}</span> // Prezzo:<span class='badge bg-success'>{Product.Cart[i].Price}$</span> </p>";
                CartContainer.Controls.Add(new LiteralControl(htmlContent));
                CartContainer.Controls.Add(deleteButton);
            }

        }

        protected void BtnRemove(object sender, EventArgs e)
        {
            string buttonId = ((Button)sender).ID;
            int index = int.Parse(buttonId.Split('_')[1]);
            Product.Cart.RemoveAt(index);
            Response.Redirect("Cart.aspx");
        }

        protected void ClearAll(object sender , EventArgs e)
        {
            Product.Cart.Clear();
            Response.Redirect("Cart.aspx");
        }
    }
}