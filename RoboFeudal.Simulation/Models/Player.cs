using System;
using System.Collections.Generic;
using RoboFeudal.Simulation.Models.Map;

namespace RoboFeudal.Simulation.Models
{
    public class Player
    {
        public Guid Id { get; private set; }

        public string DisplayName { get; private set; }

        public IEnumerable<Province> ProvincesOccupied { get; private set; }

        public IEnumerable<Forces.Force> Forces { get; private set; }
    }
}