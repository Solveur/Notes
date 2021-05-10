using System;
using System.Collections;
using System.Windows.Forms;
using static Notes.User;

namespace Notes
{
    public static class Extentions
    {
        public static Rights ToRights(this object input)
        {
            switch(Convert.ToInt32(input))
            {
                case 0: 
                    return Rights.GuestRigths;
                case 1:
                    return Rights.UserRights;
                case 2:
                    return Rights.SpectatorRights;
                case 3:
                    return Rights.AdminRights;
                default: throw new Exception("Can't convert");
            }
        }
    }
}
