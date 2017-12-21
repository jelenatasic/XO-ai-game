using System;
using System.Windows.Forms;

namespace XO
{
	public partial class FormTabel : MetroFramework.Forms.MetroForm
	{
		bool game_mode;  //false - Human vs Human; true - Human vs Computer
		private GameState CurrentGameState;
		BotPlayer bot_player;
		FormOptions form_options;
		Int16 Human_figure;

		public FormTabel(bool game_mode, bool bot_pl, FormOptions options)
		{
			InitializeComponent();
			metroLabel1.Select();

			form_options = options;
			this.game_mode = game_mode;
			CurrentGameState = new GameState();

			if (game_mode)
				bot_player = new BotPlayer((Int16)(bot_pl ? 1 : 0));

			if (game_mode && bot_pl)
			{
				Int16[] move = bot_player.Play(CurrentGameState);
				CurrentGameState.ChangeState(move[0], move[1], bot_player.GetBotValue());
				SetTileText(move[0], move[1], bot_player.GetBotValue());
				Human_figure = 0;
			}
			else
				Human_figure = 1;

			if (!game_mode)
				Human_figure = 1;

		}

		private void Tile_Clicked(MetroFramework.Controls.MetroTile tile_clicked, int pos_x, int pos_y)
		{
			if (CurrentGameState.GetValueOnPosition(pos_x, pos_y) != -1)
				return;

			if (game_mode)
			{
				CurrentGameState.ChangeState(pos_x, pos_y, Human_figure);
				if (Human_figure == 0)
					tile_clicked.Text = "O";
				else
					tile_clicked.Text = "X";

				if (CurrentGameState.GameOver(Human_figure))
				{
					MetroFramework.MetroMessageBox.Show(this, "Player won!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 150);
					form_options.Visible = true;
					this.Dispose();
					return;
				}

				if (!CurrentGameState.Empty_Positions())
				{
					MetroFramework.MetroMessageBox.Show(this, "Draw!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 150);
					form_options.Visible = true;
					this.Dispose();
					return;
				}

				Int16[] move = bot_player.Play(CurrentGameState);
				CurrentGameState.ChangeState(move[0], move[1], bot_player.GetBotValue());
				SetTileText(move[0], move[1], bot_player.GetBotValue());

				if (CurrentGameState.GameOver(bot_player.GetBotValue()))
				{
					MetroFramework.MetroMessageBox.Show(this, "Computer won!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 150);
					form_options.Visible = true;
					this.Dispose();
					return;
				}

				if (!CurrentGameState.Empty_Positions())
				{
					MetroFramework.MetroMessageBox.Show(this, "Draw!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 150);
					form_options.Visible = true;
					this.Dispose();
					return;
				}
			}
			else
			{
				CurrentGameState.ChangeState(pos_x, pos_y, Human_figure);
				if (Human_figure == 0)
					tile_clicked.Text = "O";
				else
					tile_clicked.Text = "X";

				if (CurrentGameState.GameOver(Human_figure))
				{
					if (Human_figure == 0)
						MetroFramework.MetroMessageBox.Show(this, "Player O wins!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 150);
					else
						MetroFramework.MetroMessageBox.Show(this, "Player X wins!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 150);
					form_options.Visible = true;
					this.Dispose();
					return;
				}

				if (!CurrentGameState.Empty_Positions())
				{
					MetroFramework.MetroMessageBox.Show(this, "Draw!", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 150);
					form_options.Visible = true;
					this.Dispose();
					return;
				}

				if (Human_figure == 1)
					Human_figure = 0;
				else
					Human_figure = 1;
			}
		}

		private void Tile_0_0_Click(object sender, EventArgs e)
		{
			Tile_Clicked((MetroFramework.Controls.MetroTile)sender, 0, 0);
		}

		private void Tile_1_0_Click(object sender, EventArgs e)
		{
			Tile_Clicked((MetroFramework.Controls.MetroTile)sender, 1, 0);
		}

		private void Tile_2_0_Click(object sender, EventArgs e)
		{
			Tile_Clicked((MetroFramework.Controls.MetroTile)sender, 2, 0);
		}

		private void Tile_0_1_Click(object sender, EventArgs e)
		{
			Tile_Clicked((MetroFramework.Controls.MetroTile)sender, 0, 1);
		}

		private void Tile_1_1_Click(object sender, EventArgs e)
		{
			Tile_Clicked((MetroFramework.Controls.MetroTile)sender, 1, 1);
		}

		private void Tile_2_1_Click(object sender, EventArgs e)
		{
			Tile_Clicked((MetroFramework.Controls.MetroTile)sender, 2, 1);
		}

		private void Tile_0_2_Click(object sender, EventArgs e)
		{
			Tile_Clicked((MetroFramework.Controls.MetroTile)sender, 0, 2);
		}

		private void Tile_1_2_Click(object sender, EventArgs e)
		{
			Tile_Clicked((MetroFramework.Controls.MetroTile)sender, 1, 2);
		}

		private void Tile_2_2_Click(object sender, EventArgs e)
		{
			Tile_Clicked((MetroFramework.Controls.MetroTile)sender, 2, 2);
		}

		private void FormTabel_FormClosed(object sender, FormClosedEventArgs e)
		{
			form_options.Visible = true;
		}

		private void SetTileText(Int16 p1, Int16 p2, Int16 p3)
		{
			if (p1 == 0)
			{
				if (p2 == 0)
					Tile_0_0.Text = (p3 == 0) ? "O" : "X";
				if (p2 == 1)
					Tile_0_1.Text = (p3 == 0) ? "O" : "X";
				if (p2 == 2)
					Tile_0_2.Text = (p3 == 0) ? "O" : "X";
				return;

			}
			if (p1 == 1)
			{
				if (p2 == 0)
					Tile_1_0.Text = (p3 == 0) ? "O" : "X";
				if (p2 == 1)
					Tile_1_1.Text = (p3 == 0) ? "O" : "X";
				if (p2 == 2)
					Tile_1_2.Text = (p3 == 0) ? "O" : "X";
				return;
			}
			if (p1 == 2)
			{
				if (p2 == 0)
					Tile_2_0.Text = (p3 == 0) ? "O" : "X";
				if (p2 == 1)
					Tile_2_1.Text = (p3 == 0) ? "O" : "X";
				if (p2 == 2)
					Tile_2_2.Text = (p3 == 0) ? "O" : "X";
				return;
			}
		}

	}
}
