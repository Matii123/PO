using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IEngineFactory
    {
        IEngine MakeEngine(string name);
    }

    public class EngineFactory : IEngineFactory
    {
        private readonly Dictionary<string, IEngine> engines = new Dictionary<string, IEngine>()
    {
        { "diesel standard", new Diesel136HP() },
        { "diesel automat", new Diesel190HP() },
        { "benzyna biturbo", new BiTurbo240HP() }
    };

        public IEngine MakeEngine(string name)
        {
            IEngine Car;
            this.engines.TryGetValue(name, out Car);
            return Car;
        }
    }
}
