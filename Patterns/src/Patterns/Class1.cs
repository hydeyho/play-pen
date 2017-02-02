using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Patterns.Asset;
using Patterns.NewsReader;

namespace Patterns
{
    public class Class1
    {
        public Class1()
        {
            var config = new Config.Config();
            var director = new NewsReaderDirector();
            var asset = AssetEnum.Diagnostic;

            var builderFactory = new NewsReaderBuilderFactory();
            var builder = builderFactory.GetConcreteBuilder(asset, config);
            director.Construct(builder);
            builder.NewsReader.Execute();
        }
    }
}
