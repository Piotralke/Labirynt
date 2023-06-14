using LabiryntBackend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabiryntFrontend
{
    public partial class ReadFromDb : Form
    {
        long id_user;
        dataGetter getter = new dataGetter();
        int Lp;
        List<Maze> mazes = new List<Maze>();
        public ReadFromDb(long id_user)
        {
            InitializeComponent();
            listView1.Columns.Add("Lp", 100);
            listView1.Columns.Add("Nazwa labiryntu", 200);
            this.id_user = id_user;
            mazes = getter.getUserMazes(id_user);

            foreach (var maze in mazes)
            {
                Lp++;
                ListViewItem item = new ListViewItem(Lp.ToString());
                item.SubItems.Add(maze.name);
                listView1.Items.Add(item);
            }

        }

        public Maze getItem()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                return mazes[listView1.SelectedItems[0].Index]; // Zwróć nazwę wybranego pliku
            }

            return null;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
