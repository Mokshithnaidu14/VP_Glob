using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Car_Racing_Game_MOO_ICT
{
    public partial class Form2 : Form
    {
        public Form2(List<(int score, string name)> scores)
        {
            InitializeComponent();
            LoadLeaderboard(scores);
            CustomizeDataGridView();
        }

        private void LoadLeaderboard(List<(int score, string name)> scores)
        {
            scores.Sort((a, b) => b.score.CompareTo(a.score)); // Sort scores in descending order
            DataTable dt = new DataTable();
            dt.Columns.Add("Rank");
            dt.Columns.Add("Name");
            dt.Columns.Add("Score");

            for (int i = 0; i < scores.Count; i++)
            {
                dt.Rows.Add(i + 1, scores[i].name, scores[i].score);
            }

            dataGridView1.DataSource = dt;
        }

        private void CustomizeDataGridView()
        {
            dataGridView1.EnableHeadersVisualStyles = false;

            // Column headers style
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            // Alternating row style
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Cell styles
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            // Row headers style
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Do nothing.
        }
    }
}
