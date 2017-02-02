using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.NewsReader
{
    public class NewsReaderDirector
    {
        public void Construct(NewsReaderBuilder newsReaderBuilder)
        {
            newsReaderBuilder.BuildXsdPath();
            newsReaderBuilder.BuildAsset();
        }
    }
}
