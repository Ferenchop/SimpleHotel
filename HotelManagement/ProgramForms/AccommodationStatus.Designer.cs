namespace HotelManagement.ProgramForms
{
    partial class AccommodationStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccommodationStatus));
            this.accommodataionGrid = new System.Windows.Forms.DataGridView();
            this.bbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accommodataionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // accommodataionGrid
            // 
            this.accommodataionGrid.AllowUserToAddRows = false;
            this.accommodataionGrid.AllowUserToDeleteRows = false;
            this.accommodataionGrid.AllowUserToOrderColumns = true;
            this.accommodataionGrid.AllowUserToResizeColumns = false;
            this.accommodataionGrid.AllowUserToResizeRows = false;
            this.accommodataionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accommodataionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accommodataionGrid.Location = new System.Drawing.Point(12, 12);
            this.accommodataionGrid.Name = "accommodataionGrid";
            this.accommodataionGrid.ReadOnly = true;
            this.accommodataionGrid.RowHeadersVisible = false;
            this.accommodataionGrid.Size = new System.Drawing.Size(776, 405);
            this.accommodataionGrid.TabIndex = 1;
            // 
            // bbutton
            // 
            this.bbutton.Location = new System.Drawing.Point(651, 426);
            this.bbutton.Name = "bbutton";
            this.bbutton.Size = new System.Drawing.Size(137, 23);
            this.bbutton.TabIndex = 2;
            this.bbutton.Text = "Back";
            this.bbutton.UseVisualStyleBackColor = true;
            this.bbutton.Click += new System.EventHandler(this.bbutton_Click);
            // 
            // AccommodationStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagement.Properties.Resources.Form1Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bbutton);
            this.Controls.Add(this.accommodataionGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccommodationStatus";
            this.Text = "AccommodationStatus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.accommodataionGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView accommodataionGrid;
        private System.Windows.Forms.Button bbutton;
    }
}