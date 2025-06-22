using System;
using System.Collections.Generic;

public class ProxyImage : Image
{
    private string _fileName;
    private static Dictionary<string, RealImage> _cache = new();

    public ProxyImage(string fileName)
    {
        _fileName = fileName;
    }

    public void Display()
    {
        if (!_cache.ContainsKey(_fileName))
        {
            Console.WriteLine("Image not in cache. Loading...");
            _cache[_fileName] = new RealImage(_fileName);
        }
        else
        {
            Console.WriteLine("Image loaded from cache.");
        }

        _cache[_fileName].Display();
    }
}
