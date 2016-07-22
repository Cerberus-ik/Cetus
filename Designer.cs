using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cetus
{
	public class Designer
	{
		#region - Variables -
		Game _game = new Game();
		List<List<Game.SpielBrett.SpielFeld>> _spielFelder;
		int _scaling = 1;
		Bitmap _bitmap;
		Bitmap _miniMap = new Bitmap(279, 142);
		#endregion

		#region [ Properties ]

		#region - Property: SpielFelder -
		public List<List<Game.SpielBrett.SpielFeld>> SpielFelder
		{

			get
			{
				return _spielFelder;
			}
			set
			{
				_spielFelder = value;
			}

		}
		#endregion

		#region - Property: scaling -
		public int scaling
		{
			get
			{
				return _scaling;
			}
			set
			{
				if (_scaling != value)
				{
					_scaling = value;
					initializeBitmap(_game.spielbrett.Spielfelder);
				}
			}
		}
		#endregion

		#endregion		

		#region [ Constructors ]

		#region - Contructor: Designer() -
		public Designer()
		{
		}
		#endregion

		#region - Constructor: Designer(Game game)
		public Designer(Game game)
		{
			_game = game;
		}
		#endregion

		#endregion

		#region [ Functions ]

		#region - Function: initializeBitmap(List<List<SpielFeld>> spielFelder) -
		public void initializeBitmap(List<List<Game.SpielBrett.SpielFeld>> spielFelder)
		{

			if (spielFelder.Count > 0)
			{

				int width = spielFelder.Count();
				int height = spielFelder[0].Count();

				_bitmap = new Bitmap(width * _scaling, height * _scaling);
				drawWalls();

				for (int i = 0; i < width; i++)
				{
					for (int z = 0; z < height; z++)
					{
						if (!spielFelder[i][z].isFieldWhite())
						{
							this.setNewField(i, z, false);
						}
					}
				}
			}
		}
		#endregion

		#region - Function: setNewField(int x, int y, bool white) -
		public void setNewField(int x, int y, bool white)
		{
			setNewField(Graphics.FromImage(_bitmap), x, y, white);
		}

		public void setNewField(Graphics graphics, int x, int y, bool white)
		{
			if (_scaling > 1)
			{
				SolidBrush blackBrush = new SolidBrush(Color.Black);
				SolidBrush whiteBrush = new SolidBrush(Color.White);

				if (white)
				{
					graphics.FillRectangle(whiteBrush, x * scaling, y * scaling, scaling, scaling);
				}
				else
				{
					graphics.FillRectangle(blackBrush, x * scaling, y * scaling, scaling, scaling);
				}

			}
			else
			{
				if (white)
				{
					_bitmap.SetPixel(x, y, Color.White);
				}
				else
				{
					_bitmap.SetPixel(x, y, Color.Black);
				}
			}

			//graphics.Dispose();

		}
		#endregion

		#region - Function: resetBitMap() -
		public void resetBitmap()
		{
			_bitmap = new Bitmap(_game.spielbrett.Width * scaling, _game.spielbrett.Height * scaling);
			drawWalls();
		}
		#endregion

		#region - Function: getBitmap() -
		public Bitmap getBitmap()
		{
			return _bitmap;
		}
		#endregion

		#region - Function: getMiniMap() -
		public Bitmap getMiniMap()
		{
			return _miniMap;
		}
		#endregion

		#region - Function: drawWalls()
		void drawWalls()
		{
			Pen pen = new Pen(Color.Cyan);
			Graphics.FromImage(_bitmap).DrawRectangle(pen, 0, 0, _bitmap.Width - 1 , _bitmap.Height - 1);
		}
		#endregion

		#region - Function: drawMinimap() -
		public void drawMinimap(int startX, int startY, int viewFieldWidth, int viewFieldHeight)
		{
			_miniMap = new Bitmap(_bitmap);
			Graphics.FromImage(_miniMap).DrawRectangle(new Pen(Color.Navy), startX, startY, viewFieldWidth, viewFieldHeight);
		}
		#endregion

		#endregion

	}
}
