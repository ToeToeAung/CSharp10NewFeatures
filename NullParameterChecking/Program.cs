/*In C # 9.0, we can write the null check as below
string? text = null;
SayHello(text);
void SayHello(string message)
{
    if (message is null)
    {
        throw new ArgumentNullException(nameof(message));
    }
    Console.WriteLine(message);
} */

using System.Text;
using System;

string? text = null;
SayHello(text);
void SayHello(string message)
{
    //if(message is null)
    //{
    //    throw new ArgumentNullException(nameof(message));
    //}
    ArgumentNullException.ThrowIfNull(message);
    Console.WriteLine(message);
}