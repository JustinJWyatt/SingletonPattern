namespace Singleton  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            Calculator.Instance.ValueOne = 10.5;  
            Calculator.Instance.ValueTwo = 5.5;  
            Console.WriteLine("Addition : " + Calculator.Instance.Addition());  
            Console.WriteLine("Subtraction : " + Calculator.Instance.Subtraction());  
            Console.WriteLine("Multiplication : " + Calculator.Instance.Multiplication());  
            Console.WriteLine("Division : " + Calculator.Instance.Division());  
            Console.WriteLine("\n----------------------\n");  
            Calculate.Instance.ValueTwo = 10.5;  
            Console.WriteLine("Addition : " + Calculator.Instance.Addition());  
            Console.WriteLine("Subtraction : " + Calculator.Instance.Subtraction());  
            Console.WriteLine("Multiplication : " + Calculator.Instance.Multiplication());  
            Console.WriteLine("Division : " + Calculator.Instance.Division());  
            Console.ReadLine();  
        }  
    }  
    public class Calculator  
    {  
        private Calculator()  
        {  
        }  
        private static Calculator instance = null;  
        public static Calculator Instance  
        {  
            get  
            {  
                if (instance == null)  
                {  
                    instance = new Calculator();  
                }  
                return instance;  
            }  
        }  
        public double ValueOne { get; set; }  
        public double ValueTwo { get; set; }  
        public double Addition()  
        {  
            return ValueOne + ValueTwo;  
        }  
        public double Subtraction()  
        {  
            return ValueOne - ValueTwo;  
        }  
        public double Multiplication()  
        {  
            return ValueOne * ValueTwo;  
        }  
        public double Division()  
        {  
            return ValueOne / ValueTwo;  
        }  
    }  
}  
