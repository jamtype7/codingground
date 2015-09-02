using System.IO;
using System;

class Foo {
    public delegate void f();
    public f bar;
}

class Program
{
    static void Main()
    {
        Foo foo = new Foo();
        Foo.f xx = () => {
            Console.WriteLine("Hello!");
        };
        foo.bar = xx;
        foo.bar();
        
        foo.bar = () => {
            Console.WriteLine("World!");
        };
    }
}
