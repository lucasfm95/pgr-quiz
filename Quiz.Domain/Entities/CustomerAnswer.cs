using Quiz.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Domain.Entities
{
    public class CustomerAnswer : Entity
    {
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
    }
}
