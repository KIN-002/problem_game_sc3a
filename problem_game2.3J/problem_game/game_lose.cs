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
	public partial class game_lose : Form
	{
		public Form ControlForm;
		public game_lose()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ControlForm = new Form1();
			ControlForm.Show();
			this.Visible = false;
		}
	}
}
