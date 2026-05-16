using System.IO;
using System.Collections.Generic;

IEnumerable<string> files = Directory.EnumerateFiles("stores", "*.*", SearchOption.AllDirectories);
foreach (string file in files)
{
  Console.WriteLine(file);
}
