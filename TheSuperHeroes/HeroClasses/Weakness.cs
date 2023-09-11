namespace TheSuperHeroes.HeroClasses
{
    /// <summary>
    /// A <c>Weakness</c> models characterflaws and other detrimental attributes of the Super Human.
    /// </summary>
    internal class Weakness
    {
        private string _name;
        private string _description;

        /// <summary>
        /// The Name of the weakness
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// A description of the weakness.
        /// </summary>
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
