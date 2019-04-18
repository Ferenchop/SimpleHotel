namespace HotelManagement.ProgramForms
{
    partial class Arrivals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arrivals));
            this.arrivalsGrid = new System.Windows.Forms.DataGridView();
            this.bbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // arrivalsGrid
            // 
            this.arrivalsGrid.AllowUserToAddRows = false;
            this.arrivalsGrid.AllowUserToDeleteRows = false;
            this.arrivalsGrid.AllowUserToOrderColumns = true;
            this.arrivalsGrid.AllowUserToResizeColumns = false;
            this.arrivalsGrid.AllowUserToResizeRows = false;
            this.arrivalsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.arrivalsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arrivalsGrid.Location = new System.Drawing.Point(13, 13);
            this.arrivalsGrid.Name = "arrivalsGrid";
            this.arrivalsGrid.ReadOnly = true;
            this.arrivalsGrid.RowHeadersVisible = false;
            this.arrivalsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.arrivalsGrid.Size = new System.Drawing.Size(775, 407);
            this.arrivalsGrid.TabIndex = 0;
            this.arrivalsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.arrivalsGrid_Load);
            this.arrivalsGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.arrivalsGrid_CellMouseDoubleClick);
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
            // Arrivals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagement.Properties.Resources.Form1Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bbutton);
            this.Controls.Add(this.arrivalsGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Arrivals";
            this.Text = "Arrivals";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.arrivalsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView arrivalsGrid;
        private System.Windows.Forms.Button bbutton;
    }
}