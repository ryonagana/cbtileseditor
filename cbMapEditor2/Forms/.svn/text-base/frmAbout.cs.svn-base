using System;
using System.Threading;
using System.Windows.Forms;

namespace cbMapEditor2.Forms
{
	public partial class FrmAbout : Form
	{
		readonly string _aboutText =
			" Two crazy guys who love programming... \n I hope you enjoy this software!!!\n\n Cyber - nicholasluis@gmail.com\n\njvlppm - jvlppm@gmail.com\n\nVer(0.1.3)";

		int _tickTime;

		public FrmAbout()
		{
			InitializeComponent();
		}

		void frmAbout_Load(object sender, EventArgs e)
		{
			timeText.Enabled = true;
			timeText.Start();
			timeText.Tick += timeText_Tick;
		}

		void timeText_Tick(object sender, EventArgs e)
		{
			_tickTime++;
			if (_tickTime < _aboutText.Length)
			{
				labelText.Text += _aboutText.Substring(_tickTime, 1);
			}
			else
			{

                timeText.Stop();
                labelText.Text = _aboutText;
				_tickTime = 0;
			}
		}
	}
}