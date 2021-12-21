
namespace A1_Adam_Brennan_82094_
{
    partial class frmSharpAutoForm
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
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblAdditionalOptions = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTradeInAllowance = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtAdditionalOptions = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTradeInAllowance = new System.Windows.Forms.TextBox();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpAdditionalItems = new System.Windows.Forms.GroupBox();
            this.chkCompNav = new System.Windows.Forms.CheckBox();
            this.chkLeatherInterior = new System.Windows.Forms.CheckBox();
            this.chkStereoSystem = new System.Windows.Forms.CheckBox();
            this.grpExteriorFinish = new System.Windows.Forms.GroupBox();
            this.rdoCustom = new System.Windows.Forms.RadioButton();
            this.rdoPearlized = new System.Windows.Forms.RadioButton();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpAdditionalItems.SuspendLayout();
            this.grpExteriorFinish.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(68, 27);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(64, 13);
            this.lblBasePrice.TabIndex = 0;
            this.lblBasePrice.Text = "Base Price :";
            // 
            // lblAdditionalOptions
            // 
            this.lblAdditionalOptions.AutoSize = true;
            this.lblAdditionalOptions.Location = new System.Drawing.Point(37, 65);
            this.lblAdditionalOptions.Name = "lblAdditionalOptions";
            this.lblAdditionalOptions.Size = new System.Drawing.Size(95, 13);
            this.lblAdditionalOptions.TabIndex = 1;
            this.lblAdditionalOptions.Text = "Additional &Options:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(79, 102);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(53, 13);
            this.lblSubTotal.TabIndex = 2;
            this.lblSubTotal.Text = "SubTotal:";
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(46, 143);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(86, 13);
            this.lblSalesTax.TabIndex = 3;
            this.lblSalesTax.Text = "Sales Tax(13%) :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(95, 182);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total :";
            // 
            // lblTradeInAllowance
            // 
            this.lblTradeInAllowance.AutoSize = true;
            this.lblTradeInAllowance.Location = new System.Drawing.Point(27, 220);
            this.lblTradeInAllowance.Name = "lblTradeInAllowance";
            this.lblTradeInAllowance.Size = new System.Drawing.Size(105, 13);
            this.lblTradeInAllowance.TabIndex = 5;
            this.lblTradeInAllowance.Text = "Trade In Allowance :";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(60, 260);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(72, 13);
            this.lblAmountDue.TabIndex = 6;
            this.lblAmountDue.Text = "Amount Due :";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(138, 27);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(100, 20);
            this.txtBasePrice.TabIndex = 7;
            this.txtBasePrice.TextChanged += new System.EventHandler(this.txtBasePrice_TextChanged);
            // 
            // txtAdditionalOptions
            // 
            this.txtAdditionalOptions.Location = new System.Drawing.Point(138, 62);
            this.txtAdditionalOptions.Name = "txtAdditionalOptions";
            this.txtAdditionalOptions.ReadOnly = true;
            this.txtAdditionalOptions.Size = new System.Drawing.Size(100, 20);
            this.txtAdditionalOptions.TabIndex = 8;
            this.txtAdditionalOptions.Text = "0";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(138, 99);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 9;
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Location = new System.Drawing.Point(138, 140);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.ReadOnly = true;
            this.txtSalesTax.Size = new System.Drawing.Size(100, 20);
            this.txtSalesTax.TabIndex = 10;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(138, 179);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 11;
            // 
            // txtTradeInAllowance
            // 
            this.txtTradeInAllowance.Location = new System.Drawing.Point(138, 217);
            this.txtTradeInAllowance.Name = "txtTradeInAllowance";
            this.txtTradeInAllowance.Size = new System.Drawing.Size(100, 20);
            this.txtTradeInAllowance.TabIndex = 12;
            this.txtTradeInAllowance.Text = "0\r\n";
            this.txtTradeInAllowance.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.Location = new System.Drawing.Point(138, 257);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.ReadOnly = true;
            this.txtAmountDue.Size = new System.Drawing.Size(100, 20);
            this.txtAmountDue.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculateToolStripMenuItem.Text = "&Calculate";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "C&lear";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "&Color";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(427, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpAdditionalItems
            // 
            this.grpAdditionalItems.Controls.Add(this.chkCompNav);
            this.grpAdditionalItems.Controls.Add(this.chkLeatherInterior);
            this.grpAdditionalItems.Controls.Add(this.chkStereoSystem);
            this.grpAdditionalItems.Location = new System.Drawing.Point(302, 27);
            this.grpAdditionalItems.Name = "grpAdditionalItems";
            this.grpAdditionalItems.Size = new System.Drawing.Size(200, 100);
            this.grpAdditionalItems.TabIndex = 16;
            this.grpAdditionalItems.TabStop = false;
            this.grpAdditionalItems.Text = "Additional Items";
            // 
            // chkCompNav
            // 
            this.chkCompNav.AutoSize = true;
            this.chkCompNav.Location = new System.Drawing.Point(17, 66);
            this.chkCompNav.Name = "chkCompNav";
            this.chkCompNav.Size = new System.Drawing.Size(125, 17);
            this.chkCompNav.TabIndex = 2;
            this.chkCompNav.Text = "Computer Navigation";
            this.chkCompNav.UseVisualStyleBackColor = true;
            this.chkCompNav.CheckedChanged += new System.EventHandler(this.chkCompNav_CheckedChanged);
            // 
            // chkLeatherInterior
            // 
            this.chkLeatherInterior.AutoSize = true;
            this.chkLeatherInterior.Location = new System.Drawing.Point(17, 43);
            this.chkLeatherInterior.Name = "chkLeatherInterior";
            this.chkLeatherInterior.Size = new System.Drawing.Size(97, 17);
            this.chkLeatherInterior.TabIndex = 1;
            this.chkLeatherInterior.Text = "Leather Interior";
            this.chkLeatherInterior.UseVisualStyleBackColor = true;
            this.chkLeatherInterior.CheckedChanged += new System.EventHandler(this.chkLeatherInterior_CheckedChanged);
            // 
            // chkStereoSystem
            // 
            this.chkStereoSystem.AutoSize = true;
            this.chkStereoSystem.Location = new System.Drawing.Point(17, 20);
            this.chkStereoSystem.Name = "chkStereoSystem";
            this.chkStereoSystem.Size = new System.Drawing.Size(94, 17);
            this.chkStereoSystem.TabIndex = 0;
            this.chkStereoSystem.Tag = "";
            this.chkStereoSystem.Text = "Stereo System";
            this.chkStereoSystem.UseVisualStyleBackColor = true;
            this.chkStereoSystem.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grpExteriorFinish
            // 
            this.grpExteriorFinish.Controls.Add(this.rdoCustom);
            this.grpExteriorFinish.Controls.Add(this.rdoPearlized);
            this.grpExteriorFinish.Controls.Add(this.rdoStandard);
            this.grpExteriorFinish.Location = new System.Drawing.Point(302, 163);
            this.grpExteriorFinish.Name = "grpExteriorFinish";
            this.grpExteriorFinish.Size = new System.Drawing.Size(200, 100);
            this.grpExteriorFinish.TabIndex = 17;
            this.grpExteriorFinish.TabStop = false;
            this.grpExteriorFinish.Text = "Exterior Finish";
            // 
            // rdoCustom
            // 
            this.rdoCustom.AutoSize = true;
            this.rdoCustom.Location = new System.Drawing.Point(17, 66);
            this.rdoCustom.Name = "rdoCustom";
            this.rdoCustom.Size = new System.Drawing.Size(123, 17);
            this.rdoCustom.TabIndex = 2;
            this.rdoCustom.Text = "Customized Detailing";
            this.rdoCustom.UseVisualStyleBackColor = true;
            this.rdoCustom.CheckedChanged += new System.EventHandler(this.rdoCustom_CheckedChanged);
            // 
            // rdoPearlized
            // 
            this.rdoPearlized.AutoSize = true;
            this.rdoPearlized.Location = new System.Drawing.Point(17, 43);
            this.rdoPearlized.Name = "rdoPearlized";
            this.rdoPearlized.Size = new System.Drawing.Size(68, 17);
            this.rdoPearlized.TabIndex = 1;
            this.rdoPearlized.Text = "Pearlized";
            this.rdoPearlized.UseVisualStyleBackColor = true;
            this.rdoPearlized.CheckedChanged += new System.EventHandler(this.rdoPearlized_CheckedChanged);
            // 
            // rdoStandard
            // 
            this.rdoStandard.AutoSize = true;
            this.rdoStandard.Checked = true;
            this.rdoStandard.Location = new System.Drawing.Point(17, 20);
            this.rdoStandard.Name = "rdoStandard";
            this.rdoStandard.Size = new System.Drawing.Size(68, 17);
            this.rdoStandard.TabIndex = 0;
            this.rdoStandard.TabStop = true;
            this.rdoStandard.Text = "Standard";
            this.rdoStandard.UseVisualStyleBackColor = true;
            this.rdoStandard.CheckedChanged += new System.EventHandler(this.rdoStandard_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(82, 294);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(256, 294);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmSharpAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 347);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpExteriorFinish);
            this.Controls.Add(this.grpAdditionalItems);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtAmountDue);
            this.Controls.Add(this.txtTradeInAllowance);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSalesTax);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtAdditionalOptions);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.lblTradeInAllowance);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSalesTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblAdditionalOptions);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSharpAutoForm";
            this.Text = "Auto Center";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpAdditionalItems.ResumeLayout(false);
            this.grpAdditionalItems.PerformLayout();
            this.grpExteriorFinish.ResumeLayout(false);
            this.grpExteriorFinish.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblAdditionalOptions;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTradeInAllowance;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtAdditionalOptions;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTradeInAllowance;
        private System.Windows.Forms.TextBox txtAmountDue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpAdditionalItems;
        private System.Windows.Forms.CheckBox chkCompNav;
        private System.Windows.Forms.CheckBox chkLeatherInterior;
        private System.Windows.Forms.CheckBox chkStereoSystem;
        private System.Windows.Forms.GroupBox grpExteriorFinish;
        private System.Windows.Forms.RadioButton rdoCustom;
        private System.Windows.Forms.RadioButton rdoPearlized;
        private System.Windows.Forms.RadioButton rdoStandard;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
    }
}

