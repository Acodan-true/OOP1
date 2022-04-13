namespace OPP1
{
    public class NumberGenerator : INumberGenerator
    {
        public int Generate()
        {
            Random rnd = new Random();
            //Получить случайное число (в диапазоне от 1 до 100)
            return rnd.Next(1, 100);
        }
    }
}
