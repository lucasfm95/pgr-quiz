using Quiz.Domain.Entities.Abstract;
using System;

namespace Quiz.Domain
{
    public class Customer : Entity
    {

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string SchollarShip { get; set; }
    }
}
