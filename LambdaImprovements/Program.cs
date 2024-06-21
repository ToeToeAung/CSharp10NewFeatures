using System;
/* Previous version for Lambda  */
//Func<string> welcome = () => "Lambda Improvements";
//Console.WriteLine(welcome);

// Improvement in C# 10 [Required to change LangVersion]
/*<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <LangVersion>10.0</LangVersion>
  </PropertyGroup>

</Project> */

var welcome = () => "Lambda Improvements";
Console.WriteLine(welcome);