using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccNN.EpyllionChar
{
    class Head : Part
    {
        public Image EyeClosedImg = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"..\..\Resources\headEyesClosed.png");
        public Image EyeOpenImg = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"..\..\Resources\head.png");
    }
}
