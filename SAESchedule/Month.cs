using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESchedule
{

    [System.Serializable]
    public sealed class Month
    {

        public readonly int Year;

        public readonly int Month;

        /// <summary>
        /// all shifts in this month
        /// </summary>
        private List<Shift> shifts;

        public Month(int _year, int _month, ShiftSettings _settings)
        {
            Year = _year;
            Month = _month;
            shifts = new List<Shift>();

            GenerateShifts(_settings);
        }

        public List<Shift> GetShifts()
        {
            return shifts;
        }

        public void GenerateShifts(ShiftSettings _settings)
        {
            // clear the shifts in case the shifts are regenerated
            shifts.Clear();

            // for each day in the month
            for(int i = 0; i < DateTime.DaysInMonth(Year, Month); ++i)
            {
                // get the day
                DateTime day = new DateTime(Year, Month, i);

                // check if should be a shift on the day
                if (day.DayOfWeek == DayOfWeek.Sunday) { continue; }

                // iterate over all shifts for one day
                foreach(ShiftSettings.RequestedShift req in _settings.GetAllShifts())
                {
                    DateTime begin;
                    DateTime end;

                    // get the respective times
                    req.Set(day, out begin, out end);

                    // create a new shift and add it
                    shifts.Add(new Shift(null, req.Faculty, begin, end));
                }
            }
        }
    
    }

}