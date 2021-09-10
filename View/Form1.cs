using Matteo_Clara_RafaelGuilherme.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matteo_Clara_RafaelGuilherme
{
    public partial class Form1 : Form
    {
        private string[][] matriz;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //quando o form carrega, os comandos aparecem no exato momento
        {
            CriaMatriz();
            MostraMatriz();
        }

        private void btnExecutar_Click(object sender, EventArgs e) //faz todos os comandos assim que o usuario apertar o botão de Executar
        {
            string letras = txtLetras.Text.ToUpper();
            List<string> words = new List<string>();
            if (string.IsNullOrEmpty(letras))
            {
                MessageBox.Show("Por favor, insira uma palavra");
            }
            else
            {
                bool find_duplicate_letter = Controller.Confere(letras);

                if (find_duplicate_letter)
                {
                    MessageBox.Show("Letras repetidas");
                }
                else
                {

                    listaPalavras.Items.Add(letras);

                }
            }

            txtLetras.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e) //reinicia o jogo, para que o jogador se divirta ainda mais
        {
            Application.Restart();
        }

        private void CriaMatriz() //cria a matriz, qual nos ajudou a organizar o jogo, que será mostrada na view
        {
            matriz = new string[3][];
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new string[3];
            }

            matriz[0][0] = Controller.Preenche("A", "D");
            matriz[0][1] = Controller.Preenche("E", "F");
            matriz[0][2] = Controller.Preenche("B", "C");
            matriz[1][0] = Controller.Preenche2("G", "I", "U");
            matriz[1][1] = Controller.Preenche2("H", "J", "V");
            matriz[1][2] = Controller.Preenche("K", "L");
            matriz[2][0] = Controller.Preenche2("M", "O", "Q");
            matriz[2][1] = Controller.Preenche2("N", "T", "P");
            matriz[2][2] = Controller.Preenche2("R", "S", "Z");
        }

        private void MostraMatriz() //adiciona a matriz nos quadrados do jogo.
        {
            btn1.Text = matriz[0][0];
            btn2.Text = matriz[0][1];
            btn3.Text = matriz[0][2];
            btn4.Text = matriz[1][0];
            btn5.Text = matriz[1][1];
            btn6.Text = matriz[1][2];
            btn7.Text = matriz[2][0];
            btn8.Text = matriz[2][1];
            btn9.Text = matriz[2][2];
        }

        private void btnSair_Click(object sender, EventArgs e) //fecha o aplicativo.
        {
            MessageBox.Show("Obrigado por jogar, espero te ver novamente! \n\n Aplicativo criado por: \n\n Maria Clara, Matteo e Rafael Guilherme");
            Application.Exit();
        }
    }
}
