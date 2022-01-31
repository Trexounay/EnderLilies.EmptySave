using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using System.Reflection;


[assembly: ComponentFactory(typeof(EnderLilies.EmptySave.Factory))]

namespace EnderLilies.EmptySave
{
    class Factory : IComponentFactory
    {
        public string ComponentName => Component.Name;

        public string Description => "Create empty save files for Ender Lilies";

        public Version Version => Assembly.GetExecutingAssembly().GetName().Version;

        public ComponentCategory Category => ComponentCategory.Control;

        public string UpdateName => ComponentName;

        public string XMLURL => "https://raw.githubusercontent.com/Trexounay/EnderLilies.EmptySave/master/Update/";

        public string UpdateURL => "https://raw.githubusercontent.com/Trexounay/EnderLilies.EmptySave/master/Update/update.xml";

        public IComponent Create(LiveSplitState state) => new Component(state);
    }
}
