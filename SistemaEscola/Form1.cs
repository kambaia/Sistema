using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using DAL;
using Modelo;



namespace SistemaEscola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modelo_Aluno al = new modelo_Aluno();
            al.Nome = "Kambaia Albero";
            al.NumeroBI ="2001002LAAJJD";
            al.Nacionalidade = "Angolana";
            al.Foto = "O mais Bunito";
            al.Idade = 10;
            al.Sexo = "Masculino";
            al.Data_Nas = Convert.ToDateTime("10/04/1992");
            al.Classe_aluno = "12ª";
            al.Tipo = "Bolseiro";

            MessageBox.Show(al.Nome, " "+  al.Idade + " " + al.Sexo + " " + al.Tipo);
        }
    }
}
