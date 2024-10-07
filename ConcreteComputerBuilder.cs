using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_pattern
{
    class ConcreteComputerBuilder : Collector
    {
        public override void SetCPU()
        {
            this.Computer.CPU = new CPU 
            { Model = "intel core i5-12400f", 
                Total_number_of_cores = 6, 
                Maximum_number_of_threads = 12,
                Cache_size = 18
            };
        }

        public override void SetMotherboard()
        {
            this.Computer.Motherboard = new Motherboard
            {
                Model = "MSI PRO H610M-E DDR4",
                Form_factor = "Micro-ATX"
            };
        }

        public override void SetRAM()
        {
            this.Computer.RAM = new RAM
            {
                Model = "Kingston FURY Beast Black",
                RAM_capacity = 16
            };
        }

        public override void SetStorage()
        {
            this.Computer.Storage = new Storage
            {
                Model = "WD Purple Surveillance",
                Storage_capacity = 4000
            };
        }

        public override void SetGPU()
        {
            this.Computer.GPU = new GPU
            {
                Model = "MSI GeForce RTX 4060 VENTUS 2X BLACK OC",
                VRAM = 8
            };
        }
    }
}
