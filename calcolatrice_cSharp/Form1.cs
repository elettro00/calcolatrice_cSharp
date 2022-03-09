namespace calcolatrice_cSharp
{
    public partial class Form1 : Form
    {
        double n1 = 0;
        double n2 = 0;
        double ris = 0;
        char type;
        public Form1()
        {
            InitializeComponent();
            uno.Text = "1";
            due.Text = "2";
            tre.Text = "3";
            quattro.Text = "4";
            cinque.Text = "5";
            sei.Text = "6";
            sette.Text = "7";
            otto.Text = "8";
            nove.Text = "9";
            zero.Text = "0";
            uguale.Text = "=";
            piu.Text = "+";
            meno.Text = "-";
            per.Text = "x";
            diviso.Text = ":";
            virgola.Text = ",";
            x2.Text = "n2";
            r2.Text = "Rad(n)";
            cancella.Text = "C";
            cancellaTutto.Text = "CE";
            ansB.Text = "ANS";
            pi.Text = "PI";
            less.Text = "-";
            x10.Text = "00";

            
        }


        private void uno_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "1";
        }

        private void due_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "2";
        }

        private void tre_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "3";
        }

        private void quattro_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "4";
        }

        private void cinque_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "5";
        }

        private void sei_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "6";
        }

        private void sette_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 7;
        }

        private void otto_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "8";
        }

        private void nove_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "0";
        }

        private void virgola_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + ".";
        }

        private void uguale_Click(object sender, EventArgs e)
        {
            if (!(display.Text == ""))
            {
                n2 = Convert.ToDouble(display.Text);
                v2.Text = n2.ToString();
            }
            switch (type)
            {
                case '+':
                    ris = n1 + n2;
                    break;
                case '-':
                    ris = n1 - n2;
                    break;
                case '*':
                    ris = n1 * n2;
                    break;
                case ':':
                    ris = n1 / n2;
                    break;
            }
            display.Text = ris.ToString();
            ANS.Text = ris.ToString();
        }

        private void diviso_Click(object sender, EventArgs e)
        {
            if (!(display.Text == ""))
            {
                n1 = Convert.ToDouble(display.Text);
                type = ':';
                display.Text = "";
                v1.Text = n1.ToString();
            }
        }

        private void per_Click(object sender, EventArgs e)
        {
            if (!(display.Text == ""))
            {
                n1 = Convert.ToDouble(display.Text);
                type = '*';
                display.Text = "";
                v1.Text = n1.ToString();
            }
        }

        private void meno_Click(object sender, EventArgs e)
        {
            if (!(display.Text == ""))
            {
                n1 = Convert.ToDouble(display.Text);
                type = '-';
                display.Text = "";
                v1.Text = n1.ToString();
            }
        }

        private void piu_Click(object sender, EventArgs e)
        {
            if (!(display.Text == ""))
            {
                n1 = Convert.ToDouble(display.Text);
                type = '+';
                display.Text = "";
                v1.Text = n1.ToString();
            }
        }

        private void cancella_Click(object sender, EventArgs e)
        {
            string c = display.Text;
            int l = c.Length;
            display.Text = c.Remove(l-1);
        }
        private void cancellaTutto_Click(object sender, EventArgs e)
        {
            display.Text = "";
            n1 = 0;
            n2 = 0;
            v1.Text = "";
            v2.Text = "";
        }

        private void x2_Click(object sender, EventArgs e)
        {
            if (!(display.Text == ""))
            {
                n1 = Convert.ToDouble(display.Text);
                ris = Math.Pow(n1,2);
                display.Text = ris.ToString();
                ANS.Text = ris.ToString();
            }
        }

        private void r2_Click(object sender, EventArgs e)
        {
            if (!(display.Text == ""))
            {
                n1 = Convert.ToDouble(display.Text);
                ris = Math.Sqrt(n1);
                display.Text = ris.ToString();
                ANS.Text = ris.ToString();
            }
        }

        private void pi_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + Math.PI.ToString();
        }

        private void less_Click(object sender, EventArgs e)
        {
            if (display.Text=="") 
            display.Text = display.Text + "-";
        }

        private void x10_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "00";
        }

        private void ansB_Click(object sender, EventArgs e)
        {
            display.Text = ANS.Text;
        }
    }
}
