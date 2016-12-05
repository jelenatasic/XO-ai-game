namespace XO
{
    partial class FormOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RadioButton_Human_vs_Human = new MetroFramework.Controls.MetroRadioButton();
            this.RadioButton_Human_vs_Computer = new MetroFramework.Controls.MetroRadioButton();
            this.Button_StartGame = new MetroFramework.Controls.MetroButton();
            this.RadioButton_FirtstPlayer_Human = new MetroFramework.Controls.MetroRadioButton();
            this.RadioButton_FirtstPlayer_Computer = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_FirstPlayer = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox_FirstPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadioButton_Human_vs_Human
            // 
            this.RadioButton_Human_vs_Human.AutoSize = true;
            this.RadioButton_Human_vs_Human.Checked = true;
            this.RadioButton_Human_vs_Human.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.RadioButton_Human_vs_Human.Location = new System.Drawing.Point(17, 30);
            this.RadioButton_Human_vs_Human.Name = "RadioButton_Human_vs_Human";
            this.RadioButton_Human_vs_Human.Size = new System.Drawing.Size(177, 25);
            this.RadioButton_Human_vs_Human.TabIndex = 1;
            this.RadioButton_Human_vs_Human.TabStop = true;
            this.RadioButton_Human_vs_Human.Text = "Human vs Human";
            this.RadioButton_Human_vs_Human.UseSelectable = true;
            this.RadioButton_Human_vs_Human.CheckedChanged += new System.EventHandler(this.RadioButton_Human_vs_Human_CheckedChanged);
            // 
            // RadioButton_Human_vs_Computer
            // 
            this.RadioButton_Human_vs_Computer.AutoSize = true;
            this.RadioButton_Human_vs_Computer.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.RadioButton_Human_vs_Computer.Location = new System.Drawing.Point(211, 30);
            this.RadioButton_Human_vs_Computer.Name = "RadioButton_Human_vs_Computer";
            this.RadioButton_Human_vs_Computer.Size = new System.Drawing.Size(200, 25);
            this.RadioButton_Human_vs_Computer.TabIndex = 2;
            this.RadioButton_Human_vs_Computer.Text = "Human vs Computer";
            this.RadioButton_Human_vs_Computer.UseSelectable = true;
            this.RadioButton_Human_vs_Computer.CheckedChanged += new System.EventHandler(this.RadioButton_Human_vs_Computer_CheckedChanged);
            // 
            // Button_StartGame
            // 
            this.Button_StartGame.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_StartGame.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Button_StartGame.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Button_StartGame.Location = new System.Drawing.Point(152, 296);
            this.Button_StartGame.Name = "Button_StartGame";
            this.Button_StartGame.Size = new System.Drawing.Size(170, 41);
            this.Button_StartGame.TabIndex = 3;
            this.Button_StartGame.Text = "PLAY";
            this.Button_StartGame.UseSelectable = true;
            this.Button_StartGame.Click += new System.EventHandler(this.Button_StartGame_Click);
            // 
            // RadioButton_FirtstPlayer_Human
            // 
            this.RadioButton_FirtstPlayer_Human.AutoSize = true;
            this.RadioButton_FirtstPlayer_Human.Checked = true;
            this.RadioButton_FirtstPlayer_Human.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.RadioButton_FirtstPlayer_Human.Location = new System.Drawing.Point(188, 42);
            this.RadioButton_FirtstPlayer_Human.Name = "RadioButton_FirtstPlayer_Human";
            this.RadioButton_FirtstPlayer_Human.Size = new System.Drawing.Size(89, 25);
            this.RadioButton_FirtstPlayer_Human.TabIndex = 0;
            this.RadioButton_FirtstPlayer_Human.TabStop = true;
            this.RadioButton_FirtstPlayer_Human.Text = "Human";
            this.RadioButton_FirtstPlayer_Human.UseSelectable = true;
            // 
            // RadioButton_FirtstPlayer_Computer
            // 
            this.RadioButton_FirtstPlayer_Computer.AutoSize = true;
            this.RadioButton_FirtstPlayer_Computer.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.RadioButton_FirtstPlayer_Computer.Location = new System.Drawing.Point(298, 42);
            this.RadioButton_FirtstPlayer_Computer.Name = "RadioButton_FirtstPlayer_Computer";
            this.RadioButton_FirtstPlayer_Computer.Size = new System.Drawing.Size(112, 25);
            this.RadioButton_FirtstPlayer_Computer.TabIndex = 1;
            this.RadioButton_FirtstPlayer_Computer.Text = "Computer";
            this.RadioButton_FirtstPlayer_Computer.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButton_Human_vs_Computer);
            this.groupBox1.Controls.Add(this.RadioButton_Human_vs_Human);
            this.groupBox1.Location = new System.Drawing.Point(23, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 71);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox_FirstPlayer
            // 
            this.groupBox_FirstPlayer.Controls.Add(this.RadioButton_FirtstPlayer_Computer);
            this.groupBox_FirstPlayer.Controls.Add(this.RadioButton_FirtstPlayer_Human);
            this.groupBox_FirstPlayer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_FirstPlayer.Location = new System.Drawing.Point(23, 186);
            this.groupBox_FirstPlayer.Name = "groupBox_FirstPlayer";
            this.groupBox_FirstPlayer.Size = new System.Drawing.Size(415, 73);
            this.groupBox_FirstPlayer.TabIndex = 7;
            this.groupBox_FirstPlayer.TabStop = false;
            this.groupBox_FirstPlayer.Text = "First to make move:";
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 360);
            this.Controls.Add(this.groupBox_FirstPlayer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Button_StartGame);
            this.Name = "FormOptions";
            this.Resizable = false;
            this.Text = "Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_FirstPlayer.ResumeLayout(false);
            this.groupBox_FirstPlayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton RadioButton_Human_vs_Human;
        private MetroFramework.Controls.MetroRadioButton RadioButton_Human_vs_Computer;
        private MetroFramework.Controls.MetroButton Button_StartGame;
        private MetroFramework.Controls.MetroRadioButton RadioButton_FirtstPlayer_Computer;
        private MetroFramework.Controls.MetroRadioButton RadioButton_FirtstPlayer_Human;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_FirstPlayer;
    }
}