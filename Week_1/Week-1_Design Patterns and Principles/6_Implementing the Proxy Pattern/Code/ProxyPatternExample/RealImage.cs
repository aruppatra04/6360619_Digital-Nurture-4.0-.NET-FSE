using System;

public class RealImage : Image
{
    private string _fileName;

    public RealImage(string fileName)
    {
        _fileName = fileName;
        LoadFromServer();
    }

    private void LoadFromServer()
    {
        Console.WriteLine($"Loading image from remote server: {_fileName}");
    }

    public void Display()
    {
        Console.WriteLine($"Displaying image: {_fileName}");
    }
}
