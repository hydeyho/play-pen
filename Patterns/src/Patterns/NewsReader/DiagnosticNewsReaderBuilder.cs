using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Patterns.Asset;

namespace Patterns.NewsReader
{
    public class DiagnosticNewsReaderBuilder : NewsReaderBuilder
    {
        public DiagnosticNewsReaderBuilder(Config.Config config) : base(config)
        {
        }

        public override void BuildXsdPath()
        {
            NewsReader.XsdPath = "DiagnosticXsdPath";
        }

        public override void BuildAsset()
        {
            NewsReader.Asset = new DiagnosticAsset();
        }

        public override void BuildSaveBookmark()
        {
            NewsReader.SaveBookmark = true;
        }
    }
}
