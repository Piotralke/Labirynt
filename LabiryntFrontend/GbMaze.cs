using LabiryntBackend.Models;
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
        private int rows = 10; // ilość wierszy
        private int cols = 10; // ilość kolumn

        private bool[,] grid = new bool[10, 10]; // tablica dwuwymiarowa przechowująca wartości komórek

        private bool isDrawing = false; // zmienna logiczna określająca, czy użytkownik aktualnie rysuje
        private int currentRow = -1; // numer wiersza aktualnie rysowanej komórki
        private int currentCol = -1; // numer kolumny aktualnie rysowanej komórki
        private bool isWall = true;

        private bool[,] visited = new bool[10, 10];

        public GbMaze()
        {
            InitializeComponent();
            button3.Enabled = false;
            pictureBox1.Height = rows * cellSize;
            pictureBox1.Width = cols * cellSize;
        }
        private void buttonEditor_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            visited = new bool[rows, cols]; // inicjujemy tablicę visited
            DFS(0, 0); // wywołujemy algorytm DFS od komórki (0, 0)
            pictureBox1.Invalidate(); // odświeżenie kontrolki
        }

        private void DFS(int row, int col)
        {
            visited[row, col] = true; // oznaczamy bieżącą komórkę jako odwiedzoną
            pictureBox1.Invalidate(); // odświeżenie kontrolki
            
            // sprawdzamy sąsiadów bieżącej komórki
            if (row > 0 && !visited[row - 1, col] && !grid[row, col] && !grid[row - 1, col]) // górna komórka
            {
                DFS(row - 1, col);
            }
            if (col < cols - 1 && !visited[row, col + 1] && !grid[row, col] && !grid[row, col + 1]) // prawa komórka
            {
                DFS(row, col + 1);
            }
            if (row < rows - 1 && !visited[row + 1, col] && !grid[row, col] && !grid[row + 1, col]) // dolna komórka
            {
                DFS(row + 1, col);
            }
            if (col > 0 && !visited[row, col - 1] && !grid[row, col] && !grid[row, col - 1]) // lewa komórka
            {
                DFS(row, col - 1);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Rysowanie siatki
            Pen pen = new Pen(Color.Black, 1);
            for (int i = 0; i <= rows; i++)
            {
                g.DrawLine(pen, 0, i * cellSize, rows * cellSize, i * cellSize);
            }
            for (int j = 0; j <= cols; j++)
            {
                g.DrawLine(pen, j * cellSize, 0, j * cellSize, cols * cellSize);
            }

            // Rysowanie komórek
            Brush brush = new SolidBrush(Color.White);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (visited[i, j])
                    {
                        brush = new SolidBrush(Color.Yellow); // oznaczamy odwiedzone komórki na żółto
                    }
                    else if (grid[i, j])
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
                if (row >= 0 && row < rows && col >= 0 && col < cols)
                {
                    grid[row, col] = isWall;
                }
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
                        grid[row, col] = isWall;
                    }
                    pictureBox1.Invalidate(); // odświeżenie kontrolki
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isWall = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isWall = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    grid[i, j] = true;
                }
            }
            pictureBox1.Invalidate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    grid[i, j] = false;
                }
            }
            pictureBox1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Warning! Changing the maze size will result in removing all walls. Are you sure you want to change the size?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                rows = int.Parse(rowsInput.Text);
                cols = int.Parse(colsInput.Text);

                // Resetowanie tablicy grid do nowych wymiarów
                bool[,] newGrid = new bool[cols, rows];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        newGrid[i, j] = false;
                    }
                }
                grid = newGrid;
                visited = newGrid;
                // Przerysowanie kontrolki pictureBox1 z nowymi wymiarami
                pictureBox1.Height = rows * cellSize;
                pictureBox1.Width = cols * cellSize;
                pictureBox1.Invalidate();
            }
        }

        private void colsInput_TextChanged(object sender, EventArgs e)
        {
            int colsValue, rowsValue;

            if (int.TryParse(colsInput.Text, out colsValue) && colsValue <= 100 && colsValue > 0)
            {
                // Sprawdź, czy wartość w "rowsInput" jest liczbą i czy nie przekracza 55
                if (int.TryParse(rowsInput.Text, out rowsValue) && rowsValue <= 55 && rowsValue > 0)
                {
                    button3.Enabled = true;
                }
                else
                {
                    button3.Enabled = false;
                }
            }
            else
            {
                button3.Enabled = false;
            }
        }
        public bool[,] GenerateMaze()
        {
            // Initialize the maze with all walls
            bool[,] maze = new bool[cols, rows];
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    maze[x, y] = true;
                }
            }

            // Randomly remove walls to create the maze
            Random random = new Random();
            int startX = random.Next(cols);
            int startY = random.Next(rows);
            maze[startX, startY] = false;
            GenerateMazeRecursive(maze, startX, startY, random);

            return maze;
        }

        private void GenerateMazeRecursive(bool[,] maze, int x, int y, Random random)
        {
            int[] directions = new int[] { 0, 1, 2, 3 };
            Shuffle(directions, random);

            foreach (int direction in directions)
            {
                int newX = x;
                int newY = y;

                switch (direction)
                {
                    // North
                    case 0:
                        newY--;
                        break;

                    // East
                    case 1:
                        newX++;
                        break;

                    // South
                    case 2:
                        newY++;
                        break;

                    // West
                    case 3:
                        newX--;
                        break;
                }

                if (newX >= 0 && newX < maze.GetLength(0) && newY >= 0 && newY < maze.GetLength(1) && maze[newX, newY])
                {
                    int count = 0;
                    if (newX > 0 && !maze[newX - 1, newY]) count++;
                    if (newX < maze.GetLength(0) - 1 && !maze[newX + 1, newY]) count++;
                    if (newY > 0 && !maze[newX, newY - 1]) count++;
                    if (newY < maze.GetLength(1) - 1 && !maze[newX, newY + 1]) count++;

                    if (count == 1)
                    {
                        maze[newX, newY] = false;
                        GenerateMazeRecursive(maze, newX, newY, random);
                    }
                }
            }
        }

        private static void Shuffle(int[] array, Random random)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int j = random.Next(i, array.Length);
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            grid = GenerateMaze();
            pictureBox1.Invalidate();
            Console.WriteLine("JUHU");
        }

    }
}
