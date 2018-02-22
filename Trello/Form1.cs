using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trello
{
    public partial class Form1 : Form
    {
        public TabControl _TabControl { get; set; }
        public Form1()
        {
            InitializeComponent();
            _TabControl=new TabControl();
            Controls.Add(_TabControl);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

           

        }
    }
}
