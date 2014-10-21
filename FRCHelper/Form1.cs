using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRCHelper
{
    public partial class FRCHelperForm : Form
    {
        GsFrcApiCommunicator api;
        public FRCHelperForm()
        {
            api = new GsFrcApiCommunicator();
            InitializeComponent();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();

            eventComboBox.DataSource = Properties.Settings.Default.eventCodes;
        }

        private void FRCHelperForm_Load(object sender, EventArgs e)
        {            
            eventComboBox.DataSource = Properties.Settings.Default.eventCodes;
        }

        private void eventComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventNameBox.Text = Properties.Settings.Default.eventNames[eventComboBox.SelectedIndex];
        }

        private void getEventDataButton_Click(object sender, EventArgs e)
        {
            FRCEvent evt = new FRCEvent();

            FRCEventListingResponse response = api.getEventListing(2014, eventComboBox.Text, "", false);
            evt = response.Events.First();

            eventTypeBox.Text = evt.type;
            eventDistrictCodeBox.Text = evt.districtCode;
            eventVenueBox.Text = evt.venue;
            eventLocationBox.Text = evt.location;
            eventStartDateBox.Text = evt.dateStart;
            eventEndDateBox.Text = evt.dateEnd;

            FRCTeamListingResponse teamResponse = api.getTeamListing(2014, eventComboBox.Text);

            teamComboBox.Items.Clear();

            foreach (FRCTeam team in teamResponse.teams)
            {
                teamComboBox.Items.Add(team.number);
            }
        }

        private void getTeamInfoButton_Click(object sender, EventArgs e)
        {
            FRCTeamListingResponse response = api.getTeamListing(2014, Convert.ToInt16(teamComboBox.Text));

            FRCTeam team = response.teams.First();

            teamFullNameBox.Text = team.nameFull;
            teamShortNameBox.Text = team.nameShort;
            teamNickNameBox.Text = team.nameNick;
            teamLocationBox.Text = team.location;
            teamRookieYearBox.Text = team.rookieYear.ToString();
            teamDistrictCodeBox.Text = team.districtCode;
        }
    }
}
