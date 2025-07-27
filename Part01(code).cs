using System;


namespace Day02G01
{
    class Program
    {
        static void Main()
        {
            #region Problem 1: Adding Comments

            // Problem: Add both single-line and multi-line comments in the following code segment
            //          explaining its purpose:

            int x = 10;
            int y = 20;
            /*
                This section is about performing a basic addition.
                We declare a variable called 'sum' and give it the total
                of 'x' plus 'y'. After that, we just print the result to
                see what we got!
            */
            int sum = x + y;
            Console.WriteLine(sum);

            #endregion

            #region Problem 2: Fixing Errors

            // Problem: Identify and fix the errors in this code snippet:

            // Original code with errors (commented out to show the fix):
            // int x = "10"; // ERROR: int cannot store a string!
            // console.WriteLine(x + y); // ERROR: 'console' should be 'Console' (capital 'C')!

            // ---fixed code:
            // We changed the string "10" to a number 10.
            int fixedX = 10;
            // And fixed the capitalization of Console.WriteLine.
            Console.WriteLine(fixedX + y);

            #endregion

            #region Problem 3: Variable Naming Conventions

            // Problem: Declare variables using proper naming conventions to store:
            //          - A person's Full Name
            //          - Their Age
            //          - Their Monthly Salary
            //          - Whether they are a Student

            // ---  naming PascalCase ):
            string PersonFullName = "Saef Mohamed";
            int PersonAge = 199;
            decimal PersonMonthlySalary = 50.03m; // Using 'm' suffix for decimal.
            bool IsPersonStudent = true;

            #endregion

            #region Problem 4: Reference Type Behavior (Sharing Memory)

            // Problem: Write a program that demonstrates that changing the value of a reference type affects all
            //          references pointing to that object.

           class Person
                {
                   public string Name;

                   public Person(Person other)
                         {
                            Name = other.Name;
                         }
                }

            Person p1 = new Person();
            p1.Name = "saef";

            Person p2 = new Person(p1); // Now p2 is a copy of p1
            p2.Name = "mohammed";
            
            //Console.WriteLine("Name using p1: " + p1.Name); // Will print "mohammed"
            //Console.WriteLine("Name using p2: " + p2.Name); // Will print "mohammed"

            #endregion

            #region Problem 5: Basic Arithmetic Operations

            /*
               Problem: Create a program that calculates the following using variables x = 15 and y = 4:
                        o Sum
                        o Difference
                        o Product
                        o Division result
                        o Remainder
            */

            // --- Our calculations:
            int numX = 15; //different variable names to avoid conflicts with other problems
        int numY = 4;

        int sumResult = numX + numY;
        int differenceResult = numX - numY;
        int productResult = numX * numY;
        int divisionResult = numX / numY;
        int remainderResult = numX % numY;

        // We can print these out if we want to see the results.
        //Console.WriteLine($"Sum: {sumResult}");
        //Console.WriteLine($"Difference: {differenceResult}");
        //Console.WriteLine($"Product: {productResult}");
        //Console.WriteLine($"Division (integer): {divisionResult}");
        //Console.WriteLine($"Remainder: {remainderResult}");

        #endregion

        #region Problem 6: Checking Number Conditions

        /*
           Problem: Write a program that checks if a given number is both:
                    o Greater than 10.
                    o Even.
        */

        
            int checkNumber = 12; 

            
            if (checkNumber > 10)
            {
                Console.WriteLine(checkNumber + " is greater than 10.");
            }

            
            if (checkNumber % 2 == 0)
            {
                Console.WriteLine(checkNumber + " is Even.");
            }

#endregion

#region Problem 7: Casting Data Types

// Problem: Implement a program that takes a double input from the user and casts it to an int.
//          Use both implicit and explicit casting, then print the results.


// 1. Explicit cast
double originalPrice = 99.99;
int roundedPriceExplicit = (int)originalPrice; 
Console.WriteLine($"Original Price (double): {originalPrice}");
Console.WriteLine($"Rounded Price (explicit int cast): {roundedPriceExplicit}");

// 2. Using a Conversion Method (Convert.ToInt32 is usually safer for rounding):
//    Convert.ToInt32 actually rounds to the nearest whole number (or rounds half to even).
double originalScore = 88.6;
int roundedScoreConvert = Convert.ToInt32(originalScore); // This will round 88.6 to 89.
Console.WriteLine($"Original Score (double): {originalScore}");
Console.WriteLine($"Rounded Score (Convert.ToInt32): {roundedScoreConvert}");

// --- Implicit Casting Example (if it were allowed, just to show the idea):
// int smallNum = 10;
// double bigNum = smallNum; // This would be an implicit cast (int to double is safe, no data loss)
// Console.WriteLine($"Implicit conversion (int to double): {bigNum}");

#endregion

#region Problem 8: User Input & Basic Validation (Parse)

/*
   Problem: Write a program that:
            o Prompts the user for their age as a string.
            o Converts the string to an integer using Parse.
            o Checks if the age is valid (e.g., greater than 0).
*/

// --- Let's get the user's age:
Console.Write("Please enter your age: ");
string ageInputText = Console.ReadLine(); // Read what the user types (it's always a string first!).

// Try to turn that text into a number using int.Parse.
// Be careful! If the user types "hello", this will crash!
int parsedAge = int.Parse(ageInputText);

// Now, let's check if the age is logical.
if (parsedAge > 0)
{
    Console.WriteLine($"Great! Your age ({parsedAge}) is valid.");
}
else
{
    Console.WriteLine($"Hmm, age ({parsedAge}) doesn't look valid. Age should be greater than 0.");
}

// --- Note on TryParse (Safer Way):
// For real programs, you'd use int.TryParse() to avoid crashes if user types garbage.
// int age;
// if (int.TryParse(ageInputText, out age) && age > 0)
// {
//    Console.WriteLine($"Your age ({age}) is valid.");
// }
// else
// {
//    Console.WriteLine("Invalid age entered. Please enter a positive number.");
// }

#endregion

#region Problem 9: Prefix vs. Postfix Increment/Decrement

// Problem: Write a program that demonstrates the difference between prefix and postfix
//          increment operators using a variable x.


int num = 5;


// Postfix Increment (num++)
// - Use the current value of 'num' (which is 5) in the Console.WriteLine.
// - THEN, increment 'num' by 1.
Console.WriteLine($"Value with postfix increment (num++): {num++}"); // Prints 5. 'num' is now 6.
Console.WriteLine($"Num after postfix operation: {num}");           // Prints 6.

// Prefix Increment (++num)
// - Increment 'num' by 1 FIRST (so it becomes 7).
// - THEN, use the new value of 'num' (which is 7) in the Console.WriteLine.
Console.WriteLine($"Value with prefix increment (++num): {++num}"); // Prints 7. 'num' is now 7.
Console.WriteLine($"Num after prefix operation: {num}");            // Prints 7.

Console.WriteLine("--- Decrement Demo ---");

// Postfix Decrement (num--)
// - Use the current value of 'num' (which is 7) in the Console.WriteLine.
// - THEN, decrement 'num' by 1.
Console.WriteLine($"Value with postfix decrement (num--): {num--}"); // Prints 7. 'num' is now 6.
Console.WriteLine($"Num after postfix operation: {num}");           // Prints 6.

// Prefix Decrement (--num)
// - Decrement 'num' by 1 FIRST (so it becomes 5).
// - THEN, use the new value of 'num' (which is 5) in the Console.WriteLine.
Console.WriteLine($"Value with prefix decrement (--num): {--num}"); // Prints 5. 'num' is now 5.
Console.WriteLine($"Num after prefix operation: {num}");            // Prints 5.

            #endregion
        }
    }
}
