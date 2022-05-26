namespace XYGetAlpha
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputBoxContainingCoords = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGetCoordinates = new System.Windows.Forms.Button();
            this.buttonOpenFileDialog = new System.Windows.Forms.Button();
            this.buttonCopyToClipboard = new System.Windows.Forms.Button();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelColorFilter = new System.Windows.Forms.Label();
            this.comboBoxColorSelect = new System.Windows.Forms.ComboBox();
            this.buttonCloseWindow = new System.Windows.Forms.Button();
            this.buttonMinimizeWindow = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(97, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBoxWithFilePath);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "File path to image:";
            // 
            // outputBoxContainingCoords
            // 
            this.outputBoxContainingCoords.BackColor = System.Drawing.Color.Black;
            this.outputBoxContainingCoords.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputBoxContainingCoords.ForeColor = System.Drawing.Color.White;
            this.outputBoxContainingCoords.Location = new System.Drawing.Point(591, 184);
            this.outputBoxContainingCoords.MaxLength = 10000;
            this.outputBoxContainingCoords.Multiline = true;
            this.outputBoxContainingCoords.Name = "outputBoxContainingCoords";
            this.outputBoxContainingCoords.ReadOnly = true;
            this.outputBoxContainingCoords.Size = new System.Drawing.Size(451, 547);
            this.outputBoxContainingCoords.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(591, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Generated coordinates:";
            // 
            // buttonGetCoordinates
            // 
            this.buttonGetCoordinates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGetCoordinates.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonGetCoordinates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetCoordinates.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGetCoordinates.ForeColor = System.Drawing.Color.White;
            this.buttonGetCoordinates.Location = new System.Drawing.Point(463, 138);
            this.buttonGetCoordinates.Name = "buttonGetCoordinates";
            this.buttonGetCoordinates.Size = new System.Drawing.Size(75, 31);
            this.buttonGetCoordinates.TabIndex = 4;
            this.buttonGetCoordinates.Text = "Load";
            this.buttonGetCoordinates.UseVisualStyleBackColor = true;
            this.buttonGetCoordinates.Click += new System.EventHandler(this.buttonGetCoordinates_Click);
            // 
            // buttonOpenFileDialog
            // 
            this.buttonOpenFileDialog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFileDialog.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonOpenFileDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFileDialog.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenFileDialog.ForeColor = System.Drawing.Color.White;
            this.buttonOpenFileDialog.Location = new System.Drawing.Point(14, 138);
            this.buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            this.buttonOpenFileDialog.Size = new System.Drawing.Size(77, 31);
            this.buttonOpenFileDialog.TabIndex = 5;
            this.buttonOpenFileDialog.Text = "Select";
            this.buttonOpenFileDialog.UseVisualStyleBackColor = true;
            this.buttonOpenFileDialog.Click += new System.EventHandler(this.buttonOpenFileWindow_Click);
            // 
            // buttonCopyToClipboard
            // 
            this.buttonCopyToClipboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCopyToClipboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopyToClipboard.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCopyToClipboard.ForeColor = System.Drawing.Color.White;
            this.buttonCopyToClipboard.Location = new System.Drawing.Point(591, 138);
            this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
            this.buttonCopyToClipboard.Size = new System.Drawing.Size(451, 31);
            this.buttonCopyToClipboard.TabIndex = 6;
            this.buttonCopyToClipboard.Text = "Copy to clipboard";
            this.buttonCopyToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyToClipboard.Click += new System.EventHandler(this.buttonCopyToClipboard_Click);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(14, 235);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(524, 510);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPreview.TabIndex = 7;
            this.pictureBoxPreview.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::XYGetAlpha.Properties.Resources.XYGET_Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(176, 79);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 8;
            this.pictureBoxLogo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code ExtraLight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(802, 759);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Made by Henry Strömgren";
            // 
            // labelColorFilter
            // 
            this.labelColorFilter.AutoSize = true;
            this.labelColorFilter.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelColorFilter.ForeColor = System.Drawing.Color.White;
            this.labelColorFilter.Location = new System.Drawing.Point(14, 184);
            this.labelColorFilter.Name = "labelColorFilter";
            this.labelColorFilter.Size = new System.Drawing.Size(154, 32);
            this.labelColorFilter.TabIndex = 11;
            this.labelColorFilter.Text = "Get color:";
            // 
            // comboBoxColorSelect
            // 
            this.comboBoxColorSelect.BackColor = System.Drawing.Color.Black;
            this.comboBoxColorSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxColorSelect.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxColorSelect.ForeColor = System.Drawing.Color.White;
            this.comboBoxColorSelect.FormattingEnabled = true;
            this.comboBoxColorSelect.Items.AddRange(new object[] {
            "Dark",
            "Bright"});
            this.comboBoxColorSelect.Location = new System.Drawing.Point(174, 187);
            this.comboBoxColorSelect.Name = "comboBoxColorSelect";
            this.comboBoxColorSelect.Size = new System.Drawing.Size(163, 29);
            this.comboBoxColorSelect.TabIndex = 12;
            this.comboBoxColorSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorSelect_SelectedIndexChanged);
            // 
            // buttonCloseWindow
            // 
            this.buttonCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseWindow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseWindow.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCloseWindow.ForeColor = System.Drawing.Color.White;
            this.buttonCloseWindow.Location = new System.Drawing.Point(967, 12);
            this.buttonCloseWindow.Name = "buttonCloseWindow";
            this.buttonCloseWindow.Size = new System.Drawing.Size(75, 32);
            this.buttonCloseWindow.TabIndex = 13;
            this.buttonCloseWindow.Text = "X";
            this.buttonCloseWindow.UseVisualStyleBackColor = true;
            this.buttonCloseWindow.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonMinimizeWindow
            // 
            this.buttonMinimizeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimizeWindow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizeWindow.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinimizeWindow.ForeColor = System.Drawing.Color.White;
            this.buttonMinimizeWindow.Location = new System.Drawing.Point(886, 12);
            this.buttonMinimizeWindow.Name = "buttonMinimizeWindow";
            this.buttonMinimizeWindow.Size = new System.Drawing.Size(75, 32);
            this.buttonMinimizeWindow.TabIndex = 14;
            this.buttonMinimizeWindow.Text = "---";
            this.buttonMinimizeWindow.UseVisualStyleBackColor = true;
            this.buttonMinimizeWindow.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // line
            // 
            this.line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line.Location = new System.Drawing.Point(14, 89);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(1028, 2);
            this.line.TabIndex = 15;
            this.line.Text = "line";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(561, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 643);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.DimGray;
            this.progressBar.Location = new System.Drawing.Point(194, 59);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(0, 30);
            this.progressBar.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1054, 789);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.line);
            this.Controls.Add(this.buttonMinimizeWindow);
            this.Controls.Add(this.buttonCloseWindow);
            this.Controls.Add(this.comboBoxColorSelect);
            this.Controls.Add(this.labelColorFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.buttonCopyToClipboard);
            this.Controls.Add(this.buttonOpenFileDialog);
            this.Controls.Add(this.buttonGetCoordinates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputBoxContainingCoords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XYGET";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox outputBoxContainingCoords;
        private Label label2;
        private Button buttonGetCoordinates;
        private Button buttonOpenFileDialog;
        private Button buttonCopyToClipboard;
        private PictureBox pictureBoxPreview;
        private PictureBox pictureBoxLogo;
        private Label label3;
        private Label labelColorFilter;
        private ComboBox comboBoxColorSelect;
        private Button buttonCloseWindow;
        private Button buttonMinimizeWindow;
        private Label line;
        private Label label4;
        private Label progressBar;
    }

}