// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Isubject subject = new proxy();

subject.DoAction();

public interface Isubject
{
    void DoAction();
}

public class SubjectService : Isubject
{
    public void DoAction()
    {
        Console.WriteLine("main Method");
    }
}
public class proxy : Isubject
{
    private Isubject _subject;
    public void DoAction()
    {
        if (_subject == null)
        {
            _subject = new SubjectService();
        }
        Console.WriteLine("proxy method");
    }
}