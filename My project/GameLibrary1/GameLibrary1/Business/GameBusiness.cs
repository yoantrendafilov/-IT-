using GameLibrary1.Data;
using GameLibrary1.Presentation;
using GameLibrary1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary1.Business
{
   public class GameBusiness
    {
        private GameContext gameContext;
        //Game
        public List<Game>GetGames()
        {
            using (gameContext=new GameContext())
            {
                return gameContext.Games.ToList();
            }
        }

        public Game Get(int id)
        {
            using (gameContext = new GameContext())
            {
                return gameContext.Games.Find(id);
            }
        }

        public void Add(Game game)
        {
            using (gameContext = new GameContext())
            {
                gameContext.Games.Add(game);
                gameContext.SaveChanges();
            }
        }

        public void Update(Game game)
        {
            using (gameContext = new GameContext())
            {
                var prod = gameContext.Games.Find(game.ID);
                if(prod!=null)
                {
                    gameContext.Entry(prod).CurrentValues.SetValues(game);
                    gameContext.SaveChanges();
                }

            }
        }


        public void Delete(int id)
        {
            using (gameContext = new GameContext())
            {
                var prod = gameContext.Games.Find(id);
                if (prod != null)
                {
                    gameContext.Games.Remove(prod);
                    gameContext.SaveChanges();
                }

            }
        }



       //Developer
        public List<Developer> GetDevelopers()
        {
            using (gameContext = new GameContext())
            {
                return gameContext.Developers.ToList();
            }
        }
        
        public void AddDev(Developer developer)
        {
            using (gameContext = new GameContext())
            {
                gameContext.Developers.Add(developer);
                gameContext.SaveChanges();
            }
        }

        public Developer GetDeveloper(int id)
        {
            using (gameContext = new GameContext())
            {
               return gameContext.Developers.Find(id);
               
            }
        }
        public void UpdateDev(Developer developer)
        {
            using (gameContext = new GameContext())
            {
                var prod = gameContext.Developers.Find(developer.ID);
                if (prod != null)
                {
                    gameContext.Entry(prod).CurrentValues.SetValues(developer);
                    gameContext.SaveChanges();
                }

            }
        }

        public void DeleteDev(int id)
        {
            using (gameContext = new GameContext())
            {
                var prod = gameContext.Developers.Find(id);
                if (prod != null)
                {
                    gameContext.Developers.Remove(prod);
                    gameContext.SaveChanges();
                }

            }
        }


        //Details
        public List<Detail> GetDetails()
        {
            using (gameContext = new GameContext())
            {
                return gameContext.Details.ToList();
            }
        }


        public void AddDetail(Detail detail)
        {
            using (gameContext = new GameContext())
            {
                gameContext.Details.Add(detail);
                gameContext.SaveChanges();
            }
        }

        public Detail GetDetail(int id)
        {
            using (gameContext = new GameContext())
            {
                return gameContext.Details.Find(id);

            }
        }
        public void UpdateDet(Detail detail)
        {
            using (gameContext = new GameContext())
            {
                var prod = gameContext.Details.Find(detail.ID);
                if (prod != null)
                {
                    gameContext.Entry(prod).CurrentValues.SetValues(detail);
                    gameContext.SaveChanges();
                }

            }
        }

        public void DeleteDetail(int id)
        {
            using (gameContext = new GameContext())
            {
                var prod = gameContext.Details.Find(id);
                if (prod != null)
                {
                    gameContext.Details.Remove(prod);
                    gameContext.SaveChanges();
                }

            }
        }


        //Platform
        public List<Platform> GetPlatforms()
        {
            using (gameContext = new GameContext())
            {
                return gameContext.Platforms.ToList();
            }
        }
        public void AddPlatform(Platform platform)
        {
            using (gameContext = new GameContext())
            {
                gameContext.Platforms.Add(platform);
                gameContext.SaveChanges();
            }
        }
        public Platform GetPlatform(int id)
        {
            using (gameContext = new GameContext())
            {
                return gameContext.Platforms.Find(id);

            }
        }
        public void UpdatePlat(Platform platform)
        {
            using (gameContext = new GameContext())
            {
                var prod = gameContext.Platforms.Find(platform.ID);
                if (prod != null)
                {
                    gameContext.Entry(prod).CurrentValues.SetValues(platform);
                    gameContext.SaveChanges();
                }

            }
        }
        public void DeletePlatform(int id)
        {
            using (gameContext = new GameContext())
            {
                var prod = gameContext.Platforms.Find(id);
                if (prod != null)
                {
                    gameContext.Platforms.Remove(prod);
                    gameContext.SaveChanges();
                }

            }
        }


        //Publisher
        public List<Publisher> GetPublishers()
        {
            using (gameContext = new GameContext())
            {
                return gameContext.Publishers.ToList();
            }
        }
        public void AddPublisher(Publisher publisher)
        {
            using (gameContext = new GameContext())
            {
                gameContext.Publishers.Add(publisher);
                gameContext.SaveChanges();
            }
        }
        public Publisher GetPublisher(int id)
        {
            using (gameContext = new GameContext())
            {
                return gameContext.Publishers.Find(id);

            }
        }
        public void UpdatePub(Publisher publisher)
        {
            using (gameContext = new GameContext())
            {
                var prod = gameContext.Publishers.Find(publisher.ID);
                if (prod != null)
                {
                    gameContext.Entry(prod).CurrentValues.SetValues(publisher);
                    gameContext.SaveChanges();
                }

            }
        }
        public void DeletePublisher(int id)
        {
            using (gameContext = new GameContext())
            {
                var prod = gameContext.Publishers.Find(id);
                if (prod != null)
                {
                    gameContext.Publishers.Remove(prod);
                    gameContext.SaveChanges();
                }

            }
        }
    }
}
