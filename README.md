# KutuphaneYonetimSistemi

Bu proje, bir kütüphanedeki **kitapların**, **üyelerin** ve **ödünç verme işlemlerinin** dijital ortamda yönetilmesini amaçlayan,  
**C# WinForms + MySQL** kullanılarak geliştirilmiş **katmanlı mimariye sahip** bir masaüstü uygulamasıdır.

---

##  Projenin Amacı

- Kitap, üye ve ödünç işlemlerini merkezi bir sistemde yönetmek
- Rol bazlı yetkilendirme ile farklı kullanıcı tipleri oluşturmak
- Veritabanı tabanlı, sürdürülebilir ve genişletilebilir bir yapı kurmak
- Katmanlı mimariyi (MODEL – DAL – UI) uygulamalı olarak göstermek

---

##  📂 Kullanılan Teknolojiler

- **C# (.NET WinForms)**
- **MySQL**
- **MySql.Data**
- **N Katmanlı Mimari (Layered Architecture)**

---

## 📸 Ekran Görüntüleri

##  Giriş Sayfası

<img width="747" height="490" alt="image" src="https://github.com/user-attachments/assets/fe507bb2-9b36-4b0e-8951-436b29b37970" />


Giriş Sayfası, Kütüphane yönetim sistemi kullanıcılarının uygulamaya erişim sağlamasını ve yetkilerine göre doğru sayfaya yönlendirilmesini sağlar. Kullanıcı adı ve şifre bilgilerine göre, sistem ilgili kullanıcının bir üye mi yoksa Yönetici mi olduğunu kontrol eder ve bu doğrultuda uygun sayfayı açar.


## Üye Olma Sayfası 

<img width="745" height="487" alt="image" src="https://github.com/user-attachments/assets/bf5d00cb-6e33-43c8-933c-8d2be1cc5928" />

Üye Olma Sayfası, Kütüphane Sisteminde henüz eklenmemiş bir üye giriş yapmak isterse kendi kendine kayıt yaptığı sayfadır.

## Ana Menü 

<img width="748" height="488" alt="image" src="https://github.com/user-attachments/assets/720b472f-7cd0-46c1-a051-37678806c055" />

Ana Menü, Kütüphane yönetim sistemi kullanıcılarının tüm sistem özelliklerine erişebileceği merkezi bir kontrol panelidir. Kullanıcılar yetkileri doğrultusunda çeşitli işlemleri bu ekran üzerinden gerçekleştirebilir. Personel ve Yönetici rolleri için uygun erişim izinleri sağlanmıştır.

## Kitap Ekleme Sayfası

<img width="747" height="490" alt="image" src="https://github.com/user-attachments/assets/b0a0559a-b461-463d-90ba-f2a4cb9912fd" />

Kitap Ekleme Sayfası, yönetici sisteme giriş yaptığında kitap listesine yeni kitap eklemek isterse bu sayfayı kullanır.

## Kitap Listeleme Sayfası

<img width="746" height="488" alt="image" src="https://github.com/user-attachments/assets/19bb005c-ee48-4c25-ad00-4152ccb045f6" />

Kitap Listeleme Sayfası, yönetici veya üye giriş yağtığında sistemde aktif olan kitapların listesini görebildikleri sayfadır. 

## Üye Ekleme Sayfası 

<img width="743" height="488" alt="image" src="https://github.com/user-attachments/assets/9d8782a1-5165-4732-b50e-ee9b0f4310fc" />

Üye Ekleme Sayfası, yönetici sistemine yeni bir üye eklemek isterse bu sayfayı kullanır.

## Ödünç İşlemleri Sayfası

<img width="743" height="487" alt="image" src="https://github.com/user-attachments/assets/85b8e450-7add-41e4-b58c-14c084536a17" />

Ödünç İşlemleri Sayfası, yönetici kütüphane sisteminden herhangi bir kitabı üyeye ödünç verme işlemini bu sayfadan gerçekleştirmektedir.

## Raporlar Sayfası 

<img width="747" height="493" alt="image" src="https://github.com/user-attachments/assets/64f3f60b-cfb4-4940-8d83-e3201eae1f4b" />

Raporlar sayfasında 3 adet buton bulunmaktadır. GÖrselde de görüldüğü üzere ilk butonumuz en çok ödünç alınan kitapları gösterir. İkinci butonumuz ise ödünç verilme tarihi geçen kitapları gösteren geciken kitaplar butonudur. Üçüncü butonumuz ise aktif olarak ödünç verilmiş olan kitapları gösteren aktif ödünçler butonudur.

---

## 🚀 Kullanım
Projeyi indirin.
Visual Studio kullanarak projeyi açın.
Gerekli MySQL bağlantı ayarlarını DatabaseHelper.cs dosyasından yapılandırın.
Uygulamayı çalıştırın ve giriş ekranından kullanıcı bilgilerinizi girerek başlayın.

---

## 🛠️ Proje Yapısı
DAL (Data Access Layer): Veritabanı işlemleri.
MODEL (Business Logic Layer): İş mantığı.
UI (User Interface): Windows Forms kullanıcı arayüzü.
MySQL: Veritabanı bağlantı ve sorguları.

---

## 📞 İletişim
Herhangi bir sorunuz veya öneriniz varsa lütfen benimle iletişime geçin:

Ad: Sude Nur 
soyad:Altun
E-posta: sudenuraltun555955@gmail.com
















