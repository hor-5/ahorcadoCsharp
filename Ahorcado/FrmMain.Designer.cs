namespace Ahorcado
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.cardUser = new MaterialSkin.Controls.MaterialCard();
            this.btnJugar = new MaterialSkin.Controls.MaterialButton();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.lblNotificacion = new System.Windows.Forms.Label();
            this.cardGame = new MaterialSkin.Controls.MaterialCard();
            this.txtLetra = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.lblJugadas = new System.Windows.Forms.Label();
            this.btnRetry = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.lblPalabra = new MaterialSkin.Controls.MaterialLabel();
            this.btnPlay = new MaterialSkin.Controls.MaterialButton();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.imgAhorcado = new System.Windows.Forms.PictureBox();
            this.cardUser.SuspendLayout();
            this.cardGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAhorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // cardUser
            // 
            this.cardUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardUser.Controls.Add(this.btnJugar);
            this.cardUser.Controls.Add(this.txtUsuario);
            this.cardUser.Depth = 0;
            this.cardUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardUser.Location = new System.Drawing.Point(255, 146);
            this.cardUser.Margin = new System.Windows.Forms.Padding(14);
            this.cardUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardUser.Name = "cardUser";
            this.cardUser.Padding = new System.Windows.Forms.Padding(14);
            this.cardUser.Size = new System.Drawing.Size(290, 182);
            this.cardUser.TabIndex = 0;
            // 
            // btnJugar
            // 
            this.btnJugar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnJugar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnJugar.Depth = 0;
            this.btnJugar.HighEmphasis = true;
            this.btnJugar.Icon = null;
            this.btnJugar.Location = new System.Drawing.Point(111, 113);
            this.btnJugar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnJugar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnJugar.Size = new System.Drawing.Size(68, 36);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnJugar.UseAccentColor = false;
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.Hint = "Nickname";
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.Location = new System.Drawing.Point(70, 50);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(150, 36);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "";
            this.txtUsuario.TrailingIcon = null;
            this.txtUsuario.UseTallSize = false;
            // 
            // lblNotificacion
            // 
            this.lblNotificacion.AutoSize = true;
            this.lblNotificacion.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblNotificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNotificacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNotificacion.Location = new System.Drawing.Point(301, 388);
            this.lblNotificacion.Name = "lblNotificacion";
            this.lblNotificacion.Padding = new System.Windows.Forms.Padding(5);
            this.lblNotificacion.Size = new System.Drawing.Size(160, 28);
            this.lblNotificacion.TabIndex = 1;
            this.lblNotificacion.Text = "Ingrese un nickname!!";
            this.lblNotificacion.Visible = false;
            // 
            // cardGame
            // 
            this.cardGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardGame.Controls.Add(this.txtLetra);
            this.cardGame.Controls.Add(this.lblJugadas);
            this.cardGame.Controls.Add(this.btnRetry);
            this.cardGame.Controls.Add(this.lblPalabra);
            this.cardGame.Controls.Add(this.btnPlay);
            this.cardGame.Depth = 0;
            this.cardGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardGame.Location = new System.Drawing.Point(231, 119);
            this.cardGame.Margin = new System.Windows.Forms.Padding(14);
            this.cardGame.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardGame.Name = "cardGame";
            this.cardGame.Padding = new System.Windows.Forms.Padding(14);
            this.cardGame.Size = new System.Drawing.Size(329, 255);
            this.cardGame.TabIndex = 2;
            this.cardGame.Visible = false;
            // 
            // txtLetra
            // 
            this.txtLetra.AllowPromptAsInput = true;
            this.txtLetra.AnimateReadOnly = false;
            this.txtLetra.AsciiOnly = false;
            this.txtLetra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtLetra.BeepOnError = false;
            this.txtLetra.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtLetra.Depth = 0;
            this.txtLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLetra.HelperText = "letra";
            this.txtLetra.HidePromptOnLeave = false;
            this.txtLetra.HideSelection = true;
            this.txtLetra.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtLetra.LeadingIcon = null;
            this.txtLetra.Location = new System.Drawing.Point(84, 164);
            this.txtLetra.Mask = "L";
            this.txtLetra.MaxLength = 32767;
            this.txtLetra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.PasswordChar = '\0';
            this.txtLetra.PrefixSuffixText = null;
            this.txtLetra.PromptChar = '_';
            this.txtLetra.ReadOnly = false;
            this.txtLetra.RejectInputOnFirstFailure = false;
            this.txtLetra.ResetOnPrompt = true;
            this.txtLetra.ResetOnSpace = true;
            this.txtLetra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLetra.SelectedText = "";
            this.txtLetra.SelectionLength = 0;
            this.txtLetra.SelectionStart = 0;
            this.txtLetra.ShortcutsEnabled = true;
            this.txtLetra.ShowAssistiveText = true;
            this.txtLetra.Size = new System.Drawing.Size(60, 52);
            this.txtLetra.SkipLiterals = true;
            this.txtLetra.TabIndex = 5;
            this.txtLetra.TabStop = false;
            this.txtLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLetra.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtLetra.TrailingIcon = null;
            this.txtLetra.UseSystemPasswordChar = false;
            this.txtLetra.UseTallSize = false;
            this.txtLetra.ValidatingType = null;
            // 
            // lblJugadas
            // 
            this.lblJugadas.AutoSize = true;
            this.lblJugadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJugadas.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblJugadas.Location = new System.Drawing.Point(17, 223);
            this.lblJugadas.Name = "lblJugadas";
            this.lblJugadas.Size = new System.Drawing.Size(58, 17);
            this.lblJugadas.TabIndex = 4;
            this.lblJugadas.Text = "jugadas";
            this.lblJugadas.Visible = false;
            // 
            // btnRetry
            // 
            this.btnRetry.Depth = 0;
            this.btnRetry.Icon = ((System.Drawing.Image)(resources.GetObject("btnRetry.Icon")));
            this.btnRetry.Location = new System.Drawing.Point(289, 0);
            this.btnRetry.Mini = true;
            this.btnRetry.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(40, 40);
            this.btnRetry.TabIndex = 3;
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Depth = 0;
            this.lblPalabra.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblPalabra.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblPalabra.Location = new System.Drawing.Point(70, 71);
            this.lblPalabra.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(148, 29);
            this.lblPalabra.TabIndex = 2;
            this.lblPalabra.Text = "_ _ _ _ _ _ _ _ _";
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPlay.Depth = 0;
            this.btnPlay.HighEmphasis = true;
            this.btnPlay.Icon = null;
            this.btnPlay.Location = new System.Drawing.Point(162, 164);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPlay.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPlay.Size = new System.Drawing.Size(82, 36);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Jugada!";
            this.btnPlay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnPlay.UseAccentColor = true;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblTitulo.Location = new System.Drawing.Point(255, 73);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(260, 41);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Bienvenido $user";
            this.lblTitulo.Visible = false;
            // 
            // imgAhorcado
            // 
            this.imgAhorcado.Image = ((System.Drawing.Image)(resources.GetObject("imgAhorcado.Image")));
            this.imgAhorcado.Location = new System.Drawing.Point(19, 134);
            this.imgAhorcado.Name = "imgAhorcado";
            this.imgAhorcado.Size = new System.Drawing.Size(195, 212);
            this.imgAhorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAhorcado.TabIndex = 4;
            this.imgAhorcado.TabStop = false;
            this.imgAhorcado.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 708);
            this.Controls.Add(this.imgAhorcado);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cardGame);
            this.Controls.Add(this.lblNotificacion);
            this.Controls.Add(this.cardUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ahorcado";
            this.cardUser.ResumeLayout(false);
            this.cardUser.PerformLayout();
            this.cardGame.ResumeLayout(false);
            this.cardGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAhorcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard cardUser;
        private MaterialSkin.Controls.MaterialButton btnJugar;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private Label lblNotificacion;
        private MaterialSkin.Controls.MaterialCard cardGame;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialLabel lblPalabra;
        private MaterialSkin.Controls.MaterialButton btnPlay;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnRetry;
        private PictureBox imgAhorcado;
        private Label lblJugadas;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtLetra;
    }
}