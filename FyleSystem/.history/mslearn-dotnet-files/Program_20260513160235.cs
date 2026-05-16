using System.IO;
using System.Collections.Generic;

IEnumerable<string> FindFiles(string folderName)
{
  List<string> salesFiles = Directory.EnumerateFile(folderName, "*", SearchOption.AllDirectories);
}