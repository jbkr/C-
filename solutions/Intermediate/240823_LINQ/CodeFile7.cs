// 변환 연산자 Conversion Operators
/// <summary>
/// ToList, ToArray, ToDictionary
/// 
/// LINQ 구문은 IEnumerable 인터페이스를 반환
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        string[] words = { "cherry", "apple", "blueberry" };
        var sortedWords = from w in words
                          orderby w
                          select w;
        //IEnumerable<string>

        //List<string>
        var wordList = sortedWords.ToList();
        wordList.Add("adadfaf");
    }
}