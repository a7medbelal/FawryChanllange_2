# 📚 Quantum Bookstore – Fawry Challenge

This is my solution for the Fawry internship

# 📚 Quantum Bookstore – Fawry Challenge Submission

This project is a simple console-based bookstore system built in C# as part of the Fawry OOP internship challenge.

---

##  Main Features

- **Add Books to Inventory**  
  Supports adding multiple types of books including paper books, ebooks, and demo books.

- **Buy a Book by ISBN**  
  Allows customers to purchase books using their ISBN, quantity, email, and address.

- **Different Book Types**
  - **PaperBook**: Can be shipped and has stock quantity.
  - **EBook**: Has a file type and is sent by email (no quantity limit).
  - **DemoBook**: Only for display, not for sale.

- **Remove Outdated Books**  
  Books older than a fixed number of years are removed from inventory automatically.

- **Automatic Handling of Purchase Logic**  
  Each book type handles its own buying logic using OOP principles (like overriding a `Buy` method).

- **All outputs are prefixed with "Quantum book store"**  
  As required by the task for clarity and branding.
--
##  Testing

A dedicated test class named `QuantumBookstoreFullTest` is provided to demonstrate:

- Adding different book types
- Removing outdated books
- Buying books using ISBN
- Handling invalid operations
---

##  Concepts Used

- Object-Oriented Programming (Inheritance, Encapsulation, Polymorphism)
- Clean separation of responsibilities
- Interface usage for shipping and email services
- Console-based user interaction and error handling

#here images for run project
![Checkout Summary](https://github.com/a7medbelal/FawryChanllange_2/blob/d4664651300866d05989deb63cad32447e5a478a/FawryChallenge2/Images/Screenshot%202025-07-08%20224150.png)
![Checkout Summary](https://github.com/a7medbelal/FawryChanllange_2/blob/f5eaadbff28299ad858f3cbb6f5e16c34785e2cc/FawryChallenge2/Images/Screenshot%202025-07-08%20223556.png)

