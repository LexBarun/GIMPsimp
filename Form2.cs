using System;
using System.Windows.Forms;

namespace GIMPsimp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void timerPos_Tick(object sender, EventArgs e)
        {
            cursorPosX.Text = Cursor.Position.X.ToString(); 
            cursorPosY.Text = Cursor.Position.Y.ToString();
        }

        private void saveChange_Click(object sender, EventArgs e)
        {
            bool A = uint.TryParse(inputStartPosX.Text, out Form1.cursorPos[0]);
            bool B = uint.TryParse(inputStartPosY.Text, out Form1.cursorPos[1]);
            bool C = uint.TryParse(inputDistri1X.Text, out Form1.cursorPos[2]);
            bool D = uint.TryParse(inputDistri1Y.Text, out Form1.cursorPos[3]);
            bool E = uint.TryParse(inputDistri2X.Text, out Form1.cursorPos[4]);
            bool F = uint.TryParse(inputDistri2Y.Text, out Form1.cursorPos[5]);
            bool G = uint.TryParse(inputNewPosX.Text, out Form1.cursorPos[6]);
            bool H = uint.TryParse(inputNewPosY.Text, out Form1.cursorPos[7]);
            bool I = uint.TryParse(inputPathFTextX.Text, out Form1.cursorPos[8]);
            bool J = uint.TryParse(inputPathFTextY.Text, out Form1.cursorPos[9]);
            bool K = uint.TryParse(inputMoveLayerX.Text, out Form1.cursorPos[10]);
            bool L = uint.TryParse(inputMoveLayerY.Text, out Form1.cursorPos[11]);
            if(A && B && C && D && E && F && G && H && I && J && K && L)
            {
                MessageBox.Show("Success!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Number!");
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            inputStartPosX.Text =  Form1.cursorPos[0].ToString();
            inputStartPosY.Text = Form1.cursorPos[1].ToString();
            inputDistri1X.Text = Form1.cursorPos[2].ToString();
            inputDistri1Y.Text = Form1.cursorPos[3].ToString();
            inputDistri2X.Text = Form1.cursorPos[4].ToString();
            inputDistri2Y.Text = Form1.cursorPos[5].ToString();
            inputNewPosX.Text = Form1.cursorPos[6].ToString();
            inputNewPosY.Text = Form1.cursorPos[7].ToString();
            inputPathFTextX.Text = Form1.cursorPos[8].ToString();
            inputPathFTextY.Text = Form1.cursorPos[9].ToString();
            inputMoveLayerX.Text = Form1.cursorPos[10].ToString();
            inputMoveLayerY.Text = Form1.cursorPos[11].ToString();
        }
    }
}
