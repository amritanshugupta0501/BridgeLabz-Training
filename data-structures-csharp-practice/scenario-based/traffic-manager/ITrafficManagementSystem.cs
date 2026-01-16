namespace Scenario_Based.TrafficManager
{
    // Interfact for the Traffic Management System utility program
    internal interface ITrafficManagementSystem
    {
        void Arrive(string vehicleNumber, string vehicleType);
        void EnterRoundabout();
        void ExitRoundabout();
        void ShowStatus();
    }
}