# OOP4_GameDemo
Oyun Projesi Simulasyonu_ConsoleProjesi   Oyuncu,Oyun,OyunSatışı,Kampanya yönetimi yapıldı

1) Person-Game-GameSale-Campaign classları oluşturdum

2) Abstract klasörüne Interfaceleri oluşturdum
   IEntity 
   IPersonService => oyuncular veritabanına kaydedilmek isteniyor. CRUD işlemlerinin imzalarını oluşturdum
   IPersonCheckService => oyuncunun bilglerini doğrulama metotunu(CheckIfRealPerson) imza olarak oluşturdum

3) Concrete klasörüne operasyon işlemlerini yapacağım Manager classlarımı oluşturdum
   Manager classlarına Interfacelerei implement ettim
   
4) Mernis doğrulaması kontrolü için
   IPersonCheckService interfaceni => PersonManager a Dependency Injection yöntemiyle implemente ettim 
  (PersonManager'ı zaten IPersonService'dende implemente etmiştim)

5) Oyuncu eklenirken PersonManager da Add() işleminde kontrol yaptım
   CheckIfRealPerson() metoduyla kontrol ettim. Ama önce Service referansını ekledim

6) Mernis doğrulaması için Service ekleme;
   "https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx" adresini yapıştırıp ekleriz

7)Adapter klasörüne MernisServiceAdapter classı ekleyip CheckIfRealPerson() metodunun içini doldururuz

8) PersonManager ın Add() metotuna şartımızı ekledim

9) GameSaleManager da 
   ApplyDiscount metotu oluşturdum => İndirim uygula metotu____oyuna uygulanan kampanya hesaplanır
   Add() metotuna şartımızı ekledim.Kampanya varsa indirimli satış, yoksa indirimsiz satış yaptırıdm
   Yapılan satışları Console a yazdırırken oyuncu ile ilişkilendirerek yazdırdım.

10) Program.cs de çağırarak uygulamayı simüle ettim
