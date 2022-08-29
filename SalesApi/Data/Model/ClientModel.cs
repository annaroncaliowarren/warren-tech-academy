using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class ClientModel : BaseModel
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Birthday { get; set; }
        public string Cpf { get; set; }
    }
}
