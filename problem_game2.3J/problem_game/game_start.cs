using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem_game
{
	public partial class Form1 : Form
	{
		public Form ControlForm;
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_MouseEnter(object sender, EventArgs e)
		{
		}

		private void button2_MouseLeave(object sender, EventArgs e)
		{
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ControlForm = new game_process();
			ControlForm.Show();
			this.Visible = false;
		}
	}
}
