using LiveSplit.Model;
using LiveSplit.UI;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace EnderLilies.EmptySave
{
    public partial class ComponentSettings : UserControl
    {
        int _slotNumber;
        public int SlotNumber
        {
            get
            {
                return _slotNumber;
            }
            set
            {
                _slotNumber = value;
                for (int i = 0; i < slotsContainer.Controls.Count; ++i)
                    ((RadioButton)slotsContainer.Controls[i]).Checked = i == value;
            }
        }
        public bool AutoOnReset
        {
            get;
            set;
        }

        public ComponentSettings()
        {
            InitializeComponent();
            autoOnReset.DataBindings.Add("Checked", this, "AutoOnReset", false, DataSourceUpdateMode.OnPropertyChanged, true);

            gameSlot1.CheckedChanged += GameSlot_CheckedChanged;
            gameSlot2.CheckedChanged += GameSlot_CheckedChanged;
            gameSlot3.CheckedChanged += GameSlot_CheckedChanged;

            this.Dock = DockStyle.Fill;
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            XmlElement settings_node = document.CreateElement("Settings");
            settings_node.AppendChild(SettingsHelper.ToElement(document, "SlotNumber", SlotNumber));
            settings_node.AppendChild(SettingsHelper.ToElement(document, "AutoOnReset", AutoOnReset));
            return settings_node;
        }

        private void GameSlot_CheckedChanged(object sender, EventArgs e)
        {
            var button = ((RadioButton)sender);
            if (button.Checked)
                SlotNumber = button.Parent.Controls.IndexOf(button);
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement)node;
            Version version = SettingsHelper.ParseVersion(element["Version"]);
            SlotNumber = SettingsHelper.ParseInt(element["SlotNumber"], 0);
            AutoOnReset = SettingsHelper.ParseBool(element["AutoOnReset"], false);
        }
    }
}
