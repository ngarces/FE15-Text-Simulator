using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FE15TextSimulator;

namespace FE15TextSimulator
{
    public partial class Form1 : Form
    {
        public static Bitmap backgroundImage;
        public static Bitmap importedL;
        public static Bitmap importedM;
        public static Bitmap importedR;

        NameList nameList = new NameList();
        

        public Form1()
        {
            InitializeComponent();

            List<string> backgrounds = nameList.GetBackgrounds();

            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            comboBox_Left.Items.Add("");
            comboBox_Left.Items.Add("Custom Image");
            comboBox_Mid.Items.Add("");
            comboBox_Mid.Items.Add("Custom Image");
            comboBox_Right.Items.Add("");
            comboBox_Right.Items.Add("Custom Image");
            foreach (KeyValuePair<string, string> entry in nameList.Names)
            {
                comboBox_Left.Items.Add(entry.Key);
                comboBox_Mid.Items.Add(entry.Key);
                comboBox_Right.Items.Add(entry.Key);
            }
            comboBox_Background.Items.Add("");
            comboBox_Background.Items.Add("Custom Image");
            foreach (string entry in backgrounds)
                comboBox_Background.Items.Add(entry);

            refresh_Picturebox();
        }


        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG(*.PNG)|*.png";

            if (sfd.ShowDialog() == DialogResult.OK)
                pictureBox.Image.Save(sfd.FileName, ImageFormat.Png);
        }

        private void comboBox_Left_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> playable = nameList.GetPlayable();

