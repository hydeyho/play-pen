using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Patterns.Asset;

namespace Patterns.NewsReader
{
    public class FuelNewsReaderBuilder : NewsReaderBuilder
    {
        public FuelNewsReaderBuilder(Config.Config config) : base(config)
        {
        }

        public override void BuildSaveBookmark()
        {
            NewsReader.SaveBookmark = false;
        }

        public override void BuildXsdPath()
        {
            NewsReader.XsdPath = "FuelXsdPath";
        }

        public override void BuildAsset()
        {
            NewsReader.Asset = new FuelAsset();
        }
    }
}
