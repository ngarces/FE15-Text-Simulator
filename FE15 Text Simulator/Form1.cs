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


namespace FE15TextSimulator
{
    public partial class Form1 : Form
    {
        public static Bitmap backgroundImage;
        public static Bitmap importedL;
        public static Bitmap importedM;
        public static Bitmap importedR;

        
        public Form1()
        {
            InitializeComponent();

            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            comboBox_Left.Items.Add("");
            comboBox_Left.Items.Add("Custom Image");
            comboBox_Mid.Items.Add("");
            comboBox_Mid.Items.Add("Custom Image");
            comboBox_Right.Items.Add("");
            comboBox_Right.Items.Add("Custom Image");
            foreach (KeyValuePair<string, string> entry in Names)
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

        //Holds English names and their corresponding Japanese name used on their portrait file
        public SortedDictionary<string, string> Names = new SortedDictionary<string, string>()
        {
            //Playable Characters
            {"Alm", "アルム"},
            {"Alm (Child)", "幼少アルム"},
            {"Alm (Hero)", "アルム上級"},
            {"Lukas", "ルカ"},
            {"Gray", "グレイ"},
            {"Gray (Child)", "幼少グレイ"},
            {"Tobin", "ロビン"},
            {"Tobin (Child)", "幼少ロビン"},
            {"Faye", "エフィ"},
            {"Faye (Child)", "幼少エフィ"},
            {"Kliff", "クリフ"},
            {"Kliff (Child)", "幼少クリフ"},
            {"Silque", "シルク"},
            {"Clair", "クレア"},
            {"Clive", "クレーベ"},
            {"Forsyth", "フォルス"},
            {"Python", "パイソン"},
            {"Celica", "セリカ"},
            {"Celica (Child)", "幼少セリカ"},
            {"Celica (Princess)", "セリカ上級"},
            {"Boey", "ボーイ"},
            {"Mae", "メイ"},
            {"Genny", "ジェニー"},
            {"Saber", "セーバー"},
            {"Valbar", "バルボ"},
            {"Kamui", "カムイ"},
            {"Leon", "レオ"},
            {"Luthier", "リュート"},
            {"Mathilda", "マチルダ"},
            {"Delthea", "デューテ"},
            {"Palla", "パオラ"},
            {"Catria", "カチュア"},
            {"Atlas", "アトラス"},
            {"Jesse", "ジェシー"},
            {"Sonya", "ソニア"},
            {"Deen", "ディーン"},
            {"Est", "エスト"},
            {"Nomah", "ノーマ"},
            {"Tatiana", "ティータ"},
            {"Zeke", "ジーク"},
            {"Conrad", "コンラート"},
            {"Conrad (Masked)", "仮面の騎士"},
            {"Mycen", "マイセン"},

            //Amiibo
            {"Marth", "マルス"},
            {"Ike", "アイク"},
            {"Robin", "ルフレ男"},
            {"Lucina", "ルキナ"},
            {"Roy", "ロイ"},
            {"Corrin (Male)", "カムイ男"},
            {"Corrin (Female)", "カムイ女"},

            //Enemies
            {"Wolff", "ウォルフ"},
            {"Gazelle", "ガゼル"},
            {"Garth", "ガッハ"},
            {"Gharn", "ガネフ"},
            {"Garcia", "ガルシア"},
            {"Greith", "ギース"},
            {"Cerberus", "ケルベス"},
            {"Aurum", "ゴールド"},
            {"Xaizor", "サイゾー"},
            {"Zakson", "ザクソン"},
            {"Jerome", "ジェローム"},
            {"Jamil", "ジャミル"},
            {"Jedah", "ジュダ"},
            {"Argentum", "シルバー"},
            {"Slayde", "スレイダー"},
            {"Tatarrah", "タタラ"},
            {"Barth", "ダッハ"},
            {"Desaix", "ドゼー"},
            {"Dolk", "ドルク"},
            {"Nuibaba", "ヌイババ"},
            {"Hades", "バデス"},
            {"Fernand", "フェルナン"},
            {"Blake", "ブライ"},
            {"Hestia", "ヘステ"},
            {"Berkut", "ベルクト"},
            {"Naberius", "ベルレス"},
            {"Marla", "マーラ"},
            {"Magnus", "マグナム"},
            {"Mikhail", "ミカエラ"},
            {"Mueller", "ミューラー"},
            {"Rudolf", "ルドルフ"},
            {"Lawson", "ローソン"},
            {"Berkut (Posessed)", "異常ベルクト"},
            {"Brigand Boss", "盗賊頭"},
            {"Rinea (Witch)", "魔女リネア"},

            //NPCs
            {"Irma", "イルマ"},
            {"Fat Merchant", "でっぷり商人"},
            {"Duma", "ドーマ"},
            {"Duma (Human)", "ドーマ人間形態"},
            {"Halcyon", "ハルク"},
            {"Massena", "マッセナ"},
            {"Mila", "ミラ"},
            {"Rinea", "リネア"},
            {"Old Man", "一般おじいさん"},
            {"Man", "一般おじさん"},
            {"Young Man", "一般おにいさん"},
            {"Young Woman", "一般おねえさん"},
            {"Woman", "一般おばさん"},
            {"Celica (Fake)", "偽セリカ"},
            {"Peddler (Pink)", "商人桃"},
            {"Peddler (Green)", "商人緑"},
            {"Peddler (Blue)", "商人青"},
            {"Girl", "女の子"},
            {"Scholarly Man", "学者風の男"},
            {"Conrad (Child)", "幼少コンラート"},
            {"Flashy Man", "派手な服の男"},
            {"Brigand B", "盗賊B"},
            {"Saint", "聖女"},
            {"Nobleman", "貴族のおじさん"},
            {"Nobleman B", "貴族のおじさんB"},
            {"Aristocratic Man", "貴族の老人"},
            {"Blacksmith", "鍛冶屋"},
            {"Hermit", "隠者"},

            //Classes
            {"Archer", "アーチャー"},
            {"Archer (Blue)", "アーチャー青"},
            {"Knight", "アーマー"},
            {"Gold Knight", "ゴールドナイト"},
            {"Gold Knight (Female)", "ゴールドナイト女"},
            {"Cleric", "シスター"},
            {"Cleric (Blue)", "シスター青"},
            {"Sniper", "スナイパー"},
            {"Soldier", "ソルジャー"},
            {"Soldier (Blue)", "ソルジャー青"},
            {"Cavalier", "ナイト"},
            {"Cavalier (Female)", "ナイト女"},
            {"Cavalier (Blue)", "ナイト青"},
            {"Paladin", "パラディン"},
            {"Paladin (Female)", "パラディン女"},
            {"Baron ", "バロン"},
            {"Falcon Knight", "ファルコンナイト"},
            {"Pegasus Knight", "ペガサスナイト"},
            {"Bow Knight", "ボウナイト"},
            {"Mercenary", "傭兵"},
            {"Mercenary (Blue) ", "傭兵青"},
            {"Myrmidon", "剣士"},
            {"Arcanist", "妖術師"},
            {"Villager (Female)", "村人女"},
            {"Villager (Male)", "村人男"},
            {"Brigand", "盗賊"},
            {"Cantor", "祈祷師"},
            {"Priestess", "神官赤"},
            {"Priestess (Blue)", "神官"},
            {"Sage (Blue)", "賢者青"},

            //Monsters
            {"Vesta", "ウェスタ"},
            {"Gargoyle", "ガーゴイル"},
            {"Garuda", "ガルーダ"},
            {"Bonewalker", "スケルトン"},
            {"Revenant", "ゾンビ"},
            {"Titan", "タイタン"},
            {"Dagon", "ダゴン"},
            {"Deimos", "デイモス"},
            {"Duma's Apostle", "ドーマの使徒"},
            {"Dracul", "ドラクル"},
            {"Necrodragon", "ドラゴンゾンビ"},
            {"Deathgoyle", "バルログ"},
            {"Valor", "バロール"},
            {"Mogall", "ビグル"},
            {"Fafnir", "ファフナー"},
            {"Entombed", "マミー"},
            {"Mila's Servant", "ミラのしもべ"},
            {"Lich", "リッチー"},
            {"Guardian", "守護者"},
            {"Fire Dragon", "火竜"},
            {"White Dragon", "白竜"},
            {"The Creation", "造られしもの"},

            //Other
            {"Shadow Man", "_カゲマン"},

            //DLC
            {"Emma", "エマ"},
            {"Randal", "ランド"},
            {"Shade", "シェイド"},
            {"Yuzu", "ユズ"},
            {"Clive (DLC)", "クレーベ2"},
            {"Mathilda (DLC)", "マチルダ2"},
            {"Hostages", "リゲル人捕虜"},
            {"Tomb Lord", "キングマミー"},
        };

        List<string> playable = new List<string>
        {
            "Alm",
            "Alm (Child)",
            "Alm (Hero)",
            "Atlas",
            "Boey",
            "Catria",
            "Celica",
            "Celica (Child)",
            "Celica (Princess)",
            "Clair",
            "Clive",
            "Conrad",
            "Conrad (Masked)",
            "Corrin (Female)",
            "Corrin (Male)",
            "Deen",
            "Delthea",
            "Est",
            "Faye",
            "Faye (Child)",
            "Forsyth",
            "Genny",
            "Gray",
            "Gray (Child)",
            "Ike",
            "Jesse",
            "Kamui",
            "Kliff",
            "Kliff (Child)",
            "Leon",
            "Lucina",
            "Lukas",
            "Luthier",
            "Mae",
            "Marth",
            "Mathilda",
            "Mycen",
            "Nomah",
            "Palla",
            "Python",
            "Robin",
            "Roy",
            "Saber",
            "Silque",
            "Sonya",
            "Tatiana",
            "Tobin",
            "Tobin (Child)",
            "Valbar",
            "Zeke",

            "Emma",
            "Randal",
            "Shade",
            "Yuzu",
            "Clive (DLC)",
            "Mathilda (DLC)"
        };

        Dictionary<string, string> Expressions = new Dictionary<string, string>()
        {
            {"Normal", "通常"},
            {"Cool", "キメ"},
            {"Anger", "怒"},
            {"Sadness", "悲"},
            {"Smile", "笑"},
            {"Pain", "苦"},
            {"Surprised", "驚"},
            {"Special", "特殊1"},
            {"Posessed", "幽霊"},
        };

        List<string> backgrounds = new List<string>
        {
            "Altar of Duma",
            "Dolth Keep",
            "Duma Temple",
            "Duma",
            "Dungeon",
            "Forest Crossroads",
            "Forest Village",
            "Furia Harbor Entrance",
            "Furia Harbor Square",
            "Mila Shrine",
            "Mila Temple Exterior",
            "Mycen's House",
            "Novis Greatport",
            "Pirate Throne Interior",
            "Plains 1",
            "Plains 2",
            "Plains 3",
            "Priory",
            "Prison 1",
            "Prison 2",
            "Ram Valley",
            "Ram Village Entrance",
            "Ram Village Flower Patch",
            "Ram Village Ourskirts",
            "Sage's Hamlet",
            "Ship 1",
            "Ship 2",
            "Sluice Gate Interior",
            "Sluice Gate",
            "Swamp",
            "Thabes Labyrinth",
            "Villa",
            "War Room",
            "Zofia Castle Balcony",
            "Zofia Castle Exterior",
            "Zofia Castle Interior",
            "Zofian Coast",
        };

        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG(*.PNG)|*.png";

            if (sfd.ShowDialog() == DialogResult.OK)
                pictureBox.Image.Save(sfd.FileName, ImageFormat.Png);
        }

