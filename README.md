# 🎉 EventEaseApp – Smart Event Management App (Blazor WebAssembly)

EventEaseApp is a simple and interactive event-management application built using **Blazor WebAssembly**.  
This project was created as part of the Coursera assignment on *Using Microsoft Copilot for code generation, debugging, and optimization*.

The app includes:
- Event Card creation  
- Event Registration with validation  
- Attendance tracking  
- Shared state management  
- Fully working routing across pages  

---

## 🚀 Features

### ✅ 1. Event Card Component  
Users can create an event card by entering:
- Event Title  
- Date  
- Location  
- Description  

The information updates instantly using **two-way data binding (`@bind`)**.

---

### ✅ 2. Event Registration Form  
A clean form built using Blazor’s form components:
- `<EditForm>`  
- `<InputText>`  
- `<ValidationSummary>`  
- Data annotation validation:
  - `[Required]`
  - `[EmailAddress]`

Registered attendees are stored in a shared service.

---

### ✅ 3. Attendance Tracker  
Displays all registered attendees in a table.  
Attendees persist while the app is running using a **scoped service** (`EventStateService`).

---

### ✅ 4. Routing  
The app supports clean navigation with:

| Page | Route |
|------|--------|
| Home | `/` |
| Event Card | `/event-card` |
| Register | `/register` |
| Attendance | `/attendance` |

---

## 🛠 Technologies Used

- **Blazor WebAssembly (.NET 8)**
- **C#**
- **Razor Components**
- **Bootstrap** (default template styles)
- **Microsoft Copilot** for code suggestions

---

## 🤖 How Copilot Helped (Summary for Coursera)

Copilot assisted throughout the project in multiple ways:

### 1. Generating Components  
- Suggested the initial Event Card structure  
- Created `@bind` properties and Razor markup  
- Helped format the preview section

### 2. Debugging Errors  
- Helped identify missing namespaces  
- Suggested fixes for routing issues  
- Resolved dependency injection problems (`EventStateService`)

### 3. Enhancing Forms  
- Recommended proper usage of `<EditForm>`  
- Implemented `[Required]` and `[EmailAddress]` validation attributes  
- Suggested clearing form data after submission

### 4. Creating Shared State  
- Generated the attendee model  
- Suggested the structure for `EventStateService`  
- Helped register the service using:
  ```csharp
  builder.Services.AddScoped<EventStateService>();
