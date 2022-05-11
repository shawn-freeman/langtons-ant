using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace langtons_ant
{
    public  class Sim
    {
        public Ant Ant { get; set; }
        public GridHandler GridHandler { get; set; }

        public void RunSim(int numSteps)
        {
            GridHandler = new GridHandler();
            Ant = new Ant(GridHandler);

            var currentStep = 0;
            while (currentStep < numSteps)
            {
                Ant.Move();
                currentStep++;
            }

            //output grid
            Console.Write(GridHandler.OutputGrid());

        }
    }
}
