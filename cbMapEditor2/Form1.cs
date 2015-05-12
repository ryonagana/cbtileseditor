using System;
using System.Drawing;
using System.Windows.Forms;
using cbMapEditor2.Forms;
using cbMapEditor2.Interfaces;

namespace cbMapEditor2
{
	public partial class MainForm : Form
	{
		#region Fields

        public enum ToolbarButtonSelected { PENCIL_SELECTED, FILL_SELECTED, ZOOM_SELECTED }
        public enum GridSizeState { GRID_8X8, GRID_16x16, GRID_32X32 }

		bool _editingMap;
		readonly Map _mapa;
		string _currentFile;
        ToolbarButtonSelected statusToolbar;
        GridSizeState grid_state = GridSizeState.GRID_32X32;

		public bool EditingMap
		{
			get { return _editingMap; }
			set
			{
				mpMap.Visible = value;
				mpSprites.Visible = value;
				if (_editingMap && !value)
					_mapa.Clear();
				_editingMap = value;
			}
		}

		#endregion

		#region ctor

		public MainForm()
		{
			try
			{
				InitializeComponent();

				_mapa = new Map(320, 200, mpSprites, mpMap);
				_mapa.OnOperation += UpdateUndoRedoButtons;
               

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		#endregion

		#region Grid

		void btGrid8_Click(object sender, EventArgs e)
		{
			btGrid32.Checked = false;
			btGrid16.Checked = false;
            grid_state = GridSizeState.GRID_8X8;

			_mapa.TileSize = 8;
		}

		void btGrid16_Click(object sender, EventArgs e)
		{
			btGrid32.Checked = false;
			btGrid8.Checked = false;
            grid_state = GridSizeState.GRID_16x16;

			_mapa.TileSize = 16;
		}

		void btGrid32_Click(object sender, EventArgs e)
		{
			btGrid16.Checked = false;
			btGrid8.Checked = false;
            grid_state = GridSizeState.GRID_32X32;

			_mapa.TileSize = 32;
		}

		#endregion

		#region Menu

		bool SelectSaveFile()
		{
			if (saveFileDialog.ShowDialog() != DialogResult.OK)
				return false;
			_currentFile = saveFileDialog.FileName;
			return true;
		}

		void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (SelectSaveFile())
				_mapa.SaveFile(_currentFile);
		}

		void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_currentFile != null || SelectSaveFile())
				_mapa.SaveFile(_currentFile);
		}

		void openMapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openMapFileDialog.ShowDialog() == DialogResult.OK)
			{
				_mapa.LoadFile(openMapFileDialog.FileName);
				_currentFile = openMapFileDialog.FileName;
				EditingMap = true;
			}
		}

		void openTileSheetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openTilesheetFileDialog.ShowDialog() == DialogResult.OK)
			{
				_mapa.Tilesheet = openTilesheetFileDialog.FileName;
				EditingMap = true;
			}
		}

		void MainForm_Load(object sender, EventArgs e)
		{
            _mapa.MapPBox.Image = new Bitmap(320, 200);
            _mapa.Tilesheet = "example/free_summer_coast_0.png";
            EditingMap = true;
		}

		void usmeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var aboutUs = new FrmAbout();
			aboutUs.ShowDialog();
		}

		private void closeMapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			EditingMap = false;
		}

		#endregion

		#region ToolBar
		#endregion

		#region Map Size

		void updateMapSize(object sender, EventArgs e)
		{
			int newWidth, newHeight;
			if (int.TryParse(cpWidth.Text, out newWidth) && int.TryParse(cpHeight.Text, out newHeight))
			{
				_mapa.MapPBox.Image = new Bitmap(newWidth, newHeight);
				_mapa.RefreshMap();
			}
		}

		void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(SaveChanges() == DialogResult.Cancel)
				return;

			Application.Exit();
		}

		DialogResult SaveChanges()
		{
			if (_mapa.UnsavedChanges)
			{
				DialogResult dialogResult = MessageBox.Show("Deseja salvar as alterações?", "Salvar", MessageBoxButtons.YesNoCancel);
				if (dialogResult == DialogResult.Yes && (_currentFile != null || SelectSaveFile()))
					_mapa.SaveFile(_currentFile);

				return dialogResult;
			}
			return DialogResult.No;
		}

		#endregion

		#region Undo / Redo

		void UpdateUndoRedoButtons(object sende, EventArgs e)
		{
			btnUndo.Enabled = _mapa.History.Count > _mapa.UndoLevel;
			btnRedo.Enabled = _mapa.UndoLevel > 0;
		}

		void btnUndo_Click(object sender, EventArgs e)
		{
			_mapa.UndoLevel++;
			UpdateUndoRedoButtons(sender, e);
		}

		void btnRedo_Click(object sender, EventArgs e)
		{
			_mapa.UndoLevel--;
			UpdateUndoRedoButtons(sender, e);
		}

		#endregion

	

		private void newMapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (SaveChanges() == DialogResult.Cancel)
				return;

			if (openTilesheetFileDialog.ShowDialog() == DialogResult.OK)
			{
				EditingMap = false;
				_mapa.Tilesheet = openTilesheetFileDialog.FileName;
				EditingMap = true;
			}
		}

        private void toggleButton2_Click(object sender, EventArgs e)
        {
            
            toolPaint.Checked = true;
            toolFill.Checked = false;

        }

       
	}
}