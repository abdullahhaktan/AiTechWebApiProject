# 🚀 AiTech API Project

[TR]
**ASP.NET Core 8.0 ile Geliştirilmiş API-First Yaklaşımlı Yapay Zeka Entegreli Web API Projesi**

[![.NET Core](https://img.shields.io/badge/.NET_Core-8.0-purple.svg)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![REST API](https://img.shields.io/badge/API-REST-green.svg)]()
[![Database](https://img.shields.io/badge/Database-SQL_Server-CC2927.svg)](https://www.microsoft.com/en-us/sql-server)

---

## 💻 Proje Hakkında
AiTech API Project, modern yazılım geliştirme standartlarına uygun olarak **API-first yaklaşımı** ile geliştirilmiş bir **RESTful Web API** projesidir.  

UI katmanı API’den tamamen bağımsız ayrı bir **client uygulama** olarak tasarlanmıştır ve tüm veri alışverişi HTTP istekleri üzerinden sağlanmaktadır. Proje; **temiz kod prensipleri**, **katmanlı mimari** ve **kurumsal yazılım desenleri** dikkate alınarak oluşturulmuştur.

---

## ✨ Temel Özellikler

### Mimari ve Teknolojiler
* **ASP.NET Core 8.0 Web API** mimarisi ve **C#** dili kullanılarak geliştirilmiştir.
* **N Katmanlı Mimari** uygulanmıştır (Business, Data Access, API).
* **RESTful API** standartlarına uygun yapı.
* HTTP metodları: **GET, POST, PUT, DELETE, PATCH**
* **Entity Framework Core – Code First** yaklaşımı kullanılmıştır.
* **Unit of Work Pattern** ile transaction yönetimi sağlanmıştır.

### İşlevsel Özellikler ve Tasarım
* **Bağımsız Katmanlar:** API ve UI katmanları tamamen ayrık yapıdadır.
* **Veri Yönetimi:** **DTO & AutoMapper** ile güvenli veri transferi, **Fluent Validation** ile merkezi doğrulama.
* **Gevşek Bağlılık:** **Dependency Injection** kullanımı.
* **Otomasyon:** **Interceptor** yapısı ile `CreatedDate` ve `UpdatedDate` alanlarına otomatik atama.
* **Güvenlik:** Rol bazlı yetkilendirme (Admin) ve **Area** yapısı ile ayrıştırılmış admin işlemleri.
* **Yapay Zeka:** **Gemini AI entegrasyonu** ile yapay zeka destekli soru-cevap özelliği.

---

## 🚀 Nasıl Çalıştırılır?

1.  **Projeyi Klonlama:**
    ```bash
    git clone [https://github.com/username/AiTechApiProject.git](https://github.com/username/AiTechApiProject.git)
    cd AiTechApiProject
    ```
2.  **Bağlantı Dizesi Ayarı:**
    * `appsettings.json` içindeki SQL Server bağlantı dizesini kendi ortamınıza göre güncelleyin.
3.  **Veritabanı Kurulumu:**
    * **Package Manager Console** üzerinden aşağıdaki komutları çalıştırın:
    ```bash
    add-migration InitialMigration
    update-database
    ```
4.  **Projeyi Başlatma:**
    * Visual Studio ile `.sln` dosyasını açın ve **F5** ile çalıştırın.

---

[EN]

# 🚀 AiTech API Project
**API-First AI-Integrated Web API Project Developed with ASP.NET Core 8.0**

---

## 💻 About the Project
AiTech API Project is a **RESTful Web API** developed with an **API-first approach**, following modern software development standards.

The UI layer is designed as a completely **independent client application**, and all data communication is handled via HTTP requests. The project is built based on **clean code principles**, **layered architecture**, and **enterprise design patterns**.

---

## ✨ Core Features

### Architecture and Technologies
* Developed using **ASP.NET Core 8.0 Web API** and **C#**.
* **N-Tier Architecture** (Business, Data Access, API).
* Fully **RESTful API** compliant structure.
* **Entity Framework Core – Code First** approach.
* **Unit of Work Pattern** for transaction management.

### Functional Features and Design
* Fully decoupled **API–UI architecture**.
* Secure and controlled data transfer with **DTO & AutoMapper**.
* Centralized validation and business rules with **Fluent Validation**.
* **Dependency Injection** for loose coupling.
* **Interceptors** for automatic `CreatedDate` and `UpdatedDate` assignment.
* **Role-based authorization** (Admin role).
* **Gemini AI integration** for AI-powered Q&A functionality.

---

## 🚀 How to Run

1.  **Clone the Project:**
    ```bash
    git clone [https://github.com/username/AiTechApiProject.git](https://github.com/username/AiTechApiProject.git)
    cd AiTechApiProject
    ```
2.  **Configure Connection String:**
    * Update the connection string in `appsettings.json` to match your local SQL Server.
3.  **Database Migration:**
    * Run the following commands in **Package Manager Console**:
    ```bash
    add-migration InitialMigration
    update-database
    ```
4.  **Start the Project:**
    * Open the `.sln` file in Visual Studio and press **F5**.
