using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace proxifyre_tray
{
    public partial class FormMain : Form
    {
        private static readonly string ProgramName = "ProxiFyre.exe";
        private static readonly string ProgramPath = AppContext.BaseDirectory + ProgramName;
        private static readonly string ConfigName = "app-config.json";
        private static readonly string ConfigPath = AppContext.BaseDirectory + ConfigName;
        private static readonly string[] LogLevels = { "None", "Info", "Deb", "All" };

        private Configuration configuration;
        private Configuration.Proxy proxy;
        private Process proxifyreProcess;

        private bool formVisible = false;

        protected override void SetVisibleCore(bool value)
        {
            if (!formVisible)
            {
                value = false;
            }
            base.SetVisibleCore(value);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.C))
            {
                buttonStop_Click(new object(), new EventArgs());
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public FormMain()
        {
            InitializeComponent();
            Icon = Properties.Resources.icons8_sorting_arrows_32;

            if (!File.Exists(ProgramPath))
            {
                foreach (Control control in this.Controls)
                {
                    control.Enabled = false;
                }
                richTextBoxOutput.AppendText("Couldn't find " + ProgramName + Environment.NewLine + "proxifyre-tray.exe must be inside the ProxiFyre directory to work");
                formVisible = true;
                Show();
                return;
            }

            buttonAbout_Click(new object(), new EventArgs());

            notifyIconTray.Icon = Properties.Resources.icons8_sorting_arrows_grayed_32;

            comboBoxLogLevel.DataSource = LogLevels;

            buttonStop.Enabled = false;

            loadConfig(ConfigPath);

            RegistryKey startupRegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            string startupRegistryValue = (string)startupRegistryKey.GetValue(Application.ProductName);
            if (startupRegistryValue == null)
            {
                toolStripMenuItemStartup.Checked = false;
            }
            else
            {
                if (startupRegistryValue == Application.ExecutablePath)
                {
                    toolStripMenuItemStartup.Checked = true;
                    buttonStart_Click(new object(), new EventArgs());
                }
                else
                {
                    startupRegistryKey.DeleteValue(Application.ProductName, false);
                    toolStripMenuItemStartup.Checked = false;
                }
            }

            if (!toolStripMenuItemStartup.Checked)
            {
                formVisible = true;
                Show();
            }
        }

        private void loadConfig(string fileName)
        {
            if (File.Exists(ConfigPath))
            {
                string configContent = string.Empty;
                try
                {
                    configContent = File.ReadAllText(fileName);
                }
                catch (Exception ex)
                {
                    richTextBoxOutput.AppendText(Environment.NewLine + ex.Message);
                }
                configuration = JsonConvert.DeserializeObject<Configuration>(configContent);
                updateAll();
            }
            else
            {
                configuration = new Configuration()
                {
                    logLevel = LogLevels[0]
                };
            }
        }

        private void updateAll()
        {
            if (configuration.logLevel != null && configuration.logLevel != string.Empty)
            {
                comboBoxLogLevel.Text = configuration.logLevel;
            }
            updateProxies(0);
        }

        private void updateProxies(int selectedIndex)
        {
            proxy = null;
            listBoxProxies.Items.Clear();

            if (configuration.proxies != null)
            {
                for (int index = 0; index < configuration.proxies.Count; index++)
                {
                    proxy = configuration.proxies[index];
                    if (proxy.socks5ProxyEndpoint != null && proxy.socks5ProxyEndpoint != string.Empty)
                    {
                        listBoxProxies.Items.Add(proxy.socks5ProxyEndpoint);
                    }
                    else
                    {
                        configuration.proxies.RemoveAt(index);
                        index--;
                    }
                }
            }
            if (listBoxProxies.Items.Count > 0)
            {
                if (listBoxProxies.Items.Count <= selectedIndex)
                {
                    listBoxProxies.SelectedIndex = listBoxProxies.Items.Count - 1;
                }
                else
                {
                    listBoxProxies.SelectedIndex = selectedIndex;
                }
            }
            else
            {
                updateApps(0);
            }
        }

        private void updateApps(int selectedIndex)
        {
            listBoxApps.Items.Clear();
            textBoxApp.Text = string.Empty;
            if (proxy != null && proxy.appNames != null)
            {
                foreach (string app in proxy.appNames)
                {
                    listBoxApps.Items.Add(app);
                }
            }
            if (listBoxApps.Items.Count > 0)
            {
                if (listBoxApps.Items.Count <= selectedIndex)
                {
                    listBoxApps.SelectedIndex = listBoxApps.Items.Count - 1;
                }
                else
                {
                    listBoxApps.SelectedIndex = selectedIndex;
                }
            }
        }

        private void listBoxProxies_SelectedIndexChanged(object sender, EventArgs e)
        {
            int skipDuplicateEntries = 0;
            for (int index = 0; index < listBoxProxies.SelectedIndex; index++)
            {
                if (listBoxProxies.Items[index].ToString() == listBoxProxies.Text)
                {
                    skipDuplicateEntries++;
                }
            }
            foreach (Configuration.Proxy proxy in configuration.proxies)
            {
                if (proxy.socks5ProxyEndpoint == listBoxProxies.Text)
                {
                    if (skipDuplicateEntries > 0)
                    {
                        skipDuplicateEntries--;
                        continue;
                    }
                    this.proxy = proxy;
                    break;
                }
            }

            updateApps(0);

            if (proxy.socks5ProxyEndpoint.Contains(":"))
            {
                textBoxIp.Text = proxy.socks5ProxyEndpoint.Substring(0, proxy.socks5ProxyEndpoint.IndexOf(":"));
                textBoxPort.Text = proxy.socks5ProxyEndpoint.Substring(proxy.socks5ProxyEndpoint.IndexOf(":") + 1);
            }
            textBoxUsername.Text = proxy.username;
            textBoxPassword.Text = proxy.password;
            checkBoxTcp.Checked = checkBoxUdp.Checked = false;
            if (proxy.supportedProtocols != null)
            {
                foreach (string supportedProtocol in proxy.supportedProtocols)
                {
                    if (supportedProtocol == "TCP")
                    {
                        checkBoxTcp.Checked = true;
                    }
                    if (supportedProtocol == "UDP")
                    {
                        checkBoxUdp.Checked = true;
                    }
                }
            }
        }

        private void listBoxApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (proxy != null)
            {
                textBoxApp.Text = proxy.appNames[listBoxApps.SelectedIndex];
            }
        }

        private void buttonProxiesAdd_Click(object sender, EventArgs e)
        {
            if (configuration.proxies == null)
            {
                configuration.proxies = new List<Configuration.Proxy>();
            }
            configuration.proxies.Add(new Configuration.Proxy()
            {
                socks5ProxyEndpoint = "127.0.0.1:1080",
                appNames = new List<string>(),
                supportedProtocols = new List<string>()
            });
            updateProxies(configuration.proxies.Count - 1);
        }

        private void buttonProxiesDel_Click(object sender, EventArgs e)
        {
            configuration.proxies.Remove(proxy);
            updateProxies(listBoxProxies.SelectedIndex);
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialogApp.ShowDialog();
        }

        private void openFileDialogApp_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (proxy == null || openFileDialogApp.FileName == string.Empty || listBoxApps.Items.Contains(openFileDialogApp.FileName))
            {
                return;
            }
            if (proxy.appNames == null)
            {
                proxy.appNames = new List<string>();
            }
            proxy.appNames.Add(openFileDialogApp.FileName);
            updateApps(proxy.appNames.Count - 1);
        }

        private void buttonAppsAdd_Click(object sender, EventArgs e)
        {
            if (proxy == null || textBoxApp.Text == string.Empty || listBoxApps.Items.Contains(textBoxApp.Text))
            {
                return;
            }

            if (proxy.appNames == null)
            {
                proxy.appNames = new List<string>();
            }
            proxy.appNames.Add(textBoxApp.Text);
            updateApps(proxy.appNames.Count - 1);
        }

        private void buttonAppsDel_Click(object sender, EventArgs e)
        {
            if (proxy == null)
            {
                return;
            }

            proxy.appNames.Remove(listBoxApps.Text);
            updateApps(listBoxApps.SelectedIndex);
        }

        private void setSocks5ProxyEndpoint()
        {
            if (textBoxIp.Text != string.Empty && textBoxPort.Text != string.Empty)
            {
                proxy.socks5ProxyEndpoint = textBoxIp.Text + ":" + textBoxPort.Text;
                listBoxProxies.Items[listBoxProxies.SelectedIndex] = proxy.socks5ProxyEndpoint;
            }
        }

        private void textBoxIp_Validated(object sender, EventArgs e)
        {
            if (proxy != null)
            {
                setSocks5ProxyEndpoint();
            }
        }

        private void textBoxPort_Validated(object sender, EventArgs e)
        {
            if (proxy != null)
            {
                setSocks5ProxyEndpoint();
            }
        }

        private void textBoxUsername_Validated(object sender, EventArgs e)
        {
            if (proxy != null)
            {
                proxy.username = textBoxUsername.Text;
            }
        }

        private void textBoxPassword_Validated(object sender, EventArgs e)
        {
            if (proxy != null)
            {
                proxy.password = textBoxPassword.Text;
            }
        }

        private void setSupportedProtocols(bool isChecked, string protocol)
        {
            if (proxy.supportedProtocols == null)
            {
                proxy.supportedProtocols = new List<string>();
            }
            if (isChecked)
            {
                if (!proxy.supportedProtocols.Contains(protocol))
                {
                    proxy.supportedProtocols.Add(protocol);
                    proxy.supportedProtocols.Sort();
                }
            }
            else
            {
                proxy.supportedProtocols.Remove(protocol);
            }
        }

        private void checkBoxTcp_Validated(object sender, EventArgs e)
        {
            if (proxy != null)
            {
                setSupportedProtocols(checkBoxTcp.Checked, "TCP");
            }
        }

        private void checkBoxUdp_Validated(object sender, EventArgs e)
        {
            if (proxy != null)
            {
                setSupportedProtocols(checkBoxUdp.Checked, "UDP");
            }
        }

        private void comboBoxLogLevel_Validated(object sender, EventArgs e)
        {
            configuration.logLevel = comboBoxLogLevel.Text;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string cont = JsonConvert.SerializeObject(configuration, new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.Indented
            });

            try
            {
                File.WriteAllText(ConfigPath, cont);
                richTextBoxOutput.AppendText(Environment.NewLine + "Configuration file saved");
            }
            catch (Exception ex)
            {
                richTextBoxOutput.AppendText(Environment.NewLine + ex.Message);
            }
        }

        private void processOutputReceived(object sender, DataReceivedEventArgs e)
        {
            richTextBoxOutput.Invoke((MethodInvoker)delegate
            {
                richTextBoxOutput.AppendText(Environment.NewLine + e.Data);
            });
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonSave_Click(sender, e);

            if (!File.Exists(ProgramPath))
            {
                return;
            }

            if (proxifyreProcess == null)
            {
                richTextBoxOutput.AppendText(Environment.NewLine + "Starting ProxiFyre");
            }
            else
            {
                try
                {
                    if (Process.GetProcessById(proxifyreProcess.Id) != null)
                    {
                        buttonStop_Click(sender, e);
                    }
                }
                catch (Exception)
                {
                    richTextBoxOutput.AppendText(Environment.NewLine + "Starting ProxiFyre");
                }
            }

            proxifyreProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ProgramPath,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                },
                EnableRaisingEvents = true
            };

            proxifyreProcess.OutputDataReceived += new DataReceivedEventHandler(processOutputReceived);

            try
            {
                proxifyreProcess.Start();
                proxifyreProcess.BeginOutputReadLine();
                proxifyreProcess.BeginErrorReadLine();
            }
            catch (Exception ex)
            {
                richTextBoxOutput.AppendText(Environment.NewLine + ex.Message);
            }

            buttonStart.Image = Properties.Resources.icons8_start_16;
            buttonStop.Enabled = true;
            notifyIconTray.Icon = Properties.Resources.icons8_sorting_arrows_32;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (proxifyreProcess == null)
            {
                return;
            }

            richTextBoxOutput.AppendText(Environment.NewLine + "Stopping ProxiFyre");
            proxifyreProcess.Kill();
            proxifyreProcess.Dispose();

            buttonStart.Image = Properties.Resources.icons8_next_16;
            buttonStop.Enabled = false;
            notifyIconTray.Icon = Properties.Resources.icons8_sorting_arrows_grayed_32;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            formVisible = true;
            Show();
        }

        private void toolStripMenuItemStartup_Click(object sender, EventArgs e)
        {
            RegistryKey startupRegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (!toolStripMenuItemStartup.Checked)
            {
                startupRegistryKey.SetValue(Application.ProductName, Application.ExecutablePath);
                toolStripMenuItemStartup.Checked = true;
            }
            else
            {
                startupRegistryKey.DeleteValue(Application.ProductName, false);
                toolStripMenuItemStartup.Checked = false;
            }
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(ProgramPath))
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    Hide();
                    e.Cancel = true;
                }
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (proxifyreProcess == null)
            {
                return;
            }
            try
            {
                if (Process.GetProcessById(proxifyreProcess.Id) != null)
                {
                    proxifyreProcess.Kill();
                    proxifyreProcess.Dispose();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.AppendText(Environment.NewLine + "ProxiFyre configuration utility and tray launcher thing" + Environment.NewLine
                + "proxifyre-tray by airenelias https://github.com/airenelias/proxifyre-tray" + Environment.NewLine
                + "Icons by Icons8 https://icons8.com");
        }

        private void richTextBoxOutput_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void textBoxApp_Resize(object sender, EventArgs e)
        {
            if (textBoxApp.Width <= 0)
            {
                buttonAppsAdd.Visible = false;
            }
            else
            {
                buttonAppsAdd.Visible = true;
            }
        }

        private void listBoxApps_MouseHover(object sender, EventArgs e)
        {
            Point point = listBoxApps.PointToClient(Cursor.Position);
            int index = listBoxApps.IndexFromPoint(point);
            if (index >= 0)
            {
                toolTipApp.Show(listBoxApps.Items[index].ToString(), listBoxApps);
            }
        }
    }
}
