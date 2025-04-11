public class Interpret_
{
    public string Interpret(string command)
    {

        var str1 = command.Replace("()", "o");
        return str1.Replace("(al)", "al");
    }
}