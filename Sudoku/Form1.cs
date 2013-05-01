﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = 9;
            dataGridView1.GetRowDisplayRectangle(3, false);
            dataGridView1.Rows.GetNextRow(2, DataGridViewElementStates.None);
            //var cell = dataGridView1.Rows[0].Cells[0];
            dataGridView1.Rows[2].DividerHeight = 3;
            dataGridView1.Rows[5].DividerHeight = 3;

            dataGridView1.Rows[0].Cells[0].Style.BackColor = ColorTranslator.FromHtml("#C00");
            for (int i = 0; i < 9; i++)
            {
                //dataGridView1.Rows[i].Resizable;
                for (int j = 0; j < 9; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.SelectionBackColor = Color.Pink;
                }
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1)
            {
                
                

            }
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectedCells[0].Style.BackColor = Color.White;
        }

    }
}