        private void comboBox_Left_SelectedIndexChanged(object sender, EventArgs e)
        {
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

            foreach (KeyValuePair<string, string> entry in Expressions)
            {
                string resource = Names[comboBox_Left.Text] + "_bu_" + entry.Value;
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
            foreach (KeyValuePair<string, string> entry in Expressions)
            {
                string resource = Names[comboBox_Mid.Text] + "_bu_" + entry.Value;
                if (playable.Contains(comboBox_Mid.Text))
                    resource += "_";
                if (FE15TextSimulator.Properties.Resources.ResourceManager.GetObject(resource) != null)
                    comboBox_ExpressionsMid.Items.Add(entry.Key);
            }
            comboBox_ExpressionsMid.SelectedIndex = 0;
        }

        private void comboBox_Right_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            foreach (KeyValuePair<string, string> entry in Expressions)
            {
                string resource = Names[comboBox_Right.Text] + "_bu_" + entry.Value;
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

            g.Clear(Color.Transparent);

            if (backgroundImage != null)
                g.DrawImage(backgroundImage, 0, 0);

            if (!string.IsNullOrEmpty(comboBox_Left.Text))
            {
                Bitmap portrait;

                if (comboBox_Left.Text != "Custom Image")
                {
                    string name = Names[comboBox_Left.Text] + "_bu_" + Expressions[comboBox_ExpressionsLeft.Text];
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
                    string name = Names[comboBox_Mid.Text] + "_bu_" + Expressions[comboBox_ExpressionsMid.Text];
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
                    string name = Names[comboBox_Right.Text] + "_bu_" + Expressions[comboBox_ExpressionsRight.Text];
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

                var font = new Font("FOT-Chiaro Std B", 15, FontStyle.Bold, GraphicsUnit.Pixel);
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
                        comboBox_Right.SelectedIndex = -1;
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