using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void finish_label_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("УРА");
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void MoveToStart()
        {
            Point startPoint = panel2.Location;
            startPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startPoint);
        }

        
        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
