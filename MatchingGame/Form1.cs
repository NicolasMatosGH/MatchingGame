namespace MatchingGame
{
    public partial class Form1 : Form
    {
        Random randomic = new Random();
        List<string> icons = new List<string>();
        public Label firstclicked = null;
        public Label secondclicked = null;
        int points;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        public void ChangeForeColor(object sender)
        {
            Label clickedLabel = sender as Label;
            if(firstclicked != null && secondclicked != null)
            {
                if(firstclicked.Text != secondclicked.Text)
                {
                    firstclicked.ForeColor = firstclicked.BackColor;
                    secondclicked.ForeColor = secondclicked.BackColor;
                }
                firstclicked = null;
                secondclicked = null;
            }
                     
            if (clickedLabel != null)
            {
                if(firstclicked == null)
                {
                    firstclicked = clickedLabel;
                    firstclicked.ForeColor = Color.Black;
                }
                else if(secondclicked == null)
                {
                    secondclicked = clickedLabel;  
                    secondclicked.ForeColor = Color.Black;
                    if (firstclicked.Text == secondclicked.Text)
                    {
                        points++;
                    }
                }
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void AssignIconsToSquare()
        {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if(iconLabel != null)
                {
                    int randomNumber = randomic.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    icons.RemoveAt(randomNumber);
                    iconLabel.ForeColor = iconLabel.BackColor;

                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            icons.Add("!");
            icons.Add("!");
            icons.Add("N");
            icons.Add("N");
            icons.Add(",");
            icons.Add(",");
            icons.Add("k");
            icons.Add("k");
            icons.Add("b");
            icons.Add("b");
            icons.Add("v");
            icons.Add("v");
            icons.Add("w");
            icons.Add("w");
            icons.Add("z");
            icons.Add("z");

            AssignIconsToSquare();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            ChangeForeColor(sender);
        }
    }
}