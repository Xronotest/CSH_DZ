using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_27_03
{
    internal class Laptop
    {
        static private String model_;
        static private double processorGhz_;
        static private int ram_;
        static private int memory_;
        static private int weight_;


        public Laptop()
        {
            model_ = String.Empty;
            processorGhz_ = 0;
            ram_ = 0;
            memory_ = 0;
            weight_ = 0;
        }

        public Laptop(String model, double processorGhz, int ram, int memory, int weight)
        {
            model_ = model;
            processorGhz_ = processorGhz;
            ram_ = ram;
            memory_ = memory;
            weight_ = weight;
        }

        static public void Info(Laptop laptop)
        {
            Console.WriteLine($"Модель: {model_} \nТактовая частота процессора: {processorGhz_} GHz \nОперативная память: {ram_} Gb \nОбъём памяти: {memory_} Gb \nВес: {weight_} Kg");
        }
    }
}
