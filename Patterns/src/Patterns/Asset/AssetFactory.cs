using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Patterns.Asset;

namespace Patterns.Asset
{
    public class AssetFactory
    {
        public IAsset GetConcreteAsset(AssetEnum assetEnum)
        {
            switch (assetEnum)
            {
                case AssetEnum.Diagnostic:
                    return new DiagnosticAsset();
                case AssetEnum.Fuel:
                    return new FuelAsset();
                case AssetEnum.Event:
                    return new EventAsset();
                default:
                    throw new Exception();
            }
        }

    }
}
