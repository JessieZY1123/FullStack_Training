namespace Day3_HW;
public class Program {
    public static void Main(string[] args)
    {
        //MethodPractice obj = new MethodPractice();
        //int[] numbers = obj.GenerateNumbers(20);
        //obj.Reverse(numbers);
        //obj.PrintNumbers(numbers);

        //Console.WriteLine(obj.Fibonacci(8));

        // color :
        Color purple = new Color(255, 0, 255);
        Color yellow = new Color(255, 255, 0);
        Color white = new Color(255, 255, 255);
        Color red = new Color(255, 0, 0);
        Color green = new Color(0, 255, 255);
        Color blue = new Color(0, 0, 255);
        Ball ball1 = new Ball(white, 2);
        Ball ball2 = new Ball(red, 4);

        ball1.Throw();
        ball2.Throw();
        ball1.Throw();
        Console.WriteLine($"The ball1 throws {ball1.getTrackTimes()} times, and its size is {ball1.Size} \n " +
            $"the ball2 throws {ball2.getTrackTimes()} times, and its size is {ball2.Size}");

        ball1.Throw();
        ball2.Pop();
        Console.WriteLine($"The ball1 throws {ball1.getTrackTimes()} times, and its size is {ball1.Size} \n " +
            $"the ball2 throws {ball2.getTrackTimes()} times, and its size is {ball2.Size}");
        ball2.Throw();
        ball2.Throw();
        ball2.Throw();
        Console.WriteLine($"The ball1 throws {ball1.getTrackTimes()} times, and its size is {ball1.Size} \n " +
             $"the ball2 throws {ball2.getTrackTimes()} times, and its size is {ball2.Size}");

    }
}
