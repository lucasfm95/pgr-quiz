using Quiz.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Quiz.Domain
{
    [Table("Question")]
    public class Question : Entity
    {
        public string Description { get; set; }
    }
}
