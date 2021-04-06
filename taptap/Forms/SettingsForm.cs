using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taptap
{
    public partial class SettingsForm : Form
    {
        private static Dictionary<Keys, string> AcceptedKeysToString = new Dictionary<Keys, string>()
        {
            [Keys.A] = "A",
            [Keys.B] = "B",
            [Keys.C] = "C",
            [Keys.D] = "D",
            [Keys.E] = "E",
            [Keys.F] = "F",
            [Keys.G] = "G",
            [Keys.H] = "H",
            [Keys.I] = "I",
            [Keys.J] = "J",
            [Keys.K] = "K",
            [Keys.L] = "L",
            [Keys.M] = "M",
            [Keys.N] = "N",
            [Keys.O] = "O",
            [Keys.P] = "P",
            [Keys.Q] = "Q",
            [Keys.R] = "R",
            [Keys.S] = "S",
            [Keys.T] = "T",
            [Keys.U] = "U",
            [Keys.V] = "V",
            [Keys.W] = "W",
            [Keys.X] = "X",
            [Keys.Y] = "Y",
            [Keys.Z] = "Z",
            [Keys.D1] = "1",
            [Keys.D2] = "2",
            [Keys.D3] = "3",
            [Keys.D4] = "4",
            [Keys.D5] = "5",
            [Keys.D6] = "6",
            [Keys.D7] = "7",
            [Keys.D8] = "8",
            [Keys.D9] = "9",
            [Keys.D0] = "0",
            [Keys.OemMinus] = "-",
            [Keys.Oemplus] = "=",
            [Keys.OemOpenBrackets] = "[",
            [Keys.OemCloseBrackets] = "]",
            [Keys.OemPipe] = @"\",
            [Keys.OemSemicolon] = ";",
            [Keys.OemQuotes] = "'",
            [Keys.Oemtilde] = "`",
            [Keys.Oemcomma] = ",",
            [Keys.OemPeriod] = ".",
            [Keys.OemQuestion] = "/"
        };

        private int desiredStartLocationX;
        private int desiredStartLocationY;
        private bool WaitingForKeypress = false;
        private int whichHotkey = 0;
        public List<Keys> Hotkeys;
        public SettingsForm(int x, int y, List<Keys>hotkeys)
        {
            InitializeComponent();
            desiredStartLocationX = x;
            desiredStartLocationY = y;
            Hotkeys = hotkeys;
            UpdateLabels();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            DesktopLocation = new Point(desiredStartLocationX, desiredStartLocationY);
        }

        private void keybindButton_Click(object sender, EventArgs e) => StartEditingHotkeys();
        private void StartEditingHotkeys()
        {
            if (WaitingForKeypress) return;
            WaitingForKeypress = true;
            DisableButtons();
            
        }

        private void StopEditingHotkeys()
        {
            WaitingForKeypress = false;
            whichHotkey = 0;
            EnableButtons();
            UpdateLabels();
        }

        private void DisableButtons()
        {
            keybindButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 44, 67);
            keybindButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 44, 67);
            keybindButton.ForeColor = Color.DarkGray;
        }

        private void EnableButtons()
        {
            keybindButton.FlatAppearance.MouseOverBackColor = Color.Empty;
            keybindButton.FlatAppearance.MouseDownBackColor = Color.Empty;
            keybindButton.ForeColor = Color.Black;
        }

        private void UpdateLabels()
        {
            label2.Text = AcceptedKeysToString[Hotkeys[0]];
            label3.Text = AcceptedKeysToString[Hotkeys[1]];
            label4.Text = AcceptedKeysToString[Hotkeys[2]];
            label5.Text = AcceptedKeysToString[Hotkeys[3]];
        }

        private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (WaitingForKeypress) { 
                    StopEditingHotkeys();
                }
                else Close();
            }
            

            if (WaitingForKeypress)
            {
                if (AcceptedKeysToString.Keys.Contains(e.KeyCode))
                {
                    Hotkeys[whichHotkey] = e.KeyCode;
                    whichHotkey++;
                    if(whichHotkey > 3)
                    {
                        StopEditingHotkeys();
                    }
                }
            }
        }
    }
}
