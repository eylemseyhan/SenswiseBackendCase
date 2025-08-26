# Senswise Backend Developer Case – Eylem Seyhan

## 📌 Proje Özeti
Bu proje, Senswise için geliştirilen bir case çalışmasıdır.  
API, kullanıcı ekleme, güncelleme, silme ve listeleme işlemlerini sağlar.  
Kullanıcı bilgileri aşağıdaki alanları içerir:

- **Adı** (zorunlu)  
- **Soyadı** (zorunlu)  
- **E-posta** (zorunlu)  
- **Adres** (opsiyonel)  

Zorunlu alanlar için validation eklenmiştir.

---

## 🛠️ Kullanılan Teknolojiler

- **.NET 6 Web API** – API geliştirme  
- **CQRS** – Commands & Queries ile iş mantığı ayrımı  
- **Entity Framework Core** – Veri erişim katmanı  
- **PostgreSQL** – Veri tabanı  
- **Code-First Approach** – Veri tabanı oluşturma ve yapılandırma code üzerinden  
- **Swagger** – API dokümantasyonu  

---
## 🔑 API Endpoints

| Method | Endpoint         | Açıklama                     |
|--------|-----------------|------------------------------|
| GET    | /api/Users      | Tüm kullanıcıları listeler    |
| GET    | /api/Users/{id} | ID’ye göre kullanıcı getirir |
| POST   | /api/Users      | Yeni kullanıcı ekler         |
| PUT    | /api/Users      | Kullanıcıyı günceller       |
| DELETE | /api/Users/{id} | Kullanıcıyı siler           |
