using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Cetus
{
    public partial class cetusForm : Form
    {
        #region - Variables -
        public static Game game;
        Designer designer = new Designer();
		private DispatcherTimer _timer;
		int scaleFactor = 1;
        #endregion

        #region - Constructor -
        public cetusForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
        }
        #endregion

		#region [ EventHandler ]

		#region - EventHandler: Form1_Load -
		private void Form1_Load(object sender, EventArgs e)
		{

			new ToolTip().SetToolTip(checkBoxEnergyMode, "Disables the live viewing field on the minimap");

			//String[] args = new String[0];
			//args[0] = "500";
			//args[1] = "500";

			game = new Game();

			designer = new Designer(game);
			designer.scaling = scaleFactor;
			designer.initializeBitmap(game.spielbrett.Spielfelder);

			drawBitmap();
			drawMinimap();

			sliderSpeed.MouseWheel += sliderSpeed_MouseWheel;
			trackBarFieldPercent.MouseWheel += tracktrackBarFieldPercent__MouseWheel;
			trackBarScalingLevel.MouseWheel += trackBarScalingLevel_MouseWheel;

			this.MouseWheel += cetusForm_MouseWheel;
			this.Resize += Form1_Resize;

			_timer = new DispatcherTimer(DispatcherPriority.Normal);
			_timer.Tick += new EventHandler(dispTimer_Tick);
			_timer.Interval = TimeSpan.FromMilliseconds(500);

			pictureBox.MouseDown += pictureBox_MouseDown;
			pictureBox.MouseMove += pictureBox_MouseMove;
			pictureBox.MouseUp += pictureBox_MouseUp;
		}
		#endregion

		#region - Eventhandler: Drag and Drop -
		private Point MouseDownLocation;

		void pictureBox_MouseUp(object sender, MouseEventArgs e)
		{
			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
		}
	
		private void pictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
				MouseDownLocation = e.Location;
			}
		}

		private void pictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				pictureBox.Left = e.X + pictureBox.Left - MouseDownLocation.X;
				pictureBox.Top = e.Y + pictureBox.Top - MouseDownLocation.Y;

				drawMinimap();
			}
		}
		#endregion

		#region - Eventhandler: Form1_Resize -
		private void Form1_Resize(object sender, EventArgs e)
		{
			centerBitmap(true);
			drawBitmap();
			drawMinimap();
		}
		#endregion

		#region - EventHandler: TimerTick -
		void dispTimer_Tick(object sender, EventArgs e)
		{
			if (!game.spielbrett.nextRound())
			{
				_timer.Stop();
				drawBitmap();
				drawMinimap();
				saveBitmap();
				game.spielbrett.moveAmeiseToHome();
				MessageBox.Show("Finished after: " + game.spielbrett.Moves.ToString() + " moves!");
				game.spielbrett.resetMoves();
			}
			if (rdBtnLive.Checked)
			{
				designer.setNewField(game.spielbrett.lastPosition.X, game.spielbrett.lastPosition.Y, game.spielbrett.getLastSpielFeld().isFieldWhite());
				drawBitmap();
				drawMinimap();

				if (checkBoxFollowAmeise.Checked)
				{

					//int tempX = 0;
					//int tempY = 0;

					//tempX = pictureBox.Width / designer.scaling;
					//tempY = pictureBox.Height / designer.scaling;

					//tempX = tempX / 2 + (tempX / 2 - game.spielbrett.getAmeisenPosition().X);
					//tempY = tempY / 2 + (tempY / 2 - game.spielbrett.getAmeisenPosition().Y);

					pictureBox.Location = new Point(((pictureBox.Parent.ClientSize.Width / 2) - (pictureBox.Width / 2) + pictureBox.Width / 2 + (game.spielbrett.getAmeisenPosition().X * designer.scaling - pictureBox.Width)),
													((pictureBox.Parent.ClientSize.Height / 2) - (pictureBox.Height / 2) + pictureBox.Height / 2 + (game.spielbrett.getAmeisenPosition().Y * designer.scaling - pictureBox.Height)));

					//pictureBox.Location = new Point((pictureBox.Parent.ClientSize.Width / 2) - (pictureBox.Width / 2) + tempX * designer.scaling,
					//								(pictureBox.Parent.ClientSize.Height / 2) - (pictureBox.Height / 2) + tempY * designer.scaling);
					
					//pictureBox.Location = new Point(((pictureBox.Parent.ClientSize.Width / 2) - (pictureBox.Width / 2) + pictureBox.Width / 2 + (game.spielbrett.getAmeisenPosition().X - pictureBox.Width)),
					//								((pictureBox.Parent.ClientSize.Height / 2) - (pictureBox.Height / 2) + pictureBox.Height / 2 + (game.spielbrett.getAmeisenPosition().Y - pictureBox.Height));


					//pictureBox.Location = new Point(
					//	  game.spielbrett.getAmeisenPosition().X / 2, 
					//	 game.spielbrett.getAmeisenPosition().Y / 2);
				}
			}
		}
		#endregion

		#region [ Button Events ]

		#region - EventHandler: BtnPauseClick -
		private void btnPause_Click(object sender, EventArgs e)
		{
			_timer.Stop();
		}
		#endregion

		#region - EventHandler: BtnStartClick -
		private void btnStart_Click(object sender, EventArgs e)
		{
				if (rdBtnFast.Checked)
				{
					fastMode();
				}
				else
				{
					_timer.Start();
				}


		}
		#endregion

		#region - EventHandler: BtnClearClick -
		private void btnClear_Click(object sender, EventArgs e)
		{
			designer.resetBitmap();
			pictureBox.Image = designer.getBitmap();
		}
		#endregion

		#region - EventHandler: BtnResetClick -
		private void btnReset_Click(object sender, EventArgs e)
		{
			_timer.Stop();

			game.spielbrett.initializeField();
			game.spielbrett.moveAmeiseToHome();
			designer.resetBitmap();
			
			pictureBox.Image = designer.getBitmap();
			drawMinimap();
		}
		#endregion

		#region - EventHandler: BtnAmeiseHome -
		private void btnAmeisePosition_Click(object sender, EventArgs e)
		{
			game.spielbrett.moveAmeiseToHome();
		}
		#endregion

		#region - EventHandler: BtnAmeiseRandom -
		private void btnRandomAmeisenPosition_Click(object sender, EventArgs e)
		{
			game.spielbrett.moveAmeiseToRandomPosition();
		}
		#endregion

		#region - EventHandler: BtnResetField -
		private void btnResetCustomField_Click(object sender, EventArgs e)
		{
			game.spielbrett.initializeField();
			designer.resetBitmap();
			drawBitmap();
			drawMinimap();
		}
		#endregion

		#region - EventHandler: BtnSwitchColorClick -
		private void btnSwitchColor_Click(object sender, EventArgs e)
		{
			int x;
			int y;

			bool isXValid = int.TryParse(txtBoxX.Text, out x);
			bool isYValid = int.TryParse(txtBoxY.Text, out y);

			if (!isXValid || !isYValid)
			{
				MessageBox.Show("Please enter valid values!");
				return;
			}

			if(x > game.spielbrett.Spielfelder.Count){
				MessageBox.Show("Please enter valid values!");
				return;
			}

			if (y > game.spielbrett.Spielfelder[0].Count)
			{
				MessageBox.Show("Please enter valid values!");
				return;
			}

			Game.SpielBrett.SpielFeld spielFeld = game.spielbrett.getSpielFeld(x, y);

			spielFeld.switchColor();
			
			game.spielbrett.setSpielFeld(spielFeld, x, y);
			designer.setNewField(x, y, spielFeld.isFieldWhite());

			drawBitmap();
			drawMinimap();
		}
		#endregion

		#region - EventHandler: BtnRandomiseFieldClick -
		private void btnRandomise_Click(object sender, EventArgs e)
		{
			bool enabled = false;

			if (_timer.IsEnabled)
			{
				enabled = true;
			}

			_timer.Stop();
			int percentage = trackBarFieldPercent.Value;
			game.spielbrett.initializeField(percentage);

			designer.resetBitmap();
			designer.initializeBitmap(game.spielbrett.Spielfelder);
			pictureBox.Image = designer.getBitmap();
			drawMinimap();

			if (enabled)
			{
				_timer.Start();
			}
		}
		#endregion

		#region - EventHandler: BtnApplyClick -
		private void btnApply_Click(object sender, EventArgs e)
		{
			int width;
			int height;

			bool widthValid = Int32.TryParse(txtBoxWidth.Text, out width);
			bool heightValid = Int32.TryParse(txtBoxHeight.Text, out height);

			if (!heightValid || !widthValid)
			{
				MessageBox.Show("Please enter valid values");
				return;
			}

			if (height <= 1 || height > 5000 || width <= 1 || width > 5000)
			{
				MessageBox.Show("Please enter valid values");
				return;
			}

			game = new Game();
			game.initializeSpielBrett(width, height);

			designer = new Designer(game);
			designer.scaling = scaleFactor;
			designer.initializeBitmap(game.spielbrett.Spielfelder);
			
			drawBitmap();
			drawMinimap();
		}
		#endregion

		#region - Eventhamdler: rdBtnFast_CheckedChanged -
		private void rdBtnFast_CheckedChanged(object sender, EventArgs e)
		{
			if (rdBtnFast.Checked)
			{
				if (_timer.IsEnabled)
				{
					fastMode();
				}
			}
		}
		#endregion

		#region
		private void btnMoveCameraHome_Click(object sender, EventArgs e)
		{
			pictureBox.Location = new Point((pictureBox.Parent.ClientSize.Width / 2) - (pictureBox.Width / 2),
											(pictureBox.Parent.ClientSize.Height / 2) - (pictureBox.Height / 2));
		}
		#endregion

		#endregion

		#region [ Trackbar Events ]

		#region - EventHandler: TrackBarValueChanged -
		private void trackBSpeed_Scroll(object sender, EventArgs e)
		{
			int interval = getIntervalFromSlider();

			_timer.Interval = TimeSpan.FromMilliseconds(interval);
			txtBoxSliderValue.Text = interval.ToString() + " ms";
		}
		#endregion

		#region - EventHandler: TrackBarFieldPercentageValueChanged -
		private void trackBarFieldPercent_Scroll(object sender, EventArgs e)
		{
			txtBoxSliderFieldPercent.Text = trackBarFieldPercent.Value + "%";
		}
		#endregion

		#region - Eventhandler: trackBarZoomLevel_Scroll() -
		private void trackBarZoomLevel_Scroll(object sender, EventArgs e)
		{
			this.trackBarScalingLevel.Enabled = false;
			int scaleFactor = trackBarScalingLevel.Value;
			
			txtBoxScalingLevel.Text = scaleFactor.ToString();
			txtBoxPixelsPerField.Text = (scaleFactor * scaleFactor).ToString();

			designer.scaling = scaleFactor;
			pictureBox.Image = designer.getBitmap();
			this.trackBarScalingLevel.Enabled = true;
		}
		#endregion

		#endregion

		#region - EventHandler: MouseWheelOnTrackBar -
		private void sliderSpeed_MouseWheel(object sender, MouseEventArgs e)
		{
			((HandledMouseEventArgs)e).Handled = true;

		}
		#endregion

		#region - EventHandler: MouseWheelOnTrackBar -
		private void tracktrackBarFieldPercent__MouseWheel(object sender, MouseEventArgs e)
		{
			((HandledMouseEventArgs)e).Handled = true;

		}
		#endregion

		#region - EventHandler: MouseWheelOnTrackBar -
		private void trackBarScalingLevel_MouseWheel(object sender, MouseEventArgs e)
		{
			((HandledMouseEventArgs)e).Handled = true;

		}
		#endregion

		#region - EventHandler: MouseWheel -
		void cetusForm_MouseWheel(object sender, MouseEventArgs e)
		{
			
		}
		#endregion

		#endregion

		#region [ Functions ]

		#region - Function: int getIntervalFromSlider() -
		private int getIntervalFromSlider()
		{
			int interval = 1;

			if (sliderSpeed.Value == 0)
			{
				interval = 500;
			}
			else
			{
				interval = 500 - sliderSpeed.Value * 50;
			}

			if (interval == 0)
			{
				interval = 1;
			}
			return interval;
		}
		#endregion

		#region - Function: void drawBitmap() -
		public void drawBitmap() 
		{
			pictureBox.Image = designer.getBitmap();
			centerBitmap(false);
		}

		public void drawBitmap(bool center)
		{
			pictureBox.Image = designer.getBitmap();
			if (center)
			{
				centerBitmap(false);
			}
		}
		#endregion

		#region - Function: void drawMinimap() -
		public void drawMinimap()
		{
			if (checkBoxDrawMinimap.Checked)
			{
				minimapPictureBox.Image = designer.getBitmap();
				if (!checkBoxEnergyMode.Checked)
				{
					designer.drawMinimap(pictureBox.Left * (-1), pictureBox.Top * (-1), drawingPanel.Width, drawingPanel.Height);
					minimapPictureBox.Image = designer.getMiniMap();
				}
			}
		}
		#endregion

		#region - Function: void resizePictureBox(Bitmap bitmap) -
		private void resizePictureBox(Bitmap bitmap)
		{
			pictureBox.Width = bitmap.Width;
			pictureBox.Height = bitmap.Height;
		}
		#endregion

		#region - Function: centerBitmap()
		public void centerBitmap(bool force)
		{
			if (!checkBoxAutoCenter.Checked)
			{
				return;
			}
			if (force == false)
			{
				if (_timer != null && _timer.IsEnabled)
				{
					return;
				}
			}
			if ((pictureBox.Parent.ClientSize.Width - 20) < pictureBox.Width && (pictureBox.Parent.ClientSize.Height - 20) < pictureBox.Height)
			{
				pictureBox.Location = new Point(10, 10);

			}
			else if ((pictureBox.Parent.ClientSize.Width - 20) < pictureBox.Width)
			{
				pictureBox.Location = new Point(10, (pictureBox.Parent.ClientSize.Height / 2) - (pictureBox.Height / 2));
			}
			else if ((pictureBox.Parent.ClientSize.Height - 20) < pictureBox.Height)
			{
				pictureBox.Location = new Point((pictureBox.Parent.ClientSize.Width / 2) - (pictureBox.Width / 2), 10);
			}
			else
			{
				pictureBox.Location = new Point((pictureBox.Parent.ClientSize.Width / 2) - (pictureBox.Width / 2), 
												(pictureBox.Parent.ClientSize.Height / 2) - (pictureBox.Height / 2));
			}

			pictureBox.Refresh();
		}
		#endregion

		#region - Function: saveBitmap()
		public void saveBitmap()
		{
			if (checkBoxSaveIfFinished.Checked)
			{
				designer.getBitmap().Save(new Random().Next(999999999).ToString() + ".png", ImageFormat.Png);
			}
		}
		#endregion

		#region - Function: fastMode()
		public void fastMode()
		{
			while (true)
			{
				if (!game.spielbrett.nextRound())
				{
					drawBitmap();
					drawMinimap();
					saveBitmap();
					game.spielbrett.moveAmeiseToHome();
					MessageBox.Show("Finished after: " + game.spielbrett.Moves.ToString() + " moves!");
					game.spielbrett.resetMoves();
					break;
				}
				designer.setNewField(game.spielbrett.lastPosition.X, game.spielbrett.lastPosition.Y, game.spielbrett.getLastSpielFeld().isFieldWhite());
			}
		}
		#endregion

		#endregion

	}
}