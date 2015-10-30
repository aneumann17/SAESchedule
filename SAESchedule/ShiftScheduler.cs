using System;
using System.Collections.Generic;

namespace SAESchedule
{

    /// <summary>
    /// Responsible for calculating the shifts
    /// </summary>
    public static class ShiftScheduler
    {

        /// <summary>
        /// A List which contains all Users
        /// </summary>
        private static List<User> allUsers;

        /// <summary>
        /// A List which contains all Shifts
        /// </summary>
        private static List<Shift> allShifts;

        /// <summary>
        /// Static Constructor for initializing the class
        /// </summary>
        static ShiftScheduler()
        {
            allUsers = new List<User>();
            allShifts = null;
        }

        /// <summary>
        /// Loads all Settings from the specified file
        /// </summary>
        /// <param name="_file"></param>
        public static void Load(string _file)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves all Settings to the specified file
        /// </summary>
        /// <param name="_file"></param>
        public static void Save(string _file)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates the Shifts for the given settings
        /// </summary>
        public static void Calculate()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a list with all calculated shifts.
        /// Will throw an Exception, if called before the first shifts were calculated.
        /// </summary>
        /// <returns></returns>
        public static List<Shift> GetAllShifts()
        {
            // check if shifts were calculated
            if (allShifts == null)
                throw new InvalidOperationException("Shifts aren't calculated yet. First call Calculate before GetAllShifts.");

            // return the shifts
            return allShifts;
        }

    }

}