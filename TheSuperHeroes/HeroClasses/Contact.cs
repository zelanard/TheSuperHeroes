namespace TheSuperHeroes.HeroClasses
{
    /// <summary>
    /// <c>Contact</c> models a person who is not a super human, but have a connection to the super human.
    /// </summary>
    internal class Contact
    {
        private string _name;
        private string _description;
        private Gender _gender;
        private string[] _affiliations;

        #region Properties
        /// <summary>
        /// The name of the contact.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// A description of the persons skills, abilities and why they are useful to the super human.
        /// </summary>
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        /// <summary>
        /// The persons Gender.
        /// </summary>
        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        /// <summary>
        /// A list of the contacts connections to organizations.
        /// </summary>
        public string[] Affiliations
        {
            get { return _affiliations; }
            set { _affiliations = value; }
        }
        #endregion
    }
    enum Gender
    {
        male,
        female
    }
}
