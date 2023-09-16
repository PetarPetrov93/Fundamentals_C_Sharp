namespace _05.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            
            InitializeTeams(teams);
            JoinTeams(teams);

            PrintValidTeams(teams);

            PrintTeamsToDisband(teams);
            
        }
        static void InitializeTeams(List<Team> teams)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] teamArgs = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);

                string creator = teamArgs[0];
                string teamName = teamArgs[1];

                if (TeamAlreadyExists(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (AlreadyCreatedATeam(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team newTeam = new Team(teamName, creator);
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }

            }
        }
        static void JoinTeams(List<Team> teams)
        {
            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] cmdArgs = command.Split("->", StringSplitOptions.RemoveEmptyEntries);

                string user = cmdArgs[0];
                string teamName = cmdArgs[1];

                if (!TeamAlreadyExists(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (AlreadyAMemberOfATeam(teams, user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    Team teamToJoin = teams.First(x => x.Name == teamName);

                    teamToJoin.AddMember(user);
                }
            }
        }        
        static void PrintValidTeams (List<Team> teams)
        {
            List<Team> teamsWithMembers = teams.Where(x => x.Members.Count > 0).OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();

            foreach (Team team in teamsWithMembers.OrderBy(x => x))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (string member in team.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }
        static void PrintTeamsToDisband(List<Team> teams)
        {
            List<Team> teamsToDisband = teams.Where(x => x.Members.Count == 0).OrderBy(x => x.Name).ToList();

            Console.WriteLine("Teams to disband:");
            foreach (Team disbandedTeam in teamsToDisband)
            {
                Console.WriteLine($"{disbandedTeam.Name}");
            }
        }

        static bool TeamAlreadyExists(List<Team> teams, string teamName)
        {
            return teams.Any(x => x.Name == teamName);
        }

        static bool AlreadyCreatedATeam(List<Team> teams, string creator)
        {
            return teams.Any(x => x.Creator == creator);
        }

        static bool AlreadyAMemberOfATeam (List<Team> teams, string user)
        {
            return teams.Any(x => x.Members.Contains(user)) || teams.Any(x => x.Creator == user);
        }
    }
    public class Team
    {

        // Field - not quite sure what it does but probably declares that we are going to put some data in a list.. Also, from security stand point noone outside cannot touch or change it.
        private readonly List<string> members;

        //CONSTRUCTORS (getting the info from the Main method and transfer it to the properties)
        public Team(string name, string creator) 
        {
            this.Name = name;
            this.Creator = creator;

            this.members = new List<string>();
        }


        //Properties: 
        public string Name { get; private set; }

        public string Creator { get; private set; }


        // This property only returns the value of the Field (Get-only property)
        public List<string> Members => this.members;

        //Method

        public void AddMember(string memberName) 
        {
            this.members.Add(memberName);
        }
    }
}