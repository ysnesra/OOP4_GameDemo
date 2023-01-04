using OOP4_GameDemo.Adapters;
using OOP4_GameDemo.Concrete;
using OOP4_GameDemo.Entities;
using System;
// Bir Oyun Projesi
//Yeni üye, satış ve kampanya yönetimi yapılacak
//**Person-Sale-Campaign

//Gereksinimler
//1.Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz. Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. Bunu yapacak servisi simule etmeniz yeterlidir.)

//2.Oyun satışı yapılabilecek satış ortamını simule ediniz.( Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olmasını kastediyorum.)

//3.Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

//4.Satışlarda kampanya entegrasyonunu simule ediniz.
namespace OOP4_GameDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Oyuncu ekleme Simülasyonu:  *******");

            PersonManager personManager = new PersonManager(new MernisServiceAdapter());         
            Person person = new Person
            {
                Id = 1,
                NationalityId = "22448259376",
                FirstName = "Esra",
                LastName = "Yaşın",
                DateOfBirth = new DateTime(1990, 6, 7)
            };
            personManager.Add(person);  
            personManager.Update(person);
            personManager.Delete(person);


            Console.WriteLine("******Oyun ekleme Simülasyonu:  *******");

            GameManager gameManager = new GameManager();
            Game game=new Game { Id = 1, GameName = "Chess Uygulaması", GameDescription = "Satranç turnuvaları ile kendinizi geliştirin", GamePrice = 100 };
            gameManager.Add(game); 
            gameManager.Update(game);
            gameManager.Delete(game);


            Console.WriteLine("******Kampanya ekleme Simülasyonu:  *******");

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign 
            {
                Id=1, 
                CampaignName="Sevgililer Günü Kampanyası",
                CampaignStartDate=new DateTime(2023,2,14),
                CampaignEndDate=new DateTime(2023,3,14),    
                DiscountRate= 30
            };
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);


            Console.WriteLine("******Oyun Satışı ekleme Simülasyonu:  *******");

            GameSaleManager gameSaleManager = new GameSaleManager();
            GameSale gameSale = new GameSale();
            gameSale.Id = 2;
            gameSale.Person = person;
            gameSale.Game = game;
            gameSale.Campaign = campaign;
            gameSale.SalePrice = game.GamePrice;

            gameSaleManager.Add(gameSale);
            gameSaleManager.Update(gameSale);
            gameSaleManager.Delete(gameSale);

        }
    }
}
