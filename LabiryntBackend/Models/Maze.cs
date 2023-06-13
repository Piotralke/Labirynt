using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabiryntBackend.Models
{
    public class Maze
    {
        [Key]
        public long id_maze { get; set; }
        public string? name { get; set; }
        public int? seed { get; set; }
        public uint? cols { get; set; }
        public uint? rows { get; set; }
        public string? startXY { get; set; }
        public string? exitCoords { get; set; }
        [ForeignKey("User")]
        public long id_user { get; set; }
    }
}
