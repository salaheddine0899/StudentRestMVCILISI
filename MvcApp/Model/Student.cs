using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApp.Model
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public long Id { get; set; }
        [Required,StringLength(25)]
        public string Name { get; set; }
        public int Score { get; set; }

        public Student(long id, string name, int score)
        {
            Id = id;
            Name = name;
            Score = score;
        }
        public Student(string name, int score)
        {
            Name = name;
            Score = score;
        }
        public Student() { }
    }

}
