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
        
        public Form1()
        {
            InitializeComponent();
            Trello.Instance.BoardService.Add("Table");
            var columns = Trello.Instance.BoardService as BoardService;
            columns.GetColumnService().Add("Bug");
            columns.GetColumnService().Add("In progress");
            columns.GetColumnService().Add("Solved");
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var columns = Trello.Instance.BoardService as BoardService;
            
        }
    }
}
