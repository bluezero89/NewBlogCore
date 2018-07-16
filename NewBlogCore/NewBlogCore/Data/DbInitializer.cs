using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using NewBlogCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBlogCore.Data
{
    public class DbInitializer
    {
        private ApplicationDbContext _context;

        public DbInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Milk Tea", Description="All milk tea drinks" },
                        new Category { CategoryName = "Fruit", Description="All fruit drinks" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }

        //public static void Seed(IApplicationBuilder applicationBuilder)
        //public static void Seed(ApplicationDbContext context, IApplicationBuilder applicationBuilder)
        public void Seed()
        {
            //ApplicationDbContext context =
            //    applicationBuilder.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            if (!_context.Categories.Any())
            {
                _context.AddRange(
                    new Category { CategoryName = "Milk Tea", Description = "All milk tea drinks" },
                    new Category { CategoryName = "Fruit", Description = "All fruit drinks" }
                );
                _context.SaveChangesAsync();
            }

            if (!_context.Categories.Any())
            {
                _context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!_context.Drinks.Any())
            {
                _context.AddRange
                (
                    new Drink
                    {
                        Name = "Sữa Tươi Trân Châu Đường Đen",
                        Price = 9.99M,
                        ShortDescription = "Cách làm Sữa Tươi Trân Châu Đường Đen",
                        LongDescription = "Sữa tươi trân châu đường nâu đang là món hot trend trên thị trường, vị béo ngậy của sữa tươi thanh trùng, vị dai dai ngọt ngọt của trân châu đường nâu sẽ khiến bạn uống mãi không dừng. Cách làm thì vô cùng đơn giản, bạn có thể tự làm tại nhà để đảm bảo an toàn sức khỏe nhé!",
                        Category = Categories["Milk Tea"],
                        ImageUrl = "~/images/brew1.png",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "~/images/brew1.png"
                    }, new Drink
                    {
                        Name = "Sữa Tươi Trân Châu Đường Đen",
                        Price = 9.99M,
                        ShortDescription = "Cách làm Sữa Tươi Trân Châu Đường Đen",
                        LongDescription = "Sữa tươi trân châu đường nâu đang là món hot trend trên thị trường, vị béo ngậy của sữa tươi thanh trùng, vị dai dai ngọt ngọt của trân châu đường nâu sẽ khiến bạn uống mãi không dừng. Cách làm thì vô cùng đơn giản, bạn có thể tự làm tại nhà để đảm bảo an toàn sức khỏe nhé!",
                        Category = Categories["Milk Tea"],
                        ImageUrl = "~/images/brew1.png",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "~/images/brew1.png"
                    }, new Drink
                    {
                        Name = "Sữa Tươi Trân Châu Đường Đen",
                        Price = 9.99M,
                        ShortDescription = "Cách làm Sữa Tươi Trân Châu Đường Đen",
                        LongDescription = "Sữa tươi trân châu đường nâu đang là món hot trend trên thị trường, vị béo ngậy của sữa tươi thanh trùng, vị dai dai ngọt ngọt của trân châu đường nâu sẽ khiến bạn uống mãi không dừng. Cách làm thì vô cùng đơn giản, bạn có thể tự làm tại nhà để đảm bảo an toàn sức khỏe nhé!",
                        Category = Categories["Milk Tea"],
                        ImageUrl = "~/images/brew1.png",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "~/images/brew1.png"
                    }, new Drink
                    {
                        Name = "Sữa Tươi Trân Châu Đường Đen",
                        Price = 9.99M,
                        ShortDescription = "Cách làm Sữa Tươi Trân Châu Đường Đen",
                        LongDescription = "Sữa tươi trân châu đường nâu đang là món hot trend trên thị trường, vị béo ngậy của sữa tươi thanh trùng, vị dai dai ngọt ngọt của trân châu đường nâu sẽ khiến bạn uống mãi không dừng. Cách làm thì vô cùng đơn giản, bạn có thể tự làm tại nhà để đảm bảo an toàn sức khỏe nhé!",
                        Category = Categories["Milk Tea"],
                        ImageUrl = "~/images/brew1.png",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "~/images/brew1.png"
                    }, new Drink
                    {
                        Name = "Sữa Tươi Trân Châu Đường Đen",
                        Price = 9.99M,
                        ShortDescription = "Cách làm Sữa Tươi Trân Châu Đường Đen",
                        LongDescription = "Sữa tươi trân châu đường nâu đang là món hot trend trên thị trường, vị béo ngậy của sữa tươi thanh trùng, vị dai dai ngọt ngọt của trân châu đường nâu sẽ khiến bạn uống mãi không dừng. Cách làm thì vô cùng đơn giản, bạn có thể tự làm tại nhà để đảm bảo an toàn sức khỏe nhé!",
                        Category = Categories["Milk Tea"],
                        ImageUrl = "~/images/brew1.png",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "~/images/brew1.png"
                    }, new Drink
                    {
                        Name = "Sữa Tươi Trân Châu Đường Đen",
                        Price = 9.99M,
                        ShortDescription = "Cách làm Sữa Tươi Trân Châu Đường Đen",
                        LongDescription = "Sữa tươi trân châu đường nâu đang là món hot trend trên thị trường, vị béo ngậy của sữa tươi thanh trùng, vị dai dai ngọt ngọt của trân châu đường nâu sẽ khiến bạn uống mãi không dừng. Cách làm thì vô cùng đơn giản, bạn có thể tự làm tại nhà để đảm bảo an toàn sức khỏe nhé!",
                        Category = Categories["Milk Tea"],
                        ImageUrl = "~/images/brew1.png",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "~/images/brew1.png"
                    }, new Drink
                    {
                        Name = "Sữa Tươi Trân Châu Đường Đen",
                        Price = 9.99M,
                        ShortDescription = "Cách làm Sữa Tươi Trân Châu Đường Đen",
                        LongDescription = "Sữa tươi trân châu đường nâu đang là món hot trend trên thị trường, vị béo ngậy của sữa tươi thanh trùng, vị dai dai ngọt ngọt của trân châu đường nâu sẽ khiến bạn uống mãi không dừng. Cách làm thì vô cùng đơn giản, bạn có thể tự làm tại nhà để đảm bảo an toàn sức khỏe nhé!",
                        Category = Categories["Milk Tea"],
                        ImageUrl = "~/images/brew1.png",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "~/images/brew1.png"
                    }, new Drink
                    {
                        Name = "Sữa Tươi Trân Châu Đường Đen",
                        Price = 9.99M,
                        ShortDescription = "Cách làm Sữa Tươi Trân Châu Đường Đen",
                        LongDescription = "Sữa tươi trân châu đường nâu đang là món hot trend trên thị trường, vị béo ngậy của sữa tươi thanh trùng, vị dai dai ngọt ngọt của trân châu đường nâu sẽ khiến bạn uống mãi không dừng. Cách làm thì vô cùng đơn giản, bạn có thể tự làm tại nhà để đảm bảo an toàn sức khỏe nhé!",
                        Category = Categories["Milk Tea"],
                        ImageUrl = "~/images/brew1.png",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "~/images/brew1.png"
                    }, new Drink
                    {
                        Name = "Sữa Tươi Trân Châu Đường Đen",
                        Price = 9.99M,
                        ShortDescription = "Cách làm Sữa Tươi Trân Châu Đường Đen",
                        LongDescription = "Sữa tươi trân châu đường nâu đang là món hot trend trên thị trường, vị béo ngậy của sữa tươi thanh trùng, vị dai dai ngọt ngọt của trân châu đường nâu sẽ khiến bạn uống mãi không dừng. Cách làm thì vô cùng đơn giản, bạn có thể tự làm tại nhà để đảm bảo an toàn sức khỏe nhé!",
                        Category = Categories["Milk Tea"],
                        ImageUrl = "~/images/brew1.png",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "~/images/brew1.png"
                    }, new Drink
                    {
                        Name = "Sữa Tươi Trân Châu Đường Đen",
                        Price = 9.99M,
                        ShortDescription = "Cách làm Sữa Tươi Trân Châu Đường Đen",
                        LongDescription = "Sữa tươi trân châu đường nâu đang là món hot trend trên thị trường, vị béo ngậy của sữa tươi thanh trùng, vị dai dai ngọt ngọt của trân châu đường nâu sẽ khiến bạn uống mãi không dừng. Cách làm thì vô cùng đơn giản, bạn có thể tự làm tại nhà để đảm bảo an toàn sức khỏe nhé!",
                        Category = Categories["Milk Tea"],
                        ImageUrl = "~/images/brew1.png",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "~/images/brew1.png"
                    }, new Drink
                    {
                        Name = "Sữa Tươi Trân Châu Đường Đen",
                        Price = 9.99M,
                        ShortDescription = "Cách làm Sữa Tươi Trân Châu Đường Đen",
                        LongDescription = "Sữa tươi trân châu đường nâu đang là món hot trend trên thị trường, vị béo ngậy của sữa tươi thanh trùng, vị dai dai ngọt ngọt của trân châu đường nâu sẽ khiến bạn uống mãi không dừng. Cách làm thì vô cùng đơn giản, bạn có thể tự làm tại nhà để đảm bảo an toàn sức khỏe nhé!",
                        Category = Categories["Milk Tea"],
                        ImageUrl = "~/images/brew1.png",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "~/images/brew1.png"
                    }, new Drink
                    {
                        Name = "Sữa Tươi Trân Châu Đường Đen",
                        Price = 9.99M,
                        ShortDescription = "Cách làm Sữa Tươi Trân Châu Đường Đen",
                        LongDescription = "Sữa tươi trân châu đường nâu đang là món hot trend trên thị trường, vị béo ngậy của sữa tươi thanh trùng, vị dai dai ngọt ngọt của trân châu đường nâu sẽ khiến bạn uống mãi không dừng. Cách làm thì vô cùng đơn giản, bạn có thể tự làm tại nhà để đảm bảo an toàn sức khỏe nhé!",
                        Category = Categories["Milk Tea"],
                        ImageUrl = "~/images/brew1.png",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "~/images/brew1.png"
                    }
                );
            }

            _context.SaveChanges();
        }
    }
}
