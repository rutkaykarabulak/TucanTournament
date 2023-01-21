// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using TucanTournament;
using TucanTournament.Models;
using static TucanTournament.Utils.Types;
using static TucanTournament.Utils.Constants;
using System.Reflection.Metadata;
using TucanTournament.Utils;
using TucanTournament.Services;

List<Player> teamAPlayers = new();
List<Player> teamBPlayers = new();

// Paste your stats path to here.
List<string> lines = File.ReadLines(@"C:\Users\rutka\source\repos\TucanTournament\Stats\stats2.txt").ToList();

SportType branch = lines[0].ToLower() == "basketball" ? SportType.Basketball : SportType.Handball;

Team teamA = new("Team A", branch);
Team teamB = new("Team B", branch);

// remove first line 

lines.RemoveAt(0);
// Read the file and display it line by line.  

if (branch == SportType.Basketball)
{
	foreach (string line in lines)
	{
		string[] parts = line.Split(';');

		string name = parts[Constants.PlayerNamePosition];
		int jersey = Int32.Parse(parts[Constants.PlayerJerseyPosition]);
		Team team = parts[PlayerTeamPosition] == "Team A" ? teamA : teamB;
		PlayerPosition position = PlayerService.GetPlayerPositionByChar(branch, parts[Constants.PlayerPosition].ToCharArray()[0]);
		int scores = Int32.Parse(parts[Constants.BasketballPlayerScorePosition]);
		int assists = Int32.Parse(parts[Constants.BasketballPlayerAssistPosition]);
		int rebounds = Int32.Parse(parts[Constants.BasketballPlayerReboundPosition]);
		int score = PlayerService.CalculateBasketballPlayerPoints(position, scores, rebounds, assists);

		Player player = new(branch, name, jersey, team, score);


	}
} else if (branch == SportType.Handball)
{
	foreach (string line in lines)
	{
		string[] parts = line.Split(';');

		string name = parts[Constants.PlayerNamePosition];
		int jersey = Int32.Parse(parts[Constants.PlayerJerseyPosition]);
		Team team = parts[PlayerTeamPosition] == "Team A" ? teamA : teamB;
		PlayerPosition position = PlayerService.GetPlayerPositionByChar(branch, parts[Constants.PlayerPosition].ToCharArray()[0]);
		int goalsMade = Int32.Parse(parts[Constants.HandballPlayerGoalsMadePosition]);
		int goalsReceived = Int32.Parse(parts[Constants.HandballPlayerGoalsReceivedPosition]);
		int score = PlayerService.CalculateHandballPlayerPoints(position, goalsMade, goalsReceived);


		Player player = new(branch, name, jersey, team, score);


	}
}

// If game is draw, away team is the winner! (That's my design decision)
Team winner = teamA.Point > teamB.Point ? teamA : teamB;

winner.AddBonusWinnerPoint(); // winner team's players get 10 points additional.


Player mvpOfTeamA = teamA.Players.MaxBy(p => p.Score);
Player mvpOfTeamB = teamB.Players.MaxBy(p => p.Score);
Player mvp = mvpOfTeamA.Score > mvpOfTeamB.Score ? mvpOfTeamA : mvpOfTeamB;

Match match = new(teamA, teamB, winner, mvp, DateTime.Now);

Console.WriteLine("Your MVP is:" + mvp.Name + " And it's score is: " + mvp.Score);


