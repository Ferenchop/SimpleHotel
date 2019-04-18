namespace HotelManagement.ProgramForms
{
    partial class GuestInHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestInHouse));
            this.guestsInHouseGrid = new System.Windows.Forms.DataGridView();
            this.bbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.guestsInHouseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // guestsInHouseGrid
            // 
            this.guestsInHouseGrid.AllowUserToAddRows = false;
            this.guestsInHouseGrid.AllowUserToDeleteRows = false;
            this.guestsInHouseGrid.AllowUserToOrderColumns = true;
            this.guestsInHouseGrid.AllowUserToResizeColumns = false;
            this.guestsInHouseGrid.AllowUserToResizeRows = false;
            this.guestsInHouseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guestsInHouseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestsInHouseGrid.Location = new System.Drawing.Point(12, 12);
            this.guestsInHouseGrid.Name = "guestsInHouseGrid";
            this.guestsInHouseGrid.ReadOnly = true;
            this.guestsInHouseGrid.RowHeadersVisible = false;
            this.guestsInHouseGrid.Size = new System.Drawing.Size(775, 407);
            this.guestsInHouseGrid.TabIndex = 1;
            this.guestsInHouseGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guestsInHouseGrid_CellDoubleClick);
            // 
            // bbutton
            // 
            this.bbutton.Location = new System.Drawing.Point(650, 425);
            this.bbutton.Name = "bbutton";
            this.bbutton.Size = new System.Drawing.Size(137, 23);
            this.bbutton.TabIndex = 3;
            this.bbutton.Text = "Back";
            this.bbutton.UseVisualStyleBackColor = true;
            this.bbutton.Click += new System.EventHandler(this.bbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Something else";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GuestInHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagement.Properties.Resources.Form1Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bbutton);
            this.Controls.Add(this.guestsInHouseGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuestInHouse";
            this.Text = "GuestInHouse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.guestsInHouseGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView guestsInHouseGrid;
        private System.Windows.Forms.Button bbutton;
        private System.Windows.Forms.Button button1;
    }
}