using System;
using System.Drawing;
using System.Windows.Forms;

namespace cbMapEditor2.Interfaces
{
	partial class Map
	{
		public event EventHandler OnOperation;

		#region  EventHandlers & MouseHandlers

		void DrawSelectedTile(object sender, MouseEventArgs e)
		{
			if (_currentSelection == null)
				return;


            var dstRectangle = new Rectangle(e.X - e.X % TileSize, e.Y - e.Y % TileSize, TileSize, TileSize);

            if (e.Button == MouseButtons.Left)
            {

               

                ClearRedo();

                History.Add(new TilePosition(Tilesheet, TileSize, _currentSelection.Value, dstRectangle));
                if (OnOperation != null) OnOperation(this, EventArgs.Empty);
                UnsavedChanges = true;

                Graphics g = Graphics.FromImage(MapPBox.Image);
                g.DrawImage(_tilesheetImage, dstRectangle, _currentSelection.Value, GraphicsUnit.Pixel);
                MapPBox.Refresh();
            }else if( e.Button == MouseButtons.Right){

                ClearRedo();
                Graphics g = Graphics.FromImage(MapPBox.Image);
                Bitmap grey = new Bitmap(TileSize, TileSize);
                
                g.DrawImage(grey, dstRectangle, _currentSelection.Value, GraphicsUnit.Pixel);
                MapPBox.Refresh();
                
            }
		}

		void SelectTile(object sender, MouseEventArgs e)
		{
			if (TilesetPBox.Image == null)
				return;

			int valX = e.X/TileSize;
			int valY = e.Y/TileSize;

			if (valX < 0 || valX >= TilesetPBox.Image.Width || valY < 0 || valY >= TilesetPBox.Image.Height)
				return;

			_currentSelection = new Rectangle(valX*TileSize, valY*TileSize, TileSize, TileSize);

			DrawSelection();
		}

		void DrawSelection()
		{
			if (_currentSelection != null)
			{
				var currentTileSetImage = new Bitmap(_tilesheetImage);
				Graphics g = Graphics.FromImage(currentTileSetImage);
				g.DrawRectangle(SelectionPen, _currentSelection.Value);
				TilesetPBox.Image = currentTileSetImage;
			}
			else TilesetPBox.Image = _tilesheetImage;
		}

		#endregion
	}
}