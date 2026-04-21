using System;
using Farmers_Market_API.Enums;
using Farmers_Market_API.Models;

namespace Farmers_Market_API.Repositories
{
    public class ProduceRepository
    {
        private List<ProduceListing> ProduceListings = new()
        {
            new ProduceListing(1, 1, "Tomatoes", Category.Vegetables, 2.5, 100, false, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-5), "Freshly harvested tomatoes."),
            new ProduceListing(2, 2, "Apples", Category.Fruit, 3.0, 50, true, DateTime.Now.AddDays(-15), DateTime.Now.AddDays(-7), "Crisp and sweet apples."),
            new ProduceListing(3, 3, "Carrots", Category.Vegetables, 1.8, 200, true, DateTime.Now.AddDays(-20), DateTime.Now.AddDays(-10), "Organic carrots from our farm."),
            new ProduceListing(4, 1, "Lettuce", Category.Vegetables, 2.0, 75, true, DateTime.Now.AddDays(-8), DateTime.Now.AddDays(-3), "Crisp green lettuce leaves."),
            new ProduceListing(5, 2, "Oranges", Category.Fruit, 2.8, 60, false, DateTime.Now.AddDays(-12), DateTime.Now.AddDays(-6), "Juicy navel oranges."),
            new ProduceListing(6, 3, "Potatoes", Category.Vegetables, 1.5, 150, true, DateTime.Now.AddDays(-25), DateTime.Now.AddDays(-12), "Fresh russet potatoes."),
            new ProduceListing(7, 1, "Strawberries", Category.Fruit, 4.5, 30, false, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(-2), "Sweet seasonal strawberries."),
            new ProduceListing(8, 2, "Broccoli", Category.Vegetables, 3.2, 40, false, DateTime.Now.AddDays(-7), DateTime.Now.AddDays(-4), "Nutritious broccoli florets."),
            new ProduceListing(9, 3, "Bananas", Category.Fruit, 1.2, 80, true, DateTime.Now.AddDays(-18), DateTime.Now.AddDays(-9), "Ripe yellow bananas."),
            new ProduceListing(10, 1, "Spinach", Category.Vegetables, 2.3, 55, true, DateTime.Now.AddDays(-6), DateTime.Now.AddDays(-3), "Fresh baby spinach leaves."),

            new ProduceListing(11, 2, "Cucumbers", Category.Vegetables, 1.9, 90, true, DateTime.Now.AddDays(-4), DateTime.Now.AddDays(-2), "Crisp garden cucumbers."),
            new ProduceListing(12, 3, "Blueberries", Category.Fruit, 5.0, 25, false, DateTime.Now.AddDays(-3), DateTime.Now.AddDays(-1), "Plump wild blueberries."),
            new ProduceListing(13, 1, "Garlic", Category.Vegetables, 4.0, 15, true, DateTime.Now.AddDays(-30), DateTime.Now.AddDays(-15), "Aromatic garlic bulbs."),
            new ProduceListing(14, 2, "Onions", Category.Vegetables, 1.6, 120, true, DateTime.Now.AddDays(-20), DateTime.Now.AddDays(-10), "Sweet yellow onions."),
            new ProduceListing(15, 3, "Bell Peppers", Category.Vegetables, 3.5, 45, true, DateTime.Now.AddDays(-9), DateTime.Now.AddDays(-4), "Mixed-color bell peppers."),
            new ProduceListing(16, 1, "Pumpkins", Category.Vegetables, 0.9, 60, false, DateTime.Now.AddDays(-40), DateTime.Now.AddDays(-30), "Large carving pumpkins."),
            new ProduceListing(17, 2, "Corn", Category.Grain, 1.2, 200, true, DateTime.Now.AddDays(-7), DateTime.Now.AddDays(-3), "Sweet corn on the cob."),
            new ProduceListing(18, 3, "Wheat (Bulk)", Category.Grain, 0.8, 500, true, DateTime.Now.AddDays(-60), DateTime.Now.AddDays(-45), "Whole wheat grain."),
            new ProduceListing(19, 1, "Oats", Category.Grain, 1.1, 350, true, DateTime.Now.AddDays(-50), DateTime.Now.AddDays(-25), "Rolled oats for baking."),
            new ProduceListing(20, 2, "Milk", Category.Dairy, 0.95, 200, true, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(-1), "Fresh whole milk (per liter equivalent)."),

            new ProduceListing(21, 3, "Cheese", Category.Dairy, 8.5, 20, true, DateTime.Now.AddDays(-14), DateTime.Now.AddDays(-7), "Aged farmhouse cheddar."),
            new ProduceListing(22, 1, "Yogurt", Category.Dairy, 3.2, 40, true, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(-2), "Creamy plain yogurt."),
            new ProduceListing(23, 2, "Chicken (Whole)", Category.Meat, 6.5, 35, true, DateTime.Now.AddDays(-6), DateTime.Now.AddDays(-3), "Pasture-raised whole chicken."),
            new ProduceListing(24, 3, "Beef (Ground)", Category.Meat, 9.0, 25, true, DateTime.Now.AddDays(-8), DateTime.Now.AddDays(-4), "Lean ground beef."),
            new ProduceListing(25, 1, "Pork (Chops)", Category.Meat, 7.2, 30, true, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-5), "Fresh pork chops."),
            new ProduceListing(26, 2, "Eggs (Dozen)", Category.Eggs, 2.5, 150, true, DateTime.Now.AddDays(-1), DateTime.Now.AddDays(0), "Free-range brown eggs."),
            new ProduceListing(27, 3, "Honey", Category.Other, 6.0, 18, true, DateTime.Now.AddDays(-120), DateTime.Now.AddDays(-60), "Raw wildflower honey."),
            new ProduceListing(28, 1, "Basil", Category.Other, 12.0, 5, true, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(-1), "Fresh basil bunches."),
            new ProduceListing(29, 2, "Parsley", Category.Other, 4.0, 12, true, DateTime.Now.AddDays(-3), DateTime.Now.AddDays(-1), "Curly parsley bunches."),
            new ProduceListing(30, 3, "Ginger", Category.Other, 9.0, 8, true, DateTime.Now.AddDays(-7), DateTime.Now.AddDays(-3), "Fresh ginger roots."),

