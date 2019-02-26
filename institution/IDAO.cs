using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace institution
{
    public interface IDAO
    {
        void Delete();
        void Insert();
        void Select();
        void Update();
    }
}