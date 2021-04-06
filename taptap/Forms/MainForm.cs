using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Utilities;

namespace taptap
{
    public partial class MainForm : Form
    {

        globalKeyboardHook gkh = new globalKeyboardHook();

        private int[] KeyClicks = new int [4];

        private bool[] isRepeat = new bool[4];

        private int imgValue;

        private List<Keys> Hotkeys;


        public MainForm()
        {
            InitializeComponent();
            key1Label.Text = KeyClicks[0].ToString();
            key2Label.Text = KeyClicks[1].ToString();
            key3Label.Text = KeyClicks[2].ToString();
            key4Label.Text = KeyClicks[3].ToString();

            Hotkeys = new List<Keys>();
            Hotkeys.Add(Properties.Settings.Default.Hotkey1);
            Hotkeys.Add(Properties.Settings.Default.Hotkey2);
            Hotkeys.Add(Properties.Settings.Default.Hotkey3);
            Hotkeys.Add(Properties.Settings.Default.Hotkey4);

            
            ApplyHotkeys();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ApplyHotkeys()
        {
            //Begin hook process for keys
            if (gkh != null)
            {
                gkh.unhook();
            }
            gkh = new globalKeyboardHook();
            gkh.HookedKeys = Hotkeys;
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            KeyClicks[0] = 0;
            KeyClicks[1] = 0;
            KeyClicks[2] = 0;
            KeyClicks[3] = 0;
            key1Label.Text = KeyClicks[0].ToString();
            key2Label.Text = KeyClicks[1].ToString();
            key3Label.Text = KeyClicks[2].ToString();
            key4Label.Text = KeyClicks[3].ToString();
        }

        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            //lstLog.Items.Add("Up\t" + e.KeyCode.ToString());
            //allow key throughput
            e.Handled = false;
            if(e.KeyCode == Hotkeys[0])
            {
                isRepeat[0] = false;
                imgValue -= 1;
            }
            if (e.KeyCode == Hotkeys[1])
            {
                isRepeat[1] = false;
                imgValue -= 1;
            }
            if (e.KeyCode == Hotkeys[2])
            {
                isRepeat[2] = false;
                imgValue -= 3;
            }
            if (e.KeyCode == Hotkeys[3])
            {
                isRepeat[3] = false;
                imgValue -= 3;
            }

            UpdateImage();
            Console.Out.WriteLine(imgValue);

        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            //lstLog.Items.Add("Down\t" + e.KeyCode.ToString());
            if(e.KeyCode == Hotkeys[0])
            {
                if (!isRepeat[0])
                {
                    KeyClicks[0]++;
                    key1Label.Text = KeyClicks[0].ToString();
                    imgValue += 1;
                }
                isRepeat[0] = true;
            }
            if (e.KeyCode == Hotkeys[1])
            {
                if (!isRepeat[1])
                {
                    KeyClicks[1]++;
                    key2Label.Text = KeyClicks[1].ToString();
                    imgValue += 1;
                }
                isRepeat[1] = true;
            }
            if (e.KeyCode == Hotkeys[2])
            {
                if (!isRepeat[2])
                {
                    KeyClicks[2]++;
                    key3Label.Text = KeyClicks[2].ToString();
                    imgValue += 3;
                }
                isRepeat[2] = true;
            }
            if (e.KeyCode == Hotkeys[3])
            {
                if (!isRepeat[3])
                {
                    KeyClicks[3]++;
                    key4Label.Text = KeyClicks[3].ToString();
                    imgValue += 3;
                }
                isRepeat[3] = true;
            }
            //allow key throughput
            e.Handled = false;
            UpdateImage();
            Console.Out.WriteLine(imgValue);
        }

        public void UpdateImage()
        {
            if(imgValue == 0)
            {
                pictureBox1.Image = taptap.Properties.Resources.key0image;
            } 
            else if(imgValue > 0 && imgValue < 3)
            {
                pictureBox1.Image = taptap.Properties.Resources.key1image;
            }
            else if (imgValue == 3 || imgValue == 6)
            {
                pictureBox1.Image = taptap.Properties.Resources.key3image;
            }
            else if (imgValue == 4 || imgValue == 5 || imgValue >= 7)
            {
                pictureBox1.Image = taptap.Properties.Resources.key5image;
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            int centerX = DesktopLocation.X + (Width / 2);
            int centerY = DesktopLocation.Y + (Height / 2);
            var settingsForm = new SettingsForm(centerX, centerY, Hotkeys);
            settingsForm.ShowDialog();
            Hotkeys = settingsForm.Hotkeys;
            ApplyHotkeys();
            SaveSettings();
            imgValue = 0;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.Hotkey1 = Hotkeys[0];
            Properties.Settings.Default.Hotkey2 = Hotkeys[1];
            Properties.Settings.Default.Hotkey3 = Hotkeys[2];
            Properties.Settings.Default.Hotkey4 = Hotkeys[3];
            Properties.Settings.Default.Save();
        }
    }
}
