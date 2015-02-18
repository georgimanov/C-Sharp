/*09. Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©
  © ©
 ©   ©
© © © ©
Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and the console font.
*/

using System;
using System.Text;
class PrintTriangle
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("   ©");
        Console.WriteLine("  © ©");
        Console.WriteLine(" ©   ©");
        Console.WriteLine("© © © ©");
    }
}

