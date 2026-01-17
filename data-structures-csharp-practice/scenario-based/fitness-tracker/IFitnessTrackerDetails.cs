namespace Scenario_Based.fitnesstracker
{
    internal interface IFitnessTrackerDetails
    {
        void AddUserInAGroup();
        int CountUsers();
        void GenerateHourlyRankingsAmongTheGroup();
        void GenerateStepsForEachUser();
    }
}