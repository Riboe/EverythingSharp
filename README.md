# EverythingSharp
A simple C# wrapper around the [Everything SDK](https://www.voidtools.com/support/everything/sdk/) from Voidtools.

## Requirements
Everything must be installed and running.

## Usage
The preferred way to use EverythingSharp is to use the fluent API:
```C#
using (EverythingSearcher everything = new EverythingSearcher())
{
    IEnumerable<EverythingEntry> results = everything
        .SearchFor("Visual Studio")
        .OrderBy(Sort.NameAscending)
        .WithResultLimit(10)
        .WithOffset(0)
        .GetFields(RequestFlags.FullPathAndFileName | RequestFlags.RunCount)
        .Execute();
}
```
The calls to `OrderBy`, `WithResultLimit`, `WithOffset`, and `GetFields` are all optional. If omitted, the default values used when searching are:  
`OrderBy` defaults to `Sort.NameAscending`.  
`WithResultLimit` defaults to no limit.  
`WithOffset` defaults to no offset.  
`GetFields` defaults to `RequestFlags.FullPathAndFileName`.  



There's an older way to search, which should be avoided, but is kept for backwards compabatility:
```C#
using(var everything = new Everything())
{
    var query = "Chrome";
    var maxResults = 10;
    var offset = 0;
    var sorting = Sort.SizeDescending;
    var fields = RequestFlags.FullPathAndFileName | RequestFlags.Size;
    
    var results = everything.Search(query, maxResults, offset, sorting, fields);   
}
```
