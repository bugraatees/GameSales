using GameSales;
using GameSales.Concrete;
using GameSales.Entities;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            {
                gamer1.Id = 1;
                gamer1.FirstName = "Buğra";
                gamer1.LastName = "Ateş";
                gamer1.YearOfBirth = "1997";

            }

            Gamer gamer2 = new Gamer();
            {
                gamer2.Id = 2;
                gamer2.FirstName = "Ali";
                gamer2.LastName = "Kemal";
                gamer2.YearOfBirth = "1999";
            }

            Gamer gamer3 = new Gamer();
            {
                gamer3.Id = 3;
                gamer3.FirstName = "Veli";
                gamer3.LastName = "Yılmaz";
                gamer3.YearOfBirth = "1982";
            }

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Add(gamer3);

            Console.WriteLine("--------------");


            Game game1 = new Game();
            {
                game1.Id = 1;
                game1.GameName = "FM";
                game1.UnitPrice = 150;
                game1.UnıtInStock = 20;
            }

            Game game2 = new Game();
            {
                game2.Id = 2;
                game2.GameName = "CS";
                game2.UnitPrice = 130;
                game2.UnıtInStock = 10;
            }

            Game game3 = new Game();
            {
                game3.Id = 3;
                game3.GameName = "LOL";
                game3.UnitPrice = 200;
                game3.UnıtInStock = 4;
            }

            Console.WriteLine("{0} the game is on sale..", game1.GameName);
            Console.WriteLine("{0} the game is on sale..", game2.GameName);
            Console.WriteLine("{0} the game is on sale..", game3.GameName);

            Console.WriteLine("--------------");

            Campaign campaign1 = new Campaign();
            {
                campaign1.CampaignName = "Işıldayan Kampanya";
                campaign1.CampaignRate = 0.10m;
            }
            Campaign campaign2 = new Campaign();
            {
                campaign2.CampaignName = "Bahar Kampanyası";
                campaign2.CampaignRate = 0.30m;
            }
            GameCampaignManager gameCampaignManager = new GameCampaignManager();
            gameCampaignManager.Add(campaign1);
            gameCampaignManager.Add(campaign2);

            Console.WriteLine("--------------");

            Console.WriteLine("{0} games {1} done game price = {2}TL Discounted price = {3}TL" , game1.GameName, 
                campaign1.CampaignName, game1.UnitPrice, CampaignTool.CampaignApp(campaign1,game1));

            Console.WriteLine("{0} games {1} done game price = {2}TL Discounted price = {3}TL", game2.GameName,
                campaign2.CampaignName, game2.UnitPrice, CampaignTool.CampaignApp(campaign1, game1));

            Console.WriteLine("--------------");

            GameManager gameManager = new GameManager();
            gameManager.Sell(game1, gamer1);
            gameManager.Sell(game3, gamer2);
            gameManager.Sell(game2, gamer3);

            Console.ReadLine();
        }
    }
 }
