using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabiryntBackend.Models
{
    public class Maze
    {
        [Key]
        public long id_maze { get; set; }
        public string name { get; set; }
        public string codedMaze { get; set; }
        public uint height { get; set; }
        public uint width { get; set; }
        [ForeignKey("User")]
        public long id_user { get; set; }
    }
}
