# Vehicle Management System

## Description
The **Vehicle Management System** is a console-based application that helps users manage and retrieve information about various types of vehicles, including Air Vehicles, Water Vehicles, and Land Vehicles. The application supports functionalities such as:

- Entering and storing vehicle details.
- Calculating mileage and total distance traveled.
- Differentiating vehicles based on their type and properties.
- Overriding and hiding methods for customized behavior in child classes.
- Leveraging property initializers and object initializers for efficient object management.
- Adding extension methods to enhance functionality.

## Features
1. **Vehicle Properties**:
   - Fully gauge storage capacity.
   - Passenger capacity.
   - Luggage capacity.
   - Fuel type.
   - Manufacturing date.
   - Mileage.
   - Age of the vehicle.
   - Total distance traveled.

2. **Vehicle Types**:
   - **AirVehicle**: Properties specific to aircraft, such as altitude range.
   - **WaterVehicle**: Properties specific to watercraft, such as water depth suitability.
   - **LandVehicle**: Properties specific to cars and bikes, such as terrain suitability.

3. **Object-Oriented Principles**:
   - Constructor methods for initialization.
   - Method overriding and hiding for polymorphic behavior.
   - Use of extension methods for added flexibility.

4. **Console-Based Interaction**:
   - Menu-driven interface to add and view vehicle details.

5. **Code Structure**:
   - Parent class `Vehicle`.
   - Child classes `AirVehicle`, `WaterVehicle`, `LandVehicle`.

## Code Highlights
- **Inheritance and Polymorphism**: Child classes override methods from the base `Vehicle` class to provide specialized functionality.
- **Property Initializers**: Simplifies property assignments for objects.
- **Extension Methods**: Adds functionality to existing classes without modifying their original implementation.

## How to Run the Application
1. Clone this repository to your local system.
2. Open the solution in your preferred IDE (e.g., Visual Studio).
3. Build and run the project.
4. Use the console to navigate through the menu options:
   - Enter vehicle data.
   - Display vehicle data.



## Extension Methods
1. **CalculateAge**: Calculates the age of the vehicle based on its manufacturing date.
2. **IsEligibleForService**: Checks if the vehicle requires servicing based on distance traveled or age.

## Future Enhancements
- Implement a database for persistent data storage.
- Add graphical user interface (GUI) support.
- Include support for electric vehicles.

## File Structure
```plaintext
VehicleSystem
├── Program.cs
├── VehicleMain.cs
├── AirVehicle.cs
├── WaterVehicle.cs
├── LandVehicle.cs
├── README.md
```

## Technologies Used
- Programming Language: C#
- IDE: Visual Studio

## Author
Simran Shaikh

---
Feel free to contribute to the project by submitting issues or pull requests!
