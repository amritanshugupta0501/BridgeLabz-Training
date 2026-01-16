namespace Scenario_Based.TrafficManager
{
    internal interface ITrafficManagementSystem
    {
        void Arrive(string vehicleNumber, string vehicleType);
        void EnterRoundabout();
        void ExitRoundabout();
        void ShowStatus();
    }
}