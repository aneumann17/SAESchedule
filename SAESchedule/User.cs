

namespace SAESchedule
{

    /// <summary>
    /// The Amount of Money a User can make per hour * 10
    /// </summary>
    public enum SalaryType : byte
    {
        STARTER = 105,
        REGULAR = 125
    }

    /// <summary>
    /// A User is a Person which can have Shifts
    /// </summary>
    public sealed class User
    {

        /// <summary>
        /// The Users lastname
        /// </summary>
        public readonly string LastName;

        /// <summary>
        /// The Users given Name
        /// </summary>
        public readonly string GivenName;

        /// <summary>
        /// The Name used in the Shifts for the Infoscreen
        /// Example: Lukas is Lukas K because of Lukas Lambrecht
        /// </summary>
        public string ShiftID { get; private set; }

        /// <summary>
        /// The maximal amoutn of money the user wants to earn in one month
        /// </summary>
        public float MaxRevenue { get; private set; }

        /// <summary>
        /// The SalaryType of the User
        /// </summary>
        public SalaryType SalaryType { get; private set; }

        /// <summary>
        /// The Hourly Salary the User will get
        /// </summary>
        public float HourlySalary { get { return ((float)SalaryType) / 10.0f; } }

        public User(string _lastName, string _givenName, string _shiftID, float _maxRevenue, SalaryType _salaryType)
        {
            this.LastName = _lastName;
            this.GivenName = _givenName;
            this.ShiftID = _shiftID;
            this.MaxRevenue = _maxRevenue;
            this.SalaryType = _salaryType;
        }

        /// <summary>
        /// Changes the ShiftID of the
        /// </summary>
        /// <param name="_newShiftID"></param>
        /// <returns></returns>
        public void ChangeShiftID(string _newShiftID)
        {
            ShiftID = _newShiftID;
            // TODO: Probably change some things in the Calendar
        }

        /// <summary>
        /// Changes the max revenue for this user
        /// </summary>
        /// <param name="_newMaxRevenue"></param>
        public void ChangeMaxRevenue(float _newMaxRevenue)
        {
            MaxRevenue = _newMaxRevenue;
            // TODO: Recalc the shifts
        }

        /// <summary>
        /// Changes the Salary of the User
        /// </summary>
        /// <param name="_newSalaryType"></param>
        public void ChangeSalaryType(SalaryType _newSalaryType)
        {
            SalaryType = _newSalaryType;
            // TODO: Recalc shifts
        }

    }

}