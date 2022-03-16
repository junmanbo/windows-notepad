using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotepad
{
    public partial class FrmNote : Form
    {
        public FrmNote()
        {
            InitializeComponent();
        }

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 자동줄바꿈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tBoxMain.WordWrap == true)
            {
                tBoxMain.WordWrap = false;
                자동줄바꿈ToolStripMenuItem.Checked = false;
            }
            else
            {
                tBoxMain.WordWrap = true;
                자동줄바꿈ToolStripMenuItem.Checked = true;
            }
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sd.Title = "다른 이름으로 저장";
            sd.ShowDialog();

            if (sd.FileName != "")
            {
                File.WriteAllText(sd.FileName, tBoxMain.Text);
            }

        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            od.Title = "파일 열기";
            od.ShowDialog();
            tBoxMain.Text = File.ReadAllText(od.FileName);
        }

        private void 새로만들기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tBoxMain.Text = "";
        }

        private void 도움말보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 피드백보내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 메모장정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInfo win = new FrmInfo();
            win.ShowDialog();
            win.Location = new Point(this.Location.X + 80, this.Location.Y + 80);

        }

        private void 새창ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNote win = new FrmNote();
            win.Show();
        }

        private void FrmNote_Load(object sender, EventArgs e)
        {

        }
    }
}
