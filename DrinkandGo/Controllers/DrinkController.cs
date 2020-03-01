using Microsoft.AspNetCore.Mvc;
using DrinkandGo.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkandGo.ViewModels;

namespace DrinkandGo.Controllers
{
    public class DrinkController:Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;
        public DrinkController(ICategoryRepository _categoryRepository, IDrinkRepository _drinkRepository)
        {
            this._categoryRepository = _categoryRepository;
            this._drinkRepository = _drinkRepository;
        }
        public ViewResult List()
        {
            ViewBag.Name = "Disanth Kumar?";
            DrinkListViewModel vm = new DrinkListViewModel();
            vm.Drinks = _drinkRepository.Drinks;
            vm.CurrentCategory = "DrinkCategory";
            return View(vm);
        }
    }
}
