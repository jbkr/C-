using System;
using System.Collections.Generic;
using System.Linq;

public class ActualClass
{
    public string BookName { get; set; }
    public string IssuerName { get; set; }
    public DateTime DateOfIssue { get; set; }
    public bool Status { get; set; }
}

class MainApp
{
    static void Main(string[] args)
    {
        var books = new List<ActualClass>
        {
            new ActualClass { BookName = "A", DateOfIssue = new DateTime(2015, 10, 10, 10, 10, 0), IssuerName = "1" },
            new ActualClass { BookName = "B", DateOfIssue = new DateTime(2015, 10, 10, 10, 10, 0), IssuerName = "1" },
            new ActualClass { BookName = "C", DateOfIssue = new DateTime(2015, 10, 10, 10, 10, 0), IssuerName = "1" },
            new ActualClass { BookName = "D", DateOfIssue = new DateTime(2015, 10, 10, 10, 10, 0), IssuerName = "2" },
            new ActualClass { BookName = "E", DateOfIssue = new DateTime(2015, 10, 10, 12, 10, 0), IssuerName = "2" },
            new ActualClass { BookName = "F", DateOfIssue = new DateTime(2015, 10, 10, 12, 10, 0), IssuerName = "2" }
        };

        var result = books.GroupBy(x => new { x.DateOfIssue, x.IssuerName })
                        .Select(b => new
                        {
                            Books = b.Select(bn => bn.BookName).ToList(),
                            // Accessing to DateOfIssue and IssuerName from Key.
                            DateOfIssue = b.Key.DateOfIssue,
                            IssuerName = b.Key.IssuerName
                        });
        foreach (var item in result)
        {
            Console.WriteLine(item.DateOfIssue + "   " + item.IssuerName);
            foreach (var a in item.Books) Console.WriteLine(a);


        }
    }
}
