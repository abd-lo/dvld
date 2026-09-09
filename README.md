# DVLD - Driving Vehicle License Department System

A desktop application for managing a Driving Vehicle License Department (DVLD), built with **C# WinForms** on a clean **3-layer architecture** (Presentation, Business Logic, and Data Access) backed by **SQL Server**.

## Overview

DVLD simulates the day-to-day operations of a driving license authority: registering people, managing drivers, scheduling and grading tests, issuing/renewing/replacing local and international licenses, detaining and releasing licenses, and administering system users — all through a set of interconnected WinForms screens, with domain rules enforced in the business layer rather than just the UI.

## Features

### People & Drivers
- Add, update, search, and view detailed profiles for individuals (name, national number, date of birth, gender, nationality, address, contact info, photo).
- A **Driver** record is created automatically the first time a person is issued their first local driving license — people don't need to be manually converted into drivers.
- View a driver's full profile, including every license and application linked to them.

### Applications
A generic `Application` is the base record behind every license-related transaction, each with a type, status, paid fees, and creation date. Application types include:
- New Local Driving License
- Renew Local License
- Replacement for a Lost or Damaged License
- Release of a Detained License
- New International License
- Retake Test

Several of these applications are **not created directly by a user** — they're generated automatically by the system as a side effect of another action (e.g. renewing a license auto-creates a "Renew" application; retaking a failed test auto-creates a "RetakeTest" application), keeping a full audit trail of every fee-generating action.

### Tests & Test Appointments
- Schedule test appointments for the three test types: **Vision, Written, and Street**.
- **Tests must be taken sequentially**: the Written test can't be scheduled until the Vision test is passed, and the Street test can't be scheduled until the Written test is passed.
- Only **one active (unlocked) appointment per test type** can exist at a time for a given application — a new appointment can't be scheduled while one is already pending.
- Once a test has been sat and graded, its appointment becomes **locked** and can no longer be edited or rescheduled.
- If a test is **failed**, the applicant can schedule a retake — but doing so automatically creates and charges a separate `RetakeTest` application, linked back to the original test appointment.
- The system tracks and displays the **number of tries** a person has had per test type.

### Licenses
- Issue a **new local driving license** once all three tests for the relevant license class are passed; expiration date is calculated automatically from that license class's configured validity length.
- **Renew** a license: creates a new license record (with a fresh issue/expiration date and its own fee) and deactivates the old one — old licenses are never overwritten, only deactivated, preserving full history.
- **Replace** a lost or damaged license: issues a new license carrying over the same expiration date and notes, at no additional fee, and deactivates the original.
- **Detain / Release** a license: a detained license is fined and flagged; releasing it requires a paid "Release Detained License" application before it becomes active again.
- Issue an **international license**, which can only be created against an existing local license for that driver.
- View a person's **complete license history**, including inactive/replaced/renewed licenses.

### License Classes
- Configurable license classes (e.g. by vehicle type), each with its own **minimum allowed age**, **default validity length** (in years), and **class fees** — these values drive expiration-date calculation and eligibility checks system-wide.

### Users & Authentication
- Login screen authenticating against a `Username`/`Password` pair tied to a person record.
- User accounts can be activated/deactivated (`IsActive`), added, updated, and listed, with password changes supported.

### Reusable UI Controls
- Shared UserControls (e.g. license cards, application info panels, test scheduling panel) are reused across multiple forms to keep data entry and validation logic consistent, rather than duplicating it screen by screen.

## Architecture

The solution is split into three projects:

| Project | Responsibility |
|---|---|
| `MY_DVLD` | WinForms presentation layer (forms, user controls, UI logic) |
| `MY_DVLD_Business` | Business/domain layer — enforces rules such as test sequencing, one-active-appointment, and license lifecycle transitions (`clsPerson`, `clsDriver`, `clsLicense`, `clsApplication`, `clsTest`, `clsTestAppointment`, `clsUser`, etc.) |
| `MY_DVLD_DataAccess` | Data access layer — handles all SQL Server communication (`clsPersonsData`, `clsLicenseData`, `clsApplicationData`, etc.) |

This separation keeps UI code independent of business rules, and business rules independent of how data is persisted — the UI layer reads flags and messages computed by the business layer (e.g. "Vision Test should be passed first") rather than deciding eligibility itself.

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
