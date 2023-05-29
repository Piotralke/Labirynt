using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabiryntFrontend
{
    public partial class parametrForm : Form
    {
        private int cols;
        private int rows;
        public int startX;
        public int startY;
        public ArrayList exitTable = new ArrayList() ;
        public parametrForm()
        {
            InitializeComponent();
        }
        public parametrForm(int cols, int rows)
        {
            InitializeComponent();
            this.cols = cols;
            this.rows = rows;
            exitList.Columns.Add("Współrzędne wyjść",200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exitCoords newExit = new exitCoords();
            newExit.x = int.Parse(exitXInput.Text);
            newExit.y = int.Parse(exitYInput.Text);
            exitTable.Add(newExit);
            exitList.Items.Add(newExit.x + ", " + newExit.y);
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            startX= int.Parse(startXInput.Text);
            startY = int.Parse(startYInput.Text);
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
