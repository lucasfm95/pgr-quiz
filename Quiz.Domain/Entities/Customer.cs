using Quiz.Domain.Entities;
using System;

namespace Quiz.Domain
{
    public class Customer : Entity
    {

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string SchollarShip { get; set; }
    }
}
