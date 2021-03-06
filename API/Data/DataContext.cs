using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Manager> Managers { get; set; }
        public DbSet<Elections> Elections { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Voter> Voters { get; set; }
        public DbSet<VoterPhoneInElections> VotersInElections { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<VotingArea> VotingAreas { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<ProblemNotes> ProblemNotes { get; set; }
    }
}