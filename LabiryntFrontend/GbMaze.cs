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
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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

        List<Panel> panelList = new List<Panel>();
        int seedValue = 0;
        public PictureBox storedMaze = new PictureBox();
        private List<string> variablesList = new List<string>();
        private int visualizationDelay;
        long userId;

        Stack s_stack;
        Random r;
        public ArrayList exitTable = new ArrayList();

        //Json
        public int generatedSeed;
        exitCoords entryCoords = new exitCoords();
        List<exitCoords> exitCoordsJson = new List<exitCoords>();


        //
        public int[] maze_base;
        public byte[,] maze_data = new byte[10, 10];

        public GbMaze(long userId)
        {
            InitializeComponent();
            visualizationDelay = trackBar1.Value * 10;
            exitList.Columns.Add("Współrzędne wyjść", 130);
            button3.Enabled = false;
            button6.Enabled = false;
            isRandom.Checked = false;
            buttonStart.Enabled = false;
            startXInput.Enabled = false;
            startYInput.Enabled = false;
            exitXInput.Enabled = false;
            exitYInput.Enabled = false;
            button1.Enabled = false;
            addEntryButton.Enabled = false;
            saveMazeAsPNG.Enabled = false;
            saveMazeAsFileButton.Enabled = false;
            button4.Enabled = false;
            this.userId = userId;
            panelList.Add(panelEditor);
            panelList.Add(algorithmsPanel);
            panelList.Add(stepWorkPanel);
            this.Controls.Add(storedMaze);
            Bitmap tB = new Bitmap(cols * cellSize + 1, rows * cellSize + 1);
            Graphics g = Graphics.FromImage((Image)tB);

            Brush w = Brushes.LightGray;
            g.FillRectangle(w, 0, 0, tB.Width - 1, tB.Height - 1);
            pictureBox1.Image = tB;
            g.Dispose();
        }
        public GbMaze()
        {
            InitializeComponent();
            visualizationDelay = trackBar1.Value * 10;
            exitList.Columns.Add("Współrzędne wyjść", 130);
            button3.Enabled = false;
            button6.Enabled = false;
            isRandom.Checked = false;
            buttonStart.Enabled = false;
            startXInput.Enabled = false;
            startYInput.Enabled = false;
            exitXInput.Enabled = false;
            exitYInput.Enabled = false;
            button1.Enabled = false;
            addEntryButton.Enabled = false;
            saveMazeAsPNG.Enabled = false;
            saveMazeAsFileButton.Enabled = false;
            button4.Enabled = false;
            panelList.Add(panelEditor);
            panelList.Add(algorithmsPanel);
            panelList.Add(stepWorkPanel);
            this.Controls.Add(storedMaze);
            Bitmap tB = new Bitmap(cols * cellSize + 1, rows * cellSize + 1);
            Graphics g = Graphics.FromImage((Image)tB);

            Brush w = Brushes.LightGray;
            g.FillRectangle(w, 0, 0, tB.Width - 1, tB.Height - 1);
            pictureBox1.Image = tB;
            g.Dispose();
        }
        private void buttonEditor_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            panelList[1].BringToFront();
            panelTools.Enabled = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("UWAGA! Zmiana rozmiaru labiryntu spowoduje usunięcie wszystkich ścian, wejść oraz wyjść labiryntu!. Czy na pewno chcesz zmienić rozmiar?",
                "Ostrzeżenie!",
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
                buttonStart.Enabled = false;
                //Przerysowanie kontrolki pictureBox1 z nowymi wymiarami
                Bitmap tB = new Bitmap(cols * cellSize + 1, rows * cellSize + 1);
                Graphics g = Graphics.FromImage((Image)tB);

                Brush w = Brushes.LightGray;
                g.FillRectangle(w, 0, 0, tB.Width - 1, tB.Height - 1);
                pictureBox1.Image = tB;
                storedMaze.Image = pictureBox1.Image;
                exitList.Items.Clear();
                exitTable.Clear();
                startXInput.Text = "";
                startXInput.Enabled = false;
                startYInput.Text = "";
                startYInput.Enabled = false;

                exitXInput.Text = "";
                exitXInput.Enabled = false;

                exitYInput.Text = "";
                exitYInput.Enabled = false;

                button1.Enabled = false;
                saveMazeAsPNG.Enabled = false;
                saveMazeAsFileButton.Enabled = false;
                button4.Enabled = false;

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
            variablesList.Clear();

            if (isRandom.Checked == true)
            {
                Random r = new Random();
                generatedSeed = r.Next(0, 2147483646);
                GenerateMaze(cols, rows, generatedSeed);
                pictureBox1.Image = GetBitmap(cols * cellSize, rows * cellSize);
                storedMaze.Image = pictureBox1.Image;
                saveMazeAsPNG.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                GenerateMaze(cols, rows, seedValue);
                pictureBox1.Image = GetBitmap(cols * cellSize, rows * cellSize);
                storedMaze.Image = pictureBox1.Image;
            }
            exitList.Items.Clear();
            exitCoordsJson.Clear();
            entryCoords.x = -1;
            entryCoords.y = -1;
            exitCoordsJson.Add(entryCoords);
            exitTable.Clear();
            startXInput.Text = "";
            startYInput.Text = "";
            exitXInput.Text = "";
            exitYInput.Text = "";

            startXInput.Enabled = true;
            startYInput.Enabled = true;
            exitXInput.Enabled = true;
            exitYInput.Enabled = true;
            saveMazeAsFileButton.Enabled = true;
            buttonStart.Enabled = false;
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
            Brush bl = Brushes.Blue;

            Pen bp = new Pen(b, 2);
            Pen rp = new Pen(r, 2);
            Pen bluePen = new Pen(bl, 2);

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


            g.Dispose();

            return tB;
        }

        public async Task drawAnalyzedCell(int x, int y, Image img, bool isStepWork)
        {
            int xSize = pictureBox1.Image.Width / (cols);
            int ySize = pictureBox1.Image.Height / (rows);
            int posSize = Math.Min(xSize, ySize);

            int penSize = 1;
            Bitmap tB = new Bitmap(img);
            Pen r = new Pen(Color.Coral, penSize);
            Brush b = Brushes.Coral;
            Graphics g = Graphics.FromImage((Image)tB);

            int centerX = x * posSize + posSize / 2;
            int centerY = y * posSize + posSize / 2;
            Rectangle rect = new Rectangle(centerX - xSize / 4, centerY - ySize / 4, xSize / 2, ySize / 2);

            g.DrawRectangle(r, rect);
            g.FillRectangle(b, rect);
            //g.DrawEllipse(r, rect);
            visualizationPicture.Image = tB;

            await Task.Delay(visualizationDelay);
        }

        public async Task<ArrayList> Solve(int xSource, int ySource, ArrayList exitCoords, bool isStepWork)
        {
            if (isStepWork)
            {
                panelList[2].BringToFront();
                panelTools.Enabled = false;
                visualizationPicture.Image = storedMaze.Image;
                renderGates(visualizationPicture.Image, true);
            }
            int[,] tMazePath = new int[cols, rows];
            bool destReached = false;
            exitCoords exitReached = new exitCoords();
            cCellPosition cellPos = new cCellPosition(xSource, ySource);
            Stack stack = new Stack();

            // Przygotowanie do rozpoczęcia
            stack.push(cellPos);
            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    tMazePath[i, j] = -1;
            tMazePath[xSource, ySource] = 0;

            // Zabezpieczenia
            if (maze_data == null) return null;
            foreach (exitCoords cords in exitCoords)
            {
                if (xSource == cords.x && ySource == cords.y) return new ArrayList() { cellPos };
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (destReached == false && !stack.empty())
            {
                cCellPosition currentPos = (cCellPosition)stack.pop();

                // Sprawdź cztery sąsiadujące kierunki
                // N
                if (currentPos.y > 0)
                    if (tMazePath[currentPos.x, currentPos.y - 1] == -1)
                        if ((maze_data[currentPos.x, currentPos.y] & (byte)Direction.N) != 0)
                        {
                            if (isStepWork)
                                await drawAnalyzedCell(currentPos.x, currentPos.y, visualizationPicture.Image, isStepWork);
                            tMazePath[currentPos.x, currentPos.y - 1] = tMazePath[currentPos.x, currentPos.y] + 1;
                            cCellPosition nextPos = new cCellPosition(currentPos.x, currentPos.y - 1);
                            stack.push(nextPos);
                            foreach (exitCoords cords in exitCoords)
                            {
                                if (nextPos.x == cords.x && nextPos.y == cords.y)
                                {
                                    exitReached.x = cords.x;
                                    exitReached.y = cords.y;
                                    destReached = true;
                                    break;
                                }
                            }
                        }
                // W
                if (currentPos.x > 0)
                    if (tMazePath[currentPos.x - 1, currentPos.y] == -1)
                        if ((maze_data[currentPos.x, currentPos.y] & (byte)Direction.W) != 0)
                        {
                            if (isStepWork)
                                await drawAnalyzedCell(currentPos.x, currentPos.y, visualizationPicture.Image, isStepWork);
                            tMazePath[currentPos.x - 1, currentPos.y] = tMazePath[currentPos.x, currentPos.y] + 1;
                            cCellPosition nextPos = new cCellPosition(currentPos.x - 1, currentPos.y);
                            stack.push(nextPos);
                            foreach (exitCoords cords in exitCoords)
                            {
                                if (nextPos.x == cords.x && nextPos.y == cords.y)
                                {
                                    exitReached.x = cords.x;
                                    exitReached.y = cords.y;
                                    destReached = true;
                                    break;
                                }
                            }
                        }
                // S
                if (currentPos.y < rows - 1)
                    if (tMazePath[currentPos.x, currentPos.y + 1] == -1)
                        if ((maze_data[currentPos.x, currentPos.y + 1] & (byte)Direction.N) != 0)
                        {
                            if (isStepWork)
                                await drawAnalyzedCell(currentPos.x, currentPos.y, visualizationPicture.Image, isStepWork);
                            tMazePath[currentPos.x, currentPos.y + 1] = tMazePath[currentPos.x, currentPos.y] + 1;
                            cCellPosition nextPos = new cCellPosition(currentPos.x, currentPos.y + 1);
                            stack.push(nextPos);
                            foreach (exitCoords cords in exitCoords)
                            {
                                if (nextPos.x == cords.x && nextPos.y == cords.y)
                                {
                                    exitReached.x = cords.x;
                                    exitReached.y = cords.y;
                                    destReached = true;
                                    break;
                                }
                            }
                        }
                // E
                if (currentPos.x < cols - 1)
                    if (tMazePath[currentPos.x + 1, currentPos.y] == -1)
                        if ((maze_data[currentPos.x + 1, currentPos.y] & (byte)Direction.W) != 0)
                        {
                            if (isStepWork)
                                await drawAnalyzedCell(currentPos.x, currentPos.y, visualizationPicture.Image, isStepWork);
                            tMazePath[currentPos.x + 1, currentPos.y] = tMazePath[currentPos.x, currentPos.y] + 1;
                            cCellPosition nextPos = new cCellPosition(currentPos.x + 1, currentPos.y);
                            stack.push(nextPos);

                            foreach (exitCoords cords in exitCoords)
                            {
                                if (nextPos.x == cords.x && nextPos.y == cords.y)
                                {
                                    exitReached.x = cords.x;
                                    exitReached.y = cords.y;
                                    destReached = true;
                                    break;
                                }
                            }
                        }
            }

            // Możliwe są dwa warianty:
            if (destReached == false)
            {
                return null;
            }
            else
            {
                // Buduj drogę przez tMazePath
                ArrayList pPath = new ArrayList();

                int tx = exitReached.x;
                int ty = exitReached.y;

                pPath.Add(new cCellPosition(tx, ty));

                while (tx != xSource || ty != ySource)
                {
                    int step = tMazePath[tx, ty];

                    // Szukaj kroku
                    // N
                    if (ty > 0)
                        if (tMazePath[tx, ty - 1] == step - 1 && (maze_data[tx, ty] & (byte)Direction.N) != 0)
                        {
                            ty -= 1;
                            pPath.Add(new cCellPosition(tx, ty));
                        }
                    // W
                    if (tx > 0)
                        if (tMazePath[tx - 1, ty] == step - 1 && (maze_data[tx, ty] & (byte)Direction.W) != 0)
                        {
                            tx -= 1;
                            pPath.Add(new cCellPosition(tx, ty));
                        }
                    // S
                    if (ty < rows - 1)
                        if (tMazePath[tx, ty + 1] == step - 1 && (maze_data[tx, ty + 1] & (byte)Direction.N) != 0)
                        {
                            ty += 1;
                            pPath.Add(new cCellPosition(tx, ty));
                        }
                    // E
                    if (tx < cols - 1)
                        if (tMazePath[tx + 1, ty] == step - 1 && (maze_data[tx + 1, ty] & (byte)Direction.W) != 0)
                        {
                            tx += 1;
                            pPath.Add(new cCellPosition(tx, ty));
                        }
                }

                pPath.Reverse();
                stopwatch.Stop();
                Debug.WriteLine(stopwatch.Elapsed);
                return pPath;
            }
        }

        public async Task<ArrayList> SolveBFS(int xSource, int ySource, ArrayList exitCoords, bool isStepWork)
        {
            if (isStepWork)
            {
                panelList[2].BringToFront();
                panelTools.Enabled = false;
                visualizationPicture.Image = storedMaze.Image;
                renderGates(visualizationPicture.Image, true);
            }
            int[,] tMazePath = new int[cols, rows];
            bool destReached = false;
            exitCoords exitReached = new exitCoords();
            cCellPosition cellPos = new cCellPosition(xSource, ySource);
            Queue<cCellPosition> queue = new Queue<cCellPosition>();

            // Przygotowanie do rozpoczęcia
            queue.Enqueue(cellPos);
            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    tMazePath[i, j] = -1;
            tMazePath[xSource, ySource] = 0;

            // Zabezpieczenia
            if (maze_data == null) return null;
            foreach (exitCoords cords in exitCoords)
            {

                if (xSource == cords.x && ySource == cords.y) return new ArrayList() { cellPos };
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (destReached == false && queue.Count > 0)
            {
                cCellPosition currentPos = queue.Dequeue();

                // Sprawdź cztery sąsiadujące kierunki
                // N
                if (currentPos.y > 0)
                    if (tMazePath[currentPos.x, currentPos.y - 1] == -1)
                        if ((maze_data[currentPos.x, currentPos.y] & (byte)Direction.N) != 0)
                        {
                            if (isStepWork)
                                await drawAnalyzedCell(currentPos.x, currentPos.y, visualizationPicture.Image, isStepWork);
                            tMazePath[currentPos.x, currentPos.y - 1] = tMazePath[currentPos.x, currentPos.y] + 1;
                            cCellPosition nextPos = new cCellPosition(currentPos.x, currentPos.y - 1);
                            queue.Enqueue(nextPos);
                            foreach (exitCoords cords in exitCoords)
                            {
                                if (nextPos.x == cords.x && nextPos.y == cords.y)
                                {
                                    exitReached.x = cords.x;
                                    exitReached.y = cords.y;
                                    destReached = true;
                                    break;
                                }
                            }

                        }
                // W
                if (currentPos.x > 0)
                    if (tMazePath[currentPos.x - 1, currentPos.y] == -1)
                        if ((maze_data[currentPos.x, currentPos.y] & (byte)Direction.W) != 0)
                        {
                            if (isStepWork)
                                await drawAnalyzedCell(currentPos.x, currentPos.y, visualizationPicture.Image, isStepWork);
                            tMazePath[currentPos.x - 1, currentPos.y] = tMazePath[currentPos.x, currentPos.y] + 1;
                            cCellPosition nextPos = new cCellPosition(currentPos.x - 1, currentPos.y);
                            queue.Enqueue(nextPos);
                            foreach (exitCoords cords in exitCoords)
                            {
                                if (nextPos.x == cords.x && nextPos.y == cords.y)
                                {
                                    exitReached.x = cords.x;
                                    exitReached.y = cords.y;
                                    destReached = true;
                                    break;
                                }
                            }
                        }
                // S
                if (currentPos.y < rows - 1)
                    if (tMazePath[currentPos.x, currentPos.y + 1] == -1)
                        if ((maze_data[currentPos.x, currentPos.y + 1] & (byte)Direction.N) != 0)
                        {
                            if (isStepWork)
                                await drawAnalyzedCell(currentPos.x, currentPos.y, visualizationPicture.Image, isStepWork);
                            tMazePath[currentPos.x, currentPos.y + 1] = tMazePath[currentPos.x, currentPos.y] + 1;
                            cCellPosition nextPos = new cCellPosition(currentPos.x, currentPos.y + 1);
                            queue.Enqueue(nextPos);
                            foreach (exitCoords cords in exitCoords)
                            {
                                if (nextPos.x == cords.x && nextPos.y == cords.y)
                                {
                                    exitReached.x = cords.x;
                                    exitReached.y = cords.y;
                                    destReached = true;
                                    break;
                                }
                            }
                        }
                // E
                if (currentPos.x < cols - 1)
                    if (tMazePath[currentPos.x + 1, currentPos.y] == -1)
                        if ((maze_data[currentPos.x + 1, currentPos.y] & (byte)Direction.W) != 0)
                        {
                            if (isStepWork)
                                await drawAnalyzedCell(currentPos.x, currentPos.y, visualizationPicture.Image, isStepWork);
                            tMazePath[currentPos.x + 1, currentPos.y] = tMazePath[currentPos.x, currentPos.y] + 1;
                            cCellPosition nextPos = new cCellPosition(currentPos.x + 1, currentPos.y);
                            queue.Enqueue(nextPos);

                            foreach (exitCoords cords in exitCoords)
                            {
                                if (nextPos.x == cords.x && nextPos.y == cords.y)
                                {
                                    exitReached.x = cords.x;
                                    exitReached.y = cords.y;
                                    destReached = true;
                                    break;
                                }
                            }
                        }

            }

            // Możliwe są dwa warianty:
            if (destReached == false)
            {
                return null;
            }
            else
            {
                // Buduj drogę przez tMazePath
                ArrayList pPath = new ArrayList();

                int tx = exitReached.x;
                int ty = exitReached.y;

                pPath.Add(new cCellPosition(tx, ty));

                while (tx != xSource || ty != ySource)
                {
                    int step = tMazePath[tx, ty];

                    // Szukaj kroku
                    // N
                    if (ty > 0)
                        if (tMazePath[tx, ty - 1] == step - 1 && (maze_data[tx, ty] & (byte)Direction.N) != 0)
                        {
                            ty -= 1;
                            pPath.Add(new cCellPosition(tx, ty));
                        }
                    // W
                    if (tx > 0)
                        if (tMazePath[tx - 1, ty] == step - 1 && (maze_data[tx, ty] & (byte)Direction.W) != 0)
                        {
                            tx -= 1;
                            pPath.Add(new cCellPosition(tx, ty));
                        }
                    // S
                    if (ty < rows - 1)
                        if (tMazePath[tx, ty + 1] == step - 1 && (maze_data[tx, ty + 1] & (byte)Direction.N) != 0)
                        {
                            ty += 1;
                            pPath.Add(new cCellPosition(tx, ty));
                        }
                    // E
                    if (tx < cols - 1)
                        if (tMazePath[tx + 1, ty] == step - 1 && (maze_data[tx + 1, ty] & (byte)Direction.W) != 0)
                        {
                            tx += 1;
                            pPath.Add(new cCellPosition(tx, ty));
                        }
                }

                pPath.Reverse();
                stopwatch.Stop();
                Debug.WriteLine(stopwatch.Elapsed);
                return pPath;
            }
        }

        private void seedInput_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(seedInput.Text, out seedValue) && seedValue <= 2147483646)
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

        private void backButton_Click(object sender, EventArgs e)
        {
            panelList[0].BringToFront();
            panelTools.Enabled = true;
        }

        private async void algorithm1Button_Click(object sender, EventArgs e)
        {

            ArrayList solvePath = await Solve(entryCoords.x, entryCoords.y, exitTable, stepWork.Checked);
            draw(solvePath);

        }
        private void draw(ArrayList solvePath)
        {
            Bitmap tB = new Bitmap(storedMaze.Image);

            int penSize = 5;
            Pen p = new Pen(Color.Black, penSize);
            Graphics g = Graphics.FromImage((Image)tB);
            int xSize = pictureBox1.Image.Width / cols;
            int ySize = pictureBox1.Image.Height / rows;
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
            renderGates(pictureBox1.Image);
            p.Dispose();
            g.Dispose();
            panelList[0].BringToFront();
            panelTools.Enabled = true;
        }
        private async void algorithm2Button_Click(object sender, EventArgs e)
        {
            ArrayList solvePath = await SolveBFS(entryCoords.x, entryCoords.y, exitTable, stepWork.Checked);
            draw(solvePath);
        }
        private void renderGates(Image img)
        {
            int xSize = pictureBox1.Image.Width / cols;
            int ySize = pictureBox1.Image.Height / rows;
            int penSize = 5;
            Bitmap tB = new Bitmap(img);
            Pen r = new Pen(Color.Red, penSize);
            Graphics g = Graphics.FromImage((Image)tB);

            foreach (exitCoords cords in exitTable)
            {
                g.DrawEllipse(r, cords.x * xSize, cords.y * ySize, xSize, ySize);
            }


            if (entryCoords.x >= 0 && entryCoords.x < cols && entryCoords.y >= 0 && entryCoords.y < rows)
            {
                Pen b = new Pen(Color.Blue, penSize);
                //if (startXInput.Text != "" && startYInput.Text != "")
                g.DrawEllipse(b, entryCoords.x * xSize, entryCoords.y * ySize, xSize, ySize);
            }

            pictureBox1.Image = tB;

            g.Dispose();

        }
        private void renderGates(Image img, bool visual)
        {
            int xSize = pictureBox1.Image.Width / cols;
            int ySize = pictureBox1.Image.Height / rows;
            int penSize = 5;
            Bitmap tB = new Bitmap(img);
            Pen r = new Pen(Color.Red, penSize);
            Graphics g = Graphics.FromImage((Image)tB);

            foreach (exitCoords cords in exitTable)
            {
                g.DrawEllipse(r, cords.x * xSize, cords.y * ySize, xSize, ySize);
            }


            if (entryCoords.x >= 0 && entryCoords.x < cols && entryCoords.y >= 0 && entryCoords.y < rows)
            {
                Pen b = new Pen(Color.Blue, penSize);
                //if (startXInput.Text != "" && startYInput.Text != "")
                g.DrawEllipse(b, entryCoords.x * xSize, entryCoords.y * ySize, xSize, ySize);
            }
            if (visual)
                visualizationPicture.Image = tB;

            g.Dispose();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            exitCoords newExit = new exitCoords();
            if (int.TryParse(exitXInput.Text, out newExit.x) && int.TryParse(exitYInput.Text, out newExit.y))
            {
                if (newExit.x >= 0 && newExit.x < cols && newExit.y >= 0 && newExit.y < rows)
                {
                    if (!newExit.Equals(entryCoords))
                    {
                        if (!exitTable.Contains(newExit))
                        {

                            exitTable.Add(newExit);

                            exitList.Items.Add(newExit.x + ", " + newExit.y);
                            if (exitCoordsJson.Exists(e => e.x == -1 && e.y == -1))
                            {
                                exitCoordsJson.Clear();
                            }
                            exitCoordsJson.Add(newExit);


                            renderGates(storedMaze.Image);



                            if (entryCoords.x >= 0 && entryCoords.x < cols && entryCoords.y >= 0 && entryCoords.y < rows)
                            {
                                buttonStart.Enabled = true;
                            }
                            else
                            {
                                buttonStart.Enabled = false;
                            }


                        }
                        else
                        {
                            MessageBox.Show("Nie można dodać 2 razy tych samych współrzędnych!", " Błąd dodawania wyjścia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Współrzędne wyjścia nie mogą być takie same jak współrzędne wejścia", " Błąd dodawania wyjścia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }

            }

        }

        private void exitList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = exitList.SelectedItems[0];
            exitTable.RemoveAt(selectedItem.Index);
            exitCoordsJson.RemoveAt(selectedItem.Index);
            exitList.Items.Remove(selectedItem);
            renderGates(storedMaze.Image);

            if (exitList.Items.Count > 0)
            {
                buttonStart.Enabled = true;
            }
            else
            {

                exitCoordsJson.Add(new exitCoords { x = -1, y = -1 });
                buttonStart.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            renderGates(storedMaze.Image);

        }
        private void button7_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Pliki PNG (*.png)|*.png";
                saveDialog.Title = "Zapisz labirynt jako zdjęcie";
                saveDialog.CheckFileExists = false;
                saveDialog.CheckPathExists = true;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileProperties = saveDialog.FileName;
                    string fileName = Path.GetFileName(fileProperties);
                    string fileDirectory = Path.GetDirectoryName(fileProperties);


                    SavePictureBoxAsPng(pictureBox1, fileProperties);
                    MessageBox.Show("Obraz " + fileName + " został pomyślnie zapisany w lokacji: " + fileDirectory, " Zapisano", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
        private void SavePictureBoxAsPng(PictureBox pictureBox, string fileName)
        {
            if (pictureBox.Image != null)
            {
                if (pictureBox.Image != null)
                {
                    using (Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height))
                    {
                        pictureBox.DrawToBitmap(bitmap, pictureBox1.ClientRectangle);
                        bitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                    }
                }
            }
        }

        private void exitXInput_TextChanged(object sender, EventArgs e)
        {
            exitCoords newExit = new exitCoords();
            if (int.TryParse(exitXInput.Text, out newExit.x) && int.TryParse(exitYInput.Text, out newExit.y))
            {
                if (newExit.x >= 0 && newExit.x < cols && newExit.y >= 0 && newExit.y < rows)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }

            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {

            exitCoords newEntries = new exitCoords();
            newEntries.x = int.Parse(startXInput.Text);
            newEntries.y = int.Parse(startYInput.Text);

            if (!exitTable.Contains(newEntries))
            {
                entryCoords = newEntries;
                renderGates(storedMaze.Image);




                if (exitList.Items.Count > 0)
                {
                    buttonStart.Enabled = true;

                }
                else
                {
                    buttonStart.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Współrzędne wejścia nie mogą być takie same jak współrzędne wyjścia!", " Błąd dodawania wejścia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void startXInput_TextChanged(object sender, EventArgs e)
        {
            int newInputX;
            int newInputY;
            if (int.TryParse(startXInput.Text, out newInputX) && int.TryParse(startYInput.Text, out newInputY))
            {
                if (newInputX >= 0 && newInputX < cols && newInputY >= 0 && newInputY < rows)
                {
                    addEntryButton.Enabled = true;
                }
                else
                {
                    addEntryButton.Enabled = false;
                }

            }
            else
            {
                addEntryButton.Enabled = false;
            }
        }

        private void saveMazeAsFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Plik .maze|*.maze";
            saveFileDialog.Title = "Zapisz plik .maze";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileProperties = saveFileDialog.FileName;
                string fileName = Path.GetFileName(fileProperties);
                string fileDirectory = Path.GetDirectoryName(fileProperties);



                try
                {
                    var dataModel = new
                    {
                        seed = generatedSeed,
                        rows = rows,
                        cols = cols,
                        startXY = new { startX = entryCoords.x, startY = entryCoords.y },
                        exitCoords = exitCoordsJson.Select(e => new { x = e.x, y = e.y }).ToList()
                    };

                    // Konfiguracja opcji serializacji
                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true
                    };

                    // Konwersja do formatu JSON
                    string json = JsonSerializer.Serialize(dataModel, options);

                    File.WriteAllText(fileProperties, json);

                    MessageBox.Show("Labirynt " + fileName + " został pomyślnie zapisany w lokacji: " + fileDirectory, " Zapisano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas zapisywania pliku: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void loadMaze(string json)
        {
            // Deserializacja JSON do modelu danych
            JsonDocument document = JsonDocument.Parse(json);
            generatedSeed = document.RootElement.GetProperty("seed").GetInt32();
            rows = document.RootElement.GetProperty("rows").GetInt32();
            cols = document.RootElement.GetProperty("cols").GetInt32();
            entryCoords.x = document.RootElement.GetProperty("startXY").GetProperty("startX").GetInt32();
            entryCoords.y = document.RootElement.GetProperty("startXY").GetProperty("startY").GetInt32();
            GenerateMaze(cols, rows, generatedSeed);
            pictureBox1.Image = GetBitmap(cols * cellSize, rows * cellSize);
            storedMaze.Image = pictureBox1.Image;
            saveMazeAsPNG.Enabled = true;
            startXInput.Text = entryCoords.x.ToString();
            startYInput.Text = entryCoords.y.ToString();

            exitTable.Clear();
            exitCoordsJson.Clear();
            exitList.Items.Clear();

            JsonElement exitCoordsElement = document.RootElement.GetProperty("exitCoords");
            if (exitCoordsElement.ValueKind == JsonValueKind.Array)
            {
                foreach (JsonElement exitCoordElement in exitCoordsElement.EnumerateArray())
                {
                    int x = exitCoordElement.GetProperty("x").GetInt32();
                    int y = exitCoordElement.GetProperty("y").GetInt32();

                    
                    exitTable.Add(new exitCoords { x = x, y = y });
                    exitCoordsJson.Add(new exitCoords { x = x, y = y });
                    if (x != -1 && y != -1)
                    {
                        exitList.Items.Add(x + ", " + y);
                    }
                }
            }

            renderGates(storedMaze.Image);
            saveMazeAsFileButton.Enabled = true;
            button4.Enabled = true;
            startXInput.Text = "";
            exitXInput.Text = "";
            startXInput.Enabled = true;
            startYInput.Text = "";
            exitYInput.Text = "";
            startYInput.Enabled = true;
            exitXInput.Enabled = true;
            exitYInput.Enabled = true;

            button1.Enabled = false;
            addEntryButton.Enabled = false;
            buttonStart.Enabled = false;

            if (exitTable.Count!=0 && entryCoords.x != -1 && entryCoords.y != -1)
            {
                buttonStart.Enabled = true;
            }

        }
        private void openMazeAsFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Plik .maze|*.maze";
            openFileDialog.Title = "Otwórz plik .maze";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(filePath);

                try
                {
                    string json = File.ReadAllText(filePath);
                    loadMaze(json);
                    MessageBox.Show("Labirynt " + fileName + " został pomyślnie załadowany z pliku: ", " Wczytano", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas zapisywania pliku: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            visualizationDelay = trackBar1.Value * 10;
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            //SAVE TO DB
            SaveToDB toDB = new SaveToDB(generatedSeed, (uint)rows, (uint)cols, entryCoords, exitCoordsJson, userId);
            toDB.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ReadFromDb fromDB = new ReadFromDb(userId);
            var result = fromDB.ShowDialog();

            if (result == DialogResult.OK)
            {
                Maze maze = fromDB.getItem();
                string json = ConvertStringToJson(maze);
                loadMaze(json);
                MessageBox.Show("Labirynt " + maze.name + " został pomyślnie załadowany z bazy danych: ", " Wczytano", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


        }
        public static string ConvertStringToJson(Maze inputMaze)
        {


            exitCoords startXY = new exitCoords();
            string[] startCoords = inputMaze.startXY.Split(',');
            startXY.x = int.Parse(startCoords[0]);
            startXY.y = int.Parse(startCoords[1]);

            string[] exitCoords = inputMaze.exitCoords.Split(';');
            List<exitCoords> exitArray = new List<exitCoords>();
            string[] check = exitCoords[0].Split(',');
            if (check[0] != "-1")
            {
                for (int i = 0; i < exitCoords.Length; i++)
                {
                    string[] coords = exitCoords[i].Split(',');
                    exitCoords exitCoord = new exitCoords();
                    exitCoord.x = int.Parse(coords[0]);
                    exitCoord.y = int.Parse(coords[1]);
                    exitArray.Add(exitCoord);
                }
            }



            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var dataModel = new
            {
                seed = inputMaze.seed,
                rows = inputMaze.rows,
                cols = inputMaze.cols,
                startXY = new { startX = startXY.x, startY = startXY.y },
                exitCoords = exitArray.Select(e => new { x = e.x, y = e.y }).ToList()
            };

            string json = JsonSerializer.Serialize(dataModel, options);

            return json;
        }
    }
}