            comboBox_ExpressionsLeft.Items.Clear();
            if (string.IsNullOrEmpty(comboBox_Left.Text))
            {
                refresh_Picturebox();
                return;
            }
            if (comboBox_Left.Text == "Custom Image")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    importedL = new Bitmap(ofd.FileName);
                }
                else
                {
                    comboBox_Left.SelectedIndex = 0;
                }
                refresh_Picturebox();
                return;
            }

            foreach (KeyValuePair<string, string> entry in nameList.Expressions)
            {
                string resource = nameList.Names[comboBox_Left.Text] + "_bu_" + entry.Value;
                if (playable.Contains(comboBox_Left.Text))
                    resource += "_";
                if (FE15TextSimulator.Properties.Resources.ResourceManager.GetObject(resource) != null)
                    comboBox_ExpressionsLeft.Items.Add(entry.Key);
            }
            comboBox_ExpressionsLeft.SelectedIndex = 0;
            refresh_Picturebox();
        }

        private void comboBox_Mid_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> playable = nameList.GetPlayable();
            
            comboBox_ExpressionsMid.Items.Clear();
            if (string.IsNullOrEmpty(comboBox_Mid.Text))
            {
                refresh_Picturebox();
                return;
            }
            if (comboBox_Mid.Text == "Custom Image")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    importedM = new Bitmap(ofd.FileName);
                }
                else
                {
                    comboBox_Mid.SelectedIndex = 0;
                }
                refresh_Picturebox();
                return;
            }
            foreach (KeyValuePair<string, string> entry in nameList.Expressions)
            {
                string resource = nameList.Names[comboBox_Mid.Text] + "_bu_" + entry.Value;
                if (playable.Contains(comboBox_Mid.Text))
                    resource += "_";
                if (FE15TextSimulator.Properties.Resources.ResourceManager.GetObject(resource) != null)
                    comboBox_ExpressionsMid.Items.Add(entry.Key);
            }
            comboBox_ExpressionsMid.SelectedIndex = 0;
        }

        private void comboBox_Right_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> playable = nameList.GetPlayable();
            
            comboBox_ExpressionsRight.Items.Clear();
            if (string.IsNullOrEmpty(comboBox_Right.Text))
            {
                refresh_Picturebox();
                return;
            }
            if (comboBox_Right.Text == "Custom Image")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    importedR = new Bitmap(ofd.FileName);
                }
                else
                {
                    comboBox_Right.SelectedIndex = 0;
                }
                refresh_Picturebox();
                return;
            }
            foreach (KeyValuePair<string, string> entry in nameList.Expressions)
            {
                string resource = nameList.Names[comboBox_Right.Text] + "_bu_" + entry.Value;
                if (playable.Contains(comboBox_Right.Text))
                    resource += "_";
                if (FE15TextSimulator.Properties.Resources.ResourceManager.GetObject(resource) != null)
                    comboBox_ExpressionsRight.Items.Add(entry.Key);
            }
            comboBox_ExpressionsRight.SelectedIndex = 0;
        }

        public Bitmap SetBrightness(Bitmap bmp, int brightness)
        {
            if (brightness < -255) brightness = -255;
            if (brightness > 255) brightness = 255;

            Bitmap tempBmp = bmp;

            float finalValue = (float)brightness/255.0f;

            Bitmap newBmp = new Bitmap(tempBmp.Width, tempBmp.Height);

            Graphics g = Graphics.FromImage(newBmp);

            float[][] floatColorMatrix = {
                new float[] {1, 0, 0, 0, 0},
                new float[] {0, 1, 0, 0, 0},
                new float[] {0, 0, 1, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {finalValue, finalValue, finalValue, 0, 1}
            };

            ColorMatrix newColorMatrix = new ColorMatrix(floatColorMatrix);
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(newColorMatrix);

            g.DrawImage(tempBmp, new Rectangle(0, 0, tempBmp.Width, tempBmp.Height), 0, 0, tempBmp.Width, tempBmp.Height, GraphicsUnit.Pixel, attributes);

            return newBmp;
        }

        private void refresh_Picturebox()
        {
            Bitmap bmp = new Bitmap(pictureBox.Image);
            Graphics g = Graphics.FromImage(bmp);
            List<string> playable = nameList.GetPlayable();

            g.Clear(Color.Transparent);

            if (backgroundImage != null)
                g.DrawImage(backgroundImage, 0, 0);

            if (!string.IsNullOrEmpty(comboBox_Left.Text))
            {
                Bitmap portrait;

                if (comboBox_Left.Text != "Custom Image")
                {
                    string name = nameList.Names[comboBox_Left.Text] + "_bu_" + nameList.Expressions[comboBox_ExpressionsLeft.Text];
                    if (playable.Contains(comboBox_Left.Text))
                        name += "_";    //Playable characters have an extra underscore at the end of their file names
                    portrait = (Bitmap)FE15TextSimulator.Properties.Resources.ResourceManager.GetObject(name);
                }
                else
                    portrait = (Bitmap)importedL.Clone();

                if (checkBox_DarkenL.Checked)
                    portrait = SetBrightness(portrait, -70);
                g.DrawImage(portrait, -29, 0);
            }

            if (!string.IsNullOrEmpty(comboBox_Mid.Text))
            {
                Bitmap portrait;

                if (comboBox_Mid.Text != "Custom Image")
                {
                    string name = nameList.Names[comboBox_Mid.Text] + "_bu_" + nameList.Expressions[comboBox_ExpressionsMid.Text];
                    if (playable.Contains(comboBox_Mid.Text))
                        name += "_";    //Playable characters have an extra underscore at the end of their file names
                    portrait = (Bitmap)FE15TextSimulator.Properties.Resources.ResourceManager.GetObject(name);
                }
                else
                    portrait = (Bitmap)importedM.Clone();

                if (checkBox_DarkenM.Checked)
                    portrait = SetBrightness(portrait, -70);
                g.DrawImage(portrait, 72, 0);
            }

            if (!string.IsNullOrEmpty(comboBox_Right.Text))
            {
                Bitmap portrait;

                if (comboBox_Right.Text != "Custom Image")
                {
                    string name = nameList.Names[comboBox_Right.Text] + "_bu_" + nameList.Expressions[comboBox_ExpressionsRight.Text];
                    if (playable.Contains(comboBox_Right.Text))
                        name += "_";    //Playable characters have an extra underscore at the end of their file names
                    portrait = (Bitmap)FE15TextSimulator.Properties.Resources.ResourceManager.GetObject(name);
                }
                else
                    portrait = (Bitmap)importedR.Clone();

                if (checkBox_DarkenR.Checked)
                    portrait = SetBrightness(portrait, -70);
                g.DrawImage(portrait, 172, 0);
            }

            if (!checkBox_HideText.Checked)
            {
                g.DrawImage(FE15TextSimulator.Properties.Resources.TextBox, 0, 151);

                Font font = new Font("FOT-Chiaro Std B", 14.9f, GraphicsUnit.Pixel);
                g.TextRenderingHint = TextRenderingHint.AntiAlias;
                g.DrawString(richTextBox_Text1.Text, font, Brushes.Bisque, new Point(28, 188));
                g.DrawString(richTextBox_Text2.Text, font, Brushes.Bisque, new Point(28, 208));

                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                g.DrawString(richTextBox_Name.Text, font, Brushes.Bisque, new Rectangle(8, 162, 123, 18), stringFormat);

                if (checkBox_Arrow.Checked)
                    g.DrawImage(FE15TextSimulator.Properties.Resources.Arrow, 367, 207);
            }
            pictureBox.Image = bmp;
        }

        private void richTextBox_Name_TextChanged(object sender, EventArgs e)
        {
            refresh_Picturebox();
        }

        private void richTextBox_Text1_TextChanged(object sender, EventArgs e)
        {
            refresh_Picturebox();
        }

        private void richTextBox_Text2_TextChanged(object sender, EventArgs e)
        {
            refresh_Picturebox();
        }

        private void comboBox_ExpressionsLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_Picturebox();
        }

        private void comboBox_ExpressionsMid_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_Picturebox();
        }

        private void comboBox_ExpressionsRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_Picturebox();
        }

        private void checkBox_DarkenL_Click(object sender, EventArgs e)
        {
            refresh_Picturebox();
        }

        private void checkBox_DarkenM_CheckedChanged(object sender, EventArgs e)
        {
            refresh_Picturebox();
        }

        private void checkBox_DarkenR_CheckedChanged(object sender, EventArgs e)
        {
            refresh_Picturebox();
        }

        private void checkBox_Arrow_CheckedChanged(object sender, EventArgs e)
        {
            refresh_Picturebox();
        }

        private void comboBox_Background_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox_Background.Text))
            {
                if (comboBox_Background.Text == "Custom Image")
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                    if (ofd.ShowDialog() == DialogResult.OK)
                        backgroundImage = new Bitmap(ofd.FileName);
                    else
                    {
                        comboBox_Background.SelectedIndex = 0;
                        backgroundImage = null;
                    }
                }
                else
                {
                    string resourceName = comboBox_Background.Text;
                    resourceName = resourceName.Replace(" ", "_");
                    resourceName = resourceName.Replace("'", "_");
                    backgroundImage = (Bitmap)FE15TextSimulator.Properties.Resources.ResourceManager.GetObject(resourceName);
                }
            }
            refresh_Picturebox();
        }

        private void checkBox_HideText_CheckedChanged(object sender, EventArgs e)
        {
            refresh_Picturebox();
        }
    }
}