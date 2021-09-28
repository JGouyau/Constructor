using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.MesClass
{
    class Building
    {
        int _nombreEtage;
        int _tailleDuBatiment;

        public Building(int nombreEtage, int tailleDuBatiment)
        {
            _nombreEtage = nombreEtage;
            _tailleDuBatiment = tailleDuBatiment;
        }
        public Building(int nombreEtage) : this(nombreEtage, 3*nombreEtage)
        {

        }

        public int GetFloorCount()
        {
            return _nombreEtage;
        }

        public int GetSize()
        {
            return _tailleDuBatiment;
        }

        public double GetFloorMaxSize() 
        {
            return _tailleDuBatiment / _nombreEtage;
        }
    }
}
