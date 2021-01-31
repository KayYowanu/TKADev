using System;
using System.ComponentModel.DataAnnotations;



namespace TKABlazor.Models
{
    public class TKARepliesModel
    {
        [Key]
        public int ReplyId { get; set; }
        public int CommentId { get; set; }
        public string Reply { get; set; }
        public string Username { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime ModifiedOn { get; set; } = DateTime.Now;
        public string IsDeleted { get; set; }
        public DateTime DeletedOn { get; set; } = DateTime.Now;

    }
}
