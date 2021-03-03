
namespace Rock_Paper_Scissors
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.imgBoss3 = new System.Windows.Forms.PictureBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.imgBoss1 = new System.Windows.Forms.PictureBox();
            this.lblBoss2 = new System.Windows.Forms.Label();
            this.imgBoss2 = new System.Windows.Forms.PictureBox();
            this.lblPlayerhp = new System.Windows.Forms.Label();
            this.barPlayerhp = new System.Windows.Forms.ProgressBar();
            this.barBoss2hp = new System.Windows.Forms.ProgressBar();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.grpDecision = new System.Windows.Forms.GroupBox();
            this.radProtect = new System.Windows.Forms.RadioButton();
            this.lblActions = new System.Windows.Forms.Label();
            this.barBoss1hp = new System.Windows.Forms.ProgressBar();
            this.lblBoss1 = new System.Windows.Forms.Label();
            this.barBoss3hp = new System.Windows.Forms.ProgressBar();
            this.lblBoss3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoss3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoss2)).BeginInit();
            this.grpDecision.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgPlayer
            // 
            this.imgPlayer.Location = new System.Drawing.Point(300, 243);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(172, 92);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 0;
            this.imgPlayer.TabStop = false;
            // 
            // imgBoss3
            // 
            this.imgBoss3.Image = global::Rock_Paper_Scissors.Properties.Resources.Paper;
            this.imgBoss3.Location = new System.Drawing.Point(557, 84);
            this.imgBoss3.Name = "imgBoss3";
            this.imgBoss3.Size = new System.Drawing.Size(166, 92);
            this.imgBoss3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBoss3.TabIndex = 1;
            this.imgBoss3.TabStop = false;
            this.imgBoss3.Visible = false;
            // 
            // lblPlayer
            // 
            this.lblPlayer.BackColor = System.Drawing.Color.Blue;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlayer.Location = new System.Drawing.Point(300, 338);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(172, 43);
            this.lblPlayer.TabIndex = 3;
            this.lblPlayer.Text = "Player";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgBoss1
            // 
            this.imgBoss1.Image = global::Rock_Paper_Scissors.Properties.Resources.Rock;
            this.imgBoss1.Location = new System.Drawing.Point(43, 84);
            this.imgBoss1.Name = "imgBoss1";
            this.imgBoss1.Size = new System.Drawing.Size(155, 92);
            this.imgBoss1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBoss1.TabIndex = 6;
            this.imgBoss1.TabStop = false;
            this.imgBoss1.Visible = false;
            // 
            // lblBoss2
            // 
            this.lblBoss2.BackColor = System.Drawing.Color.Crimson;
            this.lblBoss2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoss2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBoss2.Location = new System.Drawing.Point(299, 61);
            this.lblBoss2.Name = "lblBoss2";
            this.lblBoss2.Size = new System.Drawing.Size(166, 43);
            this.lblBoss2.TabIndex = 9;
            this.lblBoss2.Text = "Raid Boss";
            this.lblBoss2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBoss2.Click += new System.EventHandler(this.lblBoss2_Click);
            // 
            // imgBoss2
            // 
            this.imgBoss2.Location = new System.Drawing.Point(299, 140);
            this.imgBoss2.Name = "imgBoss2";
            this.imgBoss2.Size = new System.Drawing.Size(166, 92);
            this.imgBoss2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBoss2.TabIndex = 8;
            this.imgBoss2.TabStop = false;
            // 
            // lblPlayerhp
            // 
            this.lblPlayerhp.BackColor = System.Drawing.SystemColors.Control;
            this.lblPlayerhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerhp.Location = new System.Drawing.Point(300, 410);
            this.lblPlayerhp.Name = "lblPlayerhp";
            this.lblPlayerhp.Size = new System.Drawing.Size(172, 25);
            this.lblPlayerhp.TabIndex = 13;
            this.lblPlayerhp.Text = "250/250";
            this.lblPlayerhp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // barPlayerhp
            // 
            this.barPlayerhp.Location = new System.Drawing.Point(300, 384);
            this.barPlayerhp.Maximum = 250;
            this.barPlayerhp.Name = "barPlayerhp";
            this.barPlayerhp.Size = new System.Drawing.Size(172, 23);
            this.barPlayerhp.TabIndex = 12;
            this.barPlayerhp.Value = 250;
            // 
            // barBoss2hp
            // 
            this.barBoss2hp.Location = new System.Drawing.Point(299, 111);
            this.barBoss2hp.Maximum = 250;
            this.barBoss2hp.Name = "barBoss2hp";
            this.barBoss2hp.Size = new System.Drawing.Size(166, 23);
            this.barBoss2hp.TabIndex = 18;
            this.barBoss2hp.Value = 250;
            // 
            // radRock
            // 
            this.radRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRock.Location = new System.Drawing.Point(6, 37);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(104, 24);
            this.radRock.TabIndex = 19;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            this.radRock.CheckedChanged += new System.EventHandler(this.radRock_Checked);
            // 
            // radPaper
            // 
            this.radPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPaper.Location = new System.Drawing.Point(6, 67);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(104, 33);
            this.radPaper.TabIndex = 20;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            // 
            // radScissors
            // 
            this.radScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radScissors.Location = new System.Drawing.Point(6, 106);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(104, 33);
            this.radScissors.TabIndex = 21;
            this.radScissors.TabStop = true;
            this.radScissors.Text = "Scissors";
            this.radScissors.UseVisualStyleBackColor = true;
            // 
            // grpDecision
            // 
            this.grpDecision.Controls.Add(this.radProtect);
            this.grpDecision.Controls.Add(this.radRock);
            this.grpDecision.Controls.Add(this.radScissors);
            this.grpDecision.Controls.Add(this.radPaper);
            this.grpDecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDecision.Location = new System.Drawing.Point(12, 198);
            this.grpDecision.Name = "grpDecision";
            this.grpDecision.Size = new System.Drawing.Size(200, 173);
            this.grpDecision.TabIndex = 22;
            this.grpDecision.TabStop = false;
            this.grpDecision.Text = "Players Choice";
            // 
            // radProtect
            // 
            this.radProtect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radProtect.Location = new System.Drawing.Point(6, 138);
            this.radProtect.Name = "radProtect";
            this.radProtect.Size = new System.Drawing.Size(104, 33);
            this.radProtect.TabIndex = 22;
            this.radProtect.TabStop = true;
            this.radProtect.Text = "Protect";
            this.radProtect.UseVisualStyleBackColor = true;
            // 
            // lblActions
            // 
            this.lblActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActions.Location = new System.Drawing.Point(4, 372);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(271, 82);
            this.lblActions.TabIndex = 23;
            this.lblActions.Text = "Sample Text";
            // 
            // barBoss1hp
            // 
            this.barBoss1hp.Location = new System.Drawing.Point(46, 55);
            this.barBoss1hp.Maximum = 250;
            this.barBoss1hp.Name = "barBoss1hp";
            this.barBoss1hp.Size = new System.Drawing.Size(166, 23);
            this.barBoss1hp.TabIndex = 25;
            this.barBoss1hp.Value = 250;
            this.barBoss1hp.Visible = false;
            // 
            // lblBoss1
            // 
            this.lblBoss1.BackColor = System.Drawing.Color.Crimson;
            this.lblBoss1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoss1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBoss1.Location = new System.Drawing.Point(46, 9);
            this.lblBoss1.Name = "lblBoss1";
            this.lblBoss1.Size = new System.Drawing.Size(166, 43);
            this.lblBoss1.TabIndex = 24;
            this.lblBoss1.Text = "Raid Boss";
            this.lblBoss1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBoss1.Visible = false;
            // 
            // barBoss3hp
            // 
            this.barBoss3hp.Location = new System.Drawing.Point(557, 55);
            this.barBoss3hp.Maximum = 250;
            this.barBoss3hp.Name = "barBoss3hp";
            this.barBoss3hp.Size = new System.Drawing.Size(166, 23);
            this.barBoss3hp.TabIndex = 27;
            this.barBoss3hp.Value = 250;
            this.barBoss3hp.Visible = false;
            // 
            // lblBoss3
            // 
            this.lblBoss3.BackColor = System.Drawing.Color.Crimson;
            this.lblBoss3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoss3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBoss3.Location = new System.Drawing.Point(557, 9);
            this.lblBoss3.Name = "lblBoss3";
            this.lblBoss3.Size = new System.Drawing.Size(166, 43);
            this.lblBoss3.TabIndex = 26;
            this.lblBoss3.Text = "Raid Boss";
            this.lblBoss3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBoss3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.barBoss3hp);
            this.Controls.Add(this.lblBoss3);
            this.Controls.Add(this.barBoss1hp);
            this.Controls.Add(this.lblBoss1);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.grpDecision);
            this.Controls.Add(this.barBoss2hp);
            this.Controls.Add(this.lblPlayerhp);
            this.Controls.Add(this.barPlayerhp);
            this.Controls.Add(this.lblBoss2);
            this.Controls.Add(this.imgBoss2);
            this.Controls.Add(this.imgBoss1);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.imgBoss3);
            this.Controls.Add(this.imgPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoss3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoss2)).EndInit();
            this.grpDecision.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.PictureBox imgBoss3;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblBoss2;
        private System.Windows.Forms.PictureBox imgBoss2;
        private System.Windows.Forms.Label lblPlayerhp;
        private System.Windows.Forms.ProgressBar barPlayerhp;
        private System.Windows.Forms.ProgressBar barBoss2hp;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radScissors;
        private System.Windows.Forms.GroupBox grpDecision;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.RadioButton radProtect;
        private System.Windows.Forms.ProgressBar barBoss1hp;
        private System.Windows.Forms.Label lblBoss1;
        private System.Windows.Forms.ProgressBar barBoss3hp;
        private System.Windows.Forms.Label lblBoss3;
        private System.Windows.Forms.PictureBox imgBoss1;
    }
}

