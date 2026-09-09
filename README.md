# DVLD - Driving Vehicle License Department System

A desktop application for managing a Driving Vehicle License Department (DVLD), built with **C# WinForms** on a clean **3-layer architecture** (Presentation, Business Logic, and Data Access) backed by **SQL Server**.

## Overview

DVLD simulates the day-to-day operations of a driving license authority: registering people, managing drivers, scheduling and grading tests, issuing and renewing local/international licenses, and administering system users — all through a set of interconnected WinForms screens.

## Features

- **People Management** — add, update, search, and view detailed profiles of individuals in the system.
- **Drivers** — list and manage drivers derived from registered people.
- **Applications** — a generic application workflow covering:
  - New Local Driving License
  - Renew Local License
  - Replacement for Lost or Damaged License
  - Release of Detained License
  - New International License
  - Retake Test
- **Tests** — schedule test appointments, record results, and view test history (e.g. Vision, Written, Street tests).
- **Licenses** — issue and manage local and international driving licenses, detain/release licenses, and view a person's full license history.
- **Users & Authentication** — login screen, user management (add/update/list), password changes, and user detail views.
- **Reusable UI Controls** — shared UserControls (e.g. application info panels, license cards) used across multiple screens to keep the UI consistent.

## Architecture

The solution is split into three projects:

| Project | Responsibility |
|---|---|
| `MY_DVLD` | WinForms presentation layer (forms, user controls, UI logic) |
| `MY_DVLD_Business` | Business/domain layer (`clsPerson`, `clsDriver`, `clsLicense`, `clsApplication`, `clsTest`, `clsUser`, etc.) |
| `MY_DVLD_DataAccess` | Data access layer — handles all SQL Server communication (`clsPersonsData`, `clsLicenseData`, `clsApplicationData`, etc.) |

This separation keeps UI code independent of business rules, and business rules independent of how data is persisted.

## Tech Stack

- **Language:** C#
- **Framework:** .NET Framework 4.7.2 (Windows Forms)
- **Database:** Microsoft SQL Server (LocalDB by default)
- **IDE:** Visual Studio

## Getting Started

### Prerequisites

- Visual Studio (2019 or later recommended)
- .NET Framework 4.7.2
- SQL Server / SQL Server LocalDB

### Setup

1. Clone the repository:
   ```bash
   git clone <your-repo-url>
   ```
2. Open `MY_DVLD/MY_DVLD.sln` in Visual Studio.
3. Create a SQL Server database named `DVLD` (update the connection string in `MY_DVLD_DataAccess/clsDataAccessSettings.cs` if your server/instance differs from the default LocalDB setup):
   ```csharp
   Server=(localdb)\MSSQLLocalDB; Integrated Security=true; Database=DVLD;
   ```
4. Build and run the solution — the app starts at the login screen (`frmLogin`).

## Project Structure

```
MY_DVLD/
├── Applications/       # Application workflows (new/renew/replace license, etc.)
├── Drivers/            # Driver listing
├── Licenses/           # Local & international license management
├── Login/              # Authentication screen
├── People/             # Person management
├── Tests/              # Test scheduling, types, and appointments
├── Users/               # System user management
└── GlobalClasses/       # Shared helpers (validation, utilities, globals)

MY_DVLD_Business/        # Business logic classes
MY_DVLD_DataAccess/      # Data access classes
```

## License

This project is available for educational and personal use.
