using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESchedule
{
    class UserTimeSpanPreference
    {
        /// <summary>
        /// The User this Preference Belongs to
        /// </summary>
        public string m_User;

        /// <summary>
        /// The TimeSpan for which this Preference is made
        /// </summary>
        public DateTime m_Start;
        public DateTime m_End;

        /// <summary>
        /// The Preference for the given TimeSpan
        /// </summary>
        public Shift.UserShiftPreference m_Preference;
    }
}
