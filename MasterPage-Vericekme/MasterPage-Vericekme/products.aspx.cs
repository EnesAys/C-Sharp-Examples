using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage_Vericekme
{
    public partial class products : System.Web.UI.Page
    {
        NorthwindEntities db = new NorthwindEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
            UrunleriGetir();
        }
        private void UrunleriGetir()
        {
            Repeater1.DataSource = db.Products.Select(p => new
            {
                p.ProductID,
                p.ProductName,
                p.Categories.CategoryName,
                p.UnitsInStock,
                p.UnitPrice
            }).ToList();
            Repeater1.DataBind();
        }
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "google":
                    Response.Write("<script>window.open('http://www.google.com/search?q=" + e.CommandArgument + "','_blank');</script>");
                    break;
            }
        }
        protected void Repeater1_ItemCreated(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Footer)
            {
                var urunler = db.Products.ToList();
                int toplamUrun = urunler.Count();
                int toplamStok = Convert.ToInt32(urunler.Sum(p => p.UnitsInStock));
                int toplamFiyat = Convert.ToInt32(urunler.Sum(p => p.UnitPrice));
                Label lbl = (Label)e.Item.FindControl("lblBilgilendirme");
                lbl.Text = string.Format("Toplamda {0} adet ürün bulunmaktadır <br/> Toplam stok miktarı: {1} <br/> Tüm ürünlerin fiyatı: {2:C} ", toplamUrun, toplamStok, toplamFiyat);
            }

        }
    }
}