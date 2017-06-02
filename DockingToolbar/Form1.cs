using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using System.IO;

namespace DockingToolbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // to set the image max size. This is important!
            SVGParser.MaximumSize = new System.Drawing.Size(22, 21);
            string[] str = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames();

            // to set the image.
            string runningPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = string.Format("{0}Resources\\arcs.svg", Path.GetFullPath(Path.Combine(runningPath, @"..\..\")));
            tsbtn1.Image = SVGParser.GetBitmapFromSVG(filePath);
            filePath = string.Format("{0}Resources\\opacity01.svg", Path.GetFullPath(Path.Combine(runningPath, @"..\..\")));
            tsbtn2.Image = SVGParser.GetBitmapFromSVG(filePath);
            filePath = string.Format("{0}Resources\\quad01.svg", Path.GetFullPath(Path.Combine(runningPath, @"..\..\")));
            tsbtn3.Image = SVGParser.GetBitmapFromSVG(filePath);

        }

        private void tsbtn1_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "Hello world";
        }

        private void tsbtn2_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "This is a button!";
        }

        private void tsbtn3_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "This is the third button!";
        }
    }
}
