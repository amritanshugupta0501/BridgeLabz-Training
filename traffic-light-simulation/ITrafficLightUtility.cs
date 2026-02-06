namespace Scenario_Based.Review.trafficlightsimulation
{
    internal interface ITrafficLightUtility
    {
        void AddVehicleToTheTrafficQueue(string vehicleState);
        bool CheckTrafficQueueEmpty();
        void DisplayTrafficQueue();
        void InitalizeTrafficLights();
        void RemoveVehiclesFromTrafficQueue();
    }
}