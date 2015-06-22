namespace RoboFeudal.Simulation.Models.Map
{
    public class Adjacency
    {
        public Province From { get; internal set; }

        public Province To { get; internal set; }

        public AdjacencyType Type { get; internal set; }
    }
}