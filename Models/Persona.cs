using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7.Models
{
    [Table ("persona")]
    public  class Persona
    {
       [ PrimaryKeyAttribute, AutoIncrement]

            public int ID { get; set; }
        [MaxLength(25), Unique]
        public string Name { get; set; }


    }
}
