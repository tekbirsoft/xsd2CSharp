using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xsd2CSharp
{
    public partial class Form1 : Form
    {

        public ObservableCollection<FileModel> NetFrameworks { get; set; } = new ObservableCollection<FileModel>();

        public Form1()
        {
            var loc = @"C:\Program Files (x86)\Microsoft SDKs\Windows\";
            InitializeComponent();
            var allFiles = Directory.GetFiles(loc, "xsd.exe", SearchOption.AllDirectories);
            foreach (var item in allFiles)
            {
                NetFrameworks.Add(new FileModel() { FileFullName = item, FileName = item.Replace(loc, "") });
            }
            cbNetVersions.DataSource = NetFrameworks;
            cbNetVersions.DisplayMember = "FileName";
            lsbModel.DisplayMember = "FileName";
            lsbRef.DisplayMember = "FileName";
        }


        public class FileModel
        {
            public string FileFullName { get; set; }
            public string FileName { get; set; }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog o = new FolderBrowserDialog();
            var t = o.ShowDialog();
            if (t == DialogResult.OK)
            {
                txtOutput.Text = o.SelectedPath;
            }
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            btnClearModel_Click(null, null);
            OpenFileDialog o = new OpenFileDialog();
            o.Multiselect = true;
            var t = o.ShowDialog();
            if (t == DialogResult.OK)
            {
                foreach (var item in o.FileNames.Where(x => x.EndsWith(".xsd")))
                {
                    FileInfo f = new FileInfo(item);
                    lsbModel.Items.Add(new FileModel() { FileFullName = f.FullName, FileName = f.Name });
                }

            }
        }

        private void btnRemoveModel_Click(object sender, EventArgs e)
        {
            if (lsbRef.SelectedIndex > -1)
                lsbModel.Items.RemoveAt(lsbRef.SelectedIndex);

        }

        private void btnClearModel_Click(object sender, EventArgs e)
        {
            lsbModel.Items.Clear();
        }

        private void btnAddRef_Click(object sender, EventArgs e)
        {
            btnClearRef_Click(null, null);
            OpenFileDialog o = new OpenFileDialog();
            o.Multiselect = true;
            var t = o.ShowDialog();
            if (t == DialogResult.OK)
            {
                foreach (var item in o.FileNames.Where(x => x.EndsWith(".xsd")))
                {
                    FileInfo f = new FileInfo(item);
                    lsbRef.Items.Add(new FileModel() { FileFullName = f.FullName, FileName = f.Name });
                }
            }
        }

        private void btnRemoveRef_Click(object sender, EventArgs e)
        {
            if (lsbRef.SelectedIndex > -1)
                lsbRef.Items.RemoveAt(lsbRef.SelectedIndex);
        }

        private void btnClearRef_Click(object sender, EventArgs e)
        {
            lsbRef.Items.Clear();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            foreach (var item in lsbModel.Items)
            {
                var model = (FileModel)item;
                var t = (FileModel)cbNetVersions.SelectedItem;
                var str = "";
               
                foreach (var i in lsbRef.Items)
                {
                    var m= (FileModel)i;
                    str += @" """ + m.FileFullName+@"""";

                }
                str += @" """ + model.FileFullName+@"""";
                str += @" /c /o:""" + txtOutput.Text+ @"""";

                System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
                 start.Arguments = str;
                 start.FileName = t.FileFullName;
                 start.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                start.CreateNoWindow = true;
                int exitCode;


                 using (System.Diagnostics.Process proc = System.Diagnostics.Process.Start(start))
                {
                    proc.WaitForExit();
                     exitCode = proc.ExitCode;
                }


            }





        }
    }
}
