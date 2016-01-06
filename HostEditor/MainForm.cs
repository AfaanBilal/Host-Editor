/*
 *    HostEditor V1.0.0
 *    (c) 2012-2016 Afaan Bilal
 *
 */



using System;
using System.Windows.Forms;
using System.IO;

namespace HostEditor
{
    public partial class MainForm : Form
    {
        string hostsFileName = @"C:\Windows\system32\drivers\etc\hosts";
        //string hostsFileName = @"hosts";
        StreamReader hReader;
        StreamWriter hWriter;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            string IpAddr = (tbIpAddr.Text.Trim() != "") ? tbIpAddr.Text.Trim() : null;
            string D = (tbD.Text.Trim() != "") ? tbD.Text.Trim() : null;
            string Alias = (tbAlias.Text.Trim() != "") ? tbAlias.Text.Trim() : null;

            if (IpAddr == null || D == null || Alias == null)
            {
                MessageBox.Show("Please fill up all the fields properly.", "Host Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure to rgister:\nDomain: " + D + "\nIP: " + IpAddr + " ?", "Host Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2).Equals(DialogResult.No))
            {
                return;
            }

            if (File.Exists(hostsFileName) != true)
            {
                MessageBox.Show("The hosts file was not found on your system.", "Host Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            hWriter = new StreamWriter(hostsFileName, true);
            hWriter.WriteLine(IpAddr + "\t\t" + D + "\t\t# " + Alias);
            MessageBox.Show("Your Domain: " + D + " was registered with IP: " + IpAddr, "Host Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            hWriter.Close();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All registered domains will be deleted.\nAre you sure to reset?", "Host Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2).Equals(DialogResult.No))
            {
                return;
            }

            string HostFileOriginalText = @"# Copyright (c) 1993-2009 Microsoft Corp.
#
#   RESET BY: Host Editor (c) 2012-2016 Afaan Bilal
#
# This is a sample HOSTS file used by Microsoft TCP/IP for Windows.
#
# This file contains the mappings of IP addresses to host names. Each
# entry should be kept on an individual line. The IP address should
# be placed in the first column followed by the corresponding host name.
# The IP address and the host name should be separated by at least one
# space.
#
# Additionally, comments (such as these) may be inserted on individual
# lines or following the machine name denoted by a '#' symbol.
#
# For example:
#
#      102.54.94.97     rhino.acme.com          # source server
#       38.25.63.10     x.acme.com              # x client host

# localhost name resolution is handled within DNS itself.
#	127.0.0.1       localhost
#	::1             localhost

";
            hWriter = new StreamWriter(hostsFileName, false);
            hWriter.Write(HostFileOriginalText);
            MessageBox.Show("Your Hosts File has been reset to its original state", "Host Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            hWriter.Close();
        }

        private void btShowHostFile_Click(object sender, EventArgs e)
        {
            hReader = new StreamReader(hostsFileName);
            MessageBox.Show("HOST FILE CONTENTS:\n\n" + hReader.ReadToEnd(), "Host Editor");
            hReader.Close();
        }

        private void btAbout_Click(object sender, EventArgs e)
        {
            Resources.About abt = new Resources.About();
            abt.ShowDialog();
        }

        private void btnRD_Click(object sender, EventArgs e)
        {
            string D = (tbRD.Text.Trim() != "") ? tbRD.Text.Trim() : null;

            if (D == null)
            {
                MessageBox.Show("Please fill up the field properly.", "Host Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you wish to remove " + D + "?", "Host Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2).Equals(DialogResult.No))
            {
                return;
            }

            string hostsFileContents = "";
            bool found = false;

            using (hReader = new StreamReader(hostsFileName))
            {
                hostsFileContents = hReader.ReadToEnd();
                hReader.Close();
            }

            string[] lines = hostsFileContents.Split('\n');
            
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Length > 0 && lines[i][0] == '#') continue;

                if (lines[i].Contains(D))
                {
                    lines[i] = "";
                    found = true;
                    break;
                }
            }
            
            if (!found)
            {
                MessageBox.Show("Your Domain: " + D + " was not found.", "Host Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (hWriter = new StreamWriter(hostsFileName, false))
            {
                foreach (string line in lines)
                {
                    if (line.Length > 0)
                    {
                        hWriter.Write(line);
                        hWriter.Write('\n');
                    }
                }
                
                MessageBox.Show("Your Domain: " + D + " was successfully removed.", "Host Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hWriter.Close();
            }                
        }
    }
}
