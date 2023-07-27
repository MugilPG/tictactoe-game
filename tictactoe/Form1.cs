namespace tictactoe
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void gameover()
        {
            if (count == 9)
            {
                button10.Text = "Draw Match";
            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") {
                button10.Text = "X Wins";
                button1.BackColor= Color.Lime;
                button2.BackColor = Color.Lime;
                button3.BackColor = Color.Lime;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button10.Text = "X Wins";
                button4.BackColor = Color.Lime;
                button5.BackColor = Color.Lime;
                button6.BackColor = Color.Lime;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button10.Text = "X Wins";
                button7.BackColor = Color.Lime;
                button8.BackColor = Color.Lime;
                button9.BackColor = Color.Lime;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button10.Text = "X Wins";
                button1.BackColor = Color.Lime;
                button4.BackColor = Color.Lime;
                button7.BackColor = Color.Lime;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button10.Text = "X Wins";
                button2.BackColor = Color.Lime;
                button5.BackColor = Color.Lime;
                button8.BackColor = Color.Lime;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button10.Text = "X Wins";
                button3.BackColor = Color.Lime;
                button6.BackColor = Color.Lime;
                button9.BackColor = Color.Lime;
            }   
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button10.Text = "X Wins";
                button1.BackColor = Color.Lime;
                button5.BackColor = Color.Lime;
                button9.BackColor = Color.Lime;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button10.Text = "X Wins";
                button3.BackColor = Color.Lime;
                button5.BackColor = Color.Lime;
                button7.BackColor = Color.Lime;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button10.Text = "O Wins";
                button1.BackColor = Color.Yellow;
                button2.BackColor = Color.Yellow;
                button3.BackColor = Color.Yellow;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button10.Text = "O Wins";
                button4.BackColor = Color.Yellow;
                button5.BackColor = Color.Yellow;
                button6.BackColor = Color.Yellow;
            }
            if (button7.Text == "O  " && button8.Text == "O" && button9.Text == "O")
            {
                button10.Text = "O Wins";
                button7.BackColor = Color.Yellow;
                button8.BackColor = Color.Yellow;
                button9.BackColor = Color.Yellow;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button10.Text = "O Wins";
                button1.BackColor = Color.Yellow;
                button4.BackColor = Color.Yellow;
                button7.BackColor = Color.Yellow;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button10.Text = "O Wins";
                button2.BackColor = Color.Yellow;
                button5.BackColor = Color.Yellow;
                button8.BackColor = Color.Yellow;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button10.Text = "O Wins";
                button3.BackColor = Color.Yellow;
                button6.BackColor = Color.Yellow;
                button9.BackColor = Color.Yellow;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button10.Text = "O Wins";
                button1.BackColor = Color.Yellow;
                button5.BackColor = Color.Yellow;
                button9.BackColor = Color.Yellow;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button10.Text = "O Wins";
                button3.BackColor = Color.Yellow;
                button5.BackColor = Color.Yellow;
                button7.BackColor = Color.Yellow;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button10.Text == "O Choice" && button1.Text == "" && button1.Text != "X")
            {
                button1.ForeColor = Color.Lime;
                button1.Text = "O";
                count++;
                button10.Text = "X Choice";
                gameover();
            }
            else
            {
                if (button1.Text == "" && button1.Text != "O"&&((button10.Text == "X Choice") || (button10.Text == "TicTacToe"))) {
                    button1.ForeColor = Color.Yellow;
                    button1.Text = "X";
                    count++;
                    button10.Text = "O Choice";
                    gameover();
                }
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            MaximizeBox= false;
            MinimizeBox = false;
        }
        private void button10_Click(object sender, EventArgs e)
        {  
        
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            if (button10.Text == "O Choice" && button7.Text == "" && button7.Text != "X")
            {
                button7.ForeColor = Color.Lime;
                button7.Text = "O";
                count++;
                button10.Text = "X Choice";
                gameover();
            }
            else if (button7.Text == "" && button7.Text != "O" && ((button10.Text == "X Choice") || (button10.Text == "TicTacToe")))
            {
                button7.ForeColor = Color.Yellow;
                button7.Text = "X";
                count++;
                button10.Text = "O Choice";
                gameover();
            }
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            if (button10.Text == "O Choice" && button9.Text == "" && button9.Text != "X")
            {
                button9.ForeColor = Color.Lime;
                button9.Text = "O";
                count++;
                button10.Text = "X Choice";
                gameover();
            }
            else if (button9.Text == "" && button9.Text != "O" && ((button10.Text == "X Choice") || (button10.Text == "TicTacToe")))
            {
                button9.ForeColor = Color.Yellow;
                button9.Text = "X";
                count++;
                button10.Text = "O Choice";
                gameover();
            }
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            if (button10.Text == "O Choice" && button8.Text == "" && button8.Text != "X")
            {
                button8.ForeColor = Color.Lime;
                button8.Text = "O";
                count++;
                button10.Text = "X Choice";
                gameover();
            }
            else if (button8.Text == "" && button8.Text != "O" && ((button10.Text == "X Choice") || (button10.Text == "TicTacToe")))
            {
                button8.ForeColor = Color.Yellow;
                button8.Text = "X";
                count++;
                button10.Text = "O Choice";
                gameover();
            }
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            if (button10.Text == "O Choice" && button6.Text == "" && button6.Text != "X")
            {
                button6.ForeColor = Color.Lime;
                button6.Text = "O";
                count++;
                button10.Text = "X Choice";
                gameover();
            }
            else if (button6.Text == "" && button6.Text != "O" && ((button10.Text == "X Choice") || (button10.Text == "TicTacToe")))
            {
                button6.ForeColor = Color.Yellow;
                button6.Text = "X";
                count++;
                button10.Text = "O Choice";
                gameover();
            }
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            if (button10.Text == "O Choice" && button5.Text == "" && button5.Text != "X")
            {
                button5.ForeColor = Color.Lime;
                button5.Text = "O";
                count++;
                button10.Text = "X Choice";
                gameover();
            }
            else if (button5.Text == "" && button5.Text != "O" && ((button10.Text == "X Choice") || (button10.Text == "TicTacToe")))
            {
                button5.ForeColor = Color.Yellow;
                button5.Text = "X";
                count++;
                button10.Text = "O Choice";
                gameover();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (button10.Text == "O Choice" && button4.Text == "" && button4.Text != "X")
            {
                button4.ForeColor = Color.Lime;
                button4.Text = "O";
                count++;
                button10.Text = "X Choice";
                gameover();
            }
            else if (button4.Text == "" && button4.Text != "O" && ((button10.Text == "X Choice") || (button10.Text == "TicTacToe")))
            {
                button4.ForeColor = Color.Yellow;
                button4.Text = "X";
                count++;
                button10.Text = "O Choice";
                gameover();
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (button10.Text == "O Choice" && button2.Text == "" && button2.Text != "X")
            {
                button2.ForeColor = Color.Lime;
                button2.Text = "O";
                count++;
                button10.Text = "X Choice";
                gameover();
            }
            else if (button2.Text == "" && button2.Text != "O" && ((button10.Text == "X Choice") || (button10.Text == "TicTacToe")))
            {
                button2.ForeColor = Color.Yellow;
                button2.Text = "X";
                count++;
                button10.Text = "O Choice";
                gameover();
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (button10.Text == "O Choice" && button3.Text == "" && button3.Text != "X")
            {
                button3.ForeColor = Color.Lime;
                button3.Text = "O";
                count++;
                button10.Text = "X Choice";
                gameover();
            }
            else if (button3.Text == "" && button3.Text != "O" && ((button10.Text == "X Choice") || (button10.Text == "TicTacToe")))
            {
                button3.ForeColor = Color.Yellow;
                button3.Text = "X";
                count++;
                button10.Text = "O Choice";
                gameover();
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";
            button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor = button9.BackColor = Color.Black;
            button10.Text = "TicTacToe";
            count = 0;
        }
    }
}