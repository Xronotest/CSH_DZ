using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_27_03
{
    internal class Laptop
    {
        private string _model;
        private double _processorGhz;
        private int _ram;
        private int _memory;
        private int _weight;


        public Laptop()
        {
            _model = string.Empty;
            _processorGhz = 0;
            _ram = 0;
            _memory = 0;
            _weight = 0;
        }

        public Laptop(string model, double processorGhz, int ram, int memory, int weight)
        {
            _model = model;
            _processorGhz = processorGhz;
            _ram = ram;
            _memory = memory;
            _weight = weight;
        }

        public void Info(Laptop laptop)
        {
            Console.WriteLine($"Модель: {_model} \nТактовая частота процессора: {_processorGhz} GHz \nОперативная память: {_ram} Gb \nОбъём памяти: {_memory} Gb \nВес: {_weight} Kg");
        }
    }
}
