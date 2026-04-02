# 🤖 AiTech API Project

> ASP.NET Core 8.0 ile geliştirilmiş, Gemini AI entegrasyonlu API-first yaklaşımlı RESTful Web API projesi.
> A RESTful Web API project built with ASP.NET Core 8.0 using an API-first approach with Gemini AI integration.

[![.NET Core](https://img.shields.io/badge/.NET_Core-8.0-purple.svg)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![REST API](https://img.shields.io/badge/API-REST-green.svg)]()
[![Database](https://img.shields.io/badge/Database-SQL_Server-CC2927.svg)](https://www.microsoft.com/en-us/sql-server)

---

## 🚀 Özellikler / Features

| 🇹🇷 Türkçe | 🇬🇧 English |
|------------|------------|
| N Katmanlı Mimari (Business, DataAccess, API) | N-Tier Architecture (Business, DataAccess, API) |
| RESTful API — GET, POST, PUT, DELETE, PATCH | RESTful API — GET, POST, PUT, DELETE, PATCH |
| Entity Framework Core — Code First | Entity Framework Core — Code First |
| Unit of Work Pattern ile transaction yönetimi | Transaction management with Unit of Work Pattern |
| DTO & AutoMapper ile güvenli veri transferi | Secure data transfer with DTO & AutoMapper |
| Fluent Validation ile merkezi doğrulama | Centralized validation with Fluent Validation |
| Interceptor ile otomatik tarih ataması | Automatic date assignment via Interceptors |
| Rol tabanlı yetkilendirme & Area yapısı | Role-based authorization & Area structure |
| **Gemini AI** entegrasyonlu soru-cevap | **Gemini AI** powered Q&A functionality |
| API ve UI katmanları tamamen bağımsız | Fully decoupled API & UI layers |

---

## 🏗️ Mimari / Architecture

```
AiTechApiProject/
├── AiTech.BusinessLayer/
│   ├── Abstract/
│   └── Concrete/
│
├── AiTech.DataAccessLayer/
│   ├── Abstract/
│   ├── Concrete/
│   └── UnitOfWork/
│
├── AiTech.DtoLayer/
│   └── Dtos/
│
├── AiTech.EntityLayer/
│   └── Entities/
│
├── AiTech.WebApi/
│   ├── Controllers/
│   ├── Areas/
│   │   └── Admin/
│   └── appsettings.json
│
└── AiTech.WebUI/
    ├── Controllers/
    ├── Views/
    └── wwwroot/
```

---

## 🔄 API — UI İletişimi / API — UI Communication

UI katmanı, API'ye `HttpClient` üzerinden HTTP istekleri atar. Hiçbir entity doğrudan UI'ye taşınmaz; tüm veri alışverişi DTO'lar aracılığıyla gerçekleşir. Interceptor yapısı `CreatedDate` ve `UpdatedDate` alanlarını otomatik olarak yönetir.

The UI layer communicates with the API via `HttpClient`. No entity is exposed directly to the UI; all data exchange is handled through DTOs. The Interceptor structure automatically manages `CreatedDate` and `UpdatedDate` fields.

---

## 🤖 Gemini AI Entegrasyonu / Gemini AI Integration

Proje, **Google Gemini AI** entegrasyonu sayesinde yapay zeka destekli soru-cevap özelliği sunar. Kullanıcılar API üzerinden Gemini modeline sorgu gönderebilir ve anlık yanıt alabilir.

The project offers AI-powered Q&A functionality through **Google Gemini AI** integration. Users can send queries to the Gemini model via the API and receive instant responses.

---

## 🛠️ Kullanılan Teknolojiler / Tech Stack

| Katman / Layer | Teknoloji / Technology |
|----------------|------------------------|
| Backend API | ASP.NET Core 8.0 Web API |
| UI | ASP.NET Core MVC |
| ORM | Entity Framework Core (Code First) |
| Veritabanı / Database | SQL Server |
| Nesne Mapleme / Mapping | AutoMapper |
| Doğrulama / Validation | Fluent Validation |
| Yapay Zeka / AI | Google Gemini AI |
| Dil / Language | C# |

---

## ⚙️ Kurulum / Setup

### Gereksinimler / Requirements
- .NET 8 SDK
- SQL Server
- Visual Studio 2022+

### Adımlar / Steps

```bash
# Repoyu klonla / Clone the repo
git clone https://github.com/abdullahhaktan/AiTechApiProject.git
cd AiTechApiProject
```

**`appsettings.json` — Bağlantı dizesini güncelle / Update connection string:**

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=AiTechDb;Trusted_Connection=True;"
  }
}
```

```bash
# Package Manager Console üzerinden / Via Package Manager Console
add-migration InitialMigration
update-database
```

> Projeyi Visual Studio ile açıp **F5** ile başlatın.
> Open the project in Visual Studio and press **F5** to run.

---

## 👨‍💻 Geliştirici / Developer

**Abdullah Haktan**
GitHub → [abdullahhaktan](https://github.com/abdullahhaktan)
