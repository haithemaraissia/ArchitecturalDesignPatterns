using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Structural.Facade.SubSystem;

namespace DesignPattern.DP.Structural.Facade
{
    public class Developer
    {
        private DevelopCode _developCode;
        private RepoSourceCode _repoSourceCode;
        private PushToQa _pushToQa;

        public Developer()
        {
            _developCode = new DevelopCode();
            _repoSourceCode = new RepoSourceCode();
            _pushToQa = new PushToQa();
        }


        public void WorkOnTask()
        {
            _repoSourceCode.GrabLatestCode();
            _developCode.Code();
        }


        public void SubmitToQA()
        {
            _pushToQa.PushCode();
        }
    }
}
