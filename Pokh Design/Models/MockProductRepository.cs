using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokh_Design.Models
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Product> AllProducts => new List<Product>
        {
           new  Product{ProductId=1,Name="Old Chair refurbished",LongDescription="An old chair refurbished. supple sheepskin with primitive fish motifs.",ShortDescription="Lorem Ipsum",Price=3450,InStock=true,IsProductOfTheWeek=false,Category=_categoryRepository.AllCategories.ToList()[0],ImageUrl="https://www.facebook.com/pokhdesign/photos/a.865754870199372/3486078438166989/",ImageThumbnailUrl="https://www.facebook.com/pokhdesign/photos/a.865754870199372/3486078438166989/"},
           new  Product{ProductId=3,Name="Hand painted Chair",LongDescription="Hand painted #orginal #art",ShortDescription="Lorem Ipsum",Price=4999,InStock=true,IsProductOfTheWeek=true,Category=_categoryRepository.AllCategories.ToList()[0],ImageUrl="https://www.facebook.com/pokhdesign/photos/a.865754870199372/2359173760857468/",ImageThumbnailUrl="https://www.facebook.com/pokhdesign/photos/a.865754870199372/2359173760857468/"},
           new  Product{ProductId=2,Name="Round Pouf",LongDescription="Round pouf Manufacture of vegetal leather, painted and painted by hand Dimensions: 35 × 65 × 65 Removable cover.",ShortDescription="Lorem Ipsum",Price=500,InStock=true,IsProductOfTheWeek=false,Category=_categoryRepository.AllCategories.ToList()[1],ImageUrl="https://www.facebook.com/pokhdesign/photos/a.866175150157344/1214016528706536/",ImageThumbnailUrl="https://www.facebook.com/pokhdesign/photos/a.866175150157344/1214016528706536/"},
           new  Product{ProductId=4,Name="Big Arm Chair",LongDescription="Made by humans in Tunisian fabric",ShortDescription="Lorem Ipsum",Price=3450,InStock=true,IsProductOfTheWeek=true,Category=_categoryRepository.AllCategories.ToList()[2],ImageUrl="https://www.facebook.com/pokhdesign/photos/a.865753123532880/865753080199551/",ImageThumbnailUrl="https://www.facebook.com/pokhdesign/photos/a.865753123532880/865753080199551/"}

        };

        public IEnumerable<Product> ProductsOfTheWeek { get; }

    public Product GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(p=>p.ProductId==productId);
        }
    }
}
