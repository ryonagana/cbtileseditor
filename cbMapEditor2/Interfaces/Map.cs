﻿using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace cbMapEditor2.Interfaces
{
	partial class Map
	{
		#region Attributes

		Rectangle? _currentSelection;
		Bitmap _tilesheetImage;
		string _tilesheetName;

		#endregion

		#region Properties

		public Pen SelectionPen = new Pen(Color.Yellow);

		public int TileSize { get; set; }

		public List<TilePosition> History { get; private set; }

		public PictureBox TilesetPBox { get; private set; }
		public PictureBox MapPBox { get; private set; }

		public string Tilesheet
		{
			get { return _tilesheetName; }
			set
			{
				if (!File.Exists(value))
					throw new FileNotFoundException("File not found", value);

				if (_tilesheetName != value)
				{
					_tilesheetImage = new Bitmap(value);
					TilesetPBox.Image = _tilesheetImage;
					_tilesheetName = value;
				}
			}
		}

		public bool UnsavedChanges { get; private set; }

		#endregion

		#region ctor

		public Map(int mapWidth, int mapHeight, PictureBox pbTileset, PictureBox pbMap)
		{
			History = new List<TilePosition>();
			TileSize = 32;
			TilesetPBox = pbTileset;
			MapPBox = pbMap;

			MapPBox.Image = new Bitmap(mapWidth, mapHeight);

			TilesetPBox.MouseClick += SelectTile;

			MapPBox.MouseClick += DrawSelectedTile;
			UnsavedChanges = false;
		}

		#endregion
	}
}