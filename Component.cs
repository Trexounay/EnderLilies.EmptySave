using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace EnderLilies.EmptySave
{
    class Component : LogicComponent
    {
        public static string Name = "Ender Lilies Empty Save";
        public override string ComponentName => Component.Name;
        ComponentSettings _settings;
        LiveSplitState _state;

        public Component(LiveSplitState state)
        {
            _state = state;
            _settings = new ComponentSettings();
            state.OnReset += State_OnReset;
            ContextMenuControls = new Dictionary<string, Action>();
        }

        void State_OnReset(object sender, TimerPhase value)
        {
            if (_settings.AutoOnReset)
                NewEmptySave();
        }

        public override void Dispose()
        {
            _settings.Dispose();
            _state.OnReset -= State_OnReset;
        }

        public override XmlNode GetSettings(XmlDocument document)
        {
            var a = _settings.GetSettings(document);
            ContextMenuControls.Clear();
            ContextMenuControls.Add("Empty save file on Slot " + (_settings.SlotNumber + 1).ToString(), NewEmptySave);

            return a;
        }

        public override Control GetSettingsControl(LayoutMode mode)
        {
            return _settings;
        }

        public override void SetSettings(XmlNode settings)
        {
            _settings.SetSettings(settings);
        }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
        }

        void NewEmptySave()
        {
            var directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "EnderLilies", "Saved", "SaveGames");
            if (Directory.Exists(directory))
                File.WriteAllBytes(Path.Combine(directory, "GameSlot_" + _settings.SlotNumber.ToString() + ".sav"), Resources.GameSlot);
        }
    }
}
