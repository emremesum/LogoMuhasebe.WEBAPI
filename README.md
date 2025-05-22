# Logo Muhasebe RestAPI Entegrasyon Task

## 🧾 Logo Muhasebe Web API Entegrasyonu - Clean Architecture (Mini Proje)

Bu proje, Clean Architecture (Temiz Mimari) prensiplerine uygun şekilde yapılandırılmış basit bir **.NET Core Web API** örneğidir. Amaç, Logo muhasebe uygulamasına fatura gönderimi gibi işlemleri REST API üzerinden gerçekleştirmektir.

---

## 📌 Proje Özeti

- Fatura oluşturmak için bir Web API sunar.
- Domain-driven (iş kurallarını merkeze alan) mimari kullanılmıştır.
- Logo'ya fatura gönderimi mock (örnek) şekilde modellenmiştir.
- Kodlar `SOLID`, `Separation of Concerns` ve `Dependency Inversion` ilkelerine uygundur.

---

## 🧱 Katman Yapısı

Proje Clean Architecture modeline uygun şekilde 4 ana katmana ayrılmıştır:

| Katman | Açıklama |
|--------|----------|
| **Domain** | İş modelleri ve kuralları (`Invoice`, `InvoiceItem`, interface’ler) |
| **Application** | Use Case’ler, DTO’lar, servis ve akış yönetimi |
| **Infrastructure** | Veri erişimi ve dış sistem bağlantıları (Logo API) |
| **WebAPI** | HTTP endpoint’leri (Controllers) |

---

## 🚀 Kullanılan Teknolojiler

- .NET 7 / .NET 8
- InMemory Repository (mock DB)
- Clean Architecture
- RESTful API
- Logo API Entegrasyonu (mock)



```
 ⚙️ Dosya Yapısı
src/
├── Domain/
├── Application/
├── Infrastructure/
├── WebAPI/

 🧠 Öğrenilecek Başlıca Konular
- Clean Architecture ile proje ayrıştırma
- RESTful API yazımı
- Logo gibi dış servislerle entegrasyon mimarisi
- Jwt Token ile authorize

