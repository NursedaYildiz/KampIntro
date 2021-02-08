using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { 
                Id = 1, 
                BirthYear = 1996, 
                FirstName = "NURSEDA", 
                LastName = "YILDIZ", 
                IdentityNumber = 123456789 
            });

            Game game = new Game()
            {
                GameId = 2,
                GameName = "Rainbow Six Siege",
                GamePrice = 59
            };

            CampaignManager campaign = new CampaignManager();
            campaign.Add(new Campaign
            {
                CampaignId = 3,
                CampaignName = "Yılbaşı indirimi"
            });

            SalesManager sales = new SalesManager();
            sales.Buy(new Game
            {
                GameId = 2,
                GameName = "Rainbow Six Siege"
            }, new Gamer
            {
                FirstName = "Nurseda",
                LastName = "Yıldız"
            });
            
            }
    }
}
