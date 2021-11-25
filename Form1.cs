using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace txtparabox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //criação de variaveis para leitura de arqivos
            var txtlinhas = File.ReadAllLines("D:\\dados\\arquivo.txt");
            //verificação do arquivo
            if (txtlinhas != null && txtlinhas.Count() >1)
            {
                //Cria lista do texto do arquivo
                var segundaLinha = txtlinhas.ToList().Skip(1).First();
                var terceiraLinha = txtlinhas.ToList().Skip(2).First();
                //dividir em colunas
                var divisaoTexto = segundaLinha.Split(':');
                if (divisaoTexto.Count() > 1)
                {
                    textBox1.Text = divisaoTexto[0];
                    textBox2.Text = divisaoTexto[1];
                     
                }
                var divisaoTexto2 = terceiraLinha.Split(':'); 
                if (true)
                {
                    textBox3.Text = divisaoTexto2[0];
                    textBox4.Text = divisaoTexto2[1];
                }

            }
        }
    }
}
