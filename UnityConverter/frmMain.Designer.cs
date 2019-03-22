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
            this.grpConertUnits = new System.Windows.Forms.GroupBox();
            this.rdioMiles = new System.Windows.Forms.RadioButton();
            this.rdioFeet = new System.Windows.Forms.RadioButton();
            this.rdioInches = new System.Windows.Forms.RadioButton();
            this.chkFromEnglishtoUnity = new System.Windows.Forms.CheckBox();
            this.lstSummation = new System.Windows.Forms.ListBox();
            this.cmdCopyValueToSummationList = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdRemoveSelectedItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdCopyUnityValue = new System.Windows.Forms.Button();
            this.cmdCopyListTotal = new System.Windows.Forms.Button();
            this.cmdClearAdditionList = new System.Windows.Forms.Button();
            this.grpConertUnits.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(71, 94);
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
            this.label1.Location = new System.Drawing.Point(41, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // txtUnityUnits
            // 
            this.txtUnityUnits.Location = new System.Drawing.Point(71, 130);
            this.txtUnityUnits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUnityUnits.Name = "txtUnityUnits";
            this.txtUnityUnits.Size = new System.Drawing.Size(268, 26);
            this.txtUnityUnits.TabIndex = 4;
            this.txtUnityUnits.TabStop = false;
            // 
            // grpConertUnits
            // 
            this.grpConertUnits.Controls.Add(this.rdioMiles);
            this.grpConertUnits.Controls.Add(this.rdioFeet);
            this.grpConertUnits.Controls.Add(this.rdioInches);
            this.grpConertUnits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpConertUnits.Location = new System.Drawing.Point(71, 207);
            this.grpConertUnits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpConertUnits.Name = "grpConertUnits";
            this.grpConertUnits.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpConertUnits.Size = new System.Drawing.Size(268, 154);
            this.grpConertUnits.TabIndex = 7;
            this.grpConertUnits.TabStop = false;
            this.grpConertUnits.Text = "Units";
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
            // lstSummation
            // 
            this.lstSummation.FormattingEnabled = true;
            this.lstSummation.ItemHeight = 20;
            this.lstSummation.Location = new System.Drawing.Point(429, 117);
            this.lstSummation.Name = "lstSummation";
            this.lstSummation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstSummation.Size = new System.Drawing.Size(223, 244);
            this.lstSummation.TabIndex = 9;
            // 
            // cmdCopyValueToSummationList
            // 
            this.cmdCopyValueToSummationList.Location = new System.Drawing.Point(346, 125);
            this.cmdCopyValueToSummationList.Name = "cmdCopyValueToSummationList";
            this.cmdCopyValueToSummationList.Size = new System.Drawing.Size(49, 36);
            this.cmdCopyValueToSummationList.TabIndex = 10;
            this.cmdCopyValueToSummationList.Text = ">>";
            this.cmdCopyValueToSummationList.UseVisualStyleBackColor = true;
            this.cmdCopyValueToSummationList.Click += new System.EventHandler(this.cmdCopyValueToSummationList_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(429, 435);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(223, 26);
            this.txtTotal.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "TOTAL";
            // 
            // cmdRemoveSelectedItem
            // 
            this.cmdRemoveSelectedItem.Location = new System.Drawing.Point(658, 117);
            this.cmdRemoveSelectedItem.Name = "cmdRemoveSelectedItem";
            this.cmdRemoveSelectedItem.Size = new System.Drawing.Size(49, 36);
            this.cmdRemoveSelectedItem.TabIndex = 13;
            this.cmdRemoveSelectedItem.Text = "X";
            this.cmdRemoveSelectedItem.UseVisualStyleBackColor = true;
            this.cmdRemoveSelectedItem.Click += new System.EventHandler(this.cmdRemoveSelectedItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Addition List";
            // 
            // cmdCopyUnityValue
            // 
            this.cmdCopyUnityValue.Location = new System.Drawing.Point(151, 164);
            this.cmdCopyUnityValue.Name = "cmdCopyUnityValue";
            this.cmdCopyUnityValue.Size = new System.Drawing.Size(108, 36);
            this.cmdCopyUnityValue.TabIndex = 15;
            this.cmdCopyUnityValue.Text = "Copy";
            this.cmdCopyUnityValue.UseVisualStyleBackColor = true;
            this.cmdCopyUnityValue.Click += new System.EventHandler(this.cmdCopyUnityValue_Click);
            // 
            // cmdCopyListTotal
            // 
            this.cmdCopyListTotal.Location = new System.Drawing.Point(486, 469);
            this.cmdCopyListTotal.Name = "cmdCopyListTotal";
            this.cmdCopyListTotal.Size = new System.Drawing.Size(108, 36);
            this.cmdCopyListTotal.TabIndex = 16;
            this.cmdCopyListTotal.Text = "Copy Total";
            this.cmdCopyListTotal.UseVisualStyleBackColor = true;
            this.cmdCopyListTotal.Click += new System.EventHandler(this.cmdCopyListTotal_Click);
            // 
            // cmdClearAdditionList
            // 
            this.cmdClearAdditionList.Location = new System.Drawing.Point(486, 367);
            this.cmdClearAdditionList.Name = "cmdClearAdditionList";
            this.cmdClearAdditionList.Size = new System.Drawing.Size(108, 36);
            this.cmdClearAdditionList.TabIndex = 17;
            this.cmdClearAdditionList.Text = "Clear";
            this.cmdClearAdditionList.UseVisualStyleBackColor = true;
            this.cmdClearAdditionList.Click += new System.EventHandler(this.cmdClearAdditionList_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 549);
            this.Controls.Add(this.cmdClearAdditionList);
            this.Controls.Add(this.cmdCopyListTotal);
            this.Controls.Add(this.cmdCopyUnityValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdRemoveSelectedItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.cmdCopyValueToSummationList);
            this.Controls.Add(this.lstSummation);
            this.Controls.Add(this.chkFromEnglishtoUnity);
            this.Controls.Add(this.grpConertUnits);
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
        private System.Windows.Forms.GroupBox grpConertUnits;
        private System.Windows.Forms.RadioButton rdioMiles;
        private System.Windows.Forms.RadioButton rdioFeet;
        private System.Windows.Forms.RadioButton rdioInches;
        private System.Windows.Forms.CheckBox chkFromEnglishtoUnity;
        private System.Windows.Forms.ListBox lstSummation;
        private System.Windows.Forms.Button cmdCopyValueToSummationList;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdRemoveSelectedItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdCopyUnityValue;
        private System.Windows.Forms.Button cmdCopyListTotal;
        private System.Windows.Forms.Button cmdClearAdditionList;
    }
}

