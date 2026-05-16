using System.IO;
using System.Collections.Generic;
using Microsoft.VisualBasic;

IEnumerable<string> FindFiles(string folderName)
{
  List<string> salesFiles = 
  VariantType foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

}