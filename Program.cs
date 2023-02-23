namespace HelloWorld //A namespace is a declarative region that provides a scope to the identifiers (the names of types, functions, variables, etc) inside it
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello, World!");

            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'a';
            String firstName = "Jason";
            bool isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0}, {1}", byte.MinValue, byte.MaxValue); // format strings
            Console.WriteLine("{0}, {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f;

            // implicit type conversion
            byte b = 1; //00000001
            int i = b;  //00000000 00000000 00000000 00000001

            int i1 = 1;
            float f = i1;

            // explicit type conversion
            int i2 = 1;
            // byte b1 = i2; won't compile
            byte b1 = (byte)i2; // explicit casting

            float f1 = 1.0f;
            int i3 = (int)f1;

            // non-compatible types
            string s = "1";
            // int i4 = (int)s; won't compile
            // workaround
            int i5 = Convert.ToInt32(s); // convert methods: toByte(), toInt16() short, toInt32() int, toInt64() long
            int j = int.Parse(s);

            byte b2 = 1;
            int i6 = b2;
            Console.WriteLine(i6);

            int i7 = 1;
            byte b3 = (byte)i7;
            Console.WriteLine(b3);

            try
            {
                int number1 = 1234;
                byte b4 = Convert.ToByte(number1);
                Console.WriteLine(b4);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            try
            {
                string str = "true";
                bool b5 = Convert.ToBoolean(str);
                Console.WriteLine(b5);
            }
            catch (Exception)
            {
                Console.WriteLine("The string could not be converted to a boolean.");
            }

            var a = 1;
            var bee = 2;
            var c = 3;
            Console.WriteLine(c > bee && c > a);
        }
    }
}