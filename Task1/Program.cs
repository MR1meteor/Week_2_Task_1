namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "Сейчас", "будут", "происходить", "абсолютно", "непонятные", "вещи." };
            bool boolVar;

            try
            {
                boolVar = Convert.ToBoolean(array);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Oops, Ваш код - дерьмо: {e.Message}");
            }
        }
    }
}