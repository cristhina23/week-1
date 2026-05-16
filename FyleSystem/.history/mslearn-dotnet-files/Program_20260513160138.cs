using System.IO;
using System.Collections.Generic;

IEnumerable<string> FindFiles(string folderName)
{
  List<string> salesFiles = Directory.EnumerateFileSystemEntries(folderName)
}