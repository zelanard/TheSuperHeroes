namespace TheSuperHeroes.HeroClasses
{
    /// <summary>
    /// <c>Costume</c> models The super humans costume.
    /// </summary>
    internal class Costume
    {
        private string _name;
        private string _description;
        private Power[] _powers;

        #region Properties
        /// <summary>
        /// The name of the costume.<br/>
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// A description of the costume.
        /// </summary>
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        /// <summary>
        /// The powers of the costume.
        /// <para>
        /// <strong>Examples:</strong><br/>
        /// • Iron Mans power armours have their own powers, completely separate from Tony Stak.<br/>
        /// • The fantastic four's suites adapt to the powers of the heros.
        /// </para>
        /// </summary>
        internal Power[] Powers
        {
            get { return _powers; }
            set { _powers = value; }
        }
        #endregion
    }
}
