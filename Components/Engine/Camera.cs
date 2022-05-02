using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_EngineV2.Components.Engine
{
    internal class Camera
    {
        int x;
        int y;
        int max_cell_Width;
        double angle_Each_Side;
        double angle_Left_Right_Fuck_You_I_Wont_Use_The_Term_X_Axis;
        double angle_Up_Down_Fuck_You_I_Wont_Use_The_Term_X_Axis;

        private Image Draw_World(World input_World,int camera_View)
        {
            Bitmap return_Image = new Bitmap(camera_View, camera_View);
            var front_Layer = input_World.Get_Next_Whatever_Layer(angle_Left_Right_Fuck_You_I_Wont_Use_The_Term_X_Axis ,x ,y);
            if(front_Layer == null)
            {
                return return_Image;
            }
            return return_Image;
        }
    }
}
