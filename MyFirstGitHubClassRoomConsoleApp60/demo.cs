namespace MyFirstGitHubClassRoomConsoleApp60;

public class demo
{
    public string Name { get; private set; }
    public int YearOfBirth { get; private set; }

    public demo(string name, int yearOfBirth)
    {
        Name = name;
        YearOfBirth = yearOfBirth;
    }
}