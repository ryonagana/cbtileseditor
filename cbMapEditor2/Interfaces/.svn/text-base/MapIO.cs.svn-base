using System;
using System.Drawing;
using System.IO;

namespace cbMapEditor2.Interfaces
{
	partial class Map
	{
		#region File Operations

		public void SaveFile(string fileName)
		{
			using (var file = new StreamWriter(fileName))
			{
				string currentTileSheet = null;
				int i = 0;
				foreach (TilePosition tilePosition in History)
				{
					if (i++ >= History.Count - UndoLevel)
						break;
					if (currentTileSheet != tilePosition.Tilesheet)
					{
						file.WriteLine("[{0}]", tilePosition.Tilesheet);
						currentTileSheet = tilePosition.Tilesheet;
					}
					file.WriteLine("{0};{1};{2};{3};{4}", tilePosition.TileSize, tilePosition.Orign.Left, tilePosition.Orign.Top,
					               tilePosition.Destine.Left, tilePosition.Destine.Top);
				}
			}
		}

		public void LoadFile(string fileName)
		{
			ClearRedo();
			using (var file = new StreamReader(fileName))
			{
				string tileset = null;
				while (!file.EndOfStream)
				{
					string line = file.ReadLine();
					if (line.StartsWith("["))
						tileset = line.Trim('[', ']');
					else
					{
						string[] values = line.Split(';');
						TileSize = int.Parse(values[0]);
						var origin = new Rectangle(int.Parse(values[1]), int.Parse(values[2]), TileSize, TileSize);
						var destine = new Rectangle(int.Parse(values[3]), int.Parse(values[4]), TileSize, TileSize);
						History.Add(new TilePosition(tileset, TileSize, origin, destine));
						if (OnOperation != null) OnOperation(this, EventArgs.Empty);
					}
				}
			}
			RefreshMap();
		}

		#endregion
	}
}