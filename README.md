# ASP.NET Core: Razor Pages & MVC Implementation

This repository contains two complete ASP.NET Core web applications developed to master the fundamentals of modern web architecture, data handling, and routing.

## 📁 Projects Included

### 1. Advanced Razor Pages Application (`AdvancedRazorApp`)
A Razor Pages application focusing on modular design and advanced routing.
* **Complex Model Binding:** Handles complex models with nested collections (Products and Categories).
* **Partial Views:** Utilizes reusable UI components for cleanly displaying product data.
* **Custom Routing:** Implements dynamic route parameters to view specific product details.

### 2. MVC Binding Application (`MvcBindingApp`)
A complete web application built using the ASP.NET Core MVC architecture.
* **Separation of Concerns:** Strictly organized into Models, Views, and Controllers.
* **Model Binding:** Captures basic form data (Name, Age) and nested objects (Address) via HTTP POST requests.

## 🛠️ Tech Stack
* **Framework:** .NET Core / ASP.NET Core
* **Language:** C#
* **Frontend:** HTML5, Razor Syntax (`.cshtml`)
* **Environment:** Visual Studio Code / .NET CLI

## 🚀 How to Run Locally

1. Clone the repository to your local machine:
   ```bash
   git clone [https://github.com/your-username/your-repo-name.git](https://github.com/your-username/your-repo-name.git)
   ```
   Navigate to the project directory:

```bash
cd AdvancedRazorApp
# OR
cd MvcBindingApp
```
Run the application using the .NET CLI:

```bash
dotnet run
```
### Razor Pages Fundamentals
* Structuring Razor Pages with clean separation between the Page (`.cshtml`) and the PageModel (`.cshtml.cs`).
* Using the `[BindProperty]` attribute to capture form submissions for nested data collections.
* Cleaning up HTML structures using Partial Views.
* Mapping custom routes to specific Razor Pages for better navigation.

### MVC Architecture Fundamentals
* **Project Setup:** Deepened understanding of setting up and structuring an MVC project from scratch.
* **Data Flow:** Mastered the flow of data from the View to the Controller, and back to a Result View.
* **Routing & State:** Successfully implemented form handling and data persistence across requests using standard MVC routing.
