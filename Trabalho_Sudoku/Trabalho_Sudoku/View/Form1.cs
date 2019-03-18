using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Trabalho_Sudoku
{
    public partial class FormPrincipal : Form
    {
        int Sorteio, R;
        int[,] Matriz = new int[9, 9];

        public FormPrincipal()
        {
            InitializeComponent();

            for(int d=0; d < 9; d++) //MontarGrid
            {
                dataGridViewJogo.Rows.Add();              
            }
            for (int y = 0; y < 9; y++)
            {
                for (int k = 0; k < 9; k++)
                {
                    //Linhas 0 , 1 e 2
                    if (y < 3 && k < 3) //colunas 0, 1 e 2
                    {
                        dataGridViewJogo.Rows[y].Cells[k].Style.BackColor = Color.Snow;
                    }
                    else
                    if (y < 3 && k > 2 && k < 6) //colunas 3, 4 e 5
                    {
                        dataGridViewJogo.Rows[y].Cells[k].Style.BackColor = Color.LightGray;
                    }
                    else
                    if (y < 3 && k > 5 && k < 9) //colunas 6, 7 e 8
                    {
                        dataGridViewJogo.Rows[y].Cells[k].Style.BackColor = Color.Snow;
                    }
                    //Linhas 3, 4 e 5
                    if (y > 2  && y < 6 && k < 3) //colunas 0, 1 e 2
                    {
                        dataGridViewJogo.Rows[y].Cells[k].Style.BackColor = Color.LightGray;
                    }
                    else
                    if (y > 2 && y < 6 && k < 6) //colunas 3, 4 e 5
                    {
                        dataGridViewJogo.Rows[y].Cells[k].Style.BackColor = Color.Snow;
                    }
                    else
                    if (y > 2 && y < 6 && k < 9) //colunas 6, 7 e 8
                    {
                        dataGridViewJogo.Rows[y].Cells[k].Style.BackColor = Color.LightGray;
                    }
                    //Linhas 6, 7 e 8
                    if (y > 5 && y < 9 && k < 3) //colunas 0, 1 e 2
                    {
                        dataGridViewJogo.Rows[y].Cells[k].Style.BackColor = Color.Snow;
                    }
                    else
                    if (y > 5 && y < 9 && k < 6) //colunas 3, 4 e 5
                    {
                        dataGridViewJogo.Rows[y].Cells[k].Style.BackColor = Color.LightGray;
                    }
                    else
                    if (y > 5 && y < 9 && k < 9) //colunas 6, 7 e 8
                    {
                        dataGridViewJogo.Rows[y].Cells[k].Style.BackColor = Color.Snow;
                    }

                }
            }
        }      
        
        private bool Validar(int linha, int coluna)
        {            
            for(int i = 0; i < 9; i++) //Para percorrer todas as linhas e colunas.
            {
                if(Matriz[linha,i] == Sorteio || Matriz[i,coluna] == Sorteio)
                {
                    return true; //Não pode inserir o número sorteado.
                }                    
            }

            linha = (linha / 3) * 3;
            coluna = (coluna / 3) *3;

            for(int t = linha; t < linha + 3; t++) //Confere se repete nas submatrizes 3x3.
            {
                for(int y = coluna; y < coluna + 3; y++)
                {                    
                    if(Matriz[t,y] == Sorteio)
                    {
                        return true;
                    }
                }
            }

            return false; //Pode inserir.
        }
                
        private void GerarNumeros(int linha, int coluna)
        {
            if (linha == 8 && coluna == 9) //Ponto de parada;
            {
                switch (comboBxNivel.SelectedIndex) //3 niveis no combobox
                {
                    case 0: //Modo iniciante
                        for (int i = 0; i < 9; i += 3)
                        {
                            for (int j = 0; j < 9; j += 3)
                            {
                                dataGridViewJogo.Rows[i].Cells[j].Value = "";
                            }
                        }
                        break;

                    case 1: //Modo regular
                        for (int i = 0; i < 9; i += 2)
                        {
                            for (int j = 0; j < 9; j += 3)
                            {
                                dataGridViewJogo.Rows[i].Cells[j].Value = "";
                            }
                        }
                        break;

                    case 2: //Modo avancado

                        dataGridViewJogo.Rows[0].Cells[1].Value = ""; dataGridViewJogo.Rows[0].Cells[2].Value = ""; dataGridViewJogo.Rows[0].Cells[3].Value = ""; dataGridViewJogo.Rows[0].Cells[8].Value = "";
                        dataGridViewJogo.Rows[1].Cells[1].Value = ""; dataGridViewJogo.Rows[1].Cells[4].Value = ""; dataGridViewJogo.Rows[1].Cells[5].Value = ""; dataGridViewJogo.Rows[1].Cells[7].Value = "";
                        dataGridViewJogo.Rows[2].Cells[0].Value = ""; dataGridViewJogo.Rows[2].Cells[2].Value = ""; dataGridViewJogo.Rows[2].Cells[4].Value = ""; dataGridViewJogo.Rows[2].Cells[6].Value = "";
                        dataGridViewJogo.Rows[2].Cells[8].Value = ""; dataGridViewJogo.Rows[3].Cells[2].Value = ""; dataGridViewJogo.Rows[3].Cells[3].Value = ""; dataGridViewJogo.Rows[3].Cells[5].Value = "";
                        dataGridViewJogo.Rows[3].Cells[7].Value = ""; dataGridViewJogo.Rows[4].Cells[0].Value = ""; dataGridViewJogo.Rows[4].Cells[2].Value = ""; dataGridViewJogo.Rows[4].Cells[4].Value = "";
                        dataGridViewJogo.Rows[4].Cells[6].Value = ""; dataGridViewJogo.Rows[4].Cells[8].Value = ""; dataGridViewJogo.Rows[5].Cells[0].Value = ""; dataGridViewJogo.Rows[5].Cells[1].Value = "";
                        dataGridViewJogo.Rows[5].Cells[3].Value = ""; dataGridViewJogo.Rows[5].Cells[4].Value = ""; dataGridViewJogo.Rows[5].Cells[7].Value = ""; dataGridViewJogo.Rows[6].Cells[0].Value = "";
                        dataGridViewJogo.Rows[6].Cells[1].Value = ""; dataGridViewJogo.Rows[6].Cells[2].Value = ""; dataGridViewJogo.Rows[6].Cells[6].Value = ""; dataGridViewJogo.Rows[6].Cells[8].Value = "";
                        dataGridViewJogo.Rows[7].Cells[3].Value = ""; dataGridViewJogo.Rows[7].Cells[4].Value = ""; dataGridViewJogo.Rows[7].Cells[5].Value = ""; dataGridViewJogo.Rows[7].Cells[6].Value = "";
                        dataGridViewJogo.Rows[7].Cells[8].Value = ""; dataGridViewJogo.Rows[8].Cells[0].Value = ""; dataGridViewJogo.Rows[8].Cells[2].Value = ""; dataGridViewJogo.Rows[8].Cells[4].Value = "";
                        dataGridViewJogo.Rows[8].Cells[6].Value = ""; dataGridViewJogo.Rows[8].Cells[7].Value = "";
                        break;
                }
                return;
            }
            else
            {                
                if (coluna == 9) //Vai para proxima linha e zera a coluna;
                {
                    linha++;
                    coluna = 0;
                }
                else
                {  
                    Random nb = new Random();
                    Sorteio = nb.Next(1, 10); //Sorteio de 1 a 9.
                    while(Validar(linha,coluna) == true)
                    {
                        R++;
                        Sorteio = nb.Next(1, 10);
                        if(R > 42) //Caso ele tenta muitas vezes e não tenha sucesso.
                        {
                            for (int y = 0; y < 9; y++) //Ele irá limpar os valores na linha em questão.
                            {
                                Matriz[linha, y] = 0;
                                dataGridViewJogo.Rows[linha].Cells[y].Value = ""; //Apresenta no grid.
                                coluna = 0;
                            }
                            R = 0;                            
                        }
                    }
                    Thread.Sleep(1);
                    Matriz[linha, coluna] = Sorteio; //Insere o valor no sudoku.
                    dataGridViewJogo.Rows[linha].Cells[coluna].Value = (Sorteio); //Apresenta no grid.                        
                    coluna++;
                    Refresh();
                }
                GerarNumeros(linha, coluna); //Chama a função novamente.
            }
        }       

        private void bttnGerar_Click(object sender, EventArgs e)
        {
            if(comboBxNivel.Text == "Escolha um nível")
            {
                MessageBox.Show("Por gentileza, escolha um nível antes de dar início.", "Ops",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridViewJogo.Visible = true;                                
                bttnGerar.Visible = false;
                comboBxNivel.Visible = false;
                int linha = 0, coluna = 0;
                GerarNumeros(linha, coluna);
            }
            
        }
    }
}
