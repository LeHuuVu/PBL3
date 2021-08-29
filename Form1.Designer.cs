namespace HuffmanCoding
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtInput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstFrequency = new System.Windows.Forms.ListView();
            this.colSymbol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFrequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodeword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEncode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAverageBit = new System.Windows.Forms.Label();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtEncodedString = new System.Windows.Forms.TextBox();
            this.butHis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "String for encoding";
            // 
            // rtxtInput
            // 
            this.rtxtInput.Location = new System.Drawing.Point(24, 28);
            this.rtxtInput.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtInput.Name = "rtxtInput";
            this.rtxtInput.Size = new System.Drawing.Size(759, 131);
            this.rtxtInput.TabIndex = 1;
            this.rtxtInput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Frequency and Codeword";
            // 
            // lstFrequency
            // 
            this.lstFrequency.AllowColumnReorder = true;
            this.lstFrequency.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSymbol,
            this.colFrequency,
            this.colCodeword});
            this.lstFrequency.FullRowSelect = true;
            this.lstFrequency.HideSelection = false;
            this.lstFrequency.Location = new System.Drawing.Point(20, 234);
            this.lstFrequency.Margin = new System.Windows.Forms.Padding(4);
            this.lstFrequency.Name = "lstFrequency";
            this.lstFrequency.Size = new System.Drawing.Size(763, 250);
            this.lstFrequency.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstFrequency.TabIndex = 3;
            this.lstFrequency.UseCompatibleStateImageBehavior = false;
            this.lstFrequency.View = System.Windows.Forms.View.Details;
            this.lstFrequency.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstFrequency_ColumnClick);
            // 
            // colSymbol
            // 
            this.colSymbol.Text = "Symbol";
            this.colSymbol.Width = 62;
            // 
            // colFrequency
            // 
            this.colFrequency.Text = "Frequency";
            this.colFrequency.Width = 129;
            // 
            // colCodeword
            // 
            this.colCodeword.Text = "Codeword";
            this.colCodeword.Width = 119;
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(27, 167);
            this.btnEncode.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(100, 28);
            this.btnEncode.TabIndex = 4;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 514);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Encoded string";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bit/Letter";
            // 
            // lblAverageBit
            // 
            this.lblAverageBit.AutoSize = true;
            this.lblAverageBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageBit.Location = new System.Drawing.Point(572, 167);
            this.lblAverageBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAverageBit.Name = "lblAverageBit";
            this.lblAverageBit.Size = new System.Drawing.Size(44, 29);
            this.lblAverageBit.TabIndex = 8;
            this.lblAverageBit.Text = "Bit";
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(275, 167);
            this.btnDecode.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(100, 28);
            this.btnDecode.TabIndex = 9;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // txtEncodedString
            // 
            this.txtEncodedString.Location = new System.Drawing.Point(20, 534);
            this.txtEncodedString.Margin = new System.Windows.Forms.Padding(4);
            this.txtEncodedString.Name = "txtEncodedString";
            this.txtEncodedString.Size = new System.Drawing.Size(763, 22);
            this.txtEncodedString.TabIndex = 10;
            // 
            // butHis
            // 
            this.butHis.Location = new System.Drawing.Point(674, 167);
            this.butHis.Name = "butHis";
            this.butHis.Size = new System.Drawing.Size(109, 28);
            this.butHis.TabIndex = 12;
            this.butHis.Text = "History";
            this.butHis.UseVisualStyleBackColor = true;
            this.butHis.Click += new System.EventHandler(this.butHis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 588);
            this.Controls.Add(this.butHis);
            this.Controls.Add(this.txtEncodedString);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.lblAverageBit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.lstFrequency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtInput);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Huffman Coding ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstFrequency;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAverageBit;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.ColumnHeader colSymbol;
        private System.Windows.Forms.ColumnHeader colFrequency;
        private System.Windows.Forms.ColumnHeader colCodeword;
        private System.Windows.Forms.TextBox txtEncodedString;
        private System.Windows.Forms.Button butHis;
    }
}

