using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RegexGetTextForm.Properties;

namespace RegexGetTextForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSourceDiag_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSourceFile.Text = openFileDialog1.FileName;
            }
        }

        private void btnTargetDiag_Click(object sender, EventArgs e)
        {
            var result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtTargetFile.Text = saveFileDialog1.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var pattern = txtPattern.Text;
            var encoding = Encoding.GetEncoding(txtEncoding.Text);
            var content = File.ReadAllText(txtSourceFile.Text, encoding);

            var matches = Regex.Matches(content, pattern);
            if (matches.Count == 0)
            {
                MessageBox.Show(Resources.info_nomatch);
                return;
            }
            StringBuilder strBuilder = new StringBuilder();
            foreach (Match match in matches)
            {
                strBuilder.AppendLine(match.Value);
            }

            File.WriteAllText(txtTargetFile.Text, strBuilder.ToString(), encoding);
            MessageBox.Show(Resources.info_success);
        }
    }
}
