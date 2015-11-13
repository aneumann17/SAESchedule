using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESchedule
{
    class StaffPreferences
    {
        /// <summary>
        /// All currently saved preferences
        /// </summary>
        List<UserTimeSpanPreference> m_CurrentlyStoredPreferences;

        /// <summary>
        /// Initializes all SubComponents
        /// </summary>
        public StaffPreferences()
        {
            m_CurrentlyStoredPreferences = new List<UserTimeSpanPreference>();
        }

        /// <summary>
        /// Applies all Staff Preferences in the given month to the shifts within the Month
        /// </summary>
        /// <param name="p_Month"></param>
        public void ApplyPreferences( Month p_Month )
        {
            // Iterate over all Shifts
            foreach (Shift _Shift in p_Month.GetShifts())
            {
                // Iterate over all Preferenced Time Windows
                foreach (UserTimeSpanPreference _Pref in m_CurrentlyStoredPreferences)
                {
                    // Check if both overlap and Add the Preference to the Shift
                    if (_Shift.ContainsTimeSpan( _Pref.m_Start, _Pref.m_End ))
                    {
                        _Shift.possibleUsers.Add( new Shift.UserShift( _Pref.m_User, _Pref.m_Preference ) );
                    }
                }

                // TODO: Fill every other User with no Preferences with a Default Shift Preference
            }
        }

        /// <summary>
        /// Adds a new UserTimeSpanPreference
        /// </summary>
        /// <param name="p_Pref"></param>
        void AddUserTimeSpanPreference(UserTimeSpanPreference p_Pref)
        {
            m_CurrentlyStoredPreferences.Add( p_Pref );
        }

        /// <summary>
        /// Querys all UserTimeSpanPreferences for a given Day
        /// </summary>
        /// <returns></returns>
        List<UserTimeSpanPreference> GetPreferencesForDay(DateTime p_Day)
        {
            // Create Empty List of Preferences
            List<UserTimeSpanPreference> _Preferences;
            _Preferences = new List<UserTimeSpanPreference>();

            // Iterate over all Preferences
            foreach (UserTimeSpanPreference _Pref in m_CurrentlyStoredPreferences)
            {
                // Select only those with Matching Day and Month
                if (p_Day.Day == _Pref.m_Start.Day && p_Day.Month == _Pref.m_Start.Month)
                    _Preferences.Add( _Pref );
            }


            return _Preferences;
        }

        /// <summary>
        /// Loads all Staff Preferences
        /// </summary>
        /// <param name="_stream"></param>
        /// <returns></returns>
        public bool Load( Stream _stream )
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves all Staff Preferences
        /// </summary>
        /// <param name="_stream"></param>
        /// <returns></returns>
        public bool Save( Stream _stream )
        {
            throw new NotImplementedException();
        }

    }
}
