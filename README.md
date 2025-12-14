# AiTech API Projesi 🚀

M&Y Yazılım Eğitim Akademi’de Full-Stack .NET eğitimi kapsamında geliştirdiğim  
**5. proje olan AiTech API Projesi**’ni paylaşmak isterim.

Bu proje **API-first yaklaşımı** ile geliştirilmiştir.  
**UI katmanı ayrı bir proje** olarak konumlandırılmış olup, tüm veri alışverişi **RESTful API** üzerinden sağlanmaktadır.

---

## ⚙️ Teknik Mimari

Proje, temiz kod prensipleri ve modern kurumsal mimari ile oluşturuldu:

### 🔹 N Katmanlı Mimari
- Business Layer  
- Data Access Layer  
- API Layer  
Katmanlar birbirinden bağımsızdır.

### 🔹 .NET Core 8.0 – RESTful API
- Veri akışı HTTP metodları üzerinden sağlandı:
  - GET
  - POST
  - PUT
  - DELETE
  - PATCH

### 🔹 EF Core – Code First
- Veritabanı EF Core ile tasarlandı  
- Identity sistemi entegre edildi

### 🔹 DTO & AutoMapper
- Katmanlar arası düzenli ve güvenli veri transferi sağlandı

### 🔹 Dependency Injection
- Servisler `Program.cs` üzerinden yönetilebilir şekilde yapılandırıldı

---

## 🛡️ Güvenlik ve Modülerlik

- **Rol Yönetimi:** Admin rolü oluşturuldu  
- **Yetkilendirme:** API endpoint’lerinde rol bazlı erişim kontrolü uygulandı  
- **API – UI Ayrımı:**  
  UI, API’ye bağımlı olmadan HTTP istekleri ile veri tüketmektedir  
- **Responsive Tema:**  
  UI tarafında tüm cihazlara uyumlu yapı sağlandı  

---

## 🧠 Yapay Zeka Entegrasyonu

### 🤖 Gemini AI Entegrasyonu
- UI üzerindeki sağ üst buton aracılığıyla  
  Gemini servisine soru sorulabilmektedir

---

## 🔗 GitHub Repo
👉 https://github.com/abdullahhaktan/AiTechWebApiProject

---

# Tags
`#dotnet` `#net8` `#aspnetcore` `#webapi` `#restapi` `#csharp`  
`#software` `#architecture` `#nlayer` `#ai` `#gemini` `#cleanarchitecture`
