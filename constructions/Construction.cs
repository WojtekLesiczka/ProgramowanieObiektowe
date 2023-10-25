using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.constructions
{
    internal class Construction
    {
        public Construction()
        {
        }

        public Construction(float height, float width, int entrances, int humancapacity, string buildmaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humancapacity;
            _buildmaterial = buildmaterial;
        }
        private string _buildmaterial { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public string BuildMaterial
        {
            get
            {
                return _buildmaterial;
            }
            set { _buildmaterial = value; }
        }
    }
}
