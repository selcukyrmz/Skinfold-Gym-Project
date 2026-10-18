# Skinfold-Gym-Project
C# ile geliştirilmiş, sporcuların Skinfold (kaliper) ölçüm verilerini işleyerek Jackson-Pollock formülleriyle vücut yağ oranı ve gelişim takibini yapan otomasyon projesi. Akademik dönem içi algoritma mantığını ve nesne yönelimli programlama (OOP) prensiplerini pekiştirir.



# Skinfold Gym Project

Hocanın verdiği dönem ödevi için hazırladığım C# Windows Forms otomasyon projesidir. Proje temel olarak spor salonundaki üyelerin kaliper (deri kıvrımı) ölçümlerini alarak vücut yağ oranlarını, yağ kütlelerini ve kas kütlelerini bilimsel formüllerle hesaplıyor, ardından bunları bir MySQL veritabanında saklıyor.

## Proje Neler Yapıyor?

* **Giriş Ekranı:** Program ilk açıldığında tam ekran (Maximized) ve çerçevesiz (None) bir login ekranıyla başlıyor.
* **Üye Kayıt ve CRUD İşlemleri:** Sisteme yeni üye eklenebiliyor, mevcut üyelerin bilgileri güncellenebiliyor ya da silinebiliyor.
* **Akıllı Hesaplama Modülü (BLL):** Kullanıcıdan alınan verilere göre arka planda şu hesaplamaları otomatik yapıyor:
  * Seçilen protokole göre (Erkekler için JP3E, Kadınlar için JP3K) Jackson-Pollock formülünü kullanarak yağ yüzdesi hesaplama.
  * Toplam vücut ağırlığı üzerinden yağsız kas kütlesi (kg) ve yağ kütlesi (kg) bulma.
  * Çıkan yağ yüzdesine göre üyeyi "Atlet", "Fit", "Sporcu", "Kilolu" veya "Obez" olarak sınıflara ayırma.
* **Filtreleme ve Arama:** TextBox'a isim yazıldıkça anlık harf eşleştirerek (LIKE sorgusuyla) üye aranabiliyor. Ayrıca RadioButton'lar ile sadece Erkek veya sadece Kadın üyeler listelenebiliyor.
* **Anlık İstatistik:** Ana form yüklendiğinde veritabanına bağlanıp toplam üye sayısını, erkek ve kadın üye sayılarını COUNT(*) ile çekip ekranda gösteriyor.
* **Validasyon (Hata Yönetimi):** Yaşın 1 ile 75 arasında olması, sayısal alanlara harf girilmemesi veya ad-soyad kısımlarının boş bırakılmaması için try-catch ve if kontrolleri içeriyor.

## Teknik Detaylar ve Kod Yapısı

* **Dil ve Platform:** C# / .NET Windows Forms
* **Veri Tabanı:** MySQL (selcuksql isimli local veritabanı ve VucutOlcumleri tablosu).
* **Mimari:** Kodların çorba olmaması için katmanlı yapıya benzer şekilde arayüz formları ile iş mantığını (GymBLL sınıfını) ayrı tuttup işlemleri oradan yürüttüm.
* **Veri Tabanı Güvenliği:** Bağlantıların açık kalıp şişmemesi veya çökme anında sızıntı yapmaması için kritik sql sorgularını `using` blokları içerisine aldım. `MySqlDataReader` kullanırken de `CommandBehavior.CloseConnection` ile işi biten bağlantıyı otomatik kapattım.

## Kurulum ve Çalıştırma

1. Bilgisayarınızda XAMPP, WampServer veya benzeri bir yerel MySQL sunucusunun açık olduğundan emin olun.
2. Klasör içerisindeki sql script dosyasını kullanarak `selcuksql` veritabanını ve `VucutOlcumleri` tablosunu localinizde oluşturun.
3. Projeyi Visual Studio ile açıp `DbBaglanti.cs` dosyasındaki server, port, uid ve pwd bilgilerini kendi local veritabanı ayarlarınıza göre düzenleyin.
4. F5 tuşuna basarak projeyi derleyip çalıştırabilirsiniz.
