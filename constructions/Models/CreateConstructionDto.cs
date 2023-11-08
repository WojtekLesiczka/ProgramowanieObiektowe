using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.constructions.Models
{
    internal class CreateConstructionDto
    {
        private CreateConstructionDto inputParam;

        public CreateConstructionDto()
        {
        }

        public CreateConstructionDto(CreateConstructionDto inputParam)
        {
            this.inputParam = inputParam;
        }

        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public TypeOfMaterial1 BuildMaterial { get; set; }

    }
}
