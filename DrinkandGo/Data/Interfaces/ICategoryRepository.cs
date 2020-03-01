using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkandGo.Data.Models;

namespace DrinkandGo.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get;}
    }
}
