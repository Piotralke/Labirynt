using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabiryntFrontend
{
    public partial class GbMaze : Form
    {

        private const int cellSize = 10; // rozmiar pojedynczej komórki
        private const int rows = 55; // ilość wierszy
        private const int cols = 100; // ilość kolumn

        private int[,] grid = new int[rows, cols]; // tablica dwuwymiarowa przechowująca wartości komórek

        private bool isDrawing = false; // zmienna logiczna określająca, czy użytkownik aktualnie rysuje
        private int currentRow = -1; // numer wiersza aktualnie rysowanej komórki
        private int currentCol = -1; // numer kolumny aktualnie rysowanej komórki

        public GbMaze()
        {
            InitializeComponent();

            pictureBox1.Height = rows * cellSize;
            pictureBox1.Width = cols * cellSize;
        }
        private void buttonEditor_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Rysowanie siatki
            Pen pen = new Pen(Color.Black, 1);
            for (int i = 0; i <= rows; i++)
            {
                g.DrawLine(pen, 0, i * cellSize, cols * cellSize, i * cellSize);
            }
            for (int j = 0; j <= cols; j++)
            {
                g.DrawLine(pen, j * cellSize, 0, j * cellSize, rows * cellSize);
            }

            // Rysowanie komórek
            Brush brush = new SolidBrush(Color.White);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        brush = new SolidBrush(Color.Black);
                    }
                    else
                    {
                        brush = new SolidBrush(Color.White);
                    }
                    g.FillRectangle(brush, j * cellSize, i * cellSize, cellSize, cellSize);
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int row = e.Y / cellSize;
            int col = e.X / cellSize;
            if (row < rows && col < cols)
            {
                isDrawing = true;
                currentRow = row;
                currentCol = col;
                grid[row, col] = 1 - grid[row, col]; // zamiana wartości między 0 i 1
                pictureBox1.Invalidate(); // odświeżenie kontrolki
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            currentRow = -1;
            currentCol = -1;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                int row = e.Y / cellSize;
                int col = e.X / cellSize;
                if (row < rows && col < cols && (row != currentRow || col != currentCol))
                {
                    currentRow = row;
                    currentCol = col;
                    if (row >= 0 && row < rows && col >= 0 && col < cols)
                    {
                        grid[row, col] = 1 - grid[row, col];
                    }
                    pictureBox1.Invalidate(); // odświeżenie kontrolki
                }
            }
        }
    }
}
