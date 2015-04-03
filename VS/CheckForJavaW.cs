using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class CheckForJavaW : Component
    {
        string currentIcon = "";

        public CheckForJavaW()
        {
            InitializeComponent();
        }

        public CheckForJavaW(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string icon = "";

            int sessionId = Process.GetCurrentProcess().SessionId;
            int numberofinstances = 0;

            Process[] processes = Process.GetProcessesByName("javaw");

            foreach (Process javaw in processes)
            {
                if (javaw.SessionId == sessionId)
                { numberofinstances = numberofinstances + 1;  }
            }

            if (numberofinstances > 9)
            {
                numberofinstances = 9;
            }

            icon = Path.Combine (new FileInfo (Application.ExecutablePath).Directory.FullName,
                                 "Icons",
                                 String.Format(@"Iconarchive-Red-Orb-Alphabet-Number-{0}.ico", numberofinstances));

            if (icon != currentIcon)
            {
                notifyIcon1.Icon = new System.Drawing.Icon(icon);
                notifyIcon1.Visible = true;
                
                currentIcon = icon;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Process.Start("taskmgr");
        }

        public void Exit()
        {
            notifyIcon1.Visible = false;
            this.components.Dispose();
        }
    }
}
