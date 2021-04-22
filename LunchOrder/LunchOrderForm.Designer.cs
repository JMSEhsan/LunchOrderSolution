
namespace LunchOrder
{
    partial class LunchOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LunchOrderForm));
            this.HamRBtn = new System.Windows.Forms.RadioButton();
            this.PizzaRBtn = new System.Windows.Forms.RadioButton();
            this.SaladRBtn = new System.Windows.Forms.RadioButton();
            this.AddonGB = new System.Windows.Forms.GroupBox();
            this.AddonBx3 = new System.Windows.Forms.CheckBox();
            this.AddonBx2 = new System.Windows.Forms.CheckBox();
            this.AddonBx1 = new System.Windows.Forms.CheckBox();
            this.HamPrice = new System.Windows.Forms.Label();
            this.PizzaPrice = new System.Windows.Forms.Label();
            this.SaladPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SubTTLLb = new System.Windows.Forms.Label();
            this.PlaceOrderBtn = new System.Windows.Forms.Button();
            this.TaxLb = new System.Windows.Forms.Label();
            this.OrderTTLLb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TaxPercent = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddonGB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // HamRBtn
            // 
            this.HamRBtn.AutoSize = true;
            this.HamRBtn.Location = new System.Drawing.Point(33, 45);
            this.HamRBtn.Name = "HamRBtn";
            this.HamRBtn.Size = new System.Drawing.Size(116, 24);
            this.HamRBtn.TabIndex = 0;
            this.HamRBtn.TabStop = true;
            this.HamRBtn.Text = "Hamburger -";
            this.HamRBtn.UseVisualStyleBackColor = true;
            this.HamRBtn.CheckedChanged += new System.EventHandler(this.HamRBtn_CheckedChanged);
            // 
            // PizzaRBtn
            // 
            this.PizzaRBtn.AutoSize = true;
            this.PizzaRBtn.Location = new System.Drawing.Point(33, 88);
            this.PizzaRBtn.Name = "PizzaRBtn";
            this.PizzaRBtn.Size = new System.Drawing.Size(78, 24);
            this.PizzaRBtn.TabIndex = 1;
            this.PizzaRBtn.TabStop = true;
            this.PizzaRBtn.Text = "Pizza - ";
            this.PizzaRBtn.UseVisualStyleBackColor = true;
            this.PizzaRBtn.CheckedChanged += new System.EventHandler(this.HamRBtn_CheckedChanged);
            // 
            // SaladRBtn
            // 
            this.SaladRBtn.AutoSize = true;
            this.SaladRBtn.Location = new System.Drawing.Point(33, 133);
            this.SaladRBtn.Name = "SaladRBtn";
            this.SaladRBtn.Size = new System.Drawing.Size(77, 24);
            this.SaladRBtn.TabIndex = 2;
            this.SaladRBtn.TabStop = true;
            this.SaladRBtn.Text = "Salad -";
            this.SaladRBtn.UseVisualStyleBackColor = true;
            this.SaladRBtn.CheckedChanged += new System.EventHandler(this.HamRBtn_CheckedChanged);
            // 
            // AddonGB
            // 
            this.AddonGB.Controls.Add(this.AddonBx3);
            this.AddonGB.Controls.Add(this.AddonBx2);
            this.AddonGB.Controls.Add(this.AddonBx1);
            this.AddonGB.Location = new System.Drawing.Point(389, 27);
            this.AddonGB.Name = "AddonGB";
            this.AddonGB.Size = new System.Drawing.Size(301, 193);
            this.AddonGB.TabIndex = 3;
            this.AddonGB.TabStop = false;
            this.AddonGB.Text = "Add-on Items";
            // 
            // AddonBx3
            // 
            this.AddonBx3.AutoSize = true;
            this.AddonBx3.Location = new System.Drawing.Point(37, 141);
            this.AddonBx3.Name = "AddonBx3";
            this.AddonBx3.Size = new System.Drawing.Size(124, 24);
            this.AddonBx3.TabIndex = 2;
            this.AddonBx3.Text = "Add-on Item3";
            this.AddonBx3.UseVisualStyleBackColor = true;
            // 
            // AddonBx2
            // 
            this.AddonBx2.AutoSize = true;
            this.AddonBx2.Location = new System.Drawing.Point(37, 91);
            this.AddonBx2.Name = "AddonBx2";
            this.AddonBx2.Size = new System.Drawing.Size(124, 24);
            this.AddonBx2.TabIndex = 1;
            this.AddonBx2.Text = "Add-on Item2";
            this.AddonBx2.UseVisualStyleBackColor = true;
            // 
            // AddonBx1
            // 
            this.AddonBx1.AutoSize = true;
            this.AddonBx1.Location = new System.Drawing.Point(37, 41);
            this.AddonBx1.Name = "AddonBx1";
            this.AddonBx1.Size = new System.Drawing.Size(124, 24);
            this.AddonBx1.TabIndex = 0;
            this.AddonBx1.Text = "Add-on Item1";
            this.AddonBx1.UseVisualStyleBackColor = true;
            // 
            // HamPrice
            // 
            this.HamPrice.AutoSize = true;
            this.HamPrice.Location = new System.Drawing.Point(147, 49);
            this.HamPrice.Name = "HamPrice";
            this.HamPrice.Size = new System.Drawing.Size(73, 20);
            this.HamPrice.TabIndex = 7;
            this.HamPrice.Text = "PriceHam";
            // 
            // PizzaPrice
            // 
            this.PizzaPrice.AutoSize = true;
            this.PizzaPrice.Location = new System.Drawing.Point(105, 91);
            this.PizzaPrice.Name = "PizzaPrice";
            this.PizzaPrice.Size = new System.Drawing.Size(75, 20);
            this.PizzaPrice.TabIndex = 8;
            this.PizzaPrice.Text = "PricePizza";
            // 
            // SaladPrice
            // 
            this.SaladPrice.AutoSize = true;
            this.SaladPrice.Location = new System.Drawing.Point(108, 136);
            this.SaladPrice.Name = "SaladPrice";
            this.SaladPrice.Size = new System.Drawing.Size(78, 20);
            this.SaladPrice.TabIndex = 9;
            this.SaladPrice.Text = "PriceSalad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subtotal:";
            // 
            // SubTTLLb
            // 
            this.SubTTLLb.BackColor = System.Drawing.Color.PowderBlue;
            this.SubTTLLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SubTTLLb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubTTLLb.ForeColor = System.Drawing.Color.DarkGreen;
            this.SubTTLLb.Location = new System.Drawing.Point(147, 53);
            this.SubTTLLb.Name = "SubTTLLb";
            this.SubTTLLb.Size = new System.Drawing.Size(102, 28);
            this.SubTTLLb.TabIndex = 8;
            // 
            // PlaceOrderBtn
            // 
            this.PlaceOrderBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PlaceOrderBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.PlaceOrderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.PlaceOrderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PlaceOrderBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlaceOrderBtn.Location = new System.Drawing.Point(523, 285);
            this.PlaceOrderBtn.Name = "PlaceOrderBtn";
            this.PlaceOrderBtn.Size = new System.Drawing.Size(114, 39);
            this.PlaceOrderBtn.TabIndex = 4;
            this.PlaceOrderBtn.Text = "&Place Order";
            this.PlaceOrderBtn.UseVisualStyleBackColor = false;
            this.PlaceOrderBtn.Click += new System.EventHandler(this.PlaceOrderBtn_Click);
            this.PlaceOrderBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // TaxLb
            // 
            this.TaxLb.BackColor = System.Drawing.Color.PowderBlue;
            this.TaxLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TaxLb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TaxLb.ForeColor = System.Drawing.Color.DarkGreen;
            this.TaxLb.Location = new System.Drawing.Point(147, 105);
            this.TaxLb.Name = "TaxLb";
            this.TaxLb.Size = new System.Drawing.Size(102, 28);
            this.TaxLb.TabIndex = 10;
            // 
            // OrderTTLLb
            // 
            this.OrderTTLLb.BackColor = System.Drawing.Color.PowderBlue;
            this.OrderTTLLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrderTTLLb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderTTLLb.ForeColor = System.Drawing.Color.DarkGreen;
            this.OrderTTLLb.Location = new System.Drawing.Point(147, 155);
            this.OrderTTLLb.Name = "OrderTTLLb";
            this.OrderTTLLb.Size = new System.Drawing.Size(102, 28);
            this.OrderTTLLb.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tax";
            // 
            // TaxPercent
            // 
            this.TaxPercent.AutoSize = true;
            this.TaxPercent.BackColor = System.Drawing.Color.Transparent;
            this.TaxPercent.ForeColor = System.Drawing.Color.Black;
            this.TaxPercent.Location = new System.Drawing.Point(60, 106);
            this.TaxPercent.Name = "TaxPercent";
            this.TaxPercent.Size = new System.Drawing.Size(55, 20);
            this.TaxPercent.TabIndex = 13;
            this.TaxPercent.Text = "(%Tax):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Order Total:";
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ResetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.ResetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.ResetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetBtn.Location = new System.Drawing.Point(523, 372);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(114, 39);
            this.ResetBtn.TabIndex = 5;
            this.ResetBtn.Text = "&Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            this.ResetBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button2_KeyDown);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.Location = new System.Drawing.Point(523, 452);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(114, 39);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.ExitBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button3_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SaladRBtn);
            this.groupBox2.Controls.Add(this.SaladPrice);
            this.groupBox2.Controls.Add(this.PizzaPrice);
            this.groupBox2.Controls.Add(this.HamPrice);
            this.groupBox2.Controls.Add(this.HamRBtn);
            this.groupBox2.Controls.Add(this.PizzaRBtn);
            this.groupBox2.Location = new System.Drawing.Point(56, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 193);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main Course";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TaxLb);
            this.groupBox3.Controls.Add(this.SubTTLLb);
            this.groupBox3.Controls.Add(this.OrderTTLLb);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TaxPercent);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(56, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 206);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Total";
            // 
            // LunchOrderForm
            // 
            this.AcceptButton = this.PlaceOrderBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.CancelButton = this.ResetBtn;
            this.ClientSize = new System.Drawing.Size(746, 536);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.PlaceOrderBtn);
            this.Controls.Add(this.AddonGB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LunchOrderForm";
            this.Text = "Lunch Order";
            this.AddonGB.ResumeLayout(false);
            this.AddonGB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton HamRBtn;
        private System.Windows.Forms.RadioButton PizzaRBtn;
        private System.Windows.Forms.RadioButton SaladRBtn;
        private System.Windows.Forms.GroupBox AddonGB;
        private System.Windows.Forms.CheckBox AddonBx3;
        private System.Windows.Forms.CheckBox AddonBx2;
        private System.Windows.Forms.CheckBox AddonBx1;
        private System.Windows.Forms.Label HamPrice;
        private System.Windows.Forms.Label PizzaPrice;
        private System.Windows.Forms.Label SaladPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SubTTLLb;
        private System.Windows.Forms.Button PlaceOrderBtn;
        private System.Windows.Forms.Label TaxLb;
        private System.Windows.Forms.Label OrderTTLLb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TaxPercent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

