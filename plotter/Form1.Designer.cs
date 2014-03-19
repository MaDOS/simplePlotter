namespace plotter
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCtrlPlotter = new System.Windows.Forms.TabControl();
            this.tbPgFunctions = new System.Windows.Forms.TabPage();
            this.grpBxSelectedFunction = new System.Windows.Forms.GroupBox();
            this.chkBxArea = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblEquation = new System.Windows.Forms.Label();
            this.btnAddNewFunction = new System.Windows.Forms.Button();
            this.txtNewFunction = new System.Windows.Forms.TextBox();
            this.lstFunctions = new System.Windows.Forms.ListBox();
            this.tbPgDrawArea = new System.Windows.Forms.TabPage();
            this.trckBrScale = new System.Windows.Forms.TrackBar();
            this.tbCtrlPlotter.SuspendLayout();
            this.tbPgFunctions.SuspendLayout();
            this.grpBxSelectedFunction.SuspendLayout();
            this.tbPgDrawArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckBrScale)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCtrlPlotter
            // 
            this.tbCtrlPlotter.Controls.Add(this.tbPgFunctions);
            this.tbCtrlPlotter.Controls.Add(this.tbPgDrawArea);
            this.tbCtrlPlotter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCtrlPlotter.Location = new System.Drawing.Point(0, 0);
            this.tbCtrlPlotter.Name = "tbCtrlPlotter";
            this.tbCtrlPlotter.SelectedIndex = 0;
            this.tbCtrlPlotter.Size = new System.Drawing.Size(595, 563);
            this.tbCtrlPlotter.TabIndex = 0;
            this.tbCtrlPlotter.SelectedIndexChanged += new System.EventHandler(this.tbCtrlPlotter_SelectedIndexChanged);
            // 
            // tbPgFunctions
            // 
            this.tbPgFunctions.Controls.Add(this.grpBxSelectedFunction);
            this.tbPgFunctions.Controls.Add(this.btnAddNewFunction);
            this.tbPgFunctions.Controls.Add(this.txtNewFunction);
            this.tbPgFunctions.Controls.Add(this.lstFunctions);
            this.tbPgFunctions.Location = new System.Drawing.Point(4, 22);
            this.tbPgFunctions.Name = "tbPgFunctions";
            this.tbPgFunctions.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgFunctions.Size = new System.Drawing.Size(587, 537);
            this.tbPgFunctions.TabIndex = 0;
            this.tbPgFunctions.Text = "Functions";
            this.tbPgFunctions.UseVisualStyleBackColor = true;
            // 
            // grpBxSelectedFunction
            // 
            this.grpBxSelectedFunction.Controls.Add(this.chkBxArea);
            this.grpBxSelectedFunction.Controls.Add(this.btnDelete);
            this.grpBxSelectedFunction.Controls.Add(this.btnColor);
            this.grpBxSelectedFunction.Controls.Add(this.lblEquation);
            this.grpBxSelectedFunction.Location = new System.Drawing.Point(134, 308);
            this.grpBxSelectedFunction.Name = "grpBxSelectedFunction";
            this.grpBxSelectedFunction.Size = new System.Drawing.Size(360, 186);
            this.grpBxSelectedFunction.TabIndex = 3;
            this.grpBxSelectedFunction.TabStop = false;
            this.grpBxSelectedFunction.Text = "selected function";
            // 
            // chkBxArea
            // 
            this.chkBxArea.AutoSize = true;
            this.chkBxArea.Location = new System.Drawing.Point(47, 23);
            this.chkBxArea.Name = "chkBxArea";
            this.chkBxArea.Size = new System.Drawing.Size(82, 17);
            this.chkBxArea.TabIndex = 5;
            this.chkBxArea.Text = "display area";
            this.chkBxArea.UseVisualStyleBackColor = true;
            this.chkBxArea.CheckedChanged += new System.EventHandler(this.chkBxArea_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(285, 163);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnColor
            // 
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(9, 19);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(32, 23);
            this.btnColor.TabIndex = 1;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblEquation
            // 
            this.lblEquation.AutoSize = true;
            this.lblEquation.Location = new System.Drawing.Point(6, 45);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(35, 13);
            this.lblEquation.TabIndex = 0;
            this.lblEquation.Text = "label1";
            // 
            // btnAddNewFunction
            // 
            this.btnAddNewFunction.Location = new System.Drawing.Point(344, 9);
            this.btnAddNewFunction.Name = "btnAddNewFunction";
            this.btnAddNewFunction.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewFunction.TabIndex = 2;
            this.btnAddNewFunction.Text = "add";
            this.btnAddNewFunction.UseVisualStyleBackColor = true;
            this.btnAddNewFunction.Click += new System.EventHandler(this.btnAddNewFunction_Click);
            // 
            // txtNewFunction
            // 
            this.txtNewFunction.Location = new System.Drawing.Point(134, 11);
            this.txtNewFunction.Name = "txtNewFunction";
            this.txtNewFunction.Size = new System.Drawing.Size(204, 20);
            this.txtNewFunction.TabIndex = 1;
            // 
            // lstFunctions
            // 
            this.lstFunctions.FormattingEnabled = true;
            this.lstFunctions.Location = new System.Drawing.Point(8, 9);
            this.lstFunctions.Name = "lstFunctions";
            this.lstFunctions.Size = new System.Drawing.Size(120, 550);
            this.lstFunctions.TabIndex = 0;
            this.lstFunctions.SelectedIndexChanged += new System.EventHandler(this.lstFunctions_SelectedIndexChanged);
            // 
            // tbPgDrawArea
            // 
            this.tbPgDrawArea.BackColor = System.Drawing.Color.White;
            this.tbPgDrawArea.Controls.Add(this.trckBrScale);
            this.tbPgDrawArea.Location = new System.Drawing.Point(4, 22);
            this.tbPgDrawArea.Name = "tbPgDrawArea";
            this.tbPgDrawArea.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgDrawArea.Size = new System.Drawing.Size(587, 537);
            this.tbPgDrawArea.TabIndex = 1;
            this.tbPgDrawArea.Text = "Ouput";
            this.tbPgDrawArea.Click += new System.EventHandler(this.tbPgDrawArea_Click);
            // 
            // trckBrScale
            // 
            this.trckBrScale.Location = new System.Drawing.Point(6, 7);
            this.trckBrScale.Maximum = 500;
            this.trckBrScale.Minimum = 5;
            this.trckBrScale.Name = "trckBrScale";
            this.trckBrScale.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trckBrScale.Size = new System.Drawing.Size(45, 522);
            this.trckBrScale.TabIndex = 2;
            this.trckBrScale.Value = 5;
            this.trckBrScale.Scroll += new System.EventHandler(this.trckBrScale_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 563);
            this.Controls.Add(this.tbCtrlPlotter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbCtrlPlotter.ResumeLayout(false);
            this.tbPgFunctions.ResumeLayout(false);
            this.tbPgFunctions.PerformLayout();
            this.grpBxSelectedFunction.ResumeLayout(false);
            this.grpBxSelectedFunction.PerformLayout();
            this.tbPgDrawArea.ResumeLayout(false);
            this.tbPgDrawArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckBrScale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCtrlPlotter;
        private System.Windows.Forms.TabPage tbPgFunctions;
        private System.Windows.Forms.TabPage tbPgDrawArea;
        private System.Windows.Forms.Button btnAddNewFunction;
        private System.Windows.Forms.TextBox txtNewFunction;
        private System.Windows.Forms.ListBox lstFunctions;
        private System.Windows.Forms.GroupBox grpBxSelectedFunction;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblEquation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkBxArea;
        private System.Windows.Forms.TrackBar trckBrScale;
    }
}

