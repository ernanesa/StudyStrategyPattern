# Study Strategy Pattern

This repository contains studies and implementations of the **Strategy Pattern** using **.NET 9**.

## 📌 About the Strategy Pattern
The **Strategy Pattern** is a behavioral design pattern that allows defining a family of algorithms, encapsulating them in separate classes, and making them interchangeable dynamically.

### When to Use?
- When there are multiple variations of an algorithm and the need to switch between them.
- To avoid complex conditional structures (`if` or `switch`).
- To follow the open/closed principle (**OCP**) and facilitate extensibility.

## 🚀 Implementation in .NET 9
The project demonstrates the application of the Strategy Pattern in a freight calculation system with different carriers.

### 📂 Project Structure
```
Study_Strategy_Pattern/
│── src/
│   ├── Strategies/
│   │   ├── IFreightStrategy.cs
│   │   ├── CorreiosFreight.cs
│   │   ├── FedexFreight.cs
│   │   ├── DhlFreight.cs
│   ├── Context/
│   │   ├── FreightCalculator.cs
│   ├── Program.cs
│── README.md
```

### 🛠 Example Usage
```csharp
var calculator = new FreightCalculator();

calculator.DefineStrategy(new CorreiosFreight());
Console.WriteLine($"Correios Freight: R${calculator.Calculate(10)}");

calculator.DefineStrategy(new FedexFreight());
Console.WriteLine($"FedEx Freight: R${calculator.Calculate(10)}");

calculator.DefineStrategy(new DhlFreight());
Console.WriteLine($"DHL Freight: R${calculator.Calculate(10)}");
```

## 🏗 Technologies Used
- **.NET 9**
- **C#**

## 📌 How to Run the Project
1. Clone the repository:
   ```sh
   git clone https://github.com/your-user/Study_Strategy_Pattern.git
   ```
2. Access the project folder:
   ```sh
   cd Study_Strategy_Pattern/src
   ```
3. Run the project:
   ```sh
   dotnet run
   ```
