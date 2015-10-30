using System;
using System.Collections.Generic;
using System.Linq;


namespace SAESchedule
{


    /// <summary>
    /// Contains all Settings for the shifts
    /// </summary>
    [System.Serializable]
    public sealed class ShiftSettings
    {

        /// <summary>
        /// Contains all Settings for a possible shift
        /// </summary>
        [System.Serializable]
        public sealed class RequestedShift
        {
            
            /// <summary>
            /// The Hour of day the shift should start
            /// </summary>
            public int beginHour;

            /// <summary>
            /// the hour of day the shift should end
            /// </summary>
            public int endHour;

            /// <summary>
            /// the faculty the shift is for
            /// </summary>
            public string Faculty;

            /// <summary>
            /// sets the given begin and end DateTimes to the reference dates day and the shifts time
            /// </summary>
            /// <param name="_date"></param>
            /// <param name="_begin"></param>
            /// <param name="_end"></param>
            public void Set(DateTime _date, out DateTime _begin, out DateTime _end)
            {
                _begin = new DateTime(_date.Year, _date.Month, _date.Day, beginHour, 0, 0);
                _end = new DateTime(_date.Year, _date.Month, _date.Day, endHour, 0, 0);
            }

            public RequestedShift()
            {
                beginHour = 0;
                endHour = 0;
                Faculty = "";
            }

            public RequestedShift(int _beginHour, int _endHour, string _faculty)
            {
                beginHour = _beginHour;
                endHour = _endHour;
                Faculty = _faculty;
            }

        }

        /// <summary>
        /// Contains all shifts for one day
        /// </summary>
        private List<RequestedShift> shiftsPerDay;

        public ShiftSettings()
        {
            
        }

        /// <summary>
        /// Returns all possible shifts for the given faculty
        /// </summary>
        /// <param name="_faculty"></param>
        /// <returns></returns>
        public IEnumerable<RequestedShift> GetAllShiftsForFaculty(string _faculty)
        {
            return shiftsPerDay.Where(m => m.Faculty == _faculty);
        }

        /// <summary>
        /// Returns all possible shifts
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RequestedShift> GetAllShifts()
        {
            return shiftsPerDay;
        }

    }

}