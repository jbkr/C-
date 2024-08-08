// generic
// 기능이 같고 자료형만 다른 경우
// generic collection

class Program
{
    void CopyArray(int[] source, int[] target)
    {
        for (int i = 0; i < source.Length; i++)
        {
            target[i] = source[i];
        }
    }

    void CopyArray(float[] source, float[] target)
    {
        for (int i = 0; i < source.Length; i++)
        {
            target[i] = source[i];
        }
    }

    static void CopyArray<T>(T[] source, T[] target)       // generic programming ( generic method )
    {
        for (int i = 0; i < source.Length; i++)
        {
            target[i] = source[i];
        }
    }

    class ClassData
    {
        public int Value;
        public ClassData(int value)
        {
            this.Value = value;
        }
    }

    class ClassData<T>
    {
        public T Value;
        public ClassData(T value)
        {
            this.Value = value;
        }
    }

    static void Main(string[] args)
    {
        int[] source = { 1, 2, 3 };
        int[] target = { 0, 0, 0 };
        CopyArray<int>(source, target);

        char[] source2 = { '1', '2', '3' };
        char[] target2 = { '0', '0', '0' };
        CopyArray<char>(source2, target2);

        ClassData classData = new ClassData(1); //int
        ClassData<string> classData1 = new ClassData<string>("adfjals");    //string
    }
}













