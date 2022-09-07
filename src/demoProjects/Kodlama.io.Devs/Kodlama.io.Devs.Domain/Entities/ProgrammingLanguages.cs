using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Devs.Domain.Entities
{
    public class ProgrammingLanguages : Entity
    {
        public String Name { get; set; }

        public ProgrammingLanguages()
        {

        }

        public ProgrammingLanguages(int id,string name): this()
        {
            id = id;
            name = name;
        }
    }
}
