using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Structural.Composite.Component;

namespace DesignPattern.DP.Structural.Composite.Composite
{
    public class TeamLeader : IEmployee
    {
        public List<IEmployee> EmployeeList;
        public string Name { get; set; }
        public TeamLeader(string name)
        {
            Name = name;
            EmployeeList = new List<IEmployee> {this};
        }

        public void AddMember(IEmployee e)
        {
            if (e.GetType() == typeof(TeamLeader))
            {
                var teamLeaderMember = (TeamLeader) e;
                foreach (var member in teamLeaderMember.EmployeeList)
                {
                    EmployeeList.Add(member);

                }
            }
            else
            {
                EmployeeList.Add(e);
            }
            
        }

        public void RemoveMember(IEmployee e)
        {
            if (e.GetType() == typeof(TeamLeader))
            {
                var teamLeaderMember = (TeamLeader)e;
                foreach (var member in teamLeaderMember.EmployeeList)
                {
                    EmployeeList.Remove(member);

                }
            }
            else
            {
                EmployeeList.Remove(e);
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine(String.Format("Name: {0} - Role : -Lead",Name));
        }

        public void Show()
        {
            foreach (var Iemployee in EmployeeList)
            {
                Iemployee.PrintInfo();
            }
        }
    }
}
