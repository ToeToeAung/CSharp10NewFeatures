/*In C# 10, Microsoft has been introduced a new feature to add the reference globally at one place using the keyword “global”. */


/* In C#9,to add the reference System,Text.Json at the beginning of each files
 * using System.Text.Json;
var names = new[] { "Prasad", "Praveen" };
var serialized = JsonSerializer.Serialize(names);
Console.WriteLine(serialized); */

/*We can use global
 we can edit the project file, and add the <ItemGroup> tags
 GlobalUsingDirectives.csproj
 <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net6.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
</PropertyGroup>
       <ItemGroup Condition="'$(ImplicitUsings)'=='true' Or '$(ImplicitUsings)'== 'enable'">
             <Using Include="System.Text.Json"/>
       </ItemGroup>
</Project>

 */

var names = new[] { "Prasad", "Praveen" };
var serialized = JsonSerializer.Serialize(names);
Console.WriteLine(serialized);