using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLDB.Data;
using QLDB.Model;

namespace QLDB.Controler
{
    class FixturesControl
    {
        FixturesDataAccess _fixturesData = new FixturesDataAccess();

        public void Insert(FixturesInfo info)
        {
            _fixturesData.Insert(info);
        }

        public void Update(FixturesInfo info)
        {
            _fixturesData.Update(info);
        }

        public void Delete(FixturesInfo info)
        {
            _fixturesData.Delete(info);
        }

        public void OpenConnect()
        {
            _fixturesData.FixturesConnect();
        }

        public void CloseConnect()
        {
            _fixturesData.FixturesClose();
        }
    }
}
