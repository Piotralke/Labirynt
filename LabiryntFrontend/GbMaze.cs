using LabiryntBackend.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            pictureBox1.Height = rows * cellSize;
            pictureBox1.Width = cols * cellSize;
        }
        private void buttonEditor_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            visited = new bool[rows, cols]; // inicjujemy tablicę visited
         //   DFS(0, 0); // wywołujemy algorytm DFS od komórki (0, 0)
            pictureBox1.Invalidate(); // odświeżenie kontrolki
        }

        //private void DFS(int row, int col)
        //{
        //    visited[row, col] = true; // oznaczamy bieżącą komórkę jako odwiedzoną
        //    pictureBox1.Invalidate(); // odświeżenie kontrolki

        //    // sprawdzamy sąsiadów bieżącej komórki
        //    if (row > 0 && !visited[row - 1, col] && !grid[row, col] && !grid[row - 1, col]) // górna komórka
        //    {
        //        DFS(row - 1, col);
        //    }
        //    if (col < cols - 1 && !visited[row, col + 1] && !grid[row, col] && !grid[row, col + 1]) // prawa komórka
        //    {
        //        DFS(row, col + 1);
        //    }
        //    if (row < rows - 1 && !visited[row + 1, col] && !grid[row, col] && !grid[row + 1, col]) // dolna komórka
        //    {
        //        DFS(row + 1, col);
        //    }
        //    if (col > 0 && !visited[row, col - 1] && !grid[row, col] && !grid[row, col - 1]) // lewa komórka
        //    {
        //        DFS(row, col - 1);
        //    }
        //}

        


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
                    visited[i, j] = false;
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
                    visited[i, j] = false;
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

        }
        public enum Direction
        {
            N = 1,
            W = 2
        }

        Stack s_stack;
        Random r;

        public int MSIZEX;
        public int MSIZEY;
        public int[] maze_base;
        public byte[,] maze_data;

        public void GenerateMaze(int sizeX, int sizeY, int seed)
        {
            MSIZEX = sizeX;
            MSIZEY = sizeY;
            maze_base = new int[MSIZEX * MSIZEY];
            maze_data = new Byte[MSIZEX, MSIZEY];

            s_stack = new Stack();
            r = new Random(seed);

            MazeInit(r);

            cMazeState s = new cMazeState(r.Next() % MSIZEX, r.Next() % MSIZEY, 0);
            analyze_cell(s, r);
        }
        void analyze_cell(cMazeState s, Random r)
        {
            bool bEnd = false, found;
            int indexSrc, indexDest, tDir = 0, prevDir = 0;

            while (true)
            {
                if (s.dir == 15)
                {
                    while (s.dir == 15)
                    {
                        s = (cMazeState)s_stack.pop();
                        if (s == null)
                        {
                            bEnd = true;
                            break;
                        }
                    }
                    if (bEnd == true) break;
                }
                else
                {
                    do
                    {
                        prevDir = tDir;
                        tDir = (int)Math.Pow(2, r.Next() % 4);

                        // if ( (r.Next()%32) < iSmooth )		SMOOTH DO WYJEBANIA
                        // 	if ( (s.dir & prevDir) == 0 )
                        // 		tDir = prevDir;

                        if ((s.dir & tDir) != 0)
                            found = true;
                        else
                            found = false;
                    } while (found == true && s.dir != 15);

                    s.dir |= tDir;

                    indexSrc = cell_index(s.x, s.y);

                    // direction W
                    if (tDir == 1 && s.x > 0)
                    {
                        indexDest = cell_index(s.x - 1, s.y);
                        if (base_cell(indexSrc) != base_cell(indexDest))
                        {
                            merge(indexSrc, indexDest);
                            maze_data[s.x, s.y] |= (byte)Direction.W;

                            s_stack.push(new cMazeState(s));
                            s.x -= 1; s.dir = 0;
                        }
                    }

                    // direction E
                    if (tDir == 2 && s.x < MSIZEX - 1)
                    {
                        indexDest = cell_index(s.x + 1, s.y);
                        if (base_cell(indexSrc) != base_cell(indexDest))
                        {
                            merge(indexSrc, indexDest);
                            maze_data[s.x + 1, s.y] |= (byte)Direction.W;

                            s_stack.push(new cMazeState(s));
                            s.x += 1; s.dir = 0;
                        }
                    }

                    // direction N
                    if (tDir == 4 && s.y > 0)
                    {
                        indexDest = cell_index(s.x, s.y - 1);
                        if (base_cell(indexSrc) != base_cell(indexDest))
                        {
                            merge(indexSrc, indexDest);
                            maze_data[s.x, s.y] |= (byte)Direction.N;

                            s_stack.push(new cMazeState(s));
                            s.y -= 1; s.dir = 0;
                        }
                    }

                    // direction S
                    if (tDir == 8 && s.y < MSIZEY - 1)
                    {
                        indexDest = cell_index(s.x, s.y + 1);
                        if (base_cell(indexSrc) != base_cell(indexDest))
                        {
                            merge(indexSrc, indexDest);
                            maze_data[s.x, s.y + 1] |= (byte)Direction.N;

                            s_stack.push(new cMazeState(s));
                            s.y += 1; s.dir = 0;
                        }
                    }
                } // else
            } // while 
        } // function
        int cell_index(int x, int y)
        {
            return MSIZEX * y + x;
        }
        int base_cell(int tIndex)
        {
            int index = tIndex;
            while (maze_base[index] >= 0)
            {
                index = maze_base[index];
            }
            return index;
        }
        void merge(int index1, int index2)
        {
            // merge both lists
            int base1 = base_cell(index1);
            int base2 = base_cell(index2);
            maze_base[base2] = base1;
        }
        void MazeInit(Random r)
        {
            int i, j;

            // maze data
            for (i = 0; i < MSIZEX; i++)
                for (j = 0; j < MSIZEY; j++)
                {
                    maze_base[cell_index(i, j)] = -1;
                    maze_data[i, j] = 0;
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GenerateMaze(cols,rows,0);
            pictureBox1.Image = GetBitmap(cols * 20, rows * 20);
            //pictureBox1.Invalidate();
        }

        private void GbMaze_Load(object sender, EventArgs e)
        {

        }
        public Bitmap GetBitmap(int xS, int yS)
        {
            int i, j;

            Bitmap tB = new Bitmap(xS + 1, yS + 1);
            Graphics g = Graphics.FromImage((Image)tB);

            Brush w = Brushes.White;
            Brush r = Brushes.Red;
            Brush b = Brushes.Blue;

            Pen bp = new Pen(b, 1);
            Pen rp = new Pen(r, 1);

            // background
            g.FillRectangle(w, 0, 0, tB.Width - 1, tB.Height - 1);
            g.DrawRectangle(bp, 0, 0, tB.Width - 1, tB.Height - 1);

            int xSize = xS / MSIZEX;
            int ySize = yS / MSIZEY;
            for (i = 0; i < MSIZEX; i++)
                for (j = 0; j < MSIZEY; j++)
                {
                    Debug.WriteLine("Maze data i: "+i +" j: "+j +" maze_data[i,j] = " + maze_data[i, j]);
                    // inspect the maze
                    if ((maze_data[i, j] & (byte)Direction.N) == 0)
                        g.DrawLine(bp,
                            new Point(xSize * i, ySize * j),
                            new Point(xSize * (i + 1), ySize * j));

                    if ((maze_data[i, j] & (byte)Direction.W) == 0)
                        g.DrawLine(bp,
                            new Point(xSize * i, ySize * j),
                            new Point(xSize * i, ySize * (j + 1)));

                }

            // start & end
            g.DrawLine(rp, 0, 0, xSize, 0);
            g.DrawLine(rp, 0, 0, 0, xSize);
            g.DrawLine(rp, xS, yS, xS - xSize, yS);
            g.DrawLine(rp, xS, yS, xS, yS - ySize);

            g.Dispose();

            return tB;
        }

    }
    public class cMazeState
    {
        public int x, y, dir;
        public cMazeState(int tx, int ty, int td) { x = tx; y = ty; dir = td; }
        public cMazeState(cMazeState s) { x = s.x; y = s.y; dir = s.dir; }
    }

    public class cCellPosition
    {
        public int x, y;
        public cCellPosition() { }
        public cCellPosition(int xp, int yp) { x = xp; y = yp; }
    }
}
