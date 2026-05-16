using System.IO;
using System.Collections.Generic;
using Microsoft.VisualBasic;

IEnumerable<string> FindFiles(string folderName)
{
  List<string> salesFiles = new List<string>();
  var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);


return salesFiles;
}