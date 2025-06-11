using System;

class Program
{
    static void Main()
    {
        string[] students = new string[10]; // Array to hold student names, with a maximum of 10 students
        int studentCount = 0; // Variable to keep track of the number of students added

        bool exit = false; // Flag to control the exit of the loop

        while (!exit) // Loop until the user chooses to exit
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Add student name");
            Console.WriteLine("2. View the students list");
            Console.WriteLine("3. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) // Switch statement to handle user choices
            {
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

                case 2:
                    Console.WriteLine("Students list:");
                    for (int i = 0; i < studentCount; i++) // Loop through the array to display student names
                    {
                        Console.WriteLine($"{i + 1}. {students[i]}"); // Display each student's name with its index
                    }
                    if (studentCount == 0)
                    {
                        Console.WriteLine("No students added yet.");
                    }
                    break;

                case 3:
                    exit = true; // Set the exit flag to true to break the loop
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
