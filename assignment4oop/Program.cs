namespace assignment4oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1
            #region q1
            //Calculator calculator = new Calculator();
            //int sum1 = calculator.Add(5, 10);
            //int sum2 = calculator.Add(1, 2, 3);
            //double sum3 = calculator.Add(4.5, 5.5);

            //Console.WriteLine($"Sum of 5 and 10: {sum1}");     
            //Console.WriteLine($"Sum of 1, 2, and 3: {sum2}");  
            //Console.WriteLine($"Sum of 4.5 and 5.5: {sum3}");
            #endregion
            #region q2
            //Rectangle rect1 = new Rectangle();
            //Rectangle rect2 = new Rectangle(10, 20);
            //Rectangle rect3 = new Rectangle(15);

            //rect1.DisplayDimensions();
            //rect2.DisplayDimensions();
            //rect3.DisplayDimensions();


            #endregion
            #region q3
            //ComplexNumber c1 = new ComplexNumber(4.2, 3.5);
            //ComplexNumber c2 = new ComplexNumber(2.1, 1.7);

            //ComplexNumber sum = c1 + c2;
            //ComplexNumber difference = c1 - c2;

            //Console.WriteLine($"c1: {c1}");
            //Console.WriteLine($"c2: {c2}");
            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Difference: {difference}");
            #endregion
            #region q4
            // Employee employee = new Employee();
            // employee.Work();
            //Manager manager = new Manager();
            // manager.Work();
            #endregion
            #endregion
            #region part 2

            #region 1 
            //Duration duration = new Duration(2, 30, 45);
            //duration.DisplayDuration();
            #endregion
            #region 2
            //Duration duration1 = new Duration(2, 30, 45);
            //Duration duration2 = new Duration(2, 30, 45);
            //Duration duration3 = new Duration(1, 15, 30);

            //Console.WriteLine(duration1.ToString()); 

            //Console.WriteLine(duration1.Equals(duration2)); 
            //Console.WriteLine(duration1.Equals(duration3)); 

            //Console.WriteLine(duration1.GetHashCode()); 
            //Console.WriteLine(duration2.GetHashCode()); 
            //Console.WriteLine(duration3.GetHashCode()); 

            #endregion
            #region 3
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString()); 

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString()); 

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString()); 

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString()); 
            #endregion
            #endregion
        }
    }
} 
    

