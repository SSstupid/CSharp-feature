//Top level Statements
//Step1 Syntax sugar
using static System.Console;
  
  class Program
{
    static void Main()
    {
        WriteLine("Hello World!");
    }
}

//Step2
/*using static System.Console;

WriteLine("Hello World!");*/

//Step3
//System.Console.WriteLine("Hello World!");

//System.Console.WriteLine($"Hello {args [0]}"); // property => Debug => Application arguments 설정해야됨
//Task.Delay(1000);  // 최상위문은 기본적으로 동기(async)
//await Task.Delay(1000);


//Step1 Record
/*
var sponsor = new Sponsor
{
    Id = 0,
    DisplayName = "HotBlue"
};
sponsor.DisplayName = "RedPuls";  // mutable => init =>immutable
DisplayData(sponsor);

static void DisplayData(Sponsor sponsor) =>
System.Console.WriteLine($"{sponsor.Id} - {sponsor.DisplayName}");

struct Sponsor
{
    public int Id { get; set; }
    public string DisplayName { get; set; }
}*/


//Step2
/*class Sponsor
{
    public int Id { get; init; }        //immutable 초기화 이휴 Value 값 변경 불과
    public string DisplayName { get; init; }
}*/

//Step3
/*var subcriber = new Subscriber("record", 5);
var (title, duration) = subcriber;      //Deconstruct
System.Console.WriteLine($"{title} - {duration}");
record Subscriber(string Title, int Duration);*/

//Step4
/*var subcriber = new Subscriber { Title = "record", Duration = 2 };
var gold = subcriber with { Title = "Gold"};        //immutable일 때 재설정하는 법
System.Console.WriteLine(gold);

record Subscriber
{
    public string Title { get; init; }
    public int Duration { get; init; }
} // Simple Syntax suger => record Subscriber(string Title, int Duration)*/


//Step5
/*var subcriber = new Subscriber ("record", 2, true);
var gold = subcriber with { Title = "Gold" };        //immutable일 때 재설정하는 법
System.Console.WriteLine(gold);
var (title, duration, isAvailable) = subcriber;      //Deconstruct
System.Console.WriteLine($"{title} - {duration} - {isAvailable}");


//++ Pattern Matching
record Subscriber(string Title, int Duration, bool IsAvailable); // Syntax Sugar init 속성을 가짐
record Visual(string Title, int Duration, bool IsAvailable)
    : Subscriber(Title, Duration, IsAvailable);
record Studio : Subscriber
{
    public Studio(string Title, int Duration, bool IsAvailable) :
        base(Title, Duration, IsAvailable)
    { }
}*/


// Pattern Matching
// Step1
/*var subcriber = new Subscriber("record", 2, true);

//var membership = subcriber with { Title = "Gold" };
//Subscriber membership = new Studio("record", 2, true);
var membership = new Subscriber("Diamond", 3, true);
var membershipDecription = membership switch
{
    //("Gold", var d, var i) => $"Gold - {d} - {i}",
    //(Subscriber and (_,1,true)) or (Studio and {Duration: 2}) => "", // Parenthesized Pattern : and와 or 사용
    // Subscriber => "Subscriber Membership" // Type Pattern 
    Subscriber and {Title : "Diamond"} => "Diamond Membership",
    Subscriber and (_, 1, true) => "IsMembership true", 
    //Subscriber and (_, < 1, true) => "Expire Soon",// Relational Pattern 1보다 작은 경우
        //C# 8.0 경우 Subscriber sub when sub.Duration < 1 => $"{sub.Title} Membership < 1"
        //C# 8.0 경우 Subscriber sub => $"{sub.Title} Membership"
    not Subscriber => "No problem",
    _ => "No Membership"    //Default Case
};

record Subscriber(string Title, int Duration, bool IsAvailable); // Syntax Sugar init 속성을 가짐
record Visual(string Title, int Duration, bool IsAvailable)
    : Subscriber(Title, Duration, IsAvailable);
record Studio : Subscriber
{
    public Studio(string Title, int Duration, bool IsAvailable) :
        base(Title, Duration, IsAvailable)
    { }
}*/
