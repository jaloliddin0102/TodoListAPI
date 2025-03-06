

# TodoListAPI

Bu **TodoListAPI** - vazifalarni saqlash, yaratish, o'chirish va yangilash uchun yaratilgan RESTful API.

## 🚀 Loyihaning imkoniyatlari

- 🔐 **JWT autentifikatsiya** orqali foydalanuvchilarni tekshirish
- ✅ **CRUD amallarini bajarish** (Create, Read, Update, Delete)
- 📄 **Swagger UI** bilan API hujjatlari
- 🛠 **FluentValidation** orqali kiritilgan ma'lumotlarni tekshirish
- 📦 **PostgreSQL** bilan ishlash

## 🔧 Texnologiyalar

- **ASP.NET Core 7.0**
- **Entity Framework Core**
- **PostgreSQL**
- **JWT Authentication**
- **FluentValidation**
- **Swagger (Swashbuckle)**

## 📌 O'rnatish va Ishga tushirish

1. **Repositoryni klonlash:**
   ```sh
   git clone https://github.com/jaloliddin0102/TodoListAPI.git
   cd TodoListAPI
   ```

2. **Kerakli kutubxonalarni o'rnatish:**
   ```sh
   dotnet restore
   ```

3. **Ma'lumotlar bazasini yaratish:**
   `.env` yoki `appsettings.json` faylida `DefaultConnection` sozlamalarini o'zgartiring va migration qiling:
   ```sh
   dotnet ef database update
   ```

4. **Dastur serverini ishga tushirish:**
   ```sh
   dotnet run
   ```

## 🔑 API Autentifikatsiya

API ishlashi uchun **JWT token** talab etiladi.  
Swagger orqali API test qilishda `"Bearer {your_token}"` formatida token kiritish kerak.

## 📚 API Endpointlar

| Yo'l                  | Metod | Tavsif |
|----------------------|--------|-------------|
| `/api/auth/register` | `POST` | Foydalanuvchini ro'yxatdan o'tkazish |
| `/api/auth/login`    | `POST` | Foydalanuvchini tizimga kiritish |
| `/api/todos`        | `GET` | Barcha vazifalarni olish |
| `/api/todos/{id}`   | `GET` | ID bo'yicha vazifani olish |
| `/api/todos`        | `POST` | Yangi vazifa qo'shish |
| `/api/todos/{id}`   | `PUT` | Vazifani yangilash |
| `/api/todos/{id}`   | `DELETE` | Vazifani o'chirish |

## 🛠 Muallif

👤 **Jaloliddin Xolmirzayev**  
GitHub: [@jaloliddin0102](https://github.com/jaloliddin0102)

---
✅ Agar loyiha foydali bo'lsa, yulduzcha ⭐ qo'yishni unutmang! 😊
```
🚀
