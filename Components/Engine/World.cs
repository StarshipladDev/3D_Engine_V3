using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_EngineV2.Components.Engine
{
    internal class World
    {
        Layer[,] world_Of_Cells;
        int maxDistance;

        public Layer Get_Next_Whatever_Layer(double rotation , int x, int y)
        {
            // We want to change our 'view' which will affect which 'layer' is in front based on whether the camera has moved 'fully 'to the left or right based on half of a full 360 view
            double quarterRotation= 45.0;
            if (rotation < quarterRotation && rotation > 360 - quarterRotation)
            {
                return world_Of_Cells[x,y-1];
            }
            else if (rotation < 90 - quarterRotation && rotation > 90 + quarterRotation)
            {
                return world_Of_Cells[x+1, y];
            }

            else if (rotation < 180 -quarterRotation && rotation > 180 + quarterRotation)
            {
                return world_Of_Cells[x, y+1];
            }

            else if (rotation < 270 - quarterRotation && rotation > 270 + quarterRotation)
            {
                return world_Of_Cells[x-1, y];
            }
            return null;
        }
    }
}
