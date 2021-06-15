using System;
class Logger : ILogger{

    public void Display(string Content){
        Console.WriteLine(Content);
    }
}