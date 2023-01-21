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
List<string> lines = File.ReadLines(@"C:\Users\rutka\source\repos\TucanTournament\Stats\stats1.txt").ToList();

SportType branch = lines[0].ToLower() == "basketball" ? SportType.Basketball : SportType.Handball;

Team teamA = new("Team A", branch);
Team teamB = new("Team B", branch);

// remove first line 

lines.RemoveAt(0);
// Read the file and display it line by line.  

if (branch == SportType.Basketball)
{
	PlayerService.PlayBasketballGame(lines, branch, teamA, teamB);
} else if (branch == SportType.Handball)
{
	PlayerService.PlayHandballGame(lines, branch, teamA, teamB);
}

// If game is draw, away team is the winner! (That's my design decision)
Team winner = teamA.Point > teamB.Point ? teamA : teamB;

winner.AddBonusWinnerPoint(); // winner team's players get 10 points additional.


Player mvpOfTeamA = teamA.Players.MaxBy(p => p.Score);
Player mvpOfTeamB = teamB.Players.MaxBy(p => p.Score);
Player mvp = mvpOfTeamA.Score > mvpOfTeamB.Score ? mvpOfTeamA : mvpOfTeamB;

Match match = new(teamA, teamB, winner, mvp, DateTime.Now);

Console.WriteLine("Your MVP is:" + mvp.Name + " And it's score is: " + mvp.Score);


