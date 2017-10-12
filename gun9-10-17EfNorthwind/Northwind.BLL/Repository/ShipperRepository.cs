using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DAL;

namespace Northwind.BLL.Repository
{
    public class ShipperRepository : IRepository<Shipper>
    {
        NORTHWNDEntities db = DBTool.DbInstance;//DbTools a bak gerek yoksa yeni oluşturma
        public void Delete(int itemID)
        {
            db.Shippers.Remove(db.Shippers.Find(itemID));
            db.SaveChanges();
        }

        public void Insert(Shipper item)
        {
            db.Shippers.Add(item);
            db.SaveChanges();
        }

        public List<Shipper> SelectAll()
        {
            return db.Shippers.ToList();
        }
        public List<Shipper> getir(string a)//isme göre filtreleme şirketaında göre
        {
            return db.Shippers.Where(x => x.CompanyName.Contains(a)).ToList();

        }

        public Shipper SelectByID(int itemID)
        {
            return db.Shippers.Find(itemID);
        }

        public void Update(Shipper item)
        {
            Shipper guncellenecek = db.Shippers.Find(item.ShipperID);
            db.Entry(guncellenecek).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
