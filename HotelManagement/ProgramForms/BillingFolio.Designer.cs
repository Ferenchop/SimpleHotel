namespace HotelManagement.ProgramForms
{
    partial class BillingFolio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingFolio));
            this.bbutton = new System.Windows.Forms.Button();
            this.gFirstName = new System.Windows.Forms.TextBox();
            this.gLastName = new System.Windows.Forms.TextBox();
            this.gResNumber = new System.Windows.Forms.TextBox();
            this.gTotalCharge = new System.Windows.Forms.TextBox();
            this.gTotalPayed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.saveAndProceed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bbutton
            // 
            this.bbutton.Location = new System.Drawing.Point(651, 426);
            this.bbutton.Name = "bbutton";
            this.bbutton.Size = new System.Drawing.Size(137, 23);
            this.bbutton.TabIndex = 3;
            this.bbutton.Text = "Back";
            this.bbutton.UseVisualStyleBackColor = true;
            this.bbutton.Click += new System.EventHandler(this.bbutton_Click);
            // 
            // gFirstName
            // 
            this.gFirstName.Location = new System.Drawing.Point(183, 12);
            this.gFirstName.Name = "gFirstName";
            this.gFirstName.ReadOnly = true;
            this.gFirstName.Size = new System.Drawing.Size(144, 20);
            this.gFirstName.TabIndex = 4;
            // 
            // gLastName
            // 
            this.gLastName.Location = new System.Drawing.Point(183, 52);
            this.gLastName.Name = "gLastName";
            this.gLastName.ReadOnly = true;
            this.gLastName.Size = new System.Drawing.Size(144, 20);
            this.gLastName.TabIndex = 5;
            // 
            // gResNumber
            // 
            this.gResNumber.Location = new System.Drawing.Point(183, 97);
            this.gResNumber.Name = "gResNumber";
            this.gResNumber.ReadOnly = true;
            this.gResNumber.Size = new System.Drawing.Size(144, 20);
            this.gResNumber.TabIndex = 6;
            // 
            // gTotalCharge
            // 
            this.gTotalCharge.Location = new System.Drawing.Point(183, 167);
            this.gTotalCharge.Name = "gTotalCharge";
            this.gTotalCharge.ReadOnly = true;
            this.gTotalCharge.Size = new System.Drawing.Size(144, 20);
            this.gTotalCharge.TabIndex = 7;
            // 
            // gTotalPayed
            // 
            this.gTotalPayed.Location = new System.Drawing.Point(183, 216);
            this.gTotalPayed.Name = "gTotalPayed";
            this.gTotalPayed.Size = new System.Drawing.Size(144, 20);
            this.gTotalPayed.TabIndex = 8;
            this.gTotalPayed.TextChanged += new System.EventHandler(this.gTotalPayed_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Reservation Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hotel Charge";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Amount Payed";
            // 
            // gTotal
            // 
            this.gTotal.Location = new System.Drawing.Point(183, 271);
            this.gTotal.Name = "gTotal";
            this.gTotal.ReadOnly = true;
            this.gTotal.Size = new System.Drawing.Size(144, 20);
            this.gTotal.TabIndex = 14;
            this.gTotal.TextChanged += new System.EventHandler(this.gTotal_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(12, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total";
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(15, 426);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(137, 23);
            this.payButton.TabIndex = 16;
            this.payButton.Text = "Payment";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // saveAndProceed
            // 
            this.saveAndProceed.Location = new System.Drawing.Point(15, 426);
            this.saveAndProceed.Name = "saveAndProceed";
            this.saveAndProceed.Size = new System.Drawing.Size(137, 23);
            this.saveAndProceed.TabIndex = 17;
            this.saveAndProceed.Text = "Save and proceed";
            this.saveAndProceed.UseVisualStyleBackColor = true;
            this.saveAndProceed.Click += new System.EventHandler(this.saveAndProceed_Click);
            // 
            // BillingFolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagement.Properties.Resources.Form1Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveAndProceed);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gTotalPayed);
            this.Controls.Add(this.gTotalCharge);
            this.Controls.Add(this.gResNumber);
            this.Controls.Add(this.gLastName);
            this.Controls.Add(this.gFirstName);
            this.Controls.Add(this.bbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BillingFolio";
            this.Text = "BillingFolio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bbutton;
        private System.Windows.Forms.TextBox gFirstName;
        private System.Windows.Forms.TextBox gLastName;
        private System.Windows.Forms.TextBox gResNumber;
        private System.Windows.Forms.TextBox gTotalCharge;
        private System.Windows.Forms.TextBox gTotalPayed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Button saveAndProceed;
    }
}