using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wfTabuada
{
    public partial class Tabuada : System.Web.UI.Page
    {
        protected void btnExibir_Click(object sender, EventArgs e)
        {
            Table tabela = new Table();
            int n=ddlMultiplicador.SelectedIndex;
            int t;
            for (int i = 0; i <= 10; i++) 
            { 
                TableRow linha = new TableRow();
                TableCell coluna = new TableCell();
                coluna.Text = n.ToString() + " x " + i.ToString() + " = ";
                linha.Cells.Add(coluna);
                coluna = new TableCell();
                t = i * n;
                coluna.Text = t.ToString();
                linha.Cells.Add(coluna);
                tabela.Rows.Add(linha);
            }
            PlaceHolder1.Controls.Add(tabela);
        }
    }
}