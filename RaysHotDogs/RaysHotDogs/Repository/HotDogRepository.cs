using System.Collections.Generic;
using System.Linq;
using RaysHotDogs.Core.Model;

namespace RaysHotDogs.Core.Repository
{
    public class HotDogRepository
    {
        private static List<HotDogGroup> hotDogGroups = new List<HotDogGroup>()
        {
            new HotDogGroup()
            {
                HotDogGroupId = 1,
                Title = "Meat Lovers",
                ImagePath = "",
                HotDogs = new List<HotDog>()
                {
                    new HotDog()
                    {
                        HotDogId = 1,
                        Name = "Regular Hot Dog",
                        ShortDescription = "The best there is",
                        Description = "Some hotdog with cheese",
                        ImagePath = "hotdog1",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string>() {"Bun", "Sausage", "Ketchup", "Mustard", "Cheese"},
                        Price = 8,
                        IsFavorite = true
                    },
                    new HotDog()
                    {
                        HotDogId = 2,
                        Name = "Haute Dog",
                        ShortDescription = "Super fancy",
                        Description =
                            "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non ",
                        ImagePath = "hotdog2",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string>() {"Bun", "Sausage", "Ketchup", "Mustard", "Cheese"},
                        Price = 8,
                        IsFavorite = true
                    },
                    new HotDog()
                    {
                        HotDogId = 3,
                        Name = "Haute Dog",
                        ShortDescription = "Super fancy",
                        Description =
                            "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non ",
                        ImagePath = "hotdog2",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string>() {"Bun", "Sausage", "Ketchup", "Mustard", "Cheese"},
                        Price = 8,
                        IsFavorite = true
                    }
                }
            },
            new HotDogGroup()
            {
                HotDogGroupId = 2,
                Title = "Veggie Lovers",
                ImagePath = "",
                HotDogs = new List<HotDog>()
                {
                    new HotDog()
                    {
                        HotDogId = 4,
                        Name = "Veggie Hot Dog",
                        ShortDescription = "The best there is if you're vegan",
                        Description = "Some hotdog without cheese or meat",
                        ImagePath = "hotdog1",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string>() {"Bun", "Fake Sausage", "Ketchup", "Mustard", "Cheese"},
                        Price = 8,
                        IsFavorite = true
                    },
                    new HotDog()
                    {
                        HotDogId = 5,
                        Name = "Haute Dog",
                        ShortDescription = "Super fancy",
                        Description =
                            "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non ",
                        ImagePath = "hotdog2",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string>() {"Bun", "Sausage", "Ketchup", "Mustard", "Cheese"},
                        Price = 8,
                        IsFavorite = true
                    }
                }
            }
        };

        public List<HotDog> GetAllHotDogs()
        {
            var hotDogs =
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs
                select hotDog;

            return hotDogs.ToList<HotDog>();
        }


        public HotDog GetHotDogById(int id)
        {
            var hotDogs =
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs
                where hotDog.HotDogId == id
                select hotDog;

            return hotDogs.FirstOrDefault();
        }

        public List<HotDogGroup> GetGroupedHotDogs()
        {
            return hotDogGroups;
        }

        public List<HotDog> GetHotDogsForGroup(int groupId)
        {
            var group = hotDogGroups.FirstOrDefault(h => h.HotDogGroupId == groupId);

            return @group?.HotDogs;
        }

        public List<HotDog> GetFavoriteHotDogs()
        {
            var hotDogs =
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs
                where hotDog.IsFavorite
                select hotDog;

            return hotDogs.ToList<HotDog>();
        }
    }
}