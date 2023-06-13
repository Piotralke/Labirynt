using LabiryntBackend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabiryntFrontend
{
    public partial class SaveToDB : Form
    {
        int generatedSeed;
        uint rows;
        uint cols;
        exitCoords entryCoords;
        List<exitCoords> exitCoordsJson;
        long id_user;
        public SaveToDB(int generatedSeed, uint rows, uint cols, exitCoords entryCoords, List<exitCoords> exitCoordsJson, long  id_user)
        {
            InitializeComponent();
            this.generatedSeed = generatedSeed;
            this.rows = rows;
            this.cols = cols;
            this.entryCoords = entryCoords;
            this.exitCoordsJson = exitCoordsJson;
            this.id_user = id_user;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string stringStartXY = entryCoords.x + "," + entryCoords.y;
            string stringExitCoords = string.Join(";", exitCoordsJson.Select(e => e.x + "," + e.y)) + ";";

            Maze maze = new Maze()
            {
                id_maze = 0,
                name = textBox1.Text,
                seed = generatedSeed,
                rows = rows,
                cols = cols,
                startXY = stringStartXY,
                exitCoords = stringExitCoords,
                id_user = id_user
            };

            dataSetter<Maze> setter = new dataSetter<Maze>();

            setter.postContent("Mazes", maze);

            
            string message = "Dodano labirynt " + textBox1.Text;
            string title = "Sukces!";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}