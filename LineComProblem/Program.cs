namespace LineComProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LineCompProblem lineCompProblem = new LineCompProblem(1, 2, 3, 4);
            double line1= lineCompProblem.CalculateLength();
            Console.WriteLine("length of the first line"+line1);
            LineCompProblem lineCompProblem2 = new LineCompProblem(1, 2, 3, 4);
            double line2 = lineCompProblem.CalculateLength();
            Console.WriteLine("length of the first line" + line2);
            if (line1.CompareTo(line2) == 0)
            {
                Console.WriteLine("both lines are same");
            }
            if (line1.CompareTo(line2) > 0)
            {
                Console.WriteLine("lin1 is grater than line2");
            }
            else
            {
                Console.WriteLine("line2 is grater than line1");
            }
        }
    }
}