namespace Plugins.Plugins
{
    public interface IPluginsConvention
    {
        string PluginName { get; }
        UserControl GetControl { get; }

        PluginsConventionElement GetElement { get; }

        Form GetForm(PluginsConventionElement element);

        bool DeleteElement(PluginsConventionElement element);

        void ReloadData();

        bool CreateImageDoc(PluginsConventionSaveDocument saveDocument);

        bool CreateTableDoc(PluginsConventionSaveDocument saveDocument);

        bool CreateChartDoc(PluginsConventionSaveDocument saveDocument);
    }
}
