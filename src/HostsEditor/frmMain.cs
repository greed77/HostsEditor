using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace HostsEditor
{
    public partial class frmMain : Form
    {
        private const string FILE_NAME = "C:\\Windows\\System32\\drivers\\etc\\hosts";
        // private string FILE_NAME = Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\drivers\etc\hosts";

        public frmMain()
        {
            InitializeComponent();
            ReadHosts();
        }

        public void ReadHosts()
        {
            lstHosts.Items.Clear();

            if (!File.Exists(FILE_NAME))
            {
                MessageBox.Show(FILE_NAME + " does not exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (StreamReader sr = File.OpenText(FILE_NAME))
                {
                    String input;
                    string[] saLvwItem = new string[3];

                    while ((input = sr.ReadLine()) != null)
                    {
                        string strVal = input.ToString();
                        string[] lines = strVal.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);

                        if (lines.Length > 1)
                        {
                            string[] line = lines[1].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            if (line.Length > 1)
                            {
                                ListViewItem item = new ListViewItem();
                                // item.SubItems.Add(lines[0]);
                                item.SubItems.Add(line[0]);
                                item.SubItems.Add(line[1]);
                                lstHosts.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                MessageBox.Show("The file could not be read\n" + e.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void WriteHosts()
        {
        }
    }
}
