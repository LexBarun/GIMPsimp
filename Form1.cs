/* Main References
 * Move and Get Cursor Position : https://www.youtube.com/watch?v=B9xGJSLb3l4
 * Mouse Click                  : https://stackoverflow.com/questions/2736965/how-to-programatically-trigger-a-mouse-left-click-in-c
 * Keyboard Click               : https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys?view=net-5.0
 */
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace GIMPsimp
{
    public partial class Form1 : Form
    {
        RadioButton checkedButton;
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        public static uint[] cursorPos = { 330, 500, 65, 350, 100, 470, 660, 545, 675, 310, 1250, 750 };
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            checkedButton = doubleLineType;
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            int lineLength = captionLists.Lines.Count();
            captionLists.Enabled = false;
            buttonStart.Enabled = false;
            await Task.Delay(3000); //Delay time to making sure you have focus (select) on GIMP.
            if (checkedButton == singleLineType)
            {
                for (int i = 0; i < lineLength; i++)
                {
                    SendKeys.SendWait("^w"); //Close current GIMP image.
                    await Task.Delay(2000);
                    SendKeys.SendWait("^d"); //Discard change and don't save the GIMP image project.
                    await Task.Delay(2000);
                    SendKeys.SendWait("^n"); //New GIMP image/canvas. Make sure you have set the default settings for every new image/canvas.
                    await Task.Delay(750);
                    SendKeys.SendWait("{ENTER}"); //Generate new GIMP image/canvas.
                    await Task.Delay(750);
                    SendKeys.SendWait("x"); //Exchange the color from outline to text color.
                    await Task.Delay(750);
                    SendKeys.SendWait("t"); //Activate Text Tool.
                    await Task.Delay(750);
                    Cursor.Position = new Point((int)cursorPos[0], (int)cursorPos[1]); // Move cursor to start point inside image/canvas.
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, cursorPos[0], cursorPos[1], 0, 0); //Click the image/canvas to generate text box. Set the parameters (font, size, etc.) and Justify to Centered.
                    Clipboard.SetText(captionLists.Lines[i], TextDataFormat.UnicodeText); //Obtain the caption.
                    SendKeys.SendWait("^v"); //Paste the caption to text box.
                    await Task.Delay(750);
                    SendKeys.SendWait("{ESC}"); //Deselect the text box.
                    await Task.Delay(750);
                    SendKeys.SendWait("q"); //Activate Alignment Tool
                    await Task.Delay(750);
                    Cursor.Position = new Point((int)cursorPos[0] + 20, (int)cursorPos[1] + 20); //Move cursor to inside of text box.
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, cursorPos[0] + 20, cursorPos[1] + 20, 0, 0); //Select the text box.
                    await Task.Delay(750);
                    Cursor.Position = new Point((int)cursorPos[2], (int)cursorPos[3]); //Move cursor to Align Center of Target.
                    await Task.Delay(500);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, cursorPos[2], cursorPos[3], 0, 0); //Align the text box to center of image.
                    await Task.Delay(750);
                    Cursor.Position = new Point((int)cursorPos[4], (int)cursorPos[5]); //Move cursor to Distribute Bottoms of Target.
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, cursorPos[4], cursorPos[5], 0, 0); //Align the text box to bottom. Set the Offset Y for the distance from bottom.
                    await Task.Delay(750);
                    SendKeys.SendWait("t"); //Activate Text Tool
                    await Task.Delay(750);
                    Cursor.Position = new Point((int)cursorPos[6], (int)cursorPos[7]); //Move cursor to inside of text box.
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, cursorPos[6], cursorPos[7], 0, 0); //Select the text box.
                    await Task.Delay(750);
                    mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, cursorPos[6], cursorPos[7], 0, 0); //Show text box menu.
                    await Task.Delay(750);
                    Cursor.Position = new Point((int)cursorPos[8], (int)cursorPos[9]); //Move cursor to Path from Text option.
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, cursorPos[8], cursorPos[9], 0, 0); //Select the Path from Text option.
                    await Task.Delay(750);
                    SendKeys.SendWait("{ESC}"); //Deselect the text box.
                    await Task.Delay(750);
                    SendKeys.SendWait("+v"); //Generate selection from text path.
                    await Task.Delay(750);
                    SendKeys.SendWait("+(^n)"); //Add new layer for text outline.
                    await Task.Delay(750);
                    SendKeys.SendWait("{ENTER}"); //Generate new layer for text outline.
                    await Task.Delay(750);
                    SendKeys.SendWait("%s"); //Show Select menu.
                    await Task.Delay(750);
                    SendKeys.SendWait("g"); //Select Grow menu.
                    await Task.Delay(750);
                    SendKeys.SendWait("{ENTER}"); //Grow the text outline. Set the Grow value.
                    await Task.Delay(750);
                    SendKeys.SendWait("x"); //Exchange the color from text color to outline.
                    await Task.Delay(750);
                    SendKeys.SendWait("^,"); //Fill the outline with color.
                    await Task.Delay(750);
                    Cursor.Position = new Point((int)cursorPos[10], (int)cursorPos[11]); //Move cursor to Lower This Layer One Step in The Layer Stack button.
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, cursorPos[10], cursorPos[11], 0, 0); //Move the outline layer below the text box layer.
                    await Task.Delay(750);
                    SendKeys.SendWait("^e"); //Show Export Image dialogue.
                    await Task.Delay(7000);
                    Clipboard.SetText(i.ToString(), TextDataFormat.UnicodeText); //Obtain the caption order number.
                    SendKeys.SendWait("^v"); //Name the image with caption order number.
                    await Task.Delay(750);
                    SendKeys.SendWait("{ENTER}"); //Export the image.
                    await Task.Delay(4000);
                    SendKeys.SendWait("{ENTER}"); //Export the image.
                    await Task.Delay(4000);
                }
                captionLists.Enabled = true;
                buttonStart.Enabled = true;
            }
            else if (checkedButton == doubleLineType)
            {
                for (int i = 0; i < lineLength / 2; i++)
                {
                    SendKeys.SendWait("^w"); //Close current GIMP image.
                    await Task.Delay(2000);
                    SendKeys.SendWait("^d"); //Discard change and don't save the GIMP image project.
                    await Task.Delay(2000);
                    SendKeys.SendWait("^n"); //New GIMP image/canvas. Make sure you have set the default settings for every new image/canvas.
                    await Task.Delay(750);
                    SendKeys.SendWait("{ENTER}"); //Generate new GIMP image/canvas.
                    await Task.Delay(750);
                    SendKeys.SendWait("x"); //Exchange the color from outline to text color.
                    await Task.Delay(750);
                    SendKeys.SendWait("t"); //Activate Text Tool.
                    await Task.Delay(750);
                    Cursor.Position = new Point((int)cursorPos[0], (int)cursorPos[1]); // Move cursor to start point inside image/canvas.
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, cursorPos[0], cursorPos[1], 0, 0); //Click the image/canvas to generate text box. Set the parameters (font, size, etc.) and Justify to Centered.
                    Clipboard.SetText(captionLists.Lines[i * 2], TextDataFormat.UnicodeText); //Obtain the caption.
                    SendKeys.SendWait("^v"); //Paste the caption to text box.
                    await Task.Delay(750);
                    SendKeys.SendWait("{ENTER}"); //Move to next line of text box.
                    Clipboard.SetText(captionLists.Lines[(i * 2) + 1], TextDataFormat.UnicodeText); //Obtain the second line of caption.
                    SendKeys.SendWait("^v");
                    await Task.Delay(750);
                    SendKeys.SendWait("{ESC}"); //Deselect the text box.
                    await Task.Delay(750);
                    SendKeys.SendWait("q"); //Activate Alignment Tool
                    await Task.Delay(750);
                    Cursor.Position = new Point((int)cursorPos[0] + 20, (int)cursorPos[1] + 20); //Move cursor to inside of text box.
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, cursorPos[0] + 20, cursorPos[1] + 20, 0, 0); //Select the text box.
                    await Task.Delay(750);
                    Cursor.Position = new Point((int)cursorPos[2], (int)cursorPos[3]); //Move cursor to Align Center of Target.
                    await Task.Delay(500);
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, cursorPos[2], cursorPos[3], 0, 0); //Align the text box to center of image.
                    await Task.Delay(750);
                    Cursor.Position = new Point((int)cursorPos[4], (int)cursorPos[5]); //Move cursor to Distribute Bottoms of Target.
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, cursorPos[4], cursorPos[5], 0, 0); //Align the text box to bottom. Set the Offset Y for the distance from bottom.
                    await Task.Delay(750);
                    SendKeys.SendWait("t"); //Activate Text Tool
                    await Task.Delay(750);
                    Cursor.Position = new Point((int)cursorPos[6], (int)cursorPos[7]); //Move cursor to inside of text box.
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, cursorPos[6], cursorPos[7], 0, 0); //Select the text box.
                    await Task.Delay(750);
                    mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, cursorPos[6], cursorPos[7], 0, 0); //Show text box menu.
                    await Task.Delay(750);
                    Cursor.Position = new Point((int)cursorPos[8], (int)cursorPos[9]); //Move cursor to Path from Text option.
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, cursorPos[8], cursorPos[9], 0, 0); //Select the Path from Text option.
                    await Task.Delay(750);
                    SendKeys.SendWait("{ESC}"); //Deselect the text box.
                    await Task.Delay(750);
                    SendKeys.SendWait("+v"); //Generate selection from text path.
                    await Task.Delay(750);
                    SendKeys.SendWait("+(^n)"); //Add new layer for text outline.
                    await Task.Delay(750);
                    SendKeys.SendWait("{ENTER}"); //Generate new layer for text outline.
                    await Task.Delay(750);
                    SendKeys.SendWait("%s"); //Show Select menu.
                    await Task.Delay(750);
                    SendKeys.SendWait("g"); //Select Grow menu.
                    await Task.Delay(750);
                    SendKeys.SendWait("{ENTER}"); //Grow the text outline. Set the Grow value.
                    await Task.Delay(750);
                    SendKeys.SendWait("x"); //Exchange the color from text color to outline.
                    await Task.Delay(750);
                    SendKeys.SendWait("^,"); //Fill the outline with color.
                    await Task.Delay(750);
                    Cursor.Position = new Point((int)cursorPos[10], (int)cursorPos[11]); //Move cursor to Lower This Layer One Step in The Layer Stack button.
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, cursorPos[10], cursorPos[11], 0, 0); //Move the outline layer below the text box layer.
                    await Task.Delay(750);
                    SendKeys.SendWait("^e"); //Show Export Image dialogue.
                    await Task.Delay(7000);
                    Clipboard.SetText(i.ToString(), TextDataFormat.UnicodeText); //Obtain the caption order number.
                    SendKeys.SendWait("^v"); //Name the image with caption order number.
                    await Task.Delay(750);
                    SendKeys.SendWait("{ENTER}"); //Export the image.
                    await Task.Delay(4000);
                    SendKeys.SendWait("{ENTER}"); //Export the image.
                    await Task.Delay(4000);
                }
                captionLists.Enabled = true;
                buttonStart.Enabled = true;
            }
        }

        private void doubleLineType_CheckedChanged(object sender, EventArgs e)
        {
            checkedButton = captionTypeSelector.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked); //https://stackoverflow.com/questions/1797907/which-radio-button-in-the-group-is-checked
        }

        private void cursorSettings_Click(object sender, EventArgs e)
        {
            Form2 settingsForm = new Form2();
            settingsForm.FormClosed += settingsForm_FormClosed;
            this.Enabled = false;
            settingsForm.Show();
        }
        private void settingsForm_FormClosed(object sender, EventArgs e)
        {
            this.Enabled = true;
        }
    }
}