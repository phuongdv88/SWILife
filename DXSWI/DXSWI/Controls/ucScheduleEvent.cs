using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SWIBLL.Models;

namespace DXSWI.Controls
{
    public partial class ucScheduleEvent : DevExpress.XtraEditors.XtraUserControl
    {
        public ScheduleEvent GetScheduleEventFromUI()
        {
            ScheduleEvent ev = new ScheduleEvent();
            ev.Type = cbeType.SelectedIndex;
            ev.Title = teTitle.Text.Trim();
            if (deDate.Text.Length > 0)
            {
                ev.DateTime = DateTime.Parse(deDate.DateTime.ToString("yyyy/MM/dd ") + deTime.Text.Trim());
            }
            if (ceAllDay.Checked)
            {
                ev.Duration = -1;
            }
            else
            {
                ev.Duration = teLenght.SelectedIndex;
            }
            ev.IsPublicEntry = cePublicEntry.Checked;
            ev.Description = meDescription.Text;  
            return ev;
        }

        public void setScheduleEventToUI(ScheduleEvent ev)
        {
            if (ev == null)
                return;
            //todo
            try {
                if (ev.Type > 0 && ev.Type < cbeType.Properties.Items.Count)
                {
                    cbeType.SelectedIndex = ev.Type;
                }
            }
            catch { }
            teTitle.Text = ev.Title;
            deDate.Text = ev.DateTime.ToString("yyyy-MM-dd");
            deTime.Text = ev.DateTime.ToString("hh:mm");
            if(ev.Duration == -1)
            {
                ceAllDay.Checked = true;
            } else
            {
                ceAllDay.Checked = false;
            }
            teLenght.SelectedIndex = ev.Duration;
            cePublicEntry.Checked = ev.IsPublicEntry;
            meDescription.Text = ev.Description;
        }
        public ucScheduleEvent()
        {
            InitializeComponent();
        }

        private void ceAllDay_CheckedChanged(object sender, EventArgs e)
        {
            deTime.Enabled = !ceAllDay.Checked;
            teLenght.Enabled = !ceAllDay.Checked;
        }

        private void cePublicEntry_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
