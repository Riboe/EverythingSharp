# EverythingSharp
A simple C# wrapper around the [Everything SDK](https://www.voidtools.com/support/everything/sdk/) from Voidtools.

## Requirements
Everything must be installed an running.

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

To control sorting or request additional fields:
```C#
var query = "Chrome";
var sorting = Sort.SizeAscending;
var fields = RequestFlags.FullPathAndFileName | RequestFlags.Size;
var results = everything.Search(query, sorting, fields);
```
