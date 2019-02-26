using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace institution
{
    public interface IDAO
    {
        int Delete();
        int Insert();
        int Select();
        int Update();
    }
}