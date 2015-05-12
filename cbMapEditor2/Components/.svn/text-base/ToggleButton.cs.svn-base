using System.Drawing;
using System.Windows.Forms;

namespace cbMapEditor2.Components
{
	public sealed partial class ToggleButton : ToolStripButton
	{
		public ToggleButton()
		{
			InitializeComponent();
			Image = ImgOnReleased;
			CheckedChanged += (s, e) => Image = Checked ?  ImgOnPressed : ImgOnReleased;
		}

		public Image ImgOnPressed { get; set; }
		public Image ImgOnReleased { get; set; }
	}
}