using Quiz.Domain.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Quiz.Domain.Entities.Abstract
{
    public abstract class Entity : IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
