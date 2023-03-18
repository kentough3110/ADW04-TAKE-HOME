namespace ADW04_TAKE_HOME
{
    partial class MainForm
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
            this.textBox_nama = new System.Windows.Forms.TextBox();
            this.label_favArtist = new System.Windows.Forms.Label();
            this.label_nama = new System.Windows.Forms.Label();
            this.checkBox_allOf = new System.Windows.Forms.CheckBox();
            this.button_openNext = new System.Windows.Forms.Button();
            this.textBox_favArtist = new System.Windows.Forms.TextBox();
            this.label_header = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_nama
            // 
            this.textBox_nama.Location = new System.Drawing.Point(42, 171);
            this.textBox_nama.Multiline = true;
            this.textBox_nama.Name = "textBox_nama";
            this.textBox_nama.Size = new System.Drawing.Size(431, 53);
            this.textBox_nama.TabIndex = 19;
            this.textBox_nama.TextChanged += new System.EventHandler(this.textBox_nama_TextChanged);
            // 
            // label_favArtist
            // 
            this.label_favArtist.AutoSize = true;
            this.label_favArtist.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_favArtist.ForeColor = System.Drawing.Color.Black;
            this.label_favArtist.Location = new System.Drawing.Point(37, 254);
            this.label_favArtist.Name = "label_favArtist";
            this.label_favArtist.Size = new System.Drawing.Size(212, 27);
            this.label_favArtist.TabIndex = 17;
            this.label_favArtist.Text = "My Favorite Artist";
            this.label_favArtist.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.BackColor = System.Drawing.Color.Transparent;
            this.label_nama.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nama.ForeColor = System.Drawing.Color.Black;
            this.label_nama.Location = new System.Drawing.Point(38, 131);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(84, 27);
            this.label_nama.TabIndex = 16;
            this.label_nama.Text = "Nama ";
            // 
            // checkBox_allOf
            // 
            this.checkBox_allOf.AutoSize = true;
            this.checkBox_allOf.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_allOf.ForeColor = System.Drawing.Color.Black;
            this.checkBox_allOf.Location = new System.Drawing.Point(43, 585);
            this.checkBox_allOf.Name = "checkBox_allOf";
            this.checkBox_allOf.Size = new System.Drawing.Size(375, 26);
            this.checkBox_allOf.TabIndex = 21;
            this.checkBox_allOf.Text = "All of the content I put above is true!";
            this.checkBox_allOf.UseVisualStyleBackColor = true;
            this.checkBox_allOf.CheckedChanged += new System.EventHandler(this.checkBox_allOf_CheckedChanged);
            // 
            // button_openNext
            // 
            this.button_openNext.BackColor = System.Drawing.Color.SlateBlue;
            this.button_openNext.FlatAppearance.BorderSize = 0;
            this.button_openNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_openNext.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openNext.ForeColor = System.Drawing.Color.White;
            this.button_openNext.Location = new System.Drawing.Point(798, 571);
            this.button_openNext.Name = "button_openNext";
            this.button_openNext.Size = new System.Drawing.Size(165, 46);
            this.button_openNext.TabIndex = 18;
            this.button_openNext.Text = "Open Next Form";
            this.button_openNext.UseVisualStyleBackColor = false;
            this.button_openNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_favArtist
            // 
            this.textBox_favArtist.Location = new System.Drawing.Point(42, 294);
            this.textBox_favArtist.Multiline = true;
            this.textBox_favArtist.Name = "textBox_favArtist";
            this.textBox_favArtist.Size = new System.Drawing.Size(431, 56);
            this.textBox_favArtist.TabIndex = 20;
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.BackColor = System.Drawing.Color.Transparent;
            this.label_header.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.ForeColor = System.Drawing.Color.SlateBlue;
            this.label_header.Location = new System.Drawing.Point(33, 34);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(259, 49);
            this.label_header.TabIndex = 22;
            this.label_header.Text = "Get Started";
            this.label_header.Click += new System.EventHandler(this.label_header_Click);
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.Color.SlateBlue;
            this.button_submit.FlatAppearance.BorderSize = 0;
            this.button_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submit.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit.ForeColor = System.Drawing.Color.White;
            this.button_submit.Location = new System.Drawing.Point(983, 571);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(165, 46);
            this.button_submit.TabIndex = 23;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ADW04_TAKE_HOME.Properties.Resources.thomas_nongol_anj;
            this.pictureBox1.Location = new System.Drawing.Point(476, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(693, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 630);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.label_header);
            this.Controls.Add(this.textBox_favArtist);
            this.Controls.Add(this.button_openNext);
            this.Controls.Add(this.checkBox_allOf);
            this.Controls.Add(this.label_nama);
            this.Controls.Add(this.label_favArtist);
            this.Controls.Add(this.textBox_nama);
            this.Name = "MainForm";
            this.Text = "Main Window Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nama;
        private System.Windows.Forms.Label label_favArtist;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.Button button_openNext;
        private System.Windows.Forms.TextBox textBox_favArtist;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Button button_submit;
        public System.Windows.Forms.CheckBox checkBox_allOf;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

