using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Models.Services
{
    public class FakeProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {

                new Product{ID=1, Name="Kindle", ImageURL="https://cdn.dsmcdn.com//ty54/product/media/images/20210112/20/52277707/73993819/1/1_org.jpg", Description="E-Kitap Okuyucu", Price=1279, Discount=0.2, Rating=5 },
                new Product{ID=2, Name="Kindle ama 2", ImageURL="https://cdn.dsmcdn.com//ty54/product/media/images/20210112/20/52277707/73993819/1/1_org.jpg", Description="E-Kitap Okuyucu again", Price=699, Discount=0.2, Rating=5 },
                new Product{ID=3, Name="Kobo",ImageURL="https://cdn.dsmcdn.com//ty54/product/media/images/20210112/20/52277707/73993819/1/1_org.jpg", Description="E-Kitap Okuyucu ama Kobo", Price=959, Discount=0.2, Rating=5 },
                new Product{ID=4, Name="Ama Kobo değil", ImageURL="https://cdn.dsmcdn.com//ty54/product/media/images/20210112/20/52277707/73993819/1/1_org.jpg",Description="Yine Kobo", Price=1279, Discount=0.2, Rating=5 },
                new Product{ID=5, Name="Pahalı Kindle", ImageURL="https://cdn.dsmcdn.com//ty54/product/media/images/20210112/20/52277707/73993819/1/1_org.jpg",Description="Ciddi pahalı Kindle", Price=1479, Discount=0.2, Rating=5 },
                new Product{ID=6, Name="Fikrim Kalmadı", ImageURL="https://cdn.dsmcdn.com//ty54/product/media/images/20210112/20/52277707/73993819/1/1_org.jpg",Description="Neyse ki bende var Kobo", Price=1279, Discount=0.2, Rating=5 },
                new Product{ID=7, Name="Kindle", ImageURL="https://cdn.dsmcdn.com//ty54/product/media/images/20210112/20/52277707/73993819/1/1_org.jpg", Description="E-Kitap Okuyucu", Price=1279, Discount=0.2, Rating=5 },
                new Product{ID=8, Name="Kindle ama 2", ImageURL="https://cdn.dsmcdn.com//ty54/product/media/images/20210112/20/52277707/73993819/1/1_org.jpg", Description="E-Kitap Okuyucu again", Price=699, Discount=0.2, Rating=5 },
                new Product{ID=9, Name="Kobo",ImageURL="https://cdn.dsmcdn.com//ty54/product/media/images/20210112/20/52277707/73993819/1/1_org.jpg", Description="E-Kitap Okuyucu ama Kobo", Price=959, Discount=0.2, Rating=5 },
                new Product{ID=10, Name="Ama Kobo değil", ImageURL="https://cdn.dsmcdn.com//ty54/product/media/images/20210112/20/52277707/73993819/1/1_org.jpg",Description="Yine Kobo", Price=1279, Discount=0.2, Rating=5 },
                new Product{ID=11, Name="Pahalı Kindle", ImageURL="https://cdn.dsmcdn.com//ty54/product/media/images/20210112/20/52277707/73993819/1/1_org.jpg",Description="Ciddi pahalı Kindle", Price=1479, Discount=0.2, Rating=5 },
                new Product{ID=12, Name="Fikrim Kalmadı", ImageURL="https://cdn.dsmcdn.com//ty54/product/media/images/20210112/20/52277707/73993819/1/1_org.jpg",Description="Neyse ki bende var Kobo", Price=1279, Discount=0.2, Rating=5 }



            };


        }














    }
}
