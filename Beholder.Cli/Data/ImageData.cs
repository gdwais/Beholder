using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.ML.Data;

namespace Beholder.Cli.Data
{
    public class ImageData
    {
        [LoadColumn(0)]
        public string ImagePath;
    
        [LoadColumn(1)]
        public string Label;

        public static IEnumerable<ImageData> ReadFromFile(string imageFolder)
            => Directory.GetFiles(imageFolder)
            .Where(path => Path.GetExtension(path) != ".md")
            .Select(path => new ImageData 
            {
                ImagePath = path,
                Label = Path.GetFileName(path)
            });
    }    
}