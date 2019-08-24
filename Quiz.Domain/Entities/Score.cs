using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Text;

namespace Quiz.Domain.Entities
{
    [Table("vwScore")]
    public class Score : Abstract.Entity
    {

        public string CustomerName { get; set; }

        public DateTime BirthDate { get; set; }

        public string SchollarShip { get; set; }

        public string SocialClass { get; set; }

        public int CustomerScore { get; set; }
    }
}
