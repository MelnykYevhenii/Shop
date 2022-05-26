using Shop.Data.Models;
using System.Linq;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(v => v.Value));
            }

            if (!content.Car.Any())
            {
                content.Category.AddRange(Categories.Select(v => v.Value));
                content.AddRange(
                        new Car
                        {
                            Name = "Tesla Model S",
                            ShortDesc = "Опис коротки",
                            LongDesc = "Опис довгий",
                            Img = "/img/tesla.jpg",
                            Price = 45000,
                            IsFavorite = true,
                            Available = true,
                            Category = Categories["Електромобілі"]
                        },
                        new Car
                        {
                            Name = "BMW M3",
                            ShortDesc = "Опис коротки",
                            LongDesc = "Опис довгий",
                            Img = "/img/bmw.jpg",
                            Price = 35000,
                            IsFavorite = true,
                            Available = false,
                            Category = Categories["Класничні авто"]
                        },
                        new Car
                        {
                            Name = "Audi",
                            ShortDesc = "Опис коротки",
                            LongDesc = "Опис довгий",
                            Img = "/img/audi.jpg",
                            Price = 65000,
                            IsFavorite = false,
                            Available = true,
                            Category = Categories["Класничні авто"]
                        },
                        new Car
                        {
                            Name = "Mercedes S Class",
                            ShortDesc = "Опис коротки",
                            LongDesc = "Опис довгий",
                            Img = "/img/mercedes.jpg",
                            Price = 60000,
                            IsFavorite = false,
                            Available = false,
                            Category = Categories["Класничні авто"]
                        },
                        new Car
                        {
                            Name = "Nissan Leaf",
                            ShortDesc = "Опис коротки",
                            LongDesc = "Опис довгий",
                            Img = "/img/nissan.jpg",
                            Price = 20000,
                            IsFavorite = false,
                            Available = true,
                            Category = Categories["Електромобілі"]
                        },
                        new Car
                        {
                            Name = "Renault Megane",
                            ShortDesc = "Опис коротки",
                            LongDesc = "Опис довгий",
                            Img = "/img/megane.jpg",
                            Price = 25000,
                            IsFavorite = false,
                            Available = true,
                            Category = Categories["Класничні авто"]
                        }
                    );
            }
            content.SaveChanges(); //Зберігаємо зміни (об'єкти\товари і тд)
        }
        private static Dictionary<string, Category>? category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { CategoryName = "Електромобілі", Description = "Сучасний вид транспорту" },
                        new Category { CategoryName = "Класничні авто", Description = "Застарілий вид транспорту" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category c in list)
                    {
                        category.Add(c.CategoryName, c);
                    }
                }
                return category;
            }
        }
    }
}
