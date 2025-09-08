namespace Task_Extention_Method_Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            // using Extension Method and Lambda Expression and BuildIn Delegate
            double x = 20.5, y = 10.5;
            //double a = 20.5, b = 10.5;

            Func<double , double , double > Add = (x,y)=> x.add(y);
            Func<double , double , double > Sub = (x,y)=> x.sub(y);
            Func<double , double , double > Div = (x,y)=> x.div(y);
            Func<double , double , double > Mul = (x,y)=> x.mul(y);

            Console.WriteLine(Add(x,y));
            Console.WriteLine(Sub(x,y));
            Console.WriteLine(Div(x,y));
            Console.WriteLine(Mul(x,y));

        }
    }
}
