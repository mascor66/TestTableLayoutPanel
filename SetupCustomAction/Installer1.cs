using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SetupCustomAction
{
    [RunInstaller(true)]
    public partial class Installer1 : System.Configuration.Install.Installer
    {
        public Installer1()
        {
            InitializeComponent();
        }

        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);
        }

        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);
        }

        protected override void OnAfterInstall(IDictionary savedState)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("Notepad.exe");
                startInfo.WindowStyle = ProcessWindowStyle.Normal;

                Process.Start(startInfo);

                //startInfo.Arguments = "www.datalogic.com";
                //Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                //placeholder
            }
            base.OnAfterInstall(savedState);
        }

        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);
        }

        protected override void OnAfterUninstall(IDictionary savedState)
        {
            base.OnAfterUninstall(savedState);
        }
    }
}
