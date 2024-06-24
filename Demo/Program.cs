namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            #region Comments
            // Single Line Comment 

            /*
             * Multi
             * Line
             * Comment
             * */
            #endregion

            #region VariableDecleration
            //int Id = 10;

            //// PascalCase -> FirstName
            //// camelCase  -> firstName

            //Console.WriteLine(Id); 
            #endregion

            #region ValueType
            //int X;
            ////CLR Will Allocate 4 UnIntialized Bytes At Stack
            //// int : C# Keyword

            //X = 5;

            //Int32 Y = 10;
            ////CLR Will Allocate 4 UnIntialized Bytes At Stack
            //// int : BCL

            //Y = X; // 5
            //X++; // 6
            //Console.WriteLine(Y); 
            #endregion

            #region ReferanceType

            //Point P1;

            //P1 = new Point(); /* Has 2 Referances [P1 , P2] */

            ////Console.WriteLine(P1.X);
            ////Console.WriteLine(P1.Y);

            //Point P2;

            //P2 = new Point(); /* Unreachable Object */

            //P2 = P1;

            //P2.X = 10;

            //Console.WriteLine(P1.X);

            #endregion

            #region FractionAndDiscard
            //float X = 2.223f;
            //double Y = 3.456;
            //decimal Z = 5.2324m;

            ////Discard
            //long Number = 100_000_000_000;

            //Console.WriteLine(Number); 
            #endregion

            #region ImplicitVsExplicitCasting

            ///int X = 8;
            ///long Y = /*(long)*/ X;  // 1. Implicit Casting [Safe Casting]

            ///long X = 8134141414;
            ///checked
            ///{
            ///    int Y = (int) X;  // 2. Explicit Casting [Unsafe Casting] 
            ///    unchecked
            ///    {
            ///        Console.WriteLine(Y);   
            ///    }
            ///}

            #endregion

            #region Convert

            //// Convert : is a class Containing Set Of Methods Used For Casting From Datatype To Another 
            //Console.Write("Please Enter Your Name : ");
            //string Name = Console.ReadLine() ?? "NA";
            //Console.Write("Please Enter Your Age : ");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please Enter Your Salary : ");
            //decimal Salary = Convert.ToInt32(Console.ReadLine());

            //Console.Clear();
            //Console.Beep(324, 2000);

            //Console.WriteLine($"YourName is {Name}");
            //Console.WriteLine($"YourAge is {Age}");
            //Console.WriteLine($"YourSalary is {Salary}");
            #endregion

            #region Parse

            //// Parse : is A Method Used For Casting From String To The Caller DataType 
            //Console.Write("Please Enter Your Name : ");
            //string Name = Console.ReadLine() ?? "NA";
            //Console.Write("Please Enter Your Age : ");
            //int Age = int.Parse(Console.ReadLine());
            //Console.Write("Please Enter Your Salary : ");
            //decimal Salary = decimal.Parse(Console.ReadLine());

            //Console.Clear();
            //Console.Beep(324, 2000);

            //Console.WriteLine($"YourName is {Name}");
            //Console.WriteLine($"YourAge is {Age}");
            //Console.WriteLine($"YourSalary is {Salary}");

            #endregion

            #region Operators

            #region UnaryOpertors

            //int X = 10;
            //// 1. ++
            //// 1.1 prefix [increment then print]
            //Console.WriteLine(++X); // 11
            //// 1.2 postfix [print then increment]
            //Console.WriteLine(X++); // 10

            //// 2. --
            //// 2.1 prefix [Decrement then print]
            //Console.WriteLine(--X); // 9
            //// 2.2 postfix [print then Decrement]
            //Console.WriteLine(X--); // 10

            #endregion

            #region BinaryOperators

            //int Sum , Sub , Num01=2, Num02=6;
            //Sum = Num01 + Num02;
            //Sub = Num01 - Num02;

            #endregion

            #region AssignmentOperators

            //int X = 2;

            //X += 3;    // X = X + 3
            //X -= 3;    // X = X - 3
            //X *= 3;    // X = X * 3
            //X /= 3;    // X = X / 3
            //X %= 3;    // X = X % 3

            #endregion

            #region RelationalOperators

            //int X = 4, Y = 5;

            //Console.WriteLine(X == Y); //Equal
            //Console.WriteLine(X != Y); //NotEqual 
            //Console.WriteLine(X >= Y); //GreaterThan or equal 
            //Console.WriteLine(X <= Y); //LessThan or equal 
            //Console.WriteLine(X > Y);  //GreaterThan
            //Console.WriteLine(X < Y);  //LessThan


            #endregion

            #region LogicalOpertors

            //Console.WriteLine(!false); //true
            //Console.WriteLine(true && false); //false
            //Console.WriteLine(true || false); //true


            #endregion

            #endregion

            #region OperatorsPeriority
            ///*
            // 1. unary operators
            // 2. round braces
            // 3. * / %
            // 4. + -
            // */

            //int Equation = 4 + 3 * 5;
            //Console.WriteLine(Equation);

            #endregion

            #region TryParse

            //Console.Write("Please Enter Your Name : ");
            //string Name = Console.ReadLine() ?? "NA";
            //Console.Write("Please Enter Your Age : ");
            //int.TryParse(Console.ReadLine() ?? "0", out int Age);
            //Console.Write("Please Enter Your Salary : ");
            //decimal.TryParse(Console.ReadLine() ?? "0", out decimal Salary);

            //Console.Clear();
            //Console.Beep(324, 2000);

            //Console.WriteLine($"YourName is {Name}");
            //Console.WriteLine($"YourAge is {Age}");
            //Console.WriteLine($"YourSalary is {Salary}");


            #endregion

            #region StringFormating
            //int X = 3;
            //int Y = 5;

            //string Message = "Equation : " + X + " + " + Y + " = " + (X + Y);

            //// 1. Composite Formatting
            //Message = string.Format("Equation : {0} + {1} = {2}", X, Y, (X + Y));

            //// 2.String Interpolation
            //Message = $"Equation : {X} + {Y} = {X + Y}";

            //Console.WriteLine(Message);
            #endregion
        }
    }
}
