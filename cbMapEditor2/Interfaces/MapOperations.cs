using System;
using System.Drawing;

namespace cbMapEditor2.Interfaces
{
	partial class Map
	{
		int _undoLevel;

		public int UndoLevel
		{
			get { return _undoLevel; }
			set
			{
				if (_undoLevel != value)
				{
					if (value < _undoLevel)
					{
						Graphics g = Graphics.FromImage(MapPBox.Image);
						for (; value < _undoLevel; _undoLevel--)
						{
							TilePosition operation = History[History.Count - _undoLevel];
							if (operation.Tilesheet != _tilesheetName)
								Tilesheet = operation.Tilesheet;
							g.DrawImage(_tilesheetImage, operation.Destine, operation.Orign, GraphicsUnit.Pixel);
						}
						MapPBox.Refresh();
					}
					else
					{
						_undoLevel = value;
						RefreshMap();
					}
				}
			}
		}

		public void RefreshMap()
		{
			var newImage = new Bitmap(MapPBox.Image.Width, MapPBox.Image.Height);
			Graphics g = Graphics.FromImage(newImage);
			int i = 0;
			foreach (TilePosition operation in History)
			{
				if (i++ >= History.Count - UndoLevel)
					break;

				if (operation.Tilesheet != Tilesheet)
					Tilesheet = operation.Tilesheet;
				g.DrawImage(_tilesheetImage, operation.Destine, operation.Orign, GraphicsUnit.Pixel);
			}
			MapPBox.Image.Dispose();
			MapPBox.Image = newImage;
		}

		public void Undo()
		{
			if (History.Count > UndoLevel)
				UndoLevel++;
		}

		public void Redo()
		{
			if (UndoLevel == 0)
				throw new Exception("Invalid operation");
			UndoLevel--;
		}

		public void ClearRedo()
		{
			for (; _undoLevel > 0; _undoLevel--)
				History.RemoveAt(History.Count - 1);
		}

		public void Clear()
		{
			ClearRedo();
			History.Clear();
			RefreshMap();
			UnsavedChanges = false;
		}
	}
}