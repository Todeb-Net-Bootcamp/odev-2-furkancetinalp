# Ödev Tanımı:
#### 1) Bir console uygulaması oluştur.
#### 2) Bir tane metod override et.
#### 3) En az 1 tane Encapsulation kullan.
#### 4) Klasörlemeyi yap.
#### (Proje konusu seçimi serbest olarak belirlendi)

### "BookLibrary" Projesi
#### Proje içinde 'Book' adlı bir abstract class vardır ve içinde
 1) _isbnNumber;
 2) _name;
 3) _author;
 4) _publishDate;
 
#### değişkenleri private olarak saklanmıştır. Bu değişkenler enkapsüle edilerek ve belirli şartlar eklenerek kullanıcıya açılmıştır.
 
#### Bu sınıfta bir adet 'GiveBookDetails' adında bir override edilmesi gereken metod bulunmaktadır. Bu sınıfı kalıtım alan diğer sınıflar kendi değişkenlerine göre bu metodu düzenleyerek kitap bilgileri sunulmuştur.

#### Bu sınıftan kalıtım alan 3 adet kitap türü sınıfı mevcuttur: Novel(Roman), Story(Hikaye) ve PersonalGrowth(Kişisel Gelişim) 

#### Her bir sınıfa başlangıçta 2 kitap ve bilgilerinin eklenmesi için EF kullanılmış ve otomatik olarak eklenmiştir. 

#### Program.cs adlı sınıfta ise yapılan bu eylemlerin somutlaştırılması için her bir sınıf kullanılarak kendilerine özel oluşturulan tablolara kendi türünden kitaplar eklenmiş ve konsol'a yazdırılmıştır.

#### Projenin açıklamaları İngilizce olarak kodların içinde detaylı yazılmıştır.

### Abstract Class
![bookpicture](https://user-images.githubusercontent.com/99509540/177858853-7f0f3e6a-961f-4b3b-b0f9-e59777a9f80b.png)

### All Data in the Tables at the Beginning
![beforeAddingInputs](https://user-images.githubusercontent.com/99509540/177858944-81df7430-84fc-40fe-835c-606695b614b3.png)

### After Adding Data In Tables via Classes 
![afterAddingInputs](https://user-images.githubusercontent.com/99509540/177859013-a5443445-7d6d-4bde-b078-348964b180b1.png)
