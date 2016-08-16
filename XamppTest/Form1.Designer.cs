namespace XamppTest
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
            this.buttonSubmitClicked = new System.Windows.Forms.Button();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_z = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_timestamp = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSubmitClicked
            // 
            this.buttonSubmitClicked.Location = new System.Drawing.Point(82, 180);
            this.buttonSubmitClicked.Name = "buttonSubmitClicked";
            this.buttonSubmitClicked.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmitClicked.TabIndex = 0;
            this.buttonSubmitClicked.Text = "Submit";
            this.buttonSubmitClicked.UseVisualStyleBackColor = true;
            this.buttonSubmitClicked.Click += new System.EventHandler(this.buttonSubmitClicked_Click);
            // 
            // txt_y
            // 
            this.txt_y.Location = new System.Drawing.Point(82, 72);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(100, 22);
            this.txt_y.TabIndex = 1;
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(82, 39);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(100, 22);
            this.txt_x.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Z";
            // 
            // txt_z
            // 
            this.txt_z.Location = new System.Drawing.Point(82, 109);
            this.txt_z.Name = "txt_z";
            this.txt_z.Size = new System.Drawing.Size(100, 22);
            this.txt_z.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y,
            this.z,
            this.timestamp});
            this.dataGridView1.Location = new System.Drawing.Point(12, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(537, 223);
            this.dataGridView1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "TimeStamp";
            // 
            // txt_timestamp
            // 
            this.txt_timestamp.Location = new System.Drawing.Point(83, 139);
            this.txt_timestamp.Name = "txt_timestamp";
            this.txt_timestamp.Size = new System.Drawing.Size(100, 22);
            this.txt_timestamp.TabIndex = 8;
            // 
            // x
            // 
            this.x.HeaderText = "X";
            this.x.Name = "x";
            // 
            // y
            // 
            this.y.HeaderText = "Y";
            this.y.Name = "y";
            // 
            // z
            // 
            this.z.HeaderText = "Z";
            this.z.Name = "z";
            // 
            // timestamp
            // 
            this.timestamp.HeaderText = "Timestamp";
            this.timestamp.Name = "timestamp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 444);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_timestamp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_z);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_x);
            this.Controls.Add(this.txt_y);
            this.Controls.Add(this.buttonSubmitClicked);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmitClicked;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_z;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn z;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestamp;
    }
}

