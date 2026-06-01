#  Cool Rides: Automobile Production Simulator

![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=c-sharp&logoColor=white)
![.NET 8](https://img.shields.io/badge/.NET_8-5C2D91?style=flat-square&logo=.net&logoColor=white)
![Design Patterns](https://img.shields.io/badge/Design_Patterns-GoF-blue?style=flat-square)

> **IRUD301 Semester 1 Assignment**
> A multi-threaded C# application simulating an automobile production environment for "Cool Rides". The system models an industrial complex with separate part factories and assembly lines for cars (LUX1000) and minibuses (MV500).

---

##  Architecture & Design Patterns

This application strictly adheres to Gang of Four (GoF) design patterns to manage object creation, enforce business rules, and handle thread concurrency cleanly.

*   **Abstract Factory & Factory Method:** Manages the creation of distinct automobile parts (Chassis, Shell, Wheels, Interior Trim). This ensures that car parts and minibus parts are instantiated independently in their respective factories, strictly preventing component crossover.
*   **Singleton Pattern:** Applied to the facility's single Spraybooth. Because government regulations prohibit more than one spraybooth on the premises, the Singleton pattern securely enforces this global constraint.
*   **Command Pattern:** Handles the processing of automobile orders from Corporate HQ. Orders (specifying vehicle type and color) are queued and executed sequentially for each respective assembly line as they become available.

---

##  Key Features & Mechanics

### Concurrent Assembly
The Car Assembly Line and Minibus Assembly Line run in tandem using multi-threading to produce vehicles simultaneously without thread-locking the main interface.

### Time-Accurate Simulation
Construction phases utilize deliberate thread delays (`Thread.Sleep`) to represent accurate manufacturing times:
*   **Car Chassis:** 2 seconds | **Minibus Shell:** 3 seconds

### Shared Resource Bottleneck
Once assembled, vehicles from both lines are routed to the shared Spraybooth. The spraybooth handles only one vehicle at a time (5 seconds to paint/dry a car, 7 seconds for a minibus), accurately simulating an industrial bottleneck.

### Clean UI & Real-Time Monitoring
The system features a minimalist GUI that displays up-to-date information regarding:
*   The number of automobiles ordered.
*   The real-time status of each assembly line phase.
*   The current occupancy and state of the spraybooth.

---

##  Getting Started

### Prerequisites
*   [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
*   Visual Studio 2022 (or your preferred C# IDE)

### Installation & Execution
1. **Clone the repository:**
```bash
   [git clone [https://github.com/YourUsername/Your-Repo-Name.git](https://github.com/YourU](https://github.com/YourLAYWER/Manufacturing-Scheduler.git)
