# EverythingSharp
A simple C# wrapper around the [Everything SDK](https://www.voidtools.com/support/everything/sdk/) from Voidtools.

## Requirements
Everything must be installed and running.

## Usage
```C#
using(var everything = new Everything())
{
    var query = "Chrome";
    var results = everything.Search(query);
  
    foreach (EverythingResult result in results)
    {
        Console.WriteLine(result.FullPath);
    }
}
```

To control maximum number of results, sorting, and request additional fields:
```C#
var query = "Chrome";
var maxResults = 10;
var sorting = Sort.SizeDescending;
var fields = RequestFlags.FullPathAndFileName | RequestFlags.Size;
var results = everything.Search(query, maxResults, sorting, fields);
```
