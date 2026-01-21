using System;
using System.Collections.Generic;
using System.Linq;
public class VotingSystem
{
    private Dictionary<string, int> _votes = new Dictionary<string, int>();
    private List<string> _voteLog = new List<string>(); 
    public void CastVote(string candidate)
    {
        if (_votes.ContainsKey(candidate))
            _votes[candidate]++;
        else
            _votes[candidate] = 1;

        _voteLog.Add(candidate);
    }
    public List<KeyValuePair<string, int>> GetResultsSorted()
    {
        return _votes.OrderByDescending(v => v.Value).ToList();
    }
    public static void Main(string[] args)
    {
        VotingSystem system = new VotingSystem();
        system.CastVote("Alice");
        system.CastVote("Bob");
        system.CastVote("Alice");
        system.CastVote("Charlie");
        system.CastVote("Bob");
        system.CastVote("Alice");
        List<KeyValuePair<string, int>> results = system.GetResultsSorted();
        foreach (var entry in results)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}