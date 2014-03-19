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
            this.lblAreaOpaque = new System.Windows.Forms.Label();
            this.txtAreaOpaque = new System.Windows.Forms.TextBox();
            this.btnApplyAreaOpaque = new System.Windows.Forms.Button();
            this.lblFunctionResolution = new System.Windows.Forms.Label();
            this.txtFunctionResolution = new System.Windows.Forms.TextBox();
            this.btnApplyFunctionResolution = new System.Windows.Forms.Button();
            this.btnApplyApproximationWidth = new System.Windows.Forms.Button();
            this.txtWidthApproximationSquares = new System.Windows.Forms.TextBox();
            this.lblApproximationSquareWidth = new System.Windows.Forms.Label();
            this.chkBxApproximationRects = new System.Windows.Forms.CheckBox();
            this.chkBxArea = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblEquation = new System.Windows.Forms.Label();
            this.btnAddNewFunction = new System.Windows.Forms.Button();
            this.txtNewFunction = new System.Windows.Forms.TextBox();
            this.lstFunctions = new System.Windows.Forms.ListBox();
            this.tbPgDrawArea = new System.Windows.Forms.TabPage();
            this.trckBrScale = new System.Windows.Forms.TrackBar();
            this.tbPgOptions = new System.Windows.Forms.TabPage();
            this.chkBxNumberLines = new System.Windows.Forms.CheckBox();
            this.chkBxNumbers = new System.Windows.Forms.CheckBox();
            this.tbCtrlPlotter.SuspendLayout();
            this.tbPgFunctions.SuspendLayout();
            this.grpBxSelectedFunction.SuspendLayout();
            this.tbPgDrawArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckBrScale)).BeginInit();
            this.tbPgOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCtrlPlotter
            // 
            this.tbCtrlPlotter.Controls.Add(this.tbPgFunctions);
            this.tbCtrlPlotter.Controls.Add(this.tbPgDrawArea);
            this.tbCtrlPlotter.Controls.Add(this.tbPgOptions);
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
            this.grpBxSelectedFunction.Controls.Add(this.lblAreaOpaque);
            this.grpBxSelectedFunction.Controls.Add(this.txtAreaOpaque);
            this.grpBxSelectedFunction.Controls.Add(this.btnApplyAreaOpaque);
            this.grpBxSelectedFunction.Controls.Add(this.lblFunctionResolution);
            this.grpBxSelectedFunction.Controls.Add(this.txtFunctionResolution);
            this.grpBxSelectedFunction.Controls.Add(this.btnApplyFunctionResolution);
            this.grpBxSelectedFunction.Controls.Add(this.btnApplyApproximationWidth);
            this.grpBxSelectedFunction.Controls.Add(this.txtWidthApproximationSquares);
            this.grpBxSelectedFunction.Controls.Add(this.lblApproximationSquareWidth);
            this.grpBxSelectedFunction.Controls.Add(this.chkBxApproximationRects);
            this.grpBxSelectedFunction.Controls.Add(this.chkBxArea);
            this.grpBxSelectedFunction.Controls.Add(this.btnDelete);
            this.grpBxSelectedFunction.Controls.Add(this.btnColor);
            this.grpBxSelectedFunction.Controls.Add(this.lblEquation);
            this.grpBxSelectedFunction.Location = new System.Drawing.Point(134, 308);
            this.grpBxSelectedFunction.Name = "grpBxSelectedFunction";
            this.grpBxSelectedFunction.Size = new System.Drawing.Size(450, 226);
            this.grpBxSelectedFunction.TabIndex = 3;
            this.grpBxSelectedFunction.TabStop = false;
            this.grpBxSelectedFunction.Text = "selected function";
            // 
            // lblAreaOpaque
            // 
            this.lblAreaOpaque.AutoSize = true;
            this.lblAreaOpaque.Location = new System.Drawing.Point(9, 208);
            this.lblAreaOpaque.Name = "lblAreaOpaque";
            this.lblAreaOpaque.Size = new System.Drawing.Size(67, 13);
            this.lblAreaOpaque.TabIndex = 15;
            this.lblAreaOpaque.Text = "area opaque";
            // 
            // txtAreaOpaque
            // 
            this.txtAreaOpaque.Location = new System.Drawing.Point(108, 205);
            this.txtAreaOpaque.Name = "txtAreaOpaque";
            this.txtAreaOpaque.Size = new System.Drawing.Size(100, 20);
            this.txtAreaOpaque.TabIndex = 14;
            // 
            // btnApplyAreaOpaque
            // 
            this.btnApplyAreaOpaque.Location = new System.Drawing.Point(214, 203);
            this.btnApplyAreaOpaque.Name = "btnApplyAreaOpaque";
            this.btnApplyAreaOpaque.Size = new System.Drawing.Size(75, 23);
            this.btnApplyAreaOpaque.TabIndex = 13;
            this.btnApplyAreaOpaque.Text = "apply";
            this.btnApplyAreaOpaque.UseVisualStyleBackColor = true;
            this.btnApplyAreaOpaque.Click += new System.EventHandler(this.btnApplyAreaOpaque_Click);
            // 
            // lblFunctionResolution
            // 
            this.lblFunctionResolution.AutoSize = true;
            this.lblFunctionResolution.Location = new System.Drawing.Point(9, 159);
            this.lblFunctionResolution.Name = "lblFunctionResolution";
            this.lblFunctionResolution.Size = new System.Drawing.Size(93, 13);
            this.lblFunctionResolution.TabIndex = 12;
            this.lblFunctionResolution.Text = "function resolution";
            // 
            // txtFunctionResolution
            // 
            this.txtFunctionResolution.Location = new System.Drawing.Point(108, 156);
            this.txtFunctionResolution.Name = "txtFunctionResolution";
            this.txtFunctionResolution.Size = new System.Drawing.Size(100, 20);
            this.txtFunctionResolution.TabIndex = 11;
            // 
            // btnApplyFunctionResolution
            // 
            this.btnApplyFunctionResolution.Location = new System.Drawing.Point(214, 154);
            this.btnApplyFunctionResolution.Name = "btnApplyFunctionResolution";
            this.btnApplyFunctionResolution.Size = new System.Drawing.Size(75, 23);
            this.btnApplyFunctionResolution.TabIndex = 10;
            this.btnApplyFunctionResolution.Text = "apply";
            this.btnApplyFunctionResolution.UseVisualStyleBackColor = true;
            this.btnApplyFunctionResolution.Click += new System.EventHandler(this.btnApplyFunctionResolution_Click);
            // 
            // btnApplyApproximationWidth
            // 
            this.btnApplyApproximationWidth.Location = new System.Drawing.Point(100, 114);
            this.btnApplyApproximationWidth.Name = "btnApplyApproximationWidth";
            this.btnApplyApproximationWidth.Size = new System.Drawing.Size(75, 23);
            this.btnApplyApproximationWidth.TabIndex = 9;
            this.btnApplyApproximationWidth.Text = "apply";
            this.btnApplyApproximationWidth.UseVisualStyleBackColor = true;
            this.btnApplyApproximationWidth.Click += new System.EventHandler(this.btnApplyApproximationWidth_Click);
            // 
            // txtWidthApproximationSquares
            // 
            this.txtWidthApproximationSquares.Location = new System.Drawing.Point(47, 116);
            this.txtWidthApproximationSquares.Name = "txtWidthApproximationSquares";
            this.txtWidthApproximationSquares.Size = new System.Drawing.Size(47, 20);
            this.txtWidthApproximationSquares.TabIndex = 8;
            // 
            // lblApproximationSquareWidth
            // 
            this.lblApproximationSquareWidth.AutoSize = true;
            this.lblApproximationSquareWidth.Location = new System.Drawing.Point(9, 119);
            this.lblApproximationSquareWidth.Name = "lblApproximationSquareWidth";
            this.lblApproximationSquareWidth.Size = new System.Drawing.Size(35, 13);
            this.lblApproximationSquareWidth.TabIndex = 7;
            this.lblApproximationSquareWidth.Text = "width:";
            // 
            // chkBxApproximationRects
            // 
            this.chkBxApproximationRects.AutoSize = true;
            this.chkBxApproximationRects.Location = new System.Drawing.Point(9, 95);
            this.chkBxApproximationRects.Name = "chkBxApproximationRects";
            this.chkBxApproximationRects.Size = new System.Drawing.Size(171, 17);
            this.chkBxApproximationRects.TabIndex = 6;
            this.chkBxApproximationRects.Text = "show approximation rectangles\r\n";
            this.chkBxApproximationRects.UseVisualStyleBackColor = true;
            this.chkBxApproximationRects.CheckedChanged += new System.EventHandler(this.chkBxApproximationRects_CheckedChanged);
            // 
            // chkBxArea
            // 
            this.chkBxArea.AutoSize = true;
            this.chkBxArea.Location = new System.Drawing.Point(9, 72);
            this.chkBxArea.Name = "chkBxArea";
            this.chkBxArea.Size = new System.Drawing.Size(82, 17);
            this.chkBxArea.TabIndex = 5;
            this.chkBxArea.Text = "display area";
            this.chkBxArea.UseVisualStyleBackColor = true;
            this.chkBxArea.CheckedChanged += new System.EventHandler(this.chkBxArea_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(378, 203);
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
            this.btnColor.Location = new System.Drawing.Point(412, 11);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(32, 23);
            this.btnColor.TabIndex = 1;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblEquation
            // 
            this.lblEquation.AutoSize = true;
            this.lblEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquation.Location = new System.Drawing.Point(9, 16);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(52, 18);
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
            this.trckBrScale.Maximum = 200;
            this.trckBrScale.Minimum = 7;
            this.trckBrScale.Name = "trckBrScale";
            this.trckBrScale.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trckBrScale.Size = new System.Drawing.Size(45, 522);
            this.trckBrScale.TabIndex = 2;
            this.trckBrScale.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trckBrScale.Value = 22;
            this.trckBrScale.Scroll += new System.EventHandler(this.trckBrScale_Scroll);
            // 
            // tbPgOptions
            // 
            this.tbPgOptions.Controls.Add(this.chkBxNumberLines);
            this.tbPgOptions.Controls.Add(this.chkBxNumbers);
            this.tbPgOptions.Location = new System.Drawing.Point(4, 22);
            this.tbPgOptions.Name = "tbPgOptions";
            this.tbPgOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgOptions.Size = new System.Drawing.Size(587, 537);
            this.tbPgOptions.TabIndex = 2;
            this.tbPgOptions.Text = "Options";
            this.tbPgOptions.UseVisualStyleBackColor = true;
            // 
            // chkBxNumberLines
            // 
            this.chkBxNumberLines.AutoSize = true;
            this.chkBxNumberLines.Checked = true;
            this.chkBxNumberLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxNumberLines.Location = new System.Drawing.Point(8, 29);
            this.chkBxNumberLines.Name = "chkBxNumberLines";
            this.chkBxNumberLines.Size = new System.Drawing.Size(105, 17);
            this.chkBxNumberLines.TabIndex = 1;
            this.chkBxNumberLines.Text = "plot number lines";
            this.chkBxNumberLines.UseVisualStyleBackColor = true;
            this.chkBxNumberLines.CheckedChanged += new System.EventHandler(this.chkBxNumberLines_CheckedChanged);
            // 
            // chkBxNumbers
            // 
            this.chkBxNumbers.AutoSize = true;
            this.chkBxNumbers.Checked = true;
            this.chkBxNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxNumbers.Location = new System.Drawing.Point(8, 6);
            this.chkBxNumbers.Name = "chkBxNumbers";
            this.chkBxNumbers.Size = new System.Drawing.Size(86, 17);
            this.chkBxNumbers.TabIndex = 0;
            this.chkBxNumbers.Text = "plot numbers";
            this.chkBxNumbers.UseVisualStyleBackColor = true;
            this.chkBxNumbers.CheckedChanged += new System.EventHandler(this.chkBxNumbers_CheckedChanged);
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
            this.tbPgOptions.ResumeLayout(false);
            this.tbPgOptions.PerformLayout();
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
        private System.Windows.Forms.TabPage tbPgOptions;
        private System.Windows.Forms.CheckBox chkBxNumberLines;
        private System.Windows.Forms.CheckBox chkBxNumbers;
        private System.Windows.Forms.TextBox txtWidthApproximationSquares;
        private System.Windows.Forms.Label lblApproximationSquareWidth;
        private System.Windows.Forms.CheckBox chkBxApproximationRects;
        private System.Windows.Forms.Button btnApplyApproximationWidth;
        private System.Windows.Forms.Label lblFunctionResolution;
        private System.Windows.Forms.TextBox txtFunctionResolution;
        private System.Windows.Forms.Button btnApplyFunctionResolution;
        private System.Windows.Forms.Label lblAreaOpaque;
        private System.Windows.Forms.TextBox txtAreaOpaque;
        private System.Windows.Forms.Button btnApplyAreaOpaque;
    }
}

