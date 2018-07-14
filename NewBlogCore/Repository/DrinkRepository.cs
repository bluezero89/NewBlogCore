using Microsoft.EntityFrameworkCore;
using NewBlogCore.Data;
using NewBlogCore.Interface;
using NewBlogCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBlogCore.Repository
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public DrinkRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Drink> Drinks => _appDbContext.Drinks.Include(c => c.Category);

        public IEnumerable<Drink> PreferredDrinks => _appDbContext.Drinks.Where(p => p.IsPreferredDrink).Include(c => c.Category);

        public Drink GetDrinkById(int drinkId) => _appDbContext.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
    }
}
