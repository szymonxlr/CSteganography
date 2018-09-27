using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace CSteganography
{
   
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void load_Click(object sender, EventArgs e)
        {

            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "BMP Images (*.bmp, *.jpg, *.png) | *.bmp; *.jpg; *.png";

            if(openDialog.ShowDialog() == DialogResult.OK)
            {
                filepath.Text = openDialog.FileName.ToString();
                pictureBox1.ImageLocation = filepath.Text;
                Bitmap img = new Bitmap(filepath.Text);
                long length = new System.IO.FileInfo(filepath.Text).Length;
                ImageInfo.Text = (String.Join(Environment.NewLine,
                    img.Size.ToString(),
                    "Pixels: " + (img.Width * img.Height).ToString(),
                    "Size: " + length + " bytes",
                    "Format:" + Path.GetExtension(filepath.Text)
                    ));

                msg_find();
                capacity.Text = "Capacity: " + ((((img.Width * img.Height)-8) * 3 * (lsb_bit.Value)) / 8).ToString() + " bytes";


                //button enable
                b_encode.Enabled = true;
                b_decode.Enabled = true;
                b_show_bits.Enabled = true;
                lsb_bit.Enabled = true;
                textBox1.Enabled = true;
                //clear text
                textBox1.Text = null;
                decode_bits.Text = null;
                decode_text.Text = null;
            }
            
        }

        public int bit_set(string s, int pixel, int bit)
        {
            int c = pixel;
            if (s == "1")
            {
                c |= (1 << bit);
            }
            else if (s == "0")
            {
                c &= ~(1 << bit);
            }
            return c;
        }

        public bool bit_read(int pixel, int bit)
        {
            bool a = (pixel & (1 << bit)) != 0;
            return a;
        }

        public int msg_find()
        {
            int msg_length = 0;  
            Bitmap img = new Bitmap(filepath.Text);
            string s = "";
            string result = "";

            for (int i = 8; i > 0; i--)
            {
                Color pixel = img.GetPixel(img.Width - i, img.Height - 1);
                s += Convert.ToByte(bit_read(pixel.R, 1));
                s += Convert.ToByte(bit_read(pixel.R, 0));

                s += Convert.ToByte(bit_read(pixel.G, 1));
                s += Convert.ToByte(bit_read(pixel.G, 0));

                s += Convert.ToByte(bit_read(pixel.B, 1));
                s += Convert.ToByte(bit_read(pixel.B, 0));
            }

            int a1 = Convert.ToInt32(s.Substring(0, 8), 2);
            s = s.Substring(8);
            int a11 = Convert.ToInt32(s.Substring(0, 8), 2);
            s = s.Substring(8);

            int a2 = Convert.ToInt16(s.Substring(0, 16), 2);
            s = s.Substring(16);

            int a3 = Convert.ToInt32(s.Substring(0, 8), 2);
            s = s.Substring(8);
            int a33 = Convert.ToInt32(s.Substring(0, 8), 2);

            // '|' char id 124
            if (a1=='B')
            {
                result += (char)a1;
                result += (char)a11;
                result += (short)a2;
                result += (char)a3;
                result += (char)a33;

                lsb_info.Text = Convert.ToString(result);
                //lsb_info.Text = Convert.ToString(result) + " Bytes encoded";
                msg_length = a2;
            }
            else
            {
                lsb_info.Text = "No Secret Message Here.";
            }
            return msg_length*8;
        }

        private void ImageInfo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(filepath.Text);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files (*.bmp, *.jpg, *.png) | *.bmp; *.png; *.jpg";

            if (message.Text == "")
            {
                bits.Text = "Nothing to encode.";
                return;
            }

            string vv = string.Join("", Encoding.UTF8.GetBytes(message.Text).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')));
            string[] msg = vv.ToCharArray().Select(c => c.ToString()).ToArray();

            if (Convert.ToInt32(textlength.Text) > ((((img.Width * img.Height)-8) * 3 * (lsb_bit.Value + 1)) / 8))
            {
                bits.Text = "Message too long.";
                return;
            }

            int msg_c = 0; 
            int r, g, b;
            int l = Convert.ToInt16(lsb_bit.Value-1);
                                   
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {   
                    Color pixel = img.GetPixel(j, i);

                    r = pixel.R;
                    for (int n = l; n >= 0; n--)
                    {
                        if (msg_c < msg.Length) r = bit_set(msg[msg_c++], r, n);
                        else
                        {
                            //var random = new Random();
                            //string test = Convert.ToString(random.Next(0, 2));
                            msg_c = 0;
                            r = bit_set(msg[msg_c++], r, n);
                        }
                    }
                            
                    g = pixel.G;
                    for (int n = l; n >= 0; n--)
                    {
                        if (msg_c < msg.Length) g = bit_set(msg[msg_c++], g, n);
                        else
                        {
                            //var random = new Random();
                            //string test = Convert.ToString(random.Next(0, 2));
                            //g = bit_set(test, g, n);
                            msg_c = 0;
                            r = bit_set(msg[msg_c++], r, n);
                        }
                    }


                    b = pixel.B;
                    for (int n = l; n >= 0; n--)
                    {
                        if (msg_c < msg.Length) b = bit_set(msg[msg_c++], b, n);
                        else
                        {
                            //var random = new Random();
                            //string test = Convert.ToString(random.Next(0, 2));
                            //b = bit_set(test, b, n);
                            msg_c = 0;
                            r = bit_set(msg[msg_c++], r, n);
                        }
                    }

                    img.SetPixel(j, i, Color.FromArgb(r, g, b));
                }
                if (msg_c > msg.Length) break;
            }

            /////////////////// LAST 8 BITS - lenght info
            short a2 = 0;
            string a1, a11, a3, a33, a22;

            a2 = Convert.ToInt16(message.TextLength);
            a1 = "B" + Convert.ToString(lsb_bit.Value);
            a3 = "FF";
            //decode_bits.Text = (Convert.ToString(a2, 2).PadLeft(16, '0'));

            a11 = string.Join("", Encoding.UTF8.GetBytes(a1).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')));
            a22 = (Convert.ToString(a2, 2).PadLeft(16, '0'));
            a33 = string.Join("", Encoding.UTF8.GetBytes(a3).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')));

            //string x = string.Join("", Encoding.UTF8.GetBytes(z).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')));
            string x = a11 + a22 + a33;
            string[] zx = x.ToCharArray().Select(c => c.ToString()).ToArray();

            // B = 00000000 [0-7] = 00000000 lp = [00000000 00000000] format = [00000000 00000000] (BM/JP/PN/TX/FF...)
            int counter = 0;
            for (int i = 8; i > 0; i--)
            {
                Color pixel = img.GetPixel(img.Width - i, img.Height - 1);
                r = pixel.R;
                g = pixel.G;
                b = pixel.B;

                r = bit_set(zx[counter++], r, 1);
                r = bit_set(zx[counter++], r, 0);

                g = bit_set(zx[counter++], g, 1);
                g = bit_set(zx[counter++], g, 0); 

                b = bit_set(zx[counter++], b, 1);
                b = bit_set(zx[counter++], b, 0);

                img.SetPixel(img.Width-i, img.Height-1 , Color.FromArgb(r, g, b));
             }

            ///////////////////////

            //SAVE
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                filepath.Text = saveFile.FileName.ToString();
                pictureBox1.ImageLocation = filepath.Text;
                img.Save(filepath.Text);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void b_save_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(t_p.Text, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[1024];
            message.Text = "";
            for (int i = 0; i < 10; i++)
            {
                int bytesread = fs.Read(buffer, 0, buffer.Length);
                message.Text += Encoding.ASCII.GetString(buffer, 0, bytesread);
            }
            fs.Close();


        }

        private void b_decode_Click(object sender, EventArgs e)
        {
            decode_bits.Enabled = true;
            decode_text.Enabled = true;
            Bitmap img = new Bitmap(filepath.Text);
            BitArray bitArray = new BitArray(bits.TextLength);

            decode_bits.Text = "";
            int msg_len = 0;
            if (decode_length.Text != "") msg_len = Convert.ToInt32(decode_length.Text)*8;
            else msg_len = msg_find();

            int c = 0;
            int lsb = Convert.ToInt16(lsb_bit.Value-1);
            string rr="", gg="", bb="";
            for (int i = 0; i < img.Height; i++)
            {
                if (c > msg_len) break;
                for (int j = 0; j< img.Width; j++)
                {
                    if (c > msg_len) break;
                    Color pixel = img.GetPixel(j, i);
                    
                    for (int n = lsb; n >= 0; n--)
                    {
                        var r = bit_read(pixel.R, n);
                        var g = bit_read(pixel.G, n);
                        var b = bit_read(pixel.B, n);
                        c += 3;
                        rr += Convert.ToByte(r);
                        gg += Convert.ToByte(g);
                        bb += Convert.ToByte(b);
                    }
                    decode_bits.Text += rr;
                    decode_bits.Text += gg;
                    decode_bits.Text += bb;
                    rr = gg = bb = "";
                }
                
            }

            //decode_bits.Text = decode_bits.Text.Substring(0, msg_len);
            string s = decode_bits.Text;
            //string result = "";
            decode_text.Text = ""; 
            while (s.Length >= 8)
            {
                var first8 = s.Substring(0, 8);
                s = s.Substring(8);
                var number = Convert.ToInt32(first8, 2);
                //result += (char)number;
                decode_text.Text += Convert.ToString((char)number);
            }
            
            
        }
   
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void message_TextChanged(object sender, EventArgs e)
        {
            textlength.Text = Convert.ToString(message.TextLength);
           // bits.Text = string.Join("", Encoding.UTF8.GetBytes(message.Text).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')));
           // bits.Enabled = true;
        }

        private void tobit_Click(object sender, EventArgs e)
        {
            bits.Text = string.Join("", Encoding.UTF8.GetBytes(message.Text).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')));
            
        }
        private void show_bits_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(filepath.Text);
            textBox1.Text = null;
            string[] pad = { "0000000 0", "000000 00", "00000 000", "0000 0000", "000 00000", "00 000000", "0 0000000", "00000000" };
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    Color pixel = img.GetPixel(j, i);

                    if (i < 10 && j < 10)
                    {   
                            textBox1.Text += (String.Join(Environment.NewLine,
                            Int32.Parse(Convert.ToString(pixel.R, 2)).ToString(pad[Convert.ToInt32(lsb_bit.Value-1)]) + "  |  " +
                            Int32.Parse(Convert.ToString(pixel.G, 2)).ToString(pad[Convert.ToInt32(lsb_bit.Value-1)]) + "  |  " +
                            Int32.Parse(Convert.ToString(pixel.B, 2)).ToString(pad[Convert.ToInt32(lsb_bit.Value-1)]),  ""));
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void bits_TextChanged(object sender, EventArgs e)
        {

        }



        private void lsb_info_TextChanged(object sender, EventArgs e)
        {

        }

        private void decode_lsb_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void lsb_bit_ValueChanged(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(filepath.Text);
            textBox1.Text = null;

            capacity.Text = "Capacity: " + (((img.Width * img.Height * 3 * (lsb_bit.Value))/8)-3).ToString()+" bytes";

            string[] pad = { "0000000 0", "000000 00", "00000 000", "0000 0000", "000 00000", "00 000000", "0 0000000", "00000000" };
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    Color pixel = img.GetPixel(j, i);

                    if (i < 10 && j < 10)
                    {
                        textBox1.Text += (String.Join(Environment.NewLine,
                        Int32.Parse(Convert.ToString(pixel.R, 2)).ToString(pad[Convert.ToInt32(lsb_bit.Value-1)]) + "  |  " +
                        Int32.Parse(Convert.ToString(pixel.G, 2)).ToString(pad[Convert.ToInt32(lsb_bit.Value-1)]) + "  |  " +
                        Int32.Parse(Convert.ToString(pixel.B, 2)).ToString(pad[Convert.ToInt32(lsb_bit.Value-1)]), ""));
                    }
                }
            }
        }

        private void capacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_l_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Any file (*.txt, *.bmp, *.jpg) | *.txt; *.bmp; *.jpg; *.png";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                t_p.Text = openDialog.FileName.ToString();
                FileStream fs = new FileStream(t_p.Text, FileMode.Open, FileAccess.Read);
                //byte[] buffer = new byte[1024];
                message.Text = "";
                byte[] buff = File.ReadAllBytes(t_p.Text);

                //for (int i = 0; i < 10; i++)
                //while(byte [] buff = File.ReadAllBytes(t_p.Text);
               // {
                //    int bytesread = fs.Read(buffer, 0, buffer.Length);
                    message.Text += Encoding.ASCII.GetString(buff);
                //}
                fs.Close();
            }

            
           

            //message.Text = Encoding.ASCII.GetString(File.ReadAllBytes(t_p.Text));
        }

        private void filepath_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_p_TextChanged(object sender, EventArgs e)
        {

        }

        private void mab_Click(object sender, EventArgs e)
        {
            bits.Text = string.Join("", Encoding.UTF8.GetBytes(message.Text).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')));
        }
    }
}
