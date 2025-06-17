namespace MauiApp3.Models;

public class About
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string Message => "App de apuntes de Michelle Reyes";
}