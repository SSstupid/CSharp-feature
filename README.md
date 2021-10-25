# C# 9.0 feature
 ### C# Strategy
 * Evolve and Innovate  (진화 및 혁신)
 * Benefit C# developers (개발자의 이점)
 * Community and Stewardship (커뮤니티 및 관리)      

*******************************

## 간편 구문(Syntactic sugar, Syntax suger)
* 복잡한 코드를 간편하게 처리해주는 구문으로 점진적으로 적용 중
    ```
    System.Console.WriteLine("Hello World!");
    ```
### 최상위 문             
<img src=https://user-images.githubusercontent.com/90036120/138667912-af08a1f7-f6c8-46c9-966a-bc298a6c78a6.JPG width="300" height="240"/> =>
<img src=https://user-images.githubusercontent.com/90036120/138667908-ac88c02e-343f-4962-a85a-d329e2bd3b5b.JPG width="290" height="200"/> =>
![Syntax3](https://user-images.githubusercontent.com/90036120/138668381-6b81e745-113c-41d7-8f1b-e107c690b7ff.JPG)         
      
하나 이상의 cs파일을 둘경우 명확한 Main 메소드를 두어야함.    
이런 최상위 문은 학습할 때 가장 효과가 좋음 => 기본적인 API만 연습하면 됨.    
    
    
### Record    
```
record Sponsor(string Title, int Duration)
```
<img src=https://user-images.githubusercontent.com/90036120/138682160-c2e31cda-5cf3-4904-87d7-4b8f2f30388c.JPG width="300" height="120"/>  =>  <img src=https://user-images.githubusercontent.com/90036120/138682154-a26af696-0a2b-4f46-8bcb-307824efb3ee.JPG width="300" height="25"/>




### Pattern Matching
```
Console.WriteLine(IsLetter('_')); // False
static bool IsLetter(char c) => 
    c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
```


```
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
```
     
*******************************
      
### 개발환경
* Visual Studio 2019 Preview (https://visualstudio.microsoft.com/ko/downloads/)
* .NET CLI(.NET 5.0 SDK)      
dotnet --version    
dotnet --list-sdks    
dotnet new console --help     
dotnet new console -f net5.0      

    
 *********************************************
    
예제는 Program.cs에서 볼수 있습니다.   
.NET Conf 2021 x Seoul을 기반으로 작성했습니다.      
동영상이 아닌지라;;;  간편구문으로 변하는 과정이 난잡하게 보이네요. (┬┬﹏┬┬)  
곧 C# 10.0으로 찾아뵙겠습니다.


참조 : https://devblogs.microsoft.com/dotnet/the-net-language-strategy        
      .NET Conf 2021 x Seoul
