# 🧾 InvoFlow | Finansal Süreç Yönetimi

**InvoFlow**, işletmelerin faturalama süreçlerini pürüzsüz bir akışa dönüştürmek için ASP.NET Core altyapısıyla geliştirilmiş, modern ve dinamik bir **Web Uygulamasıdır.**

---

## 📊 Dashboard & Görünüm
Uygulama, veritabanındaki verileri anlık olarak analiz ederek kullanıcıya özet istatistikler sunar.

* **Toplam Ciro Takibi:** Tüm kayıtlı faturaların otomatik toplamı.
* **Ödeme Durum Analizi:** "Ödendi", "Beklemede" ve "İptal" durumlarına göre dinamik etiketleme.
* **Hızlı Arama:** Binlerce kayıt arasından müşteri veya fatura no ile saniyeler içinde filtreleme.

---

## 🛠️ Teknik Stack (Technology Stack)

| Alan | Kullanılan Teknoloji |
| :--- | :--- |
| **Framework** | ASP.NET Core 9.0 (Razor Pages) |
| **Veritabanı** | MS SQL Server |
| **ORM** | Entity Framework Core (Code First) |
| **Frontend** | Bootstrap 5, CSS3, Google Fonts |
| **Mimari** | Repository Logic & CRUD Pattern |

---

## 🚀 Öne Çıkan Özellikler

- ✅ **Dinamik Dashboard:** Veritabanı üzerinden `LINQ` sorguları ile anlık finansal özet.
- ✅ **Akıllı Arama UI:** Kullanıcı deneyimini (UX) ön planda tutan filtreleme sistemi.
- ✅ **Veri Doğrulama (Validation):** Hatalı veya eksik veri girişini engelleyen sunucu taraflı kontrol mekanizması.
- ✅ **Responsive Tasarım:** Mobil, tablet ve masaüstü cihazlarla tam uyumlu arayüz.

---

## 💻 Kurulum ve Çalıştırma

1. Projeyi klonlayın: `git clone https://github.com/kullaniciadi/InvoFlow.git`
2. `appsettings.json` dosyasındaki `ConnectionStrings` bölümünü kendi SQL Server adresinize göre güncelleyin.
3. Package Manager Console üzerinden migration'ları uygulayın:
   ```bash
   Update-Database