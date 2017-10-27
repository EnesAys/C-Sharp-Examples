using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage_Vericekme
{
    public partial class category : System.Web.UI.Page
    {

        NorthwindEntities db = new NorthwindEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
            KategoriGetir();
        }
        private void KategoriGetir()
        {
            Repeater1.DataSource = db.Categories.Select(p => new
            {
                p.CategoryID,
                p.CategoryName,
                p.Description          
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
                var kategori = db.Categories.ToList();
                int toplamKategori = kategori.Count();
              
                Label lbl = (Label)e.Item.FindControl("lblBilgilendirme");
                lbl.Text = string.Format("Toplamda {0} adet Kategori bulunmaktadır.",toplamKategori );
            }

        }
    }
}