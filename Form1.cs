using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;

        }

        int bandera = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bandera++;  
            panel1.Visible = false;
            panel2.Visible = true;
        }

        //panel instrucciones
        private void button3_Click(object sender, EventArgs e)
        {

        }
        //panel Creditos
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (bandera >= 1)
            {
                panel2.Visible = false;
                panel5.Visible = true;
            }
            else
            {
                panel2.Visible = false;
                panel3.Visible = true;
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (bandera >= 1)
            {
                panel2.Visible = false;
                panel6.Visible = true;
            }
            else
            {
                panel2.Visible = false;
                panel4.Visible = true;
            }

        }

        //inicia panel de loteria avanzada un jugador


        int contadorAvanzda = 0;
        int contadorAvanzda2 = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = !button6.Enabled;
            contadorAvanzda++;
            if (contadorAvanzda >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel3.Visible = false;
                panel1.Visible = true;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = !button7.Enabled;
            contadorAvanzda++;
            if (contadorAvanzda >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel3.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button3.Enabled = !button3.Enabled;
            contadorAvanzda++;
            if (contadorAvanzda >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel3.Visible = false;
                panel1.Visible = true;
            }
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            button4.Enabled = !button4.Enabled;
            contadorAvanzda++;
            if (contadorAvanzda >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel3.Visible = false;
                panel1.Visible = true;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = !button5.Enabled;
            contadorAvanzda++;
            if (contadorAvanzda >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel3.Visible = false;
                panel1.Visible = true;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = !button8.Enabled;
            contadorAvanzda++;
            if (contadorAvanzda >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel3.Visible = false;
                panel1.Visible = true;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = !button9.Enabled;
            contadorAvanzda++;
            if (contadorAvanzda >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel3.Visible = false;
                panel1.Visible = true;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = !button10.Enabled;
            contadorAvanzda++;
            if (contadorAvanzda >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel3.Visible = false;
                panel1.Visible = true;
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = !button11.Enabled;
            contadorAvanzda++;
            if (contadorAvanzda >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel3.Visible = false;
                panel1.Visible = true;
            }
        }

        //finaliza panel avanzada un jugador


        private void AbandonarLoteriaAvansada_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has perdido ", "Perdiste",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            panel3.Visible = false;
            panel1.Visible = true;
        }
        //inicia loteria un jugador básica 
        private void button12_Click(object sender, EventArgs e)
        {
            button12.Enabled = !button12.Enabled;
            contadorAvanzda2++;
            if (contadorAvanzda2 >= 6)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel4.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Enabled = !button13.Enabled;
            contadorAvanzda2++;
            if (contadorAvanzda2 >= 6)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel4.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Enabled = !button14.Enabled;
            contadorAvanzda2++;
            if (contadorAvanzda2 >= 6)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel4.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Enabled = !button15.Enabled;
            contadorAvanzda2++;
            if (contadorAvanzda2 >= 6)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel4.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Enabled = !button16.Enabled;
            contadorAvanzda2++;
            if (contadorAvanzda2 >= 6)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel4.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Enabled = !button17.Enabled;
            contadorAvanzda2++;
            if (contadorAvanzda2 >= 6)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel4.Visible = false;
                panel1.Visible = true;
            }
        }

        private void AbandonarLoteriaBasica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has perdido ", "Perdiste",
   MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            panel4.Visible = false;
            panel1.Visible = true;
        }
        //inicia panel de multijugador avanzada botones declaracion de ds variables

           int  contadorJ1=0;
          int   contadorJ2=0;

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Enabled = !button20.Enabled;
            contadorJ1++;
            if (contadorJ1 >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
              MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel5.Visible = false;
                panel1.Visible = true;
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            button21.Enabled = !button21.Enabled;
            contadorJ1++;
            if (contadorJ1 >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
              MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel5.Visible = false;
                panel1.Visible = true;
            }

        }


        private void button22_Click(object sender, EventArgs e)
        {
            button22.Enabled = !button22.Enabled;
            contadorJ1++;
            if (contadorJ1 >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel5.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.Enabled = !button23.Enabled;
            contadorJ1++;
            if (contadorJ1 >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
              MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel5.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.Enabled = !button24.Enabled;
            contadorJ1++;
            if (contadorJ1 >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
              MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel5.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.Enabled = !button25.Enabled;
            contadorJ1++;
            if (contadorJ1 >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
              MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel5.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.Enabled = !button26.Enabled;
            contadorJ1++;
            if (contadorJ1 >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel5.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.Enabled = !button27.Enabled;
            contadorJ1++;
            if (contadorJ1 >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel5.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.Enabled = !button28.Enabled;
            contadorJ1++;
            if (contadorJ1 >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1  ", "Ganador",
              MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel5.Visible = false;
                panel1.Visible = true;
            }
        }

        private void AbandonarJugador1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has perdido ", "Perdiste",
   MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            panel5.Visible = false;
            panel1.Visible = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.Enabled = !button29.Enabled;
            contadorJ2++;
            if (contadorJ2 >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 2 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel5.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button30.Enabled = !button30.Enabled;
            contadorJ2++;
            if (contadorJ2 >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 2 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel5.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.Enabled = !button31.Enabled;
            contadorJ2++;
            if (contadorJ2 >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 2 ", "Ganador",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel5.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.Enabled = !button32.Enabled;
            contadorJ2++;
            if (contadorJ2 >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 2 ", "Ganador",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel5.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33.Enabled = !button33.Enabled;
            contadorJ2++;
            if (contadorJ2 >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 2 ", "Ganador",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel5.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button34.Enabled = !button34.Enabled;
            contadorJ2++;
            if (contadorJ2 >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 2 ", "Ganador",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel5.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button35.Enabled = !button35.Enabled;
            contadorJ2++;
            if (contadorJ2 >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 2 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel5.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button36.Enabled = !button36.Enabled;
            contadorJ2++;
            if (contadorJ2 >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 2 ", "Ganador",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel5.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button37.Enabled = !button37.Enabled;
            contadorJ2++;
            if (contadorJ2 >= 9)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 2 ", "Ganador",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel5.Visible = false;
                panel1.Visible = true;
            }
        }
        private void AbandonarJugador2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has perdido ", "Perdiste",
   MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            panel5.Visible = false;
            panel1.Visible = true;
        }
        //finaliza panel de multijugador avanzada


        //inicia panel de multijugador basica declaracion de variables

        int contadorBasicaJ1 = 0;
        int contadorBasicaJ2 = 0;
        private void button55_Click(object sender, EventArgs e)
        {
            button55.Enabled = !button55.Enabled;
            contadorBasicaJ1++;
            if (contadorBasicaJ1 >= 6)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel6.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            button54.Enabled = !button54.Enabled;
            contadorBasicaJ1++;
            if (contadorBasicaJ1 >= 6)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel6.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            button53.Enabled = !button53.Enabled;
            contadorBasicaJ1++;
            if (contadorBasicaJ1 >= 6)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel6.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            button52.Enabled = !button52.Enabled;
            contadorBasicaJ1++;
            if (contadorBasicaJ1 >= 6)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel6.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            button51.Enabled = !button51.Enabled;
            contadorBasicaJ1++;
            if (contadorBasicaJ1 >= 6)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel6.Visible = false;
                panel1.Visible = true;
            }
        }

       
        private void button50_Click(object sender, EventArgs e)
        {
            button50.Enabled = !button50.Enabled;
            contadorBasicaJ1++;
            if (contadorBasicaJ1 >= 6)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 1 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel6.Visible = false;
                panel1.Visible = true;
            }
        }


        private void button46_Click(object sender, EventArgs e)
        {
            button46.Enabled = !button46.Enabled;
            contadorBasicaJ2++;
            if (contadorBasicaJ2 >= 6)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 2 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel6.Visible = false;
                panel1.Visible = true;
            }

        }
        private void button45_Click(object sender, EventArgs e)
        {
            button45.Enabled = !button45.Enabled;
            contadorBasicaJ2++;
            if (contadorBasicaJ2 >= 6)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 2 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel6.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            button44.Enabled = !button44.Enabled;
            contadorBasicaJ2++;
            if (contadorBasicaJ2 >= 6)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 2 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel6.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            button43.Enabled = !button43.Enabled;
            contadorBasicaJ2++;
            if (contadorBasicaJ2 >= 6)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 2 ", "Ganador",
              MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel6.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            button42.Enabled = !button42.Enabled;
            contadorBasicaJ2++;
            if (contadorBasicaJ2 >= 6)
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 2 ", "Ganador",
             MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel6.Visible = false;
                panel1.Visible = true;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            button41.Enabled = !button41.Enabled;
            contadorBasicaJ2++;
            if (contadorBasicaJ2 >=6 )
            {
                MessageBox.Show("Ganaste!!!! Felizidades jugador 2 ", "Ganador",
              MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                panel6.Visible = false;
                panel1.Visible = true;
            }
        }

        private void AbandonarBasica2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has perdido ", "Perdiste",
   MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            panel6.Visible = false;
            panel1.Visible = true;
        }

        private void AbandonarBasica1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has perdido ", "Perdiste",
   MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            panel6.Visible = false;
            panel1.Visible = true;
        }

        //finaliza panel de multijugador basica
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelPrincipal_Click(object sender, EventArgs e)
        {

        }
    }
}
