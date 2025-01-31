# Tax Calculator System using Generics

## Overview
The Tax Calculator System is a console-based C# application that calculates annual tax based on user earnings and investments. It supports two implementations:
1. **Delegate-Based Implementation**: Uses delegates to switch between test and real user data input.
2. **Generics-Based Implementation**: Uses generics and interfaces to provide a more flexible approach for user data handling.

---

## Features
- Accepts **Name, Profession, Earnings, and Investments** as input.
- Uses **tax slabs** to compute taxable income.
- Provides **Test Mode** with pre-filled data for faster testing.
- Implements **Delegates** and **Generics** for dynamic data input handling.

---

## 2️⃣ Generics-Based Implementation
### Files Structure
```
TaxCalculatorSystemGenerics/
│── Program.cs
│── Calculation.cs
│── IUserData.cs
│── TestUserData.cs
│── RealUserData.cs
```
