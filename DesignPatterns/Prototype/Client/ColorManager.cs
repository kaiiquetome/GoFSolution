using Prototype.Prototype;
using System.Collections.Generic;

namespace Prototype.Client
{
    /// <summary>
    /// Prototype manager
    /// </summary>
    public class ColorManager
    {
        private Dictionary<string, ColorPrototype> colors =
            new Dictionary<string, ColorPrototype>();
        // Indexer
        public ColorPrototype this[string key]
        {
            get { return colors[key]; }
            set { colors.Add(key, value); }
        }
    }
}
