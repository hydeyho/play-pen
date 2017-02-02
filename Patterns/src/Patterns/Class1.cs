using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Patterns.NewsReader;

namespace Patterns
{
    public class Class1
    {
        public Class1()
        {
            NewsReaderBuilder builder;
            var config = new Config.Config();

            var director = new NewsReaderDirector();

            builder = new DiagnosticNewsReaderBuilder(config);
            director.Construct(builder);
            builder.NewsReader.Execute();

            builder = new FuelNewsReaderBuilder(config);
            director.Construct(builder);
            builder.NewsReader.Execute();

            builder = new EventNewsReaderBuilder(config);
            director.Construct(builder);
            builder.NewsReader.Execute();
        }
    }
}
