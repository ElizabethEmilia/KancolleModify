﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KancolleModify
{
    class Constants
    {
        public const string ShipRelativePath = @"\kcs2\resources\ship\";
    }

    enum VertialDrawingLocation
    {
        Port, // 母港
        InBattle, // 战斗中 
        Map, // 海域地图中
        Exercise, // 演习
        Modernization, // 近代化改修
        Remodel, // 改造
    }
}
