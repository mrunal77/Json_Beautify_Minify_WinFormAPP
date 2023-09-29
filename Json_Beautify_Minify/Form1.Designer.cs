namespace Json_Beautify_Minify
{
    partial class formJsonFormatter
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
            txtMinifiedJson = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            txtFormattedJSON = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            btnOpenFile = new Button();
            SuspendLayout();
            // 
            // txtMinifiedJson
            // 
            txtMinifiedJson.BorderStyle = BorderStyle.FixedSingle;
            txtMinifiedJson.Dock = DockStyle.Left;
            txtMinifiedJson.Location = new Point(0, 0);
            txtMinifiedJson.Name = "txtMinifiedJson";
            txtMinifiedJson.Size = new Size(600, 768);
            txtMinifiedJson.TabIndex = 0;
            txtMinifiedJson.Text = "";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(640, 169);
            button1.Name = "button1";
            button1.Size = new Size(160, 111);
            button1.TabIndex = 2;
            button1.Text = "Beauitfy>>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.Location = new Point(640, 331);
            button2.Name = "button2";
            button2.Size = new Size(160, 111);
            button2.TabIndex = 3;
            button2.Text = "<<Minfy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.Location = new Point(628, 46);
            label1.Name = "label1";
            label1.Size = new Size(185, 31);
            label1.TabIndex = 5;
            label1.Text = "JSON Formatter";
            // 
            // txtFormattedJSON
            // 
            txtFormattedJSON.BorderStyle = BorderStyle.FixedSingle;
            txtFormattedJSON.Dock = DockStyle.Right;
            txtFormattedJSON.Location = new Point(837, 0);
            txtFormattedJSON.Name = "txtFormattedJSON";
            txtFormattedJSON.Size = new Size(600, 768);
            txtFormattedJSON.TabIndex = 4;
            txtFormattedJSON.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Anchor = AnchorStyles.None;
            btnOpenFile.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnOpenFile.Location = new Point(640, 489);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(160, 111);
            btnOpenFile.TabIndex = 6;
            btnOpenFile.Text = "Open File";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // formJsonFormatter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1437, 768);
            Controls.Add(btnOpenFile);
            Controls.Add(label1);
            Controls.Add(txtFormattedJSON);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtMinifiedJson);
            MaximizeBox = false;
            Name = "formJsonFormatter";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "JSON Formatter";
            Load += formJsonFormatter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtMinifiedJson;
        private Button button1;
        private Button button2;
        private Label label1;
        private RichTextBox txtFormattedJSON;
        private OpenFileDialog openFileDialog1;
        private Button btnOpenFile;
    }
}
