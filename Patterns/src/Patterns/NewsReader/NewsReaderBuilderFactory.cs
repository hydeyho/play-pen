using System;
using Patterns.Asset;

namespace Patterns.NewsReader
{
    public class NewsReaderBuilderFactory
    {
        public NewsReaderBuilder GetConcreteBuilder(AssetEnum assetEnum, Config.Config config)
        {
            switch (assetEnum)
            {
                case AssetEnum.Diagnostic:
                    return new DiagnosticNewsReaderBuilder(config);
                case AssetEnum.Fuel:
                    return new FuelNewsReaderBuilder(config);
                case AssetEnum.Event:
                    return new EventNewsReaderBuilder(config);
                default:
                    throw new Exception();
            }
        }

    }
}
