using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Win_Banco01
{
    public partial class FrmBanco1 : Form
    {
        ClassBD bd = new ClassBD();
        MySqlDataReader objDados;
        StringBuilder strQuery = new StringBuilder();
        public FrmBanco1()
        {
            InitializeComponent();
        }

        private void FrmBanco1_Load(object sender, EventArgs e)
        {

            btnCancelar_Click_1(sender, e);
            strQuery.Append("Select * from cadfun");
            objDados = bd.RetornaDataSet(strQuery.ToString());
            while (objDados.Read())
            {
                dgvDados.Rows.Add(objDados["CODFUN"].ToString(),
                                  objDados["NOME"].ToString(),
                                  objDados["DEPTO"].ToString(),
                                  objDados["FUNCAO"].ToString(),
                                  objDados["SALARIO"].ToString());
            }
            if (!objDados.IsClosed)
            {
                objDados.Close();
                strQuery.Remove(0, strQuery.Length);
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            FrmBanco1_Load(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja sair da aplicação?",
                             "<<<< FINALIZANDO >>>>",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            dgvDados.Rows.Clear();
        }
    }
}
