using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;

namespace FRCHelper
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshEventCodesButton_Click(object sender, EventArgs e)
        {
            GsFrcApiCommunicator communicator = new GsFrcApiCommunicator();
            FRCEventListingResponse eventListing = communicator.getEventListing(2014);//, "CMP", "PNW", true);

            StringCollection eventCodes = new StringCollection();
            StringCollection eventNames = new StringCollection();

            foreach (FRCEvent evt in eventListing.Events)
            {
                eventCodes.Add(evt.code);
                eventNames.Add(evt.name);
            }

            Properties.Settings.Default.eventCodes = eventCodes;
            Properties.Settings.Default.eventNames = eventNames;
            Properties.Settings.Default.Save();
        }
    }
}
