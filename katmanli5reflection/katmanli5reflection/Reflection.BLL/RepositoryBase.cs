using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection.BLL
{
   public class RepositoryBase<T> where T:class // Sadece bir repo ile ekle güncelle sil işlemlerini yapmak istiyoruz bu yuzden 
      //dbcontext kullanarak bu işlemi yapmaya çalışıyoruz
    {
        DbContext db = DBTool.DBInstance;
        public void Insert(T item)
        {
            db.Set(typeof(T)).Add(item);
            db.SaveChanges();
        }
        //object,string tipinde tanımlıyoruz global olabilmesi için
        public void Delete(object id)
        {
            db.Set(typeof(T)).Remove(db.Set(typeof(T)).Find(id));
            db.SaveChanges();
        }
        public List<T> SelectAll()
        {

            return db.Set(typeof(T)).Cast<T>().ToList();
        }
        public void Update(T item)
        {
            PropertyInfo pInfo = null;
            foreach (var property in item.GetType().GetProperties())
            {
                if (property.Name.Contains("id"))
                {
                    pInfo = property;
                    break;
                }
            }

            var guncellenecek = db.Set(typeof(T)).Find(pInfo.GetValue(item));
            db.Entry(guncellenecek).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
        public T SelectByID(object itemID)
        {
            return (T)db.Set(typeof(T)).Find(itemID);
        }
    }
}
