using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggShell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Init(object sender, EventArgs e)
        {
            panel1.Size = this.Size;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.Location = new Point(this.Location.X, Screen.PrimaryScreen.Bounds.Height - this.Size.Height);
        }
    }
}
