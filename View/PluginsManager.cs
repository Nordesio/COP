using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using Plugins.Plugins;

namespace View
{
    public class PluginsManager
    {
        //Тег, указывающий, что plugins должны быть заполнены CompositionContainer
        [ImportMany(typeof(IPluginsConvention))]
        IEnumerable<IPluginsConvention> plugins { get; set; }

        public readonly Dictionary<string, IPluginsConvention> plugins_dictionary = new Dictionary<string, IPluginsConvention>();

        public PluginsManager()
        {
            AggregateCatalog catalog = new AggregateCatalog();
            //catalog.Catalogs.Add(new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory));
            //catalog.Catalogs.Add(new DirectoryCatalog("C:/Users/vladg/source/repos/Libarary1_COP/Plugins/Interfaces"));
            //catalog.Catalogs.Add(new DirectoryCatalog("C:/Users/vladg/source/repos/Libarary1_COP/Plugins"));
            //catalog.Catalogs.Add(new DirectoryCatalog("C:/Users/vladg/source/repos/Libarary1_COP/Plugins/Plugins"));
            catalog.Catalogs.Add(new DirectoryCatalog("C:/Users/vladg/source/repos/Libarary1_COP/Plugins/bin/Debug/net6.0-windows"));


            //Контейнер композиции
            CompositionContainer container = new CompositionContainer(catalog);
            container.ComposeParts(this);
            if (plugins.Any())
            {
                plugins
                    .ToList()
                    .ForEach(p =>
                    {
                        if (!plugins_dictionary.Keys.Contains(p.PluginName))
                            plugins_dictionary.Add(p.PluginName, p);
                    });
            }
        }
    }
}