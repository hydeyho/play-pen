using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Patterns.Asset;

namespace Patterns.NewsReader
{
    public class NewsReader
    {
        public string XsdPath { get; set; }
        public bool SaveBookmark { get; set; }
        public IAsset Asset { get; set; }

        public void Execute()
        {
            // TODO add execution
            Asset.Run();
        }
    }
}
