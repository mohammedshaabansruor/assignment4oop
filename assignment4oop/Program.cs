namespace assignment4oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            Rectangle rect1 = new Rectangle();
            Rectangle rect2 = new Rectangle(10, 20);
            Rectangle rect3 = new Rectangle(15);
   
            rect1.DisplayDimensions();
            rect2.DisplayDimensions(); 
            rect3.DisplayDimensions(); 
        }
        #endregion
    }
    
}
