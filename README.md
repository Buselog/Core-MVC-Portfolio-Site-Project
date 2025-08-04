# 🚀 Asp .Net Core MVC ile Admin Panelli Portföy Sitesi Projesi

Bu proje, ASP.NET Core MVC ve Code First yöntemi kullanılarak geliştirilmiş admin panelli dinamik bir kişisel portföy sitesidir. Site içerisinde kişisel bilgilerim, indirilebilir özgeçmişim, referanslarım, yayınladığım projeler ve deneyimler kısmı mevcuttur. Kullanıcıların istek ve önerilerini iletebilecekleri; mesajların admin paneli ve veritabanına başarıyla kaydedildiği dinamik bir contact alanı kullanıcıları karşılamaktadır. 
Portföy sitesi verilerinin yönetimi için kullanıcı dostu bir admin paneli de projede yer almaktadır.

-----

## ☄️ Projenin Sahip Olduğu Kazanımlar

###### 🌟 ASP.NET Core MVC

    - ViewComponent kullanımı ve responsive tasarım prensipleriyle geliştirilen, 
      modern ve ölçeklenebilir bir proje geliştirimi.
    
###### 🌟 Entity Framework Core ile Veritabanı İşlemleri( SQL Server - Code First Yaklaşım)

    - PortfolioContext sınıfı üzerinden veritabanı işlemleri gerçekleştirilmiştir. 
    - Admin girişleri, profil verileri ve güncellemeler Entity Framework Core ile yönetilmiştir.
    
###### 🌟 Authentication & Authorization 

    -  Cookie Authentication kullanılarak kimlik doğrulama yapılmıştır.
    - [Authorize] attribute'u ile Admin yetkilendirmesi sağlanmıştır.

###### 🌟 Session & Cookie Yönetimi 

    - Admin oturumu ve tercihlerini saklama

###### 🌟 FluentValidation ile Form Doğrulama

    - FluentValidation kütüphanesi ile kullanıcı girişlerinde form verilerinin doğruluğu kontrol edilmiştir.
    - Kullanıcıdan alınan verilerin belirlenen kurallara uygunluğu sağlanarak hata riskleri azaltılmıştır.

###### 🌟 Dosya Yükleme (Resim Upload) İşlemleri

    - Admin profil resminin yüklenmesi için sunucu tarafında dosya yükleme işlemi gerçekleştirilmiştir.
    - Kullanıcının seçtiği resim dosyası sunucunun wwwroot/images klasörüne kaydedilmiş ve veritabanında yolu tutulmuştur.
    
###### 🌟 Şifre Güncelleme İşlemi

    - Kullanıcı mevcut şifresini doğrulayarak yeni şifre belirleyebilmektedir.
    - Şifre değişimi sırasında hata kontrolleri yapılmış (örneğin, mevcut şifrenin doğru girilmesi ve yeni şifrelerin eşleşmesi).

###### 🌟 Bootstrap Kullanımı

    - Responsive (duyarlı) tasarım ve görsel bileşenler için kullanılmıştır.

----- 


## ☄️ Projeye Genel Bakış

### Buselog Portfolio Site

###### 🏠 Home Page

<img src="https://github.com/user-attachments/assets/d3f52eca-e2f7-476a-bafc-6b050e7b35e7" width:600>

###### 🪪 About Section

<img src="https://github.com/user-attachments/assets/4a77e8f3-ca96-43bc-81cc-72211bea44e4" width:600>

###### 🔎 Experience Section

<img src="https://github.com/user-attachments/assets/745447c6-72ba-4f77-9fd3-b9effd26272c" width:600>

###### 📋 Project Section

<img src="https://github.com/user-attachments/assets/03ab2fee-5036-4dba-a465-3b348f05ccf5" width:600>

###### 👤 Testimonial Section

<img src="https://github.com/user-attachments/assets/a108b29e-2387-476c-be70-8f79cd28aa31" width:600>

###### 📈 Statistic Section

<img src="https://github.com/user-attachments/assets/fde7dc43-738c-419d-9921-8214c021efc6" width:600>

###### ✉️ Contact Section

<img src="https://github.com/user-attachments/assets/63da32ad-7b7f-4902-8fad-25ab96452e34" width:600>

###### 🔌 Footer Section

<img src="https://github.com/user-attachments/assets/436b23c4-5a4b-4183-9163-a159d603010d" width:600>


-----

### Admin Panel Section

###### 🏠 Login Page

<img src="https://github.com/user-attachments/assets/fb5111c1-d6cc-4bf1-90ed-55053870fd2a" width:600>

###### 🏠 Login Page (With Validation)

<img src="https://github.com/user-attachments/assets/4134fd1a-cbdb-4d24-b642-f6aa2bf30bbf" width:600>

###### 🔎 Admin Profile Page

<img src="https://github.com/user-attachments/assets/0afbeccc-eda5-4a9b-a198-6e7d680eb3f9" width:600>

###### 🪪 Password Change Page

<img src="https://github.com/user-attachments/assets/4d47ff5e-c2ec-44f6-96f6-a7d919a59234" width:600>

###### 📈 Dashboard Page

<img src="https://github.com/user-attachments/assets/7f5b6788-67f4-4e83-8090-0a939f125ca2" width:600>

###### ➡️ Feature Page

<img src="https://github.com/user-attachments/assets/e338e11f-945c-4ec1-9958-e5c18ca3acae" width:600>

###### 🪪 About Page

<img src="https://github.com/user-attachments/assets/c1af8444-8d59-4443-9da1-4258f651ee47" width:600>

###### 📋 Skill Page

<img src="https://github.com/user-attachments/assets/38e78b4d-0336-4812-a4a6-015eff3b844f" width:600>

###### 🔌 Experience Page

<img src="https://github.com/user-attachments/assets/aba6fe62-d4a0-4823-a676-ca4a59c3b26a" width:600>

###### 🔌 Experience (With Fluent Validation)

<img src="https://github.com/user-attachments/assets/ed26fa14-21d2-4dc0-9a37-d5bd0a195974" width:600>

###### 📋 Project Page

<img src="https://github.com/user-attachments/assets/613a79e6-0bc0-4998-88d1-afa8c8574b1f" width:600>

###### 📋 Project Page (With Fluent Validation)

<img src="https://github.com/user-attachments/assets/31b7e4f3-2c14-4f56-94b0-25f5a999fabc" width:600>

###### 👤 Testimonial Page

<img src="https://github.com/user-attachments/assets/1da8bdc1-94bc-4920-86f8-4e9e74b7670a" width:600>

###### 👤 Testimonial Page (With Fluent Validation)

<img src="https://github.com/user-attachments/assets/854ef88d-c915-47d4-98a3-9ccdb9fa60bf" width:600>

###### ✉️ Messages Page

<img src="https://github.com/user-attachments/assets/471ce660-7732-440b-b8a1-cf6376b0c236" width:600>




