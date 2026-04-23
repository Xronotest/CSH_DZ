using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSH_DZ_27_03
{
    internal class PC
    {
        private string _model;
        private double _processorGhz;
        private int _ram;
        private int _memory;


        public PC() 
        { 
            _model = string.Empty;
            _processorGhz = 0;
            _ram = 0;
            _memory = 0;
        }

        public PC(string model, double processorGhz, int ram, int memory)
        {
            _model = model;
            _processorGhz = processorGhz;
            _ram = ram;
            _memory = memory;
        }

        public void Info(PC pc)
        {
            Console.WriteLine($"Модель: {_model} \nТактовая частота процессора: {_processorGhz} GHz \nОперативная память: {_ram} Gb \nОбъём памяти: {_memory} Gb");
        }
    }
}
