using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category() { KategoriAdi="C#"},
                new Category() { KategoriAdi="Asp.net MVC"},
                new Category() { KategoriAdi="Asp.net WebForm"},
                new Category() { KategoriAdi=" Windows Form "}

            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }

            context.SaveChanges();  


            List<Blog> bloglar = new List<Blog>
            {
                new Blog() {Baslik="C#",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=false,Icerik="C# Delegates Hakkında Framework Çalışmaları Yapan 28 Saatlik Eğitimdir.",Resim="1.jpg",CategoryId=1},
                new Blog() {Baslik="C#",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=false,Icerik="C# Delegates Hakkında Framework Çalışmaları Yapan 28 Saatlik Eğitimdir.",Resim="1.jpg",CategoryId=1},
                new Blog() {Baslik="C# Katmanlı Mimari ile MVC ve Çeşitli Frameworkler , Kütüphanler ve Mikroservisler kullanarak c# dili ile .net programlama öğreten eğitim içeriği",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-20),Anasayfa=true,Onay=true,Icerik="C# Delegates Hakkında Framework Çalışmaları Yapan 28 Saatlik Eğitimdir.",Resim="1.jpg",CategoryId=1},
                new Blog() {Baslik="C#",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-30),Anasayfa=true,Onay=false,Icerik="C# Delegates Hakkında Framework Çalışmaları Yapan 28 Saatlik Eğitimdir.",Resim="2.jpg",CategoryId=2},
                new Blog() {Baslik="C# Mikroservisler",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-15),Anasayfa=true,Onay=true,Icerik="C# Delegates Hakkında Framework Çalışmaları Yapan 28 Saatlik Eğitimdir.",Resim="2.jpg",CategoryId=2},
                new Blog() {Baslik="C#",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-40),Anasayfa=false,Onay=true,Icerik="C# Delegates Hakkında Framework Çalışmaları Yapan 28 Saatlik Eğitimdir.",Resim="2.jpg",CategoryId=2},
                new Blog() {Baslik="C# Delegates Hakkında",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-5),Anasayfa=true,Onay=true,Icerik="C# Delegates Hakkında Framework Çalışmaları Yapan 28 Saatlik Eğitimdir.",Resim="3.jpg",CategoryId=3},
                new Blog() {Baslik="C#",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-13),Anasayfa=false,Onay=false,Icerik="C# Delegates Hakkında Framework Çalışmaları Yapan 28 Saatlik Eğitimdir.",Resim="3.jpg",CategoryId=3},
                new Blog() {Baslik="C#",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-20),Anasayfa=false,Onay=true,Icerik="C# Delegates Hakkında Framework Çalışmaları Yapan 28 Saatlik Eğitimdir.",Resim="3.jpg",CategoryId=3},
                new Blog() {Baslik="C#",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-18),Anasayfa=true,Onay=false,Icerik="C# Delegates Hakkında Framework Çalışmaları Yapan 28 Saatlik Eğitimdir.",Resim="4.jpg",CategoryId=4},
                new Blog() {Baslik="Asp.net MVC",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-9),Anasayfa=true,Onay=true,Icerik="C# Delegates Hakkında Framework Çalışmaları Yapan 28 Saatlik Eğitimdir.",Resim="4.jpg",CategoryId=4},
                new Blog() {Baslik="C#",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-17),Anasayfa=false,Onay=true,Icerik="C# Delegates Hakkında Framework Çalışmaları Yapan 28 Saatlik Eğitimdir.",Resim="4.jpg",CategoryId=4},
                new Blog() {Baslik="Windows Form",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-16),Anasayfa=true,Onay=true,Icerik="C# Delegates Hakkında Framework Çalışmaları Yapan 28 Saatlik Eğitimdir.",Resim="4.jpg",CategoryId=4}

            };

            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }

            context.SaveChanges();  
            base.Seed(context);
        }
    }
}