﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.REP
{
    interface IRepository<T> where T:class,new()
    {
        DbSet<T> Set();
        void Sil(T entity);
        void Ekle(T entity);

        T Bul(int id);
        T Bul(string id);
        void guncelle(T entity);
        void Save();
        List<T> liste();

        IQueryable<T> GenelListe();



    }
}
