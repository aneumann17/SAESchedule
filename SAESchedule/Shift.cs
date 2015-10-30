using System;
using System.Collections.Generic;


namespace SAESchedule
{

    public sealed class Shift
    {

        /// <summary>
        /// The User who will work
        /// </summary>
        public readonly string UserID;

        /// <summary>
        /// The Faculty of the Shift, e.g. Art, Prog, ...
        /// </summary>
        public readonly string ShiftFaculty;

        /// <summary>
        /// The Begin of the shift
        /// </summary>
        public readonly DateTime begin;

        /// <summary>
        /// The End of the shift
        /// </summary>
        public readonly DateTime end;

        /// <summary>
        /// The Time in hours the User is working
        /// </summary>
        public float Hours { get { return (end - begin).Hours; } }

        public Shift(string _userID, string _shiftFaculty, DateTime _begin, DateTime _end)
        {
            UserID = _userID;
            ShiftFaculty = _shiftFaculty;
            begin = _begin;
            end = _end;
        }

    }

}