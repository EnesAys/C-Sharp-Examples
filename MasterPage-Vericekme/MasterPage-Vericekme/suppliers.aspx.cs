using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage_Vericekme
{
    public partial class suppliers : System.Web.UI.Page
    {
        NorthwindEntities db = new NorthwindEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
           TedarikciGetir();
        }
        private void TedarikciGetir()
        {
            Repeater1.DataSource = db.Suppliers.Select(s => new
            {
                s.SupplierID,
                s.ContactName,
                s.Country,
                s.Region,
                s.CompanyName
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
                var tedarikciler = db.Suppliers.ToList();
                int toplamTedarikci = tedarikciler.Count();
                //int toplamStok = Convert.ToInt32(urunler.Sum(p => p.UnitsInStock));
                //int toplamFiyat = Convert.ToInt32(urunler.Sum(p => p.UnitPrice));
                Label lbl = (Label)e.Item.FindControl("lblBilgilendirme");
                lbl.Text = string.Format("Toplamda {0} adet Tedarikçi bulunmaktadır . ", toplamTedarikci);
            }

        }
    }
}