            new ProduceListing(31, 1, "Sweet Potatoes", Category.Vegetables, 2.2, 80, true, DateTime.Now.AddDays(-18), DateTime.Now.AddDays(-9), "Orange-fleshed sweet potatoes."),
            new ProduceListing(32, 2, "Kale", Category.Vegetables, 3.0, 30, true, DateTime.Now.AddDays(-4), DateTime.Now.AddDays(-2), "Fresh curly kale."),
            new ProduceListing(33, 3, "Zucchini", Category.Vegetables, 1.7, 60, true, DateTime.Now.AddDays(-6), DateTime.Now.AddDays(-3), "Green zucchinis."),
            new ProduceListing(34, 1, "Pears", Category.Fruit, 2.9, 40, true, DateTime.Now.AddDays(-12), DateTime.Now.AddDays(-6), "Juicy Bartlett pears."),
            new ProduceListing(35, 2, "Plums", Category.Fruit, 3.3, 28, false, DateTime.Now.AddDays(-9), DateTime.Now.AddDays(-4), "Sweet red plums."),
            new ProduceListing(36, 3, "Grapes", Category.Fruit, 4.1, 35, true, DateTime.Now.AddDays(-11), DateTime.Now.AddDays(-5), "Seedless table grapes."),
            new ProduceListing(37, 1, "Avocados", Category.Fruit, 2.75, 22, false, DateTime.Now.AddDays(-7), DateTime.Now.AddDays(-2), "Hass avocados."),
            new ProduceListing(38, 2, "Pineapple", Category.Fruit, 3.8, 10, true, DateTime.Now.AddDays(-14), DateTime.Now.AddDays(-7), "Tropical pineapples."),
            new ProduceListing(39, 3, "Cabbage", Category.Vegetables, 1.4, 48, true, DateTime.Now.AddDays(-16), DateTime.Now.AddDays(-8), "Green and red cabbages."),
            new ProduceListing(40, 1, "Radishes", Category.Vegetables, 2.0, 22, true, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(-1), "Crisp radish bunches."),

            new ProduceListing(41, 2, "Beets", Category.Vegetables, 2.5, 26, true, DateTime.Now.AddDays(-14), DateTime.Now.AddDays(-7), "Earthy red beets."),
            new ProduceListing(42, 3, "Celery", Category.Vegetables, 1.8, 20, true, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(-2), "Crunchy celery stalks."),
            new ProduceListing(43, 1, "Green Beans", Category.Vegetables, 3.1, 34, true, DateTime.Now.AddDays(-6), DateTime.Now.AddDays(-3), "Fresh snap beans."),
            new ProduceListing(44, 2, "Peaches", Category.Fruit, 3.6, 27, true, DateTime.Now.AddDays(-8), DateTime.Now.AddDays(-4), "Juicy summer peaches."),
            new ProduceListing(45, 3, "Nectarines", Category.Fruit, 3.7, 18, false, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-5), "Sweet nectarines."),
            new ProduceListing(46, 1, "Apricots", Category.Fruit, 4.2, 12, true, DateTime.Now.AddDays(-9), DateTime.Now.AddDays(-4), "Sun-ripened apricots."),
            new ProduceListing(47, 2, "Mixed Herbs", Category.Other, 10.0, 6, true, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(-1), "Bunches of mixed culinary herbs."),
            new ProduceListing(48, 3, "Almonds (Shelled)", Category.Other, 12.5, 14, true, DateTime.Now.AddDays(-200), DateTime.Now.AddDays(-100), "Locally grown almonds."),
            new ProduceListing(49, 1, "Lentils (Bulk)", Category.Grain, 1.6, 220, true, DateTime.Now.AddDays(-90), DateTime.Now.AddDays(-45), "Dry lentils for cooking."),
            new ProduceListing(50, 2, "Tofu (Fresh)", Category.Other, 4.5, 30, true, DateTime.Now.AddDays(-3), DateTime.Now.AddDays(-1), "Freshly made soybean tofu.")
        };

        public void AddProduce(ProduceListing produce) 
        {
            int newId = ProduceListings.Max(p => p.ListingId) + 1;
            produce.ListingId = newId;
            ProduceListings.Add(produce);
        }

        public List<ProduceListing> getAll() { return ProduceListings; }

        public ProduceListing? GetById(int id)
        {

            for (int i = 0; i < ProduceListings.Count; i++)
            {
                if (ProduceListings[i].ListingId == id)
                {
                    return ProduceListings[i];
                }
            }
            return null;
        }

        public List<ProduceListing> GetByCategory(Category category)
        {
            List<ProduceListing> results = new();
            for (int i = 0; i < ProduceListings.Count; i++)
            {
                if (ProduceListings[i].Category == category)
                {
                    results.Add(ProduceListings[i]);
                }
            }
            return results;
        }
        
        public List<ProduceListing> GetAvailable()
        {
            List<ProduceListing> results = new();
            foreach (var produce in ProduceListings)
            {
                if (produce.IsAvailable) { results.Add(produce); }
            }

            return results;
        }
    }
}
