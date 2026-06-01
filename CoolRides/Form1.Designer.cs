namespace CoolRides
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
            this.rbnBlackLux = new System.Windows.Forms.RadioButton();
            this.rbnWhiteLux = new System.Windows.Forms.RadioButton();
            this.rbnBlackMv = new System.Windows.Forms.RadioButton();
            this.rbnWhiteMv = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblModels = new System.Windows.Forms.Label();
            this.lblCarQue = new System.Windows.Forms.Label();
            this.lblMinibusQue = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblMinibus = new System.Windows.Forms.Label();
            this.lblCarAssembly = new System.Windows.Forms.Label();
            this.lblCarStatus = new System.Windows.Forms.Label();
            this.lblMinibusAssembly = new System.Windows.Forms.Label();
            this.lblMinibusStatus = new System.Windows.Forms.Label();
            this.lblSpraybooth = new System.Windows.Forms.Label();
            this.lblSprayboothStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbnBlackLux
            // 
            this.rbnBlackLux.AutoSize = true;
            this.rbnBlackLux.Location = new System.Drawing.Point(12, 111);
            this.rbnBlackLux.Name = "rbnBlackLux";
            this.rbnBlackLux.Size = new System.Drawing.Size(118, 20);
            this.rbnBlackLux.TabIndex = 0;
            this.rbnBlackLux.TabStop = true;
            this.rbnBlackLux.Text = "Black LUX1000";
            this.rbnBlackLux.UseVisualStyleBackColor = true;
            // 
            // rbnWhiteLux
            // 
            this.rbnWhiteLux.AutoSize = true;
            this.rbnWhiteLux.Location = new System.Drawing.Point(12, 153);
            this.rbnWhiteLux.Name = "rbnWhiteLux";
            this.rbnWhiteLux.Size = new System.Drawing.Size(118, 20);
            this.rbnWhiteLux.TabIndex = 1;
            this.rbnWhiteLux.TabStop = true;
            this.rbnWhiteLux.Text = "White LUX1000";
            this.rbnWhiteLux.UseVisualStyleBackColor = true;
            // 
            // rbnBlackMv
            // 
            this.rbnBlackMv.AutoSize = true;
            this.rbnBlackMv.Location = new System.Drawing.Point(12, 196);
            this.rbnBlackMv.Name = "rbnBlackMv";
            this.rbnBlackMv.Size = new System.Drawing.Size(106, 20);
            this.rbnBlackMv.TabIndex = 2;
            this.rbnBlackMv.TabStop = true;
            this.rbnBlackMv.Text = "Black MV500";
            this.rbnBlackMv.UseVisualStyleBackColor = true;
            this.rbnBlackMv.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbnWhiteMv
            // 
            this.rbnWhiteMv.AutoSize = true;
            this.rbnWhiteMv.Checked = true;
            this.rbnWhiteMv.Location = new System.Drawing.Point(12, 244);
            this.rbnWhiteMv.Name = "rbnWhiteMv";
            this.rbnWhiteMv.Size = new System.Drawing.Size(106, 20);
            this.rbnWhiteMv.TabIndex = 3;
            this.rbnWhiteMv.TabStop = true;
            this.rbnWhiteMv.Text = "White MV500";
            this.rbnWhiteMv.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(35, 317);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(104, 68);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblModels
            // 
            this.lblModels.AutoSize = true;
            this.lblModels.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModels.Location = new System.Drawing.Point(54, 34);
            this.lblModels.Name = "lblModels";
            this.lblModels.Size = new System.Drawing.Size(65, 20);
            this.lblModels.TabIndex = 5;
            this.lblModels.Text = "Models";
            // 
            // lblCarQue
            // 
            this.lblCarQue.AutoSize = true;
            this.lblCarQue.Location = new System.Drawing.Point(343, 60);
            this.lblCarQue.Name = "lblCarQue";
            this.lblCarQue.Size = new System.Drawing.Size(93, 20);
            this.lblCarQue.TabIndex = 6;
            this.lblCarQue.Text = "Car Queue:";
            // 
            // lblMinibusQue
            // 
            this.lblMinibusQue.AutoSize = true;
            this.lblMinibusQue.Location = new System.Drawing.Point(675, 60);
            this.lblMinibusQue.Name = "lblMinibusQue";
            this.lblMinibusQue.Size = new System.Drawing.Size(120, 20);
            this.lblMinibusQue.TabIndex = 7;
            this.lblMinibusQue.Text = "Minibus Queue";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(313, 101);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(165, 20);
            this.lblCar.TabIndex = 8;
            this.lblCar.Text = "Car production status";
            // 
            // lblMinibus
            // 
            this.lblMinibus.AutoSize = true;
            this.lblMinibus.Location = new System.Drawing.Point(634, 101);
            this.lblMinibus.Name = "lblMinibus";
            this.lblMinibus.Size = new System.Drawing.Size(158, 16);
            this.lblMinibus.TabIndex = 9;
            this.lblMinibus.Text = "Minibus Production status";
            // 
            // lblCarAssembly
            // 
            this.lblCarAssembly.AutoSize = true;
            this.lblCarAssembly.Location = new System.Drawing.Point(502, 198);
            this.lblCarAssembly.Name = "lblCarAssembly";
            this.lblCarAssembly.Size = new System.Drawing.Size(122, 16);
            this.lblCarAssembly.TabIndex = 10;
            this.lblCarAssembly.Text = "Car Assembly Line:";
            // 
            // lblCarStatus
            // 
            this.lblCarStatus.AutoSize = true;
            this.lblCarStatus.Location = new System.Drawing.Point(489, 262);
            this.lblCarStatus.Name = "lblCarStatus";
            this.lblCarStatus.Size = new System.Drawing.Size(135, 16);
            this.lblCarStatus.TabIndex = 11;
            this.lblCarStatus.Text = "Car Production Status";
            // 
            // lblMinibusAssembly
            // 
            this.lblMinibusAssembly.AutoSize = true;
            this.lblMinibusAssembly.Location = new System.Drawing.Point(502, 317);
            this.lblMinibusAssembly.Name = "lblMinibusAssembly";
            this.lblMinibusAssembly.Size = new System.Drawing.Size(147, 16);
            this.lblMinibusAssembly.TabIndex = 12;
            this.lblMinibusAssembly.Text = "Minibus Assembly Line:";
            // 
            // lblMinibusStatus
            // 
            this.lblMinibusStatus.AutoSize = true;
            this.lblMinibusStatus.Location = new System.Drawing.Point(489, 382);
            this.lblMinibusStatus.Name = "lblMinibusStatus";
            this.lblMinibusStatus.Size = new System.Drawing.Size(160, 16);
            this.lblMinibusStatus.TabIndex = 13;
            this.lblMinibusStatus.Text = "Minibus Production Status";
            // 
            // lblSpraybooth
            // 
            this.lblSpraybooth.AutoSize = true;
            this.lblSpraybooth.Location = new System.Drawing.Point(502, 439);
            this.lblSpraybooth.Name = "lblSpraybooth";
            this.lblSpraybooth.Size = new System.Drawing.Size(80, 16);
            this.lblSpraybooth.TabIndex = 14;
            this.lblSpraybooth.Text = "Spraybooth:";
            // 
            // lblSprayboothStatus
            // 
            this.lblSprayboothStatus.AutoSize = true;
            this.lblSprayboothStatus.Location = new System.Drawing.Point(489, 493);
            this.lblSprayboothStatus.Name = "lblSprayboothStatus";
            this.lblSprayboothStatus.Size = new System.Drawing.Size(117, 16);
            this.lblSprayboothStatus.TabIndex = 15;
            this.lblSprayboothStatus.Text = "Spraybooth Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 661);
            this.Controls.Add(this.lblSprayboothStatus);
            this.Controls.Add(this.lblSpraybooth);
            this.Controls.Add(this.lblMinibusStatus);
            this.Controls.Add(this.lblMinibusAssembly);
            this.Controls.Add(this.lblCarStatus);
            this.Controls.Add(this.lblCarAssembly);
            this.Controls.Add(this.lblMinibus);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.lblMinibusQue);
            this.Controls.Add(this.lblCarQue);
            this.Controls.Add(this.lblModels);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.rbnWhiteMv);
            this.Controls.Add(this.rbnBlackMv);
            this.Controls.Add(this.rbnWhiteLux);
            this.Controls.Add(this.rbnBlackLux);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbnBlackLux;
        private System.Windows.Forms.RadioButton rbnWhiteLux;
        private System.Windows.Forms.RadioButton rbnBlackMv;
        private System.Windows.Forms.RadioButton rbnWhiteMv;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblModels;
        private System.Windows.Forms.Label lblCarQue;
        private System.Windows.Forms.Label lblMinibusQue;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblMinibus;
        private System.Windows.Forms.Label lblCarAssembly;
        private System.Windows.Forms.Label lblCarStatus;
        private System.Windows.Forms.Label lblMinibusAssembly;
        private System.Windows.Forms.Label lblMinibusStatus;
        private System.Windows.Forms.Label lblSpraybooth;
        private System.Windows.Forms.Label lblSprayboothStatus;
    }
}

