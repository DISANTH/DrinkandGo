using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkandGo.Data.Interfaces;
using DrinkandGo.Data.Models;

namespace DrinkandGo.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {

        IEnumerable<Category> ICategoryRepository.Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Alchoholics", Description = "All alcoholic drinks" },
                    new Category { CategoryName = "Non-Alchoholics", Description = "All non-alcoholic drinks" }
                };
            }
        }
    }
}
