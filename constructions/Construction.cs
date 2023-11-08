using lab2.constructions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ctrl+d
//CTRO 2 RAZY TAB
namespace lab2.constructions
{
    internal class Construction
    {
        // Usunięto drugi bezparametrowy konstruktor
        // Jeśli chcesz mieć konstruktor bezparametrowy z domyślnymi wartościami, pozostaw tylko ten
        public Construction()
        {
            Height = 23;
            Width = 12;
            Entrances = 1;
            HumanCapacity = 1;
            _buildmaterial = TypeOfMaterial1.Wood;
        }
        public Construction(CreateConstructionDto input)
        {
            Height = input.Height;
            Width = input.Width;
            Entrances = input.Entrances;
            HumanCapacity = input.HumanCapacity;
            _buildmaterial = input.BuildMaterial;
        }
        public Construction(float height, float width, int entrances, int humancapacity, string buildmaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humancapacity;
            _buildmaterial = TypeOfMaterial1.Wood;
        }

        private TypeOfMaterial1 _buildmaterial;
        public float Width { get; set; }
        public float Height { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }

        public TypeOfMaterial1 BuildMaterial
        {
            get
            {
                return _buildmaterial;
            }
            set
            {
                _buildmaterial = value;
            }
        }
    }
}

