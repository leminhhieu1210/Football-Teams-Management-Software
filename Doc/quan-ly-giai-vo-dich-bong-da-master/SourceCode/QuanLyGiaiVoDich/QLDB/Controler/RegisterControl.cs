using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLDB.Data;
using QLDB.Model;

namespace QLDB.Controler
{
    class RegisterControl
    {
        RegisterDataAccess _registerData = new RegisterDataAccess();

        public void Insert(RegisterInfo info)
        {
            _registerData.Insert(info);
        }

        public void Update(RegisterInfo info)
        {
            _registerData.Update(info);
        }

        public void Delete(RegisterInfo info)
        {
            _registerData.Delete(info);
        }

        public void OpenConnect()
        {
            _registerData.RegisterConnect();
        }

        public void CloseConnect()
        {
            _registerData.RegisterClose();
        }
    }
}
