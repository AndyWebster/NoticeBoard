using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoticeBoard.Models
{
    public class Note
    {
        [BindNever]
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage ="Your post needs a title")]
        public string Title { get; set; }
        [Required]
        [StringLength(600, ErrorMessage = "Your post needs some content")]
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
