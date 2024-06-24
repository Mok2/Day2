namespace Assighnmet
{
    internal class Program
    {
        static void Main()
        {
            #region 1-	Write a program that allows the user to enter a number then print it.
            //Console.Write("Please Enter Num:");
            //int Num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The Num You Enter Is {Num}");
            #endregion

            #region 2-	Write C# program that Convert a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            //Console.WriteLine(Convert.ToInt32("Mok12"));
            ////String Will Not Convert Casue Its not A Numeric String

            #endregion

            #region 3-	Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //double num1 = 10.5;
            //double num2 = 4.2;
            //double result = num1 + num2;
            //Console.WriteLine($"Result = {result}");
            ////Program Will Run Without Any Erorr
            #endregion

            #region 4-	Write C# program that Extract a substring from a given string.
            //string Name = "Ibrahim Mokhtar";
            //Console.WriteLine(Name.Substring(0,5));
            #endregion

            #region 5-	Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            // int Num1;
            // Num1 = 5;
            // int Num2 = 10;
            // Num2 = Num1; // =5
            // Num1 = 3;
            // Console.WriteLine(Num1);  // =3
            // Console.WriteLine(Num2);  // =5
            //// We Equal The value in Number1 with Num2 and  changes to Num2 doesn't not affect Num1 and Opposite
            #endregion

            #region 6-	Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //Point P1;
            //P1 = new Point();  
            //Point P2;        
            //P2 = P1!; // We Assign the Address in P! from P2
            //P1.X = 10;

            //Console.WriteLine(P1.X); // =10
            //Console.WriteLine(P2.X); // =10

            //// We Assign the Address in P1 from P2 and lost the current Address after modifying  And If you change in any Point[P1 , P2 ] Will Affect to Another Point .
            #endregion

            #region 7-	Write C# program that take two string variables and print them as one variable 
            //string FristName = "Ibrahim";
            //string LastName = "Mokhtar";
            //Console.WriteLine($"FullName Is \"{FristName+" "+LastName}\"");
            #endregion

            #region 8-	Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is  Interest = (principal * rate * time) / 100.
            //Console.Write("Enter principal:");
            //double Princaple = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter rate:");
            //double Rate = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter time:");
            //double Time = Convert.ToDouble(Console.ReadLine());

            //double Interests = (Princaple * Rate * Time) / 100;
            //Console.WriteLine(Interests);
            #endregion

            #region 9-	Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI isBMI = (Weight) / (Height * Height)
            //Console.Write("Enter Weight:");
            //double Weight = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter Hight:");
            //double Hight = Convert.ToDouble(Console.ReadLine());
            //double BMR = (Weight)/ (Hight * Hight);
            //Console.WriteLine(BMR);
            #endregion

            #region 10-	Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".
            //Console.Write("Please Enter Tempereture Degree :");
            //double.TryParse(Console.ReadLine() ?? "0", out double TempDeg);
            //string TempState = TempDeg < 10 ? "Just Cold" : TempDeg > 30 ? "Just Hot" : "Just Good";
            //Console.WriteLine($"Tempereture Status Is {TempState}");

            #endregion

            #region 11-	Write a program that takes the date from user and displays it in various formats using string interpolation.
            //Console.Write("Please Enter Day :");
            //int.TryParse(Console.ReadLine() ?? "0", out int Day);

            //Console.Write("Please Enter Month :");
            //int.TryParse(Console.ReadLine() ?? "0", out int Month);

            //Console.Write("Please Enter Year :");
            //int.TryParse(Console.ReadLine() ?? "0", out int Year);

            //Console.Clear();

            //Console.WriteLine($"Enter Date Is : {Day} , {Month} , {Year}");
            //Console.WriteLine($"Enter Date Is : {Day} - {Month} - {Year}");
            //Console.WriteLine($"Enter Date Is : {Day} / {Month} / {Year}");
            #endregion

            #region 12 - What is the output of the following C# code?
            //Answer IS {C}
            #endregion

            #region 13-	Which of the following statements is correct about the C#.NET code snippet given below?
            //Answer IS {F}
            #endregion

            #region 14-	Which of the following is the correct output for the C# code given below?
            //Answer IS {D}
            #endregion

            #region 15-What will be the output of the C# code given below?
            //Answer IS {D}
            #endregion
        }
    }
}
