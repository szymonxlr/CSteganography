namespace CSteganography
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.load = new System.Windows.Forms.Button();
            this.b_encode = new System.Windows.Forms.Button();
            this.b_decode = new System.Windows.Forms.Button();
            this.filepath = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ImageInfo = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.TextBox();
            this.bits = new System.Windows.Forms.TextBox();
            this.b_show_bits = new System.Windows.Forms.Button();
            this.decode_text = new System.Windows.Forms.TextBox();
            this.decode_bits = new System.Windows.Forms.TextBox();
            this.lsb_info = new System.Windows.Forms.TextBox();
            this.lsb_bit = new System.Windows.Forms.NumericUpDown();
            this.textlength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.TextBox();
            this.t_p = new System.Windows.Forms.TextBox();
            this.t_l = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.decode_length = new System.Windows.Forms.TextBox();
            this.mab = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsb_bit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(418, 211);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 201);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.load.Location = new System.Drawing.Point(12, 419);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(94, 23);
            this.load.TabIndex = 5;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // b_encode
            // 
            this.b_encode.Enabled = false;
            this.b_encode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.b_encode.Location = new System.Drawing.Point(879, 336);
            this.b_encode.Name = "b_encode";
            this.b_encode.Size = new System.Drawing.Size(157, 23);
            this.b_encode.TabIndex = 6;
            this.b_encode.Text = "ENCODE";
            this.b_encode.UseVisualStyleBackColor = true;
            this.b_encode.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_decode
            // 
            this.b_decode.Enabled = false;
            this.b_decode.Location = new System.Drawing.Point(653, 336);
            this.b_decode.Name = "b_decode";
            this.b_decode.Size = new System.Drawing.Size(220, 23);
            this.b_decode.TabIndex = 7;
            this.b_decode.Text = "DECODE";
            this.b_decode.UseVisualStyleBackColor = true;
            this.b_decode.Click += new System.EventHandler(this.b_decode_Click);
            // 
            // filepath
            // 
            this.filepath.Location = new System.Drawing.Point(112, 419);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(300, 22);
            this.filepath.TabIndex = 8;
            this.filepath.TextChanged += new System.EventHandler(this.filepath_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ImageInfo
            // 
            this.ImageInfo.Enabled = false;
            this.ImageInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImageInfo.Location = new System.Drawing.Point(418, 32);
            this.ImageInfo.Multiline = true;
            this.ImageInfo.Name = "ImageInfo";
            this.ImageInfo.Size = new System.Drawing.Size(220, 80);
            this.ImageInfo.TabIndex = 10;
            this.ImageInfo.TextChanged += new System.EventHandler(this.ImageInfo_TextChanged);
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.message.Location = new System.Drawing.Point(879, 211);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(220, 119);
            this.message.TabIndex = 12;
            this.message.TextChanged += new System.EventHandler(this.message_TextChanged);
            // 
            // bits
            // 
            this.bits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bits.Location = new System.Drawing.Point(879, 57);
            this.bits.Multiline = true;
            this.bits.Name = "bits";
            this.bits.Size = new System.Drawing.Size(220, 131);
            this.bits.TabIndex = 14;
            this.bits.TextChanged += new System.EventHandler(this.bits_TextChanged);
            // 
            // b_show_bits
            // 
            this.b_show_bits.Enabled = false;
            this.b_show_bits.Location = new System.Drawing.Point(418, 182);
            this.b_show_bits.Name = "b_show_bits";
            this.b_show_bits.Size = new System.Drawing.Size(220, 23);
            this.b_show_bits.TabIndex = 15;
            this.b_show_bits.Text = "Bit Color Values";
            this.b_show_bits.UseVisualStyleBackColor = true;
            this.b_show_bits.Click += new System.EventHandler(this.show_bits_Click);
            // 
            // decode_text
            // 
            this.decode_text.Enabled = false;
            this.decode_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decode_text.Location = new System.Drawing.Point(653, 211);
            this.decode_text.Multiline = true;
            this.decode_text.Name = "decode_text";
            this.decode_text.Size = new System.Drawing.Size(220, 119);
            this.decode_text.TabIndex = 16;
            this.decode_text.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // decode_bits
            // 
            this.decode_bits.Enabled = false;
            this.decode_bits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decode_bits.Location = new System.Drawing.Point(653, 57);
            this.decode_bits.Multiline = true;
            this.decode_bits.Name = "decode_bits";
            this.decode_bits.Size = new System.Drawing.Size(220, 131);
            this.decode_bits.TabIndex = 17;
            this.decode_bits.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // lsb_info
            // 
            this.lsb_info.Enabled = false;
            this.lsb_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lsb_info.Location = new System.Drawing.Point(418, 118);
            this.lsb_info.Name = "lsb_info";
            this.lsb_info.Size = new System.Drawing.Size(220, 24);
            this.lsb_info.TabIndex = 23;
            this.lsb_info.TextChanged += new System.EventHandler(this.lsb_info_TextChanged);
            // 
            // lsb_bit
            // 
            this.lsb_bit.Enabled = false;
            this.lsb_bit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lsb_bit.Location = new System.Drawing.Point(600, 420);
            this.lsb_bit.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.lsb_bit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lsb_bit.Name = "lsb_bit";
            this.lsb_bit.Size = new System.Drawing.Size(38, 26);
            this.lsb_bit.TabIndex = 26;
            this.lsb_bit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lsb_bit.ValueChanged += new System.EventHandler(this.lsb_bit_ValueChanged);
            // 
            // textlength
            // 
            this.textlength.Enabled = false;
            this.textlength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textlength.Location = new System.Drawing.Point(1042, 336);
            this.textlength.Multiline = true;
            this.textlength.Name = "textlength";
            this.textlength.Size = new System.Drawing.Size(57, 23);
            this.textlength.TabIndex = 27;
            this.textlength.TextChanged += new System.EventHandler(this.textBox2_TextChanged_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Image Info:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Decoded bits:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Decoded message:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(879, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Enter message:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(559, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Bit:";
            // 
            // capacity
            // 
            this.capacity.Enabled = false;
            this.capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.capacity.Location = new System.Drawing.Point(418, 148);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(220, 24);
            this.capacity.TabIndex = 34;
            this.capacity.TextChanged += new System.EventHandler(this.capacity_TextChanged);
            // 
            // t_p
            // 
            this.t_p.Location = new System.Drawing.Point(806, 433);
            this.t_p.Name = "t_p";
            this.t_p.Size = new System.Drawing.Size(180, 22);
            this.t_p.TabIndex = 35;
            this.t_p.Visible = false;
            this.t_p.TextChanged += new System.EventHandler(this.t_p_TextChanged);
            // 
            // t_l
            // 
            this.t_l.Location = new System.Drawing.Point(1005, 367);
            this.t_l.Name = "t_l";
            this.t_l.Size = new System.Drawing.Size(94, 23);
            this.t_l.TabIndex = 36;
            this.t_l.Text = "Load File";
            this.t_l.UseVisualStyleBackColor = true;
            this.t_l.Click += new System.EventHandler(this.t_l_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1064, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "v1.3";
            // 
            // decode_length
            // 
            this.decode_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decode_length.Location = new System.Drawing.Point(653, 365);
            this.decode_length.Multiline = true;
            this.decode_length.Name = "decode_length";
            this.decode_length.Size = new System.Drawing.Size(50, 23);
            this.decode_length.TabIndex = 38;
            // 
            // mab
            // 
            this.mab.Location = new System.Drawing.Point(879, 26);
            this.mab.Name = "mab";
            this.mab.Size = new System.Drawing.Size(220, 25);
            this.mab.TabIndex = 39;
            this.mab.Text = "Message as Bits";
            this.mab.UseVisualStyleBackColor = true;
            this.mab.Click += new System.EventHandler(this.mab_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1106, 457);
            this.Controls.Add(this.mab);
            this.Controls.Add(this.decode_length);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.t_l);
            this.Controls.Add(this.t_p);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textlength);
            this.Controls.Add(this.lsb_bit);
            this.Controls.Add(this.lsb_info);
            this.Controls.Add(this.decode_bits);
            this.Controls.Add(this.decode_text);
            this.Controls.Add(this.b_show_bits);
            this.Controls.Add(this.bits);
            this.Controls.Add(this.message);
            this.Controls.Add(this.ImageInfo);
            this.Controls.Add(this.filepath);
            this.Controls.Add(this.b_decode);
            this.Controls.Add(this.b_encode);
            this.Controls.Add(this.load);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "209382_Steganography";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsb_bit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button b_encode;
        private System.Windows.Forms.Button b_decode;
        private System.Windows.Forms.TextBox filepath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox ImageInfo;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.TextBox bits;
        private System.Windows.Forms.Button b_show_bits;
        private System.Windows.Forms.TextBox decode_text;
        private System.Windows.Forms.TextBox decode_bits;
        private System.Windows.Forms.TextBox lsb_info;
        private System.Windows.Forms.NumericUpDown lsb_bit;
        private System.Windows.Forms.TextBox textlength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox capacity;
        private System.Windows.Forms.TextBox t_p;
        private System.Windows.Forms.Button t_l;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox decode_length;
        private System.Windows.Forms.Button mab;
    }
}

