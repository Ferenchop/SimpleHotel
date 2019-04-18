namespace HotelManagement.ProgramForms
{
    partial class Departures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departures));
            this.deprturesGrid = new System.Windows.Forms.DataGridView();
            this.bbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deprturesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // deprturesGrid
            // 
            this.deprturesGrid.AllowUserToAddRows = false;
            this.deprturesGrid.AllowUserToDeleteRows = false;
            this.deprturesGrid.AllowUserToOrderColumns = true;
            this.deprturesGrid.AllowUserToResizeColumns = false;
            this.deprturesGrid.AllowUserToResizeRows = false;
            this.deprturesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deprturesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deprturesGrid.Location = new System.Drawing.Point(12, 12);
            this.deprturesGrid.Name = "deprturesGrid";
            this.deprturesGrid.ReadOnly = true;
            this.deprturesGrid.RowHeadersVisible = false;
            this.deprturesGrid.Size = new System.Drawing.Size(776, 408);
            this.deprturesGrid.TabIndex = 0;
            this.deprturesGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deprturesGrid_CellContentDoubleClick);
            // 
            // bbutton
            // 
            this.bbutton.Location = new System.Drawing.Point(651, 426);
            this.bbutton.Name = "bbutton";
            this.bbutton.Size = new System.Drawing.Size(137, 23);
            this.bbutton.TabIndex = 1;
            this.bbutton.Text = "Back";
            this.bbutton.UseVisualStyleBackColor = true;
            this.bbutton.Click += new System.EventHandler(this.bbutton_Click);
            // 
            // Departures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagement.Properties.Resources.Form1Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bbutton);
            this.Controls.Add(this.deprturesGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Departures";
            this.Text = "Departures";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.deprturesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView deprturesGrid;
        private System.Windows.Forms.Button bbutton;
    }
}