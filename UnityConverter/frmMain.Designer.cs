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
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnityUnits = new System.Windows.Forms.TextBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.grpConertUnits = new System.Windows.Forms.GroupBox();
            this.rdioInches = new System.Windows.Forms.RadioButton();
            this.rdioFeet = new System.Windows.Forms.RadioButton();
            this.rdioMiles = new System.Windows.Forms.RadioButton();
            this.chkFromEnglishtoUnity = new System.Windows.Forms.CheckBox();
            this.grpConertUnits.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(71, 126);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(268, 26);
            this.txtFrom.TabIndex = 1;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // txtUnityUnits
            // 
            this.txtUnityUnits.Location = new System.Drawing.Point(437, 126);
            this.txtUnityUnits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUnityUnits.Name = "txtUnityUnits";
            this.txtUnityUnits.Size = new System.Drawing.Size(268, 26);
            this.txtUnityUnits.TabIndex = 4;
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(581, 305);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(124, 35);
            this.cmdClose.TabIndex = 5;
            this.cmdClose.Text = "&CLOSE";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // grpConertUnits
            // 
            this.grpConertUnits.Controls.Add(this.rdioMiles);
            this.grpConertUnits.Controls.Add(this.rdioFeet);
            this.grpConertUnits.Controls.Add(this.rdioInches);
            this.grpConertUnits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpConertUnits.Location = new System.Drawing.Point(71, 186);
            this.grpConertUnits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpConertUnits.Name = "grpConertUnits";
            this.grpConertUnits.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpConertUnits.Size = new System.Drawing.Size(333, 154);
            this.grpConertUnits.TabIndex = 7;
            this.grpConertUnits.TabStop = false;
            this.grpConertUnits.Text = "Units";
            // 
            // rdioInches
            // 
            this.rdioInches.AutoSize = true;
            this.rdioInches.Location = new System.Drawing.Point(36, 29);
            this.rdioInches.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdioInches.Name = "rdioInches";
            this.rdioInches.Size = new System.Drawing.Size(94, 24);
            this.rdioInches.TabIndex = 7;
            this.rdioInches.TabStop = true;
            this.rdioInches.Text = "INCHES";
            this.rdioInches.UseVisualStyleBackColor = true;
            this.rdioInches.CheckedChanged += new System.EventHandler(this.rdioInches_CheckedChanged);
            // 
            // rdioFeet
            // 
            this.rdioFeet.AutoSize = true;
            this.rdioFeet.Location = new System.Drawing.Point(36, 65);
            this.rdioFeet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdioFeet.Name = "rdioFeet";
            this.rdioFeet.Size = new System.Drawing.Size(72, 24);
            this.rdioFeet.TabIndex = 8;
            this.rdioFeet.TabStop = true;
            this.rdioFeet.Text = "FEET";
            this.rdioFeet.UseVisualStyleBackColor = true;
            this.rdioFeet.CheckedChanged += new System.EventHandler(this.rdioFeet_CheckedChanged);
            // 
            // rdioMiles
            // 
            this.rdioMiles.AutoSize = true;
            this.rdioMiles.Location = new System.Drawing.Point(36, 100);
            this.rdioMiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdioMiles.Name = "rdioMiles";
            this.rdioMiles.Size = new System.Drawing.Size(81, 24);
            this.rdioMiles.TabIndex = 9;
            this.rdioMiles.TabStop = true;
            this.rdioMiles.Text = "MILES";
            this.rdioMiles.UseVisualStyleBackColor = true;
            this.rdioMiles.CheckedChanged += new System.EventHandler(this.rdioMiles_CheckedChanged);
            // 
            // chkFromEnglishtoUnity
            // 
            this.chkFromEnglishtoUnity.AutoSize = true;
            this.chkFromEnglishtoUnity.Checked = true;
            this.chkFromEnglishtoUnity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFromEnglishtoUnity.Location = new System.Drawing.Point(82, 60);
            this.chkFromEnglishtoUnity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkFromEnglishtoUnity.Name = "chkFromEnglishtoUnity";
            this.chkFromEnglishtoUnity.Size = new System.Drawing.Size(166, 24);
            this.chkFromEnglishtoUnity.TabIndex = 8;
            this.chkFromEnglishtoUnity.Text = "English to UNITY";
            this.chkFromEnglishtoUnity.UseVisualStyleBackColor = true;
            this.chkFromEnglishtoUnity.CheckedChanged += new System.EventHandler(this.chkFromEnglishtoUnity_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 467);
            this.Controls.Add(this.chkFromEnglishtoUnity);
            this.Controls.Add(this.grpConertUnits);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.txtUnityUnits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFrom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "UNITY Measurements Converter";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpConertUnits.ResumeLayout(false);
            this.grpConertUnits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnityUnits;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.GroupBox grpConertUnits;
        private System.Windows.Forms.RadioButton rdioMiles;
        private System.Windows.Forms.RadioButton rdioFeet;
        private System.Windows.Forms.RadioButton rdioInches;
        private System.Windows.Forms.CheckBox chkFromEnglishtoUnity;
    }
}

