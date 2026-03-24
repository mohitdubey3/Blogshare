# Blogshare - Full-Stack Blog Platform


**BlogShare** is a dynamic content-sharing web application built with **ASP.NET Core MVC**. It is a community-driven platform where users can discover, read, and share their thoughts through blog posts. The application features a dynamic feed, category-based filtering.

## 🚀 Key Features

* **Dynamic Home Feed:** Displays "Latest" and "Popular" blog posts using optimized LINQ queries.
* **Interest Categories:** Users can filter and browse blogs based on specific topics (e.g., Tech, Lifestyle, Education).
* **User Authentication:** Powered by **ASP.NET Core Identity** to manage guest vs. registered user permissions.
* **Interactive Engagement:** Registered users can create, edit, and delete their own posts and leave comments on others'.
* **Admin Moderation:** Dedicated Admin role with authority to manage all site content, including deleting inappropriate comments or posts.

## 🛠 Tech Stack

* **Framework:** ASP.NET Core 9.0 (MVC)
* **Database:** SQL Server
* **ORM:** Entity Framework Core (Code First)
* **Security:** ASP.NET Core Identity (RBAC)
* **Frontend:** Razor Views, Bootstrap 5, HTML5, CSS3

## ⚙️ Setup & Installation

1. Clone the repo: `git clone https://github.com/yourusername/BlogShare.git`
2. Update the `DefaultConnection` string in `appsettings.json`.
3. Run `Update-Database` in the Package Manager Console.
4. Press `F5` to run the application.

![Screenshot_24-3-2026_13320_localhost](https://github.com/user-attachments/assets/bf9a2921-7694-43d5-a592-571a3b49e3b6)
