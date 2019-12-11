namespace BasicCalculator
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
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.CalculationResultText = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.SumButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.SubtButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.MultiButtom = new System.Windows.Forms.Button();
            this.NineButon = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.DevisionButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.UserInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputText.Location = new System.Drawing.Point(13, 13);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(259, 38);
            this.UserInputText.TabIndex = 0;
            this.UserInputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculationResultText
            // 
            this.CalculationResultText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculationResultText.Location = new System.Drawing.Point(10, 65);
            this.CalculationResultText.Name = "CalculationResultText";
            this.CalculationResultText.Size = new System.Drawing.Size(259, 30);
            this.CalculationResultText.TabIndex = 1;
            this.CalculationResultText.Text = "0";
            this.CalculationResultText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.EqualsButton, 3, 4);
            this.ButtonsPanel.Controls.Add(this.DotButton, 2, 4);
            this.ButtonsPanel.Controls.Add(this.ZeroButton, 1, 4);
            this.ButtonsPanel.Controls.Add(this.SumButton, 3, 3);
            this.ButtonsPanel.Controls.Add(this.ThreeButton, 2, 3);
            this.ButtonsPanel.Controls.Add(this.TwoButton, 1, 3);
            this.ButtonsPanel.Controls.Add(this.OneButton, 0, 3);
            this.ButtonsPanel.Controls.Add(this.SubtButton, 3, 2);
            this.ButtonsPanel.Controls.Add(this.SixButton, 2, 2);
            this.ButtonsPanel.Controls.Add(this.FiveButton, 1, 2);
            this.ButtonsPanel.Controls.Add(this.FourButton, 0, 2);
            this.ButtonsPanel.Controls.Add(this.MultiButtom, 3, 1);
            this.ButtonsPanel.Controls.Add(this.NineButon, 2, 1);
            this.ButtonsPanel.Controls.Add(this.EightButton, 1, 1);
            this.ButtonsPanel.Controls.Add(this.SevenButton, 0, 1);
            this.ButtonsPanel.Controls.Add(this.DevisionButton, 3, 0);
            this.ButtonsPanel.Controls.Add(this.DelButton, 2, 0);
            this.ButtonsPanel.Controls.Add(this.CButton, 1, 0);
            this.ButtonsPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonsPanel.Location = new System.Drawing.Point(13, 130);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(259, 219);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // EqualsButton
            // 
            this.EqualsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsButton.Location = new System.Drawing.Point(195, 175);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(61, 41);
            this.EqualsButton.TabIndex = 19;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotButton.Location = new System.Drawing.Point(131, 175);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(58, 41);
            this.DotButton.TabIndex = 18;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Location = new System.Drawing.Point(67, 175);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(58, 41);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // SumButton
            // 
            this.SumButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumButton.Location = new System.Drawing.Point(195, 132);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(61, 37);
            this.SumButton.TabIndex = 15;
            this.SumButton.Text = "+";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Location = new System.Drawing.Point(131, 132);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(58, 37);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Location = new System.Drawing.Point(67, 132);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(58, 37);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Location = new System.Drawing.Point(3, 132);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(58, 37);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // SubtButton
            // 
            this.SubtButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtButton.Location = new System.Drawing.Point(195, 89);
            this.SubtButton.Name = "SubtButton";
            this.SubtButton.Size = new System.Drawing.Size(61, 37);
            this.SubtButton.TabIndex = 11;
            this.SubtButton.Text = "-";
            this.SubtButton.UseVisualStyleBackColor = true;
            this.SubtButton.Click += new System.EventHandler(this.SubtButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Location = new System.Drawing.Point(131, 89);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(58, 37);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.Location = new System.Drawing.Point(67, 89);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(58, 37);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.Location = new System.Drawing.Point(3, 89);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(58, 37);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // MultiButtom
            // 
            this.MultiButtom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiButtom.Location = new System.Drawing.Point(195, 46);
            this.MultiButtom.Name = "MultiButtom";
            this.MultiButtom.Size = new System.Drawing.Size(61, 37);
            this.MultiButtom.TabIndex = 7;
            this.MultiButtom.Text = "×";
            this.MultiButtom.UseVisualStyleBackColor = true;
            this.MultiButtom.Click += new System.EventHandler(this.MultiButtom_Click);
            // 
            // NineButon
            // 
            this.NineButon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButon.Location = new System.Drawing.Point(131, 46);
            this.NineButon.Name = "NineButon";
            this.NineButon.Size = new System.Drawing.Size(58, 37);
            this.NineButon.TabIndex = 6;
            this.NineButon.Text = "9";
            this.NineButon.UseVisualStyleBackColor = true;
            this.NineButon.Click += new System.EventHandler(this.NineButon_Click);
            // 
            // EightButton
            // 
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.Location = new System.Drawing.Point(67, 46);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(58, 37);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Location = new System.Drawing.Point(3, 46);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(58, 37);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // DevisionButton
            // 
            this.DevisionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DevisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevisionButton.Location = new System.Drawing.Point(195, 3);
            this.DevisionButton.Name = "DevisionButton";
            this.DevisionButton.Size = new System.Drawing.Size(61, 37);
            this.DevisionButton.TabIndex = 3;
            this.DevisionButton.Text = "÷";
            this.DevisionButton.UseVisualStyleBackColor = true;
            this.DevisionButton.Click += new System.EventHandler(this.DevisionButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelButton.Location = new System.Drawing.Point(131, 3);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(58, 37);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "Del";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // CButton
            // 
            this.CButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CButton.Location = new System.Drawing.Point(67, 3);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(58, 37);
            this.CButton.TabIndex = 1;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // CEButton
            // 
            this.CEButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(58, 37);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.EqualsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.CalculationResultText);
            this.Controls.Add(this.UserInputText);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "Form1";
            this.Text = "Basic Claculator";
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label CalculationResultText;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button SubtButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button MultiButtom;
        private System.Windows.Forms.Button NineButon;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button DevisionButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button CButton;
    }
}

