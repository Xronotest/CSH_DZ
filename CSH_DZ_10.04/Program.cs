namespace CSH_DZ_10._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            int userChoise = Convert.ToInt32(Console.ReadLine());
            if (userChoise == 1)
            {
                Starter.StartGradus();
            }
            else if (userChoise == 2)
            {
                Starter.StartSalary();
            }
            else if (userChoise == 3)
            {
                Starter.StartAnticafe();
            }
        }
    }
}
