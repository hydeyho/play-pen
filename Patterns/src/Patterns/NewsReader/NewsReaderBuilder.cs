using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.NewsReader
{
    public abstract class NewsReaderBuilder
    {
        protected Config.Config Config { get; private set; }
        public NewsReader NewsReader { get; private set; }

        protected NewsReaderBuilder(Config.Config config)
        {
            Config = config;
            NewsReader = new NewsReader();
        }

        public abstract void BuildSaveBookmark();
        public abstract void BuildXsdPath();
        public abstract void BuildAsset();
    }
}
