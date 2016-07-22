using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cetus
{
	public class Game
    {

		#region [ Class: SpielBrett ]
		public class SpielBrett
		{
			#region [ Classes ]

			#region [ Class: Field ]
			public class SpielFeld
			{

				#region - Variable -
				bool _isWhite = true;
				#endregion

				#region - Constructor -
				public SpielFeld()
				{

				}
				#endregion

				/// TODO add property

				#region [ Functions ]

				#region - Function: switchColor() -
				public void switchColor()
				{
					if (_isWhite)
					{
						_isWhite = false;
					}
					else
					{
						_isWhite = true;
					}
				}
				#endregion

				#region - Function: isFielWhite()
				public bool isFieldWhite()
				{
					return _isWhite;
				}
				#endregion

				#endregion

			}
			#endregion

			#region [ Class: Position ]
			public class Position
			{
				#region - Variables -
				int _x;
				int _y;
				#endregion

				#region [ Properties ]

				#region - Property: X -
				public int X
				{
					get
					{
						return _x;
					}
					internal set
					{
						_x = value;
					}
				}
				#endregion

				#region - Property: Y -
				public int Y
				{

					get
					{
						return _y;
					}
					internal set
					{
						_y = value;
					}
				}
				#endregion

				#endregion

				#region - Constructor -
				public Position()
					: this(0, 0)
				{

				}

				public Position(int x, int y)
				{
					_x = x;
					_y = y;
				}

				public Position(Position source)
				{
					if (source != null)
					{
						_x = source._x;
						_y = source._y;
					}
				}
				#endregion
			}
			#endregion

			#region [ Class: Ameise ]
			public class Ameise
			{
				#region - Variables -
				Position _position;
				Directions _direction = Directions.North;
				#endregion

				#region [ Properties ]

				#region - Property: Position -
				public Position Position
				{
					get
					{
						return _position;
					}
					internal set
					{
						_position = value;
					}
				}
				#endregion

				#region - Property: Direction -
				public Directions Direction
				{
					get
					{
						return _direction;
					}
					internal set
					{
						_direction = value;
					}
				}
				#endregion

				#endregion

				#region [ Constructor ]

				#region - Contructor()
				public Ameise()
				{
				}
				#endregion

				#region - Contructor(Position startPosition)
				public Ameise(Position startPosition) : this(startPosition, Directions.North)
				{
				}
				#endregion

				#region - Contructor(Position startPosition, Directions direction)
				public Ameise(Position startPosition, Directions direction)
				{
					_position = startPosition;
					_direction = direction;
				}
				#endregion

				#endregion
			}
			#endregion

			#endregion


			#region - Variables -
			int _width = 512;
			int _height = 512;
			Ameise _ameise = new Ameise();
			List<List<SpielFeld>> _spielfelder = new List<List<SpielFeld>>();
			SpielFeld _lastSpielFeld;
			Position _lastPosition = new Position();
			int moves = 0;
			#endregion

			#region [ Properties ]

			#region - Property -
			public Position lastPosition
			{
				get
				{
					return _lastPosition;
				}
				internal set
				{
					_lastPosition = value;
				}
			}
			#endregion

			#region - Property: width -
			public int Width
			{
				get
				{
					return _width;
				}
			}
			#endregion

			#region - Property: height -
			public int Height
			{
				get
				{
					return _height;
				}
			}
			#endregion

			#region - Property: Spielfelder() -
			public List<List<SpielFeld>> Spielfelder
			{
				get
				{
					return _spielfelder;
				}
			}
			#endregion

			#region - Property: Moves -
			public int Moves
			{
				get
				{
					return moves;
				}
			}
			#endregion

			#endregion

			#region [ Constructor ]

			#region - Constructor: SpielBrett() -
			public SpielBrett() : this(0, 0)
			{
				
			}

			public SpielBrett(int width, int height)
			{
				if ((width > 0) && (height > 0))
				{
					_width = width;
					_height = height;
				}

				initializeField();
				_ameise = new Ameise(new Position(_width / 2, _height / 2));
			}
			#endregion

			#endregion

			#region [ Functions ]

			#region - Function: isPositionValide(Position position) -
			private bool isPositionValide(Position position)
			{
				if (position.X >= _width || position.X <= 0)
				{
					return false;
				}

				if (position.Y >= _height || position.Y <= 0)
				{
					return false;
				}
				return true;
			}
			#endregion

			#region - Function: initializeField() -
			public void initializeField()
			{
				_spielfelder = new List<List<SpielFeld>>();

				for (int i = 0; i < _width; i++)
				{
					List<SpielFeld> spielFeldSpalte = new List<SpielFeld>();
					for (int z = 0; z < _height; z++)
					{
						spielFeldSpalte.Add(new SpielFeld());
					}
					_spielfelder.Add(spielFeldSpalte);
				}

			}
			#endregion

			#region - Function: initializeField(int random) -
			public void initializeField(int percentage)
			{
				//Feld initaliesieren
				initializeField();

				//Feld zufällig vorbelegen
				Random random = new Random();
				for (int i = 0; i < _width; i++)
				{
					for (int z = 0; z < _height; z++)
					{
						if (random.Next(100) + 1 <= percentage)
						{
							_spielfelder[i][z].switchColor();
						}
					}
				}

			}
			#endregion

			#region - Function: nexRound() -
			public bool nextRound()
			{
				moves++;
				Position newPosition = new Position(_ameise.Position);
				Directions direction = _ameise.Direction;

				if (!this.isPositionValide(_ameise.Position))
				{
					return false;
				}

				SpielFeld spielFeld = _spielfelder[_ameise.Position.X][_ameise.Position.Y];

				spielFeld.switchColor();
				_lastSpielFeld = spielFeld;

				if (!spielFeld.isFieldWhite())
				{
					switch (direction)
					{
						case Directions.North:
							newPosition.X--;
							direction = Directions.West;
							break;
						case Directions.East:
							newPosition.Y++;
							direction = Directions.North;
							break;
						case Directions.South:
							newPosition.X++;
							direction = Directions.East;
							break;
						case Directions.West:
							newPosition.Y--;
							direction = Directions.South;
							break;
					}

				}
				else
				{
					switch (direction)
					{
						case Directions.North:
							newPosition.X++;
							direction = Directions.East;
							break;
						case Directions.East:
							newPosition.Y--;
							direction = Directions.South;
							break;
						case Directions.South:
							newPosition.X--;
							direction = Directions.West;
							break;
						case Directions.West:
							newPosition.Y++;
							direction = Directions.North;
							break;
					}
				}

				if (!isPositionValide(newPosition))
				{
					return false;
				}

				_lastPosition = new Position(_ameise.Position);
				_ameise.Position = new Position(newPosition);
				_ameise.Direction = (Directions)direction;

				return true;
			}
			#endregion

			#region - Function: void setSpielBrettSize(int lenght, int width) -
			public void setSpielBrettSize(int lenght, int width)
			{
				_width = width;
				_height = lenght;
			}
			#endregion

			#region - Function: getAmeisenPosition() -
			public Position getAmeisenPosition()
			{
				return _ameise.Position;
			}
			#endregion

			#region - Function: SpielFeld getSpielFeld(int x, int y)
			public SpielFeld getSpielFeld(int x, int y)
			{
				return _spielfelder[x][y];
			}
			#endregion

			#region - Function: SpielFeld setSpielFeld(SpielFeld spielFeld, int x, int y)
			public void setSpielFeld(SpielFeld spielFeld, int x, int y)
			{
				_spielfelder[x][y] = spielFeld;
			}
			#endregion

			#region - Function: SpielFeld getLastSpielFeld()
			public SpielFeld getLastSpielFeld()
			{
				return _lastSpielFeld;
			}
			#endregion

			#region - Function: moveAmeiseToHome() -
			public void moveAmeiseToHome()
			{
				_ameise.Direction = Directions.North;
				_ameise.Position = new Position(_width / 2, _height / 2);
			}
			#endregion

			#region - Function: moveAmeiseToRandomPosition() -
			public void moveAmeiseToRandomPosition()
			{
				Random random = new Random();
				_ameise.Position = new Position(random.Next(_width), random.Next(_height));
			}
			#endregion

			#region - Function: resetMoves() -
			public void resetMoves()
			{
				moves = 0;
			}
			#endregion

			#endregion
		}
		#endregion


		#region - Enum: Directions -
		public enum Directions
        {
            North = 1,
            East = 2,
            South = 3,
            West = 4
        }
        #endregion

        #region - Variables -
        public static SpielBrett _spielbrett = new SpielBrett();
        #endregion

        #region [ Properties ]

        #region - Property: Spielbrett -
        public SpielBrett spielbrett
        {

            get
            {
                return _spielbrett;
            }
         }
        #endregion

        #endregion

        #region - Constructor -
        public Game()
        {
        
        }
        #endregion

        #region - Function: initializeSpielBrett(int width, int height, bool setDiameters) -
        public void initializeSpielBrett(int width, int height)
        {
            _spielbrett = new SpielBrett(width, height);
        }
        #endregion

    }
}
