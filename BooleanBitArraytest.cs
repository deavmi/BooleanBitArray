public class BooleanBitArrayTest
{
public static void Main(string[] args)
{
    //Testing
            CompressedBoolean j = new CompressedBoolean();
            Console.Out.WriteLine(j.getBoolean(0));
            Console.Out.WriteLine(j.getBoolean(1));
            Console.Out.WriteLine(j.getBoolean(2));
            Console.Out.WriteLine(j.getBoolean(3));
            Console.Out.WriteLine(j.getBoolean(4));
            Console.Out.WriteLine(j.getBoolean(5));
            Console.Out.WriteLine(j.getBoolean(6));
            Console.Out.WriteLine(j.getBoolean(7));

            j.setBoolean(0,true);
            Console.Out.WriteLine(j.getBoolean(0));
            Console.Out.WriteLine(j.getBoolean(1));

            j.setBoolean(1,true);
            Console.Out.WriteLine(j.getBoolean(0));
            Console.Out.WriteLine(j.getBoolean(1));
}
}