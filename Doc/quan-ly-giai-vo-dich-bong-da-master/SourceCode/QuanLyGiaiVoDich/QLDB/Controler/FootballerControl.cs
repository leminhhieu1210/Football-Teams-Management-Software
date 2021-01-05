using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLDB.Data;
using QLDB.Model;

namespace QLDB.Controler
{
    class FootballerControl
    {
        FootballerDataAccess _footballerData = new FootballerDataAccess();

        public void Insert(FootballerInfo info)
        {
            _footballerData.Insert(info);
        }

        public void Update(FootballerInfo info)
        {
            _footballerData.Update(info);
        }

        public void Delete(FootballerInfo info)
        {
            _footballerData.Delete(info);
        }

        public void OpenConnect()
        {
            _footballerData.FootballerConnect();
        }

        public void CloseConnect()
        {
            _footballerData.FootballerClose();
        }
    }
}
