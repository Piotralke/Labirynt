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
        public enum Direction
        {
            N = 1,
            W = 2
        }

        private const int cellSize = 20; // rozmiar pojedynczej komórki
        private int rows = 10; // ilość wierszy
        private int cols = 10; // ilość kolumn

        int seedValue = 0;

        Stack s_stack;
        Random r;


        public int[] maze_base;
        public byte[,] maze_data = new byte[10, 10];

        public GbMaze()
        {
            InitializeComponent();
            button3.Enabled = false;
            button6.Enabled = false;
            isRandom.Checked = false;
           
            Bitmap tB = new Bitmap(cols * cellSize + 1, rows * cellSize + 1);
            Graphics g = Graphics.FromImage((Image)tB);

            Brush w = Brushes.LightGray;
            g.FillRectangle(w, 0, 0, tB.Width - 1, tB.Height - 1);
            pictureBox1.Image = tB;
        }
        private void buttonEditor_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ArrayList solvePath = Solve(0, 0, cols - 1, rows - 1);

            int xSize = pictureBox1.Image.Width / cols;
            int ySize = pictureBox1.Image.Height / rows;

            int penSize = 5;

            Bitmap tB = new Bitmap(pictureBox1.Image);
            Pen p = new Pen(Color.Black, penSize);
            Graphics g = Graphics.FromImage((Image)tB);

            // not time-cosuming, so don't bother to optimize
            if (solvePath != null)
                for (int i = 1; i < solvePath.Count; i++)
                {
                    cCellPosition u = (cCellPosition)solvePath[i - 1];
                    cCellPosition t = (cCellPosition)solvePath[i];
                    g.DrawLine(p,
                               xSize * u.x + xSize / 2,
                               ySize * u.y + ySize / 2,
                               xSize * t.x + xSize / 2,
                               ySize * t.y + ySize / 2);
                    pictureBox1.Image = tB;
                }
            p.Dispose();
            g.Dispose();



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
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    maze_data[i, j] = 0;
                }
            }
            pictureBox1.Image = GetBitmap(cols * cellSize, rows * cellSize);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    maze_data[i, j] = 3;
                }
            }
            pictureBox1.Image = GetBitmap(cols * cellSize, rows * cellSize);
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
                byte[,] newGrid = new byte[cols, rows];
                for (int i = 0; i < cols; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        newGrid[i, j] = 3;
                    }
                }
                maze_data = newGrid;
                // Przerysowanie kontrolki pictureBox1 z nowymi wymiarami
                Bitmap tB = new Bitmap(cols * cellSize + 1, rows * cellSize + 1);
                Graphics g = Graphics.FromImage((Image)tB);

                Brush w = Brushes.LightGray;
                g.FillRectangle(w, 0, 0, tB.Width - 1, tB.Height - 1);
                pictureBox1.Image = tB;
            }
        }

        private void colsInput_TextChanged(object sender, EventArgs e)
        {
            int colsValue, rowsValue;

            if (int.TryParse(colsInput.Text, out colsValue) && colsValue <= 500 && colsValue > 0)
            {
                // Sprawdź, czy wartość w "rowsInput" jest liczbą i czy nie przekracza 55
                if (int.TryParse(rowsInput.Text, out rowsValue) && rowsValue <= 500 && rowsValue > 0)
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


        public void GenerateMaze(int sizeX, int sizeY, int seed)
        {
            cols = sizeX;
            rows = sizeY;
            maze_base = new int[cols * rows];
            maze_data = new Byte[cols, rows];

            s_stack = new Stack();
            r = new Random(seed);

            MazeInit(r);

            cMazeState s = new cMazeState(r.Next() % cols, r.Next() % rows, 0);
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
                    if (tDir == 2 && s.x < cols - 1)
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
                    if (tDir == 8 && s.y < rows - 1)
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
            return cols * y + x;
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
            for (i = 0; i < cols; i++)
                for (j = 0; j < rows; j++)
                {
                    maze_base[cell_index(i, j)] = -1;
                    maze_data[i, j] = 0;
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(isRandom.Checked == true)
            {
                Random r = new Random();
                int randomSeed = r.Next(0, 2147483646);
                GenerateMaze(cols, rows, randomSeed);
                pictureBox1.Image = GetBitmap(cols * cellSize, rows * cellSize);
            }
            else
            {
                GenerateMaze(cols, rows, seedValue);
                pictureBox1.Image = GetBitmap(cols * cellSize, rows * cellSize);
            }
            
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

            Brush w = Brushes.LightGray;
            Brush r = Brushes.Black;
            Brush b = Brushes.Green;

            Pen bp = new Pen(b, 2);
            Pen rp = new Pen(r, 2);

            // background
            g.FillRectangle(w, 0, 0, tB.Width - 1, tB.Height - 1);
            g.DrawRectangle(bp, 0, 0, tB.Width - 1, tB.Height - 1);

            int xSize = xS / cols;
            int ySize = yS / rows;
            for (i = 0; i < cols; i++)
                for (j = 0; j < rows; j++)
                {
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
        public ArrayList Solve(int xSource, int ySource, int xDest, int yDest)
        {
            int[,] tMazePath = new int[cols, rows];
            bool destReached = false;

            cCellPosition cellPos = new cCellPosition(xSource, ySource);
            ArrayList calcState = new ArrayList();

            // przygotowanie do rozpoczcia
            calcState.Add(cellPos);

            int step = 0;
            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    tMazePath[i, j] = -1;
            tMazePath[xSource, ySource] = step;

            // zabezpieczenia
            if (maze_data == null) return null;
            if (xSource == xDest && ySource == yDest) return calcState;

            while (destReached == false && calcState.Count > 0)
            {
                step++;
                ArrayList calcNextState = new ArrayList();

                for (int i = 0; i < calcState.Count; i++)
                {
                    cCellPosition calcCPos = (cCellPosition)calcState[i];
                    // sprawd cztery ssiadujce kierunki
                    // N
                    if (calcCPos.y > 0) // tylko jesli w zakresie
                        if (tMazePath[calcCPos.x, calcCPos.y - 1] == -1) // i jeszcze tam nie bylismy
                            if ((maze_data[calcCPos.x, calcCPos.y] & (byte)Direction.N) != 0) // a mozna tam isc
                            {
                                tMazePath[calcCPos.x, calcCPos.y - 1] = step;
                                cCellPosition calcNextCPos = new cCellPosition(calcCPos.x, calcCPos.y - 1);
                                calcNextState.Add(calcNextCPos);

                                if (calcNextCPos.x == xDest && calcNextCPos.y == yDest) destReached = true;
                            }
                    // W
                    if (calcCPos.x > 0) // tylko jesli w zakresie
                        if (tMazePath[calcCPos.x - 1, calcCPos.y] == -1) // i jeszcze tam nie bylismy
                            if ((maze_data[calcCPos.x, calcCPos.y] & (byte)Direction.W) != 0) // a mozna tam isc
                            {
                                tMazePath[calcCPos.x - 1, calcCPos.y] = step;
                                cCellPosition calcNextCPos = new cCellPosition(calcCPos.x - 1, calcCPos.y);
                                calcNextState.Add(calcNextCPos);

                                if (calcNextCPos.x == xDest && calcNextCPos.y == yDest) destReached = true;
                            }
                    // S
                    if (calcCPos.y < rows - 1) // tylko jesli w zakresie
                        if (tMazePath[calcCPos.x, calcCPos.y + 1] == -1) // i jeszcze tam nie bylismy
                            if ((maze_data[calcCPos.x, calcCPos.y + 1] & (byte)Direction.N) != 0) // a mozna tam isc
                            {
                                tMazePath[calcCPos.x, calcCPos.y + 1] = step;
                                cCellPosition calcNextCPos = new cCellPosition(calcCPos.x, calcCPos.y + 1);
                                calcNextState.Add(calcNextCPos);

                                if (calcNextCPos.x == xDest && calcNextCPos.y == yDest) destReached = true;
                            }
                    // E
                    if (calcCPos.x < cols - 1) // tylko jesli w zakresie
                        if (tMazePath[calcCPos.x + 1, calcCPos.y] == -1) // i jeszcze tam nie bylismy
                            if ((maze_data[calcCPos.x + 1, calcCPos.y] & (byte)Direction.W) != 0) // a mozna tam isc
                            {
                                tMazePath[calcCPos.x + 1, calcCPos.y] = step;
                                cCellPosition calcNextCPos = new cCellPosition(calcCPos.x + 1, calcCPos.y);
                                calcNextState.Add(calcNextCPos);

                                if (calcNextCPos.x == xDest && calcNextCPos.y == yDest) destReached = true;
                            }
                }
                calcState = calcNextState;
            }
            // moliwe s dwa warianty:
            if (destReached == false)
                return null;
            else
            {
                tMazePath[xDest, yDest] = step;
                // buduj drog przez tMazePath
                ArrayList pPath = new ArrayList();

                int tx = xDest;
                int ty = yDest;

                pPath.Add(new cCellPosition(tx, ty));

                bool stepExists;

                while (tx != xSource || ty != ySource)
                {
                    step = tMazePath[tx, ty];
                    stepExists = false;

                    // szukaj kroku 
                    // N
                    if (ty > 0 && stepExists == false)
                        if (tMazePath[tx, ty - 1] == step - 1 &&
                             (maze_data[tx, ty] & (byte)Direction.N) != 0
                           )
                        {
                            ty -= 1; stepExists = true;
                            pPath.Add(new cCellPosition(tx, ty));
                        }
                    // W	
                    if (tx > 0 && stepExists == false)
                        if (tMazePath[tx - 1, ty] == step - 1 &&
                             (maze_data[tx, ty] & (byte)Direction.W) != 0
                           )
                        {
                            tx -= 1; stepExists = true;
                            pPath.Add(new cCellPosition(tx, ty));
                        }
                    // S	
                    if (ty < rows - 1 && stepExists == false)
                        if (tMazePath[tx, ty + 1] == step - 1 &&
                             (maze_data[tx, ty + 1] & (byte)Direction.N) != 0
                           )
                        {
                            ty += 1; stepExists = true;
                            pPath.Add(new cCellPosition(tx, ty));
                        }
                    // E	
                    if (tx < cols - 1 && stepExists == false)
                        if (tMazePath[tx + 1, ty] == step - 1 &&
                             (maze_data[tx + 1, ty] & (byte)Direction.W) != 0
                           )
                        {
                            tx += 1; stepExists = true;
                            pPath.Add(new cCellPosition(tx, ty));
                        }

                    if (stepExists == false) return null;
                }

                return pPath;

            }
        }

        private void seedInput_TextChanged(object sender, EventArgs e)
        {
            
            if (int.TryParse(seedInput.Text, out seedValue) && seedValue <= 2147483646 )
            {
                button6.Enabled = true;
            }
            else
            {
                button6.Enabled = false;
            }
        }

        private void isRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (isRandom.Checked == true)
            {
                seedInput.Enabled = false;
                button6.Enabled = true;
            }
            else
            {
                seedInput.Enabled = true;
            }
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
