namespace GreenLuma
{
    partial class Form_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_SteamClient = new System.Windows.Forms.Label();
            this.textBox_SteamClient = new System.Windows.Forms.TextBox();
            this.button_SteamClient = new System.Windows.Forms.Button();
            this.label_SteamGames = new System.Windows.Forms.Label();
            this.textBox_SteamGames = new System.Windows.Forms.TextBox();
            this.button_LumaInstall = new System.Windows.Forms.Button();
            this.gradientProgressBar_LumaStatus = new GradientProgressBar();
            this.SuspendLayout();
            // 
            // label_SteamClient
            // 
            this.label_SteamClient.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SteamClient.Location = new System.Drawing.Point(12, 8);
            this.label_SteamClient.Name = "label_SteamClient";
            this.label_SteamClient.Size = new System.Drawing.Size(280, 24);
            this.label_SteamClient.TabIndex = 0;
            this.label_SteamClient.Text = "Steam Client Directory";
            // 
            // textBox_SteamClient
            // 
            this.textBox_SteamClient.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SteamClient.Location = new System.Drawing.Point(17, 35);
            this.textBox_SteamClient.Name = "textBox_SteamClient";
            this.textBox_SteamClient.ReadOnly = true;
            this.textBox_SteamClient.Size = new System.Drawing.Size(670, 23);
            this.textBox_SteamClient.TabIndex = 1;
            this.textBox_SteamClient.Text = " ...";
            // 
            // button_SteamClient
            // 
            this.button_SteamClient.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SteamClient.Location = new System.Drawing.Point(695, 35);
            this.button_SteamClient.Name = "button_SteamClient";
            this.button_SteamClient.Size = new System.Drawing.Size(75, 23);
            this.button_SteamClient.TabIndex = 2;
            this.button_SteamClient.Text = "Edit";
            this.button_SteamClient.UseVisualStyleBackColor = true;
            this.button_SteamClient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_SteamClient_MouseClick);
            // 
            // label_SteamGames
            // 
            this.label_SteamGames.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SteamGames.Location = new System.Drawing.Point(12, 76);
            this.label_SteamGames.Name = "label_SteamGames";
            this.label_SteamGames.Size = new System.Drawing.Size(280, 24);
            this.label_SteamGames.TabIndex = 3;
            this.label_SteamGames.Text = "Steam Games";
            // 
            // textBox_SteamGames
            // 
            this.textBox_SteamGames.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SteamGames.Location = new System.Drawing.Point(17, 104);
            this.textBox_SteamGames.Multiline = true;
            this.textBox_SteamGames.Name = "textBox_SteamGames";
            this.textBox_SteamGames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_SteamGames.Size = new System.Drawing.Size(670, 180);
            this.textBox_SteamGames.TabIndex = 4;
            this.textBox_SteamGames.TextChanged += new System.EventHandler(this.textBox_SteamGames_TextChanged);
            this.textBox_SteamGames.Leave += new System.EventHandler(this.textBox_SteamGames_Leave);
            // 
            // button_LumaInstall
            // 
            this.button_LumaInstall.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LumaInstall.Location = new System.Drawing.Point(302, 306);
            this.button_LumaInstall.Name = "button_LumaInstall";
            this.button_LumaInstall.Size = new System.Drawing.Size(180, 60);
            this.button_LumaInstall.TabIndex = 7;
            this.button_LumaInstall.Text = "...";
            this.button_LumaInstall.UseVisualStyleBackColor = true;
            this.button_LumaInstall.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_LumaInstall_MouseClick);
            // 
            // gradientProgressBar_LumaStatus
            // 
            this.gradientProgressBar_LumaStatus.BorderColor = System.Drawing.Color.Black;
            this.gradientProgressBar_LumaStatus.BorderThickness = 1;
            this.gradientProgressBar_LumaStatus.EndColor = System.Drawing.Color.White;
            this.gradientProgressBar_LumaStatus.Location = new System.Drawing.Point(0, 388);
            this.gradientProgressBar_LumaStatus.Name = "gradientProgressBar_LumaStatus";
            this.gradientProgressBar_LumaStatus.ShowBorder = false;
            this.gradientProgressBar_LumaStatus.Size = new System.Drawing.Size(784, 23);
            this.gradientProgressBar_LumaStatus.StartColor = System.Drawing.Color.Black;
            this.gradientProgressBar_LumaStatus.TabIndex = 6;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.button_LumaInstall);
            this.Controls.Add(this.gradientProgressBar_LumaStatus);
            this.Controls.Add(this.textBox_SteamGames);
            this.Controls.Add(this.label_SteamGames);
            this.Controls.Add(this.button_SteamClient);
            this.Controls.Add(this.textBox_SteamClient);
            this.Controls.Add(this.label_SteamClient);
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Green Luma";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SteamClient;
        private System.Windows.Forms.TextBox textBox_SteamClient;
        private System.Windows.Forms.Button button_SteamClient;
        private System.Windows.Forms.Label label_SteamGames;
        private System.Windows.Forms.TextBox textBox_SteamGames;
        private GradientProgressBar gradientProgressBar_LumaStatus;
        private System.Windows.Forms.Button button_LumaInstall;
    }
}

