# 📘 Student List App


This is a simple console-based application that allows you to add students and view the complete list.


---



## 📦 Technologies Used



- Lenguaje: C# (.NET 6/7/8)

- Entorno: Visual Studio 2022+

- Tipo de aplicación: Console

- Plataforma: Windows / Cross-platform



---



## 🎯 Main Features



- ✅ Displays a simple menu with 3 options

- ✅ Allows you to add student names

- ✅ Lets you view the list or continue adding students



---



## 🧠 Logic Overview



The application uses a basic `array` to store student names. It displays a menu and processes user input in a loop:



```csharp

 case 1:
     if (studentCount >= students.Length) // Check if the maximum number of students has been reached
     {
         Console.WriteLine("Maximum number of students reached. Cannot add more.");
     }
     else
     {
         Console.WriteLine("Enter student name:");
         string studentName = Console.ReadLine();
         students[studentCount] = studentName; // Add the student name to the array
         studentCount++; // Increment the student count
         Console.WriteLine($"Student '{studentName}' added successfully.");// Confirmation message
     }
     break;
```


---


# 🖥️ Sample Output

plaintext
```
Select an option:
1. Add student name
2. View the students list
3. Exit
1
Enter student name:
Luis
Student 'Luis' added successfully.

Select an option:
1. Add student name
2. View the students list
3. Exit
1
Enter student name:
Fer
Student 'Fer' added successfully.

Select an option:
1. Add student name
2. View the students list
3. Exit
2
Students list:
1. Luis
2. Fer

Select an option:
1. Add student name
2. View the students list
3. Exit
3
Exiting...
```

---



## 🏁 Cómo ejecutar el proyecto


1. Clone this repository:

   ```bash

   git clone https://github.com/LuisMichel-developer/Student-List-APP

   ```

2. Open the file `.sln` in Visual Studio

3. Run the project with `Ctrl + F5`



---



## 🚀 Possible Improvements



- [ ] Add file saving (persist data)

- [ ] Improve the user interface

- [ ] Add input validation



---



## 🧑‍💻 Author

- 👤 **Luis Michel**
- 🎓 Software Engineering student
- 📍 Colima, Mexico
- 🌐 [LinkedIn Profile](https://www.linkedin.com/in/luis-michel-dev/)


---

## 📃 License

This project is licensed under the [MIT License](LICENSE).

