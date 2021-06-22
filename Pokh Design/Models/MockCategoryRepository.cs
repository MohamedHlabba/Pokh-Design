using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokh_Design.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>  new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Chair", Description="All-Hand Made Chairs"},
                new Category{CategoryId=2, CategoryName="Pouf", Description="Elegant Leather Piece"},
                new Category { CategoryId = 3, CategoryName = "ArmChair", Description = "Get the comfort that you deserve" }
            };
    }
}
