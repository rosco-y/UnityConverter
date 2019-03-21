namespace UnityConverter
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmbInputUnits = new System.Windows.Forms.ComboBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnityUnits = new System.Windows.Forms.TextBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbInputUnits
            // 
            this.cmbInputUnits.FormattingEnabled = true;
            this.cmbInputUnits.Items.AddRange(new object[] {
            "INCHES",
            "FEET",
            "MILES"});
            this.cmbInputUnits.Location = new System.Drawing.Point(52, 82);
            this.cmbInputUnits.Name = "cmbInputUnits";
            this.cmbInputUnits.Size = new System.Drawing.Size(163, 21);
            this.cmbInputUnits.TabIndex = 0;
            this.cmbInputUnits.SelectedIndexChanged += new System.EventHandler(this.cmbInputUnits_SelectedIndexChanged);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(52, 56);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(163, 20);
            this.txtFrom.TabIndex = 1;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // txtUnityUnits
            // 
            this.txtUnityUnits.Location = new System.Drawing.Point(271, 56);
            this.txtUnityUnits.Name = "txtUnityUnits";
            this.txtUnityUnits.Size = new System.Drawing.Size(163, 20);
            this.txtUnityUnits.TabIndex = 4;
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(204, 132);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 5;
            this.cmdClose.Text = "&CLOSE";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 177);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.txtUnityUnits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.cmbInputUnits);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "ConvertFromUnityto";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbInputUnits;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnityUnits;
        private System.Windows.Forms.Button cmdClose;
    }
}

