using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace stickynotes.Models
{

    public class Sticky
    {
        public int Id { get; set; }
        public string Notetitle { get; set; } 
        public string Notetext { get; set; }
        [DataType(DataType.Date)] public DateTime NoteDate { get; set; }
        public int Order { get; set; }
    }

}