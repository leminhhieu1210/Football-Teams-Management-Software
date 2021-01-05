using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLDB.Data;
using QLDB.Model;

namespace QLDB.Controler
{
    class TeamControl
    {
        TeamDataAccess _teamData = new TeamDataAccess();

        public void Insert(TeamInfo info)
        {
            _teamData.Insert(info);
        }

        public void Update(TeamInfo info)
        {
            _teamData.Update(info);
        }

        public void Delete(TeamInfo info)
        {
            _teamData.Delete(info);
        }

        public void OpenConnect()
        {
            _teamData.TeamConnect();
        }

        public void CloseConnect()
        {
            _teamData.TeamClose();
        }
    }
}
