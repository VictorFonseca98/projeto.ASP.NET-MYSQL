using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroTimes.Models
{
    [Table("Brasileirao")]
    public class Times
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("numeroTitulos")]
        public int Titulos { get; set; }
    }
}
