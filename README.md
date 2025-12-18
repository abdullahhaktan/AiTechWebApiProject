# 🚀 AiTech API Project

[TR]

**ASP.NET Core 8.0 ile Geliştirilmiş API-First Yaklaşımlı Yapay Zeka Entegreli Web API Projesi**

[![.NET Core](https://img.shields.io/badge/.NET_Core-8.0-purple.svg)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![REST API](https://img.shields.io/badge/API-REST-green.svg)]()

---

## 💻 Proje Hakkında

AiTech API Project, modern yazılım geliştirme standartlarına uygun olarak **API-first yaklaşımı** ile geliştirilmiş bir **RESTful Web API** projesidir.  

UI katmanı API’den tamamen bağımsız ayrı bir **client uygulama** olarak tasarlanmıştır ve tüm veri alışverişi HTTP istekleri üzerinden sağlanmaktadır.

Proje; **temiz kod prensipleri**, **katmanlı mimari** ve **kurumsal yazılım desenleri** dikkate alınarak oluşturulmuştur.

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

* API ve UI katmanları tamamen **ayrık** yapıdadır.
* **DTO & AutoMapper** ile güvenli ve kontrollü veri transferi.
* **Fluent Validation** ile merkezi veri doğrulama ve iş kuralları yönetimi.
* **Dependency Injection** ile gevşek bağlı mimari.
* **Interceptor** yapısı ile `CreatedDate` ve `UpdatedDate` alanlarına otomatik atama.
* **Rol bazlı yetkilendirme** (Admin rolü).
* Admin işlemleri **Area** yapısı ile ayrıştırılmıştır.
* UI tarafında **responsive** tasarım.
* **Gemini AI entegrasyonu** ile yapay zeka destekli soru-cevap özelliği.

---

# Nasıl Çalıştırılır

# Depoyu Klonlayın ve Klasöre Girin

* git clone https://github.com/username/AiTechApiProject.git
* cd AiTechApiProject

# appsettings.json dosyasında ConnectionString bilgisini kendinize göre ayarlayın,
# ardından migrasyonları ekleyip veritabanını güncelleyin

* add-migration InitialMigration
* update-database
* projeyi çalıştırabilirsiniz

---

---
---

[EN]

## 💻 About the Project

AiTech API Project is a **RESTful Web API** developed with an **API-first approach**, following modern software development standards.

The UI layer is designed as a completely **independent client application**, and all data communication is handled via HTTP requests.

The project is built based on **clean code principles**, **layered architecture**, and **enterprise design patterns**.

---

## ✨ Core Features

### Architecture and Technologies

* Developed using **ASP.NET Core 8.0 Web API** architecture and **C#** language.
* **N-Tier Architecture** (Business, Data Access, API).
* Fully **RESTful API** compliant structure.
* HTTP methods: **GET, POST, PUT, DELETE, PATCH**
* **Entity Framework Core – Code First** approach.
* **Unit of Work Pattern** for transaction management.

### Functional Features and Design

* Fully decoupled **API–UI architecture**.
* Secure and controlled data transfer with **DTO & AutoMapper**.
* Centralized validation and business rules with **Fluent Validation**.
* **Dependency Injection** for loose coupling.
* **Interceptors** for automatic `CreatedDate` and `UpdatedDate` assignment.
* **Role-based authorization** (Admin role).
* Admin operations separated using **Area** structure.
* **Responsive UI** design.
* **Gemini AI integration** for AI-powered Q&A functionality.

# how to run

# Clone the Repository and Navigate to the Folder

* git clone https://github.com/username/AiTechApiProject.git
* cd AiTechApiProject

# Update the ConnectionString in appsettings.json according to your environment,
# then add migrations and update the database

* add-migration InitialMigration
* update-database
* then you will be able to start the project

---
