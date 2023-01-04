// Bir Oyun Projesi

/*Yeni üye, satış ve kampanya yönetimi yapılacak

//Gereksinimler
1.Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz. Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. Bunu yapacak servisi simule etmeniz yeterlidir.)

2.Oyun satışı yapılabilecek satış ortamını simule ediniz.( Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olmasını kastediyorum.)

3.Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

4.Satışlarda kampanya entegrasyonunu simule ediniz.*/


/*
 
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
 */




/*NOT:
Sisteme yeni kampanya eklenecek, güncellencek, silinecek
Oyuncu içinde ekleme, güncelleme , silme yapmıştık
Campaign ve Person için ortak operasyonlar olduğu için AbstactClass oluşturayım dedim 
ama türleri farklı farklı tabloya ekleneceğinden vazgeçtim
*/