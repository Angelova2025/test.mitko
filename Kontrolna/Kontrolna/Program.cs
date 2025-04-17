namespace Kontrolna;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Въведи числа:");
        string input = Console.ReadLine();
        
        int[] numbers = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = input[i] - '0';
        }
        
        int sum = 0;
        int max = numbers[0];
        int countOfNines = 0;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];

            if (numbers[i] > max)
            {
                max = numbers[i];
            }

            if (numbers[i] == 9)
            {
                countOfNines++;
            }
        }
        
        Console.WriteLine("Сума на елементи: " + sum);
        Console.WriteLine("Най-голям елемент: " + max);
        Console.WriteLine("Числото 9 се среща " + countOfNines + " пъти");
    }
}
