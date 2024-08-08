class Program
{
    interface IGenericInterface<T>
    {
        void SetValue(T x);
        string GetValueType();
    }

    class GenericClass<T> : IGenericInterface<T>
    {
        T value;
        public string GetValueType()
        {
            return value.GetType().Name;
        }

        public void SetValue(T x)
        {
            value = x;
        }
    }

    static void Main(string[] args)
    {
        GenericClass<int> genericClass = new GenericClass<int>();
        genericClass.SetValue(1);
        Console.WriteLine(genericClass.GetValueType());

        GenericClass<string> genericClass1 = new GenericClass<string>();
        genericClass1.SetValue("hello");
        Console.WriteLine(genericClass1.GetValueType());
    }
}