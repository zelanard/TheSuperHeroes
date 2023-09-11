namespace TheSuperHeroes.HeroClasses
{
    /// <summary>
    /// <c>Power</c> models a super human ability or a powerful technology.
    /// <para>
    /// <strong>Examples:</strong><br/>
    /// • Spiderman's Webshooters are technological Powers<br/>
    /// • Magneto's Magnetic manipulation is a super human ability.
    /// </para>
    /// </summary>
    internal class Power
    {
        private string _name;
        private string _description;
        private int _powerLevel;
        private bool _inborn;

        /// <summary>
        /// The name of the power.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// A description of what the power can do at which power levels.
        /// </summary>
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        /// A number which determines how strong the power is.
        /// </summary>
        public int PowerLevel
        {
            get { return _powerLevel; }
            set { _powerLevel = value; }
        }

        /// <summary>
        /// A power which is not inborn, is technological.
        /// </summary>
        public bool Inborn
        {
            get { return _inborn; }
            set { _inborn = value; }
        }
    }
}