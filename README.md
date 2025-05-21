# EventEase
# 📅 EventEase — Event Registration App

**EventEase** is a Blazor Server application for browsing and registering for corporate and social events. Built using ASP.NET Core and Razor Components, it demonstrates form binding, navigation, dependency injection, and server-side component rendering.

## 🛠 Features

- ✅ Browse upcoming events
- ✅ Register for specific events
- ✅ Client-side validation with `EditForm` + `DataAnnotations`
- ✅ In-memory registration service (mock)
- ✅ Bootstrap-styled UI
- ✅ Clean routing with fallback support

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Visual Studio 2022+ or VS Code

### 🔧 Running the App

1. Clone the repository:

```bash
git clone https://github.com/yourusername/EventEase.git
cd EventEase
```

2. Build and run:

```bash
dotnet run
```

3. Navigate to:
```
https://localhost:5001
```

## 🧩 Project Structure

```
EventEase2/
│
├── Pages/               # Razor pages (Index, EventList, Registration)
├── Services/            # IEventService and IRegistrationService (mocked)
├── Models/              # DTOs like EventDto and EventRegistrationDto
├── Shared/              # Layout and NavMenu
├── wwwroot/             # CSS, Bootstrap
├── _Host.cshtml         # Blazor Server entry point
└── Program.cs           # Startup logic
```

## 🧪 Demo Pages

| Page | Route | Description |
|------|-------|-------------|
| Home | `/` | Welcome message + CTA |
| Browse Events | `/events` | List of upcoming events |
| Register | `/events/{eventId}/register` | Form with validation |
| Debug View | `/registrations` | (Optional) See in-memory registrations |

## 🧠 Design Patterns & Principles

- **SOLID principles**:
  - `IEventService` and `IRegistrationService` promote Interface Segregation
  - `MockRegistrationService` demonstrates Dependency Inversion
- **Separation of concerns**:
  - Views (`.razor`) are cleanly separated from models and services
- **Blazor Server DI**:
  - Services are scoped and injected properly in `Program.cs`

## ✅ TODO

- [ ] Persist registrations to database (e.g., SQLite or EF Core)
- [ ] Add admin event creation page
- [ ] Add user authentication
- [ ] Add email confirmation / notifications

## 📸 Screenshots

> _You can add screenshots here using:_
```md
![Browse Events](screenshots/browse-events.png)
```

## 👨‍💻 Author

**Shane Kirkbride**  
🔗 [LinkedIn](https://linkedin.com/in/yourprofile)  
💻 [GitHub](https://github.com/yourusername)
