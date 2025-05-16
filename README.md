# 🔥 Fire Track PH

A community-based fire tracking application that empowers citizens to report fire incidents and helps authorities respond more effectively.

[![License](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-9.0-purple.svg)](https://dotnet.microsoft.com/download)
[![Open Source](https://img.shields.io/badge/Open%20Source-%E2%9D%A4-red.svg)](https://github.com/yourusername/fire-track-ph)

## 📋 Overview

Fire Track PH is a digital reporting platform that allows community members to report fire incidents in real-time. When users upload photos of fire incidents, the application automatically extracts GPS coordinates from the images and plots them on a map, providing emergency services with crucial location data to respond quickly and effectively.

### Key Features

- **Real-time fire incident reporting** by community members
- **Automatic GPS coordinate extraction** from uploaded photos
- **Interactive map visualization** of reported incidents
- **Admin dashboard** for emergency services to track and manage reports
- **Notification system** for alerts and updates
- **Community engagement tools** to foster participation

## 🚀 Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Express edition works fine for development)
- [Git](https://git-scm.com/downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/) with C# extensions

### Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/IlocosScript/FireTrackPH
   cd firetrackph
   ```

2. **Set up the database:**
   ```bash
   dotnet ef database update
   ```

3. **Configure application settings:**
   - Rename `appsettings.example.json` to `appsettings.json`
   - Update the connection strings and API keys as needed

4. **Run the application:**
   ```bash
   dotnet run
   ```

5. **Access the application:**
   - Backend API: `https://localhost:5001`
   - Swagger documentation: `https://localhost:5001/swagger`

## 🏗️ Project Structure

```
fire-track-ph/
├── src/
│   ├── FireTrackPH.Application/     # Business Logic
│   ├── FireTrackPH.Domain/          # Domain Models(Entities)
│   ├── FireTrackPH.WebUI/           # Controllers(HTTP Access)
│   ├── FireTrackPH.Infrastructure/  # Data access and external services
│   └── FireTrackPH.Tests/           # Unit and integration tests
├── docs/                            # Documentation
├── scripts/                         # Utility scripts
└── README.md                        # This file
```

## 🧠 Technical Architecture

Fire Track PH follows a clean architecture approach with these key components:

### Backend (.NET C#)
- **ASP.NET Core Web API**: Provides RESTful endpoints for the frontend
- **Entity Framework Core**: ORM for database operations
- **Identity Server**: Authentication and authorization
- **SignalR**: Real-time communication for notifications

### Database
- SQL Server for data persistence
- Redis for caching and real-time data

## 👨‍💻 How to Contribute

We welcome contributions from developers of all skill levels! Here's how you can participate:

1. **Find an issue**: Check out the [Issues](https://github.com/IlocosScript/FireTrackPH/issues) page for tasks labeled "good first issue" or "help wanted".

2. **Fork the repository**: Create your own copy of the project.

3. **Create a branch**: 
   ```bash
   git checkout -b feature/your-feature-name
   ```

4. **Make your changes**: Implement your feature or bug fix.

5. **Test your changes**: Ensure all tests pass.
   ```bash
   dotnet test
   ```

6. **Submit a pull request**: Push your changes and create a PR against the main repository.

### Coding Standards

- Follow [Microsoft's C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)
- Include comments for public APIs
- Write unit tests for new features
- Keep the code modular and maintainable

## 📄 Roadmap

- **Q2 2025**: Backend API development and testing
- **Q3 2025**: Admin dashboard implementation
- **Q4 2025**: Mobile application development
- **Q1 2026**: Public beta release and community testing

## 📱 Planned Extensions

- **Mobile Apps**: Native mobile applications for iOS and Android
- **Offline Mode**: Support for offline reporting with sync when connection is restored
- **AI Integration**: Fire spread prediction using machine learning
- **Multi-language Support**: Localization for Filipino languages and dialects

## 🔒 Security

We take security seriously. If you discover any security vulnerabilities, please report them by sending an email to security@firetrackph.org rather than creating a public issue.

## 📊 Data Privacy

Fire Track PH is committed to protecting user privacy:
- All personal information is encrypted
- GPS data is used only for emergency response purposes
- Users can opt out of data collection while still reporting incidents

## 📜 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🤝 Acknowledgements

- National Fire Protection Association of the Philippines
- Department of Science and Technology
- Contributing developers and community members

## 📞 Contact

- Project Lead: [Your Name](mailto:your.email@example.com)
- Website: [www.firetrackph.org](https://www.firetrackph.org)
- Twitter: [@FireTrackPH](https://twitter.com/FireTrackPH)

---

<p align="center">Made with ❤️ in the Philippines</p>

## Deployment

To deploy this project run

```
  clone these files
  open 
```

