using System;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET_9_OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1

            #region q1 Q1 : What is an interface in C#? Why do we use interfaces instead of depending on concrete classes directly? Mention at least three benefits of using interfaces.

            //An interface defines a contract that a class must follow.
            //It specifies what a class can do, not how it does it.
            //Benefits of using interfaces:
            //1. Abstraction: Interfaces allow us to define methods without implementing them, providing a clear separation between what a class does and how it does it.
            //2. Multiple Inheritance: A class can implement multiple interfaces, allowing for more flexible and modular design.
            //3. Loose Coupling: By depending on interfaces rather than concrete classes, we can reduce dependencies and make our code more maintainable and testable.
            //4. Polymorphism: Interfaces enable polymorphic behavior, allowing us to treat different classes that implement the same interface as the same type, which can simplify code and enhance flexibility.
            //5. Testability: Interfaces make it easier to create mock objects for unit testing, allowing us to test components in isolation without relying on concrete implementations.
            //6. Extensibility: Interfaces allow us to add new functionality without modifying existing code, adhering to the Open/Closed Principle of software design.
            //7. Code Reusability: By defining common behaviors in interfaces, we can promote code reuse across different classes that implement the same interface./

            #endregion
            #region q2
            //a) The problem with this design is that both interfaces have a method called Greet(), which creates ambiguity for the Translator class. The class does not know which Greet() method to implement, leading to a compilation error.
            //b) To fix this, we can use explicit interface implementation. This technique allows us to implement each interface's Greet() method separately, specifying which one belongs to which interface. Here's how you can do it:
            //class Translator : IEnglishSpeaker, IArabicSpeaker
            //{
            //    void IEnglishSpeaker.Greet()
            //    {
            //        Console.WriteLine("Hello");
            //    } 
            //    void IArabicSpeaker.Greet()
            //    {
            //        Console.WriteLine("Ahlan");
            //    }
            //}



            #endregion

            #region Q3
            //A shallow copy creates a new object but copies the references of the fields, meaning that both the original and the copied object point to the same memory location for reference-type fields. A deep copy, on the other hand, creates a new object and also creates new instances of any reference-type fields, ensuring that the original and copied objects are completely independent.
            //You would use a shallow copy when you want to create a new object that shares the same data as the original, and you don't need to modify the reference-type fields independently. A deep copy is necessary when you want to ensure that changes to the copied object do not affect the original object, especially when dealing with mutable reference-type fields.
            //The risk of using a shallow copy when the object has reference-type fields is that if you modify the reference-type field in the copied object, it will also affect the original object since both objects point to the same memory location for that field. This can lead to unintended side effects and bugs in your program.
            //In general, prefer deep copies when working with complex objects that contain reference-type fields to avoid these issues.


            #endregion
            #region Q4 : Look at the following code and determine the output. Explain why.
            //Output:
            //Dev - Testing
            //QA - Testing
            //Explanation:
            //In this code, we have an Employee class that contains a Title and a reference to a Department object. When we create e1 and then call ShallowCopy() to create e2, we are creating a shallow copy of e1. This means that e2 is a new Employee object, but it references the same Department object as e1.
            //When we change e2.Title to "QA", it does not affect e1.Title, which remains "Dev". However, when we change e2.Dept.Name to "Testing", it affects e1.Dept.Name as well because both e1 and e2 reference the same Department object. Therefore, both e1 and e2 will show "Testing" for the department name, while their titles will differ.
            //This illustrates the concept of a shallow copy, where the reference-type fields (like Dept) are shared between the original and the copied object, leading to potential side effects when one of them is modified.
        

            #endregion
            #endregion



            #region part2
            Cinema cinema = new Cinema();
                cinema.Open();

                StandardTicket t1 = new StandardTicket("Inception", 80, "A5");
                VIPTicket t2 = new VIPTicket("Avengers", 200, true, 50);
                IMAXTicket t3 = new IMAXTicket("Dune", 130, true);

                t1.Book();
                t2.Book();
                t3.Book();

                cinema.AddTicket(t1);
                cinema.AddTicket(t2);
                cinema.AddTicket(t3);

                cinema.PrintAllTickets();

                Console.WriteLine("\n--- Clone Test ---");
                VIPTicket clone = (VIPTicket)t2.Clone();
                clone.MovieName = "Interstellar";

                Console.WriteLine("Original : " + t2.Print());
                Console.WriteLine("Clone    : " + clone.Print());

                Console.WriteLine("\n--- After Cancellation ---");
                t1.Cancel();
                Console.WriteLine(t1.Print());

                IPrintable[] tickets = { t1, t2, t3 };
                BookingHelper.PrintAll(tickets);

                Console.WriteLine("\n=== Cinema Closed ===");
            }




        #endregion 







    }



}

