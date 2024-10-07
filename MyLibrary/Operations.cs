namespace MyLibrary
{
    public class Operations
    {
        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        public bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        public double AddDouble(double d1, double d2)
        {
            return d1 + d2;
        }

        public IList<int> GetEvenNumbers(int start, int end)
        {
            /*
            List<int> lista = new List<int>();

            for (int i = start; i < end; i++)
            {
                if (i % 2 == 0)
                {
                    lista.Add(i);
                }
            }
            return lista;
            */

            return Enumerable.Range(start, end).Where(IsEven).ToList();
        }

    }
}
