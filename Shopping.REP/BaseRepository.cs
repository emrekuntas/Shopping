using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopping.DAL;
using System.Data.Entity;



namespace Shopping.REP
{
    public class BaseRepository<T> : IRepository<T> where T : class, new()
    {
        NorthwindEntities db = DBSingleTone.GetInstance();
        public T Bul(int id)
        {
            return Set().Find(id);
        }

        public T Bul(string id)
        {
            return Set().Find(id);
        }

        public void Ekle(T entity)
        {
            db.Entry(entity).State = EntityState.Added;
        }

        public IQueryable<T> GenelListe()
        {
            return Set().AsQueryable();
        }

        public void guncelle(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;

        }

        public List<T> liste()
        {
            return Set().ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public DbSet<T> Set()
        {
            return db.Set<T>();
        }

        public void Sil(T entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
        }
    }
}
