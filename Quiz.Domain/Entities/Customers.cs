using Quiz.Domain.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz.Domain
{
    [Table("Customer")]
    public class Customers : Entity
    {

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string SchollarShip { get; set; }
    }
}
