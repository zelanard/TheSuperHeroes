namespace TheSuperHeroes.HeroClasses
{
    /// <summary>
    ///  A <c>SuperHuman</c> models a person with super human abilities which is either a hero or a villain.
    /// </summary>
    internal class SuperHuman
    {
        private readonly string _name;
        private readonly string _secretIdentity;
        private readonly Power[] _powers;
        private readonly Costume _costume;
        private readonly Contact[] _contacts;
        private SuperHuman[] _sideKicks;
        private string[] _affiliations;
        private readonly string _codex;
        private SuperHuman _nemesis;
        private Weakness[] _weaknesses;

        #region Properties

        /// <summary>
        /// The given name of the super human.
        /// <para>
        /// <strong>Examples:</strong><br/>
        /// • Peter Parker,<br/>
        /// • Tony Stark
        /// </para>
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// The made up name of the super human.
        /// <para>
        /// <strong>Example:</strong><br/>
        /// • Spider Man,<br/>
        /// • Iron Man
        /// </para>
        /// </summary>
        public string SecretIdentity
        {
            get { return _secretIdentity; }
        }
        
        /// <summary>
        /// An array of the super humans's powers.
        /// </summary>
        public Power[] Powers
        {
            get { return _powers; }
        }
        
        /// <summary>
        /// The Super humans's costume.
        /// </summary>
        public Costume Costume
        {
            get { return _costume; }
        }
        
        /// <summary>
        /// A list of the super humans contacts.
        /// </summary>
        public Contact[] Contacts
        {
            get { return _contacts; }
        }

        /// <summary>
        /// A list of super humans who follow the super human.
        /// <para>
        /// <strong>Example:</strong><br/>
        /// • Hero.Batman: Sidekick.Robin,<br/>
        /// • Hero.Arrow: Sidekick.Overwatch
        /// </para>
        /// </summary>
        public SuperHuman[] SideKicks
        {
            get { return _sideKicks; }
        }

        /// <summary>
        /// A list of the super humans connections to organizations.
        /// </summary>
        public string[] Affiliations
        {
            get { return _affiliations; }
        }
        
        /// <summary>
        /// A description of the super humans morale codex, convictions, beliefs and ideals.
        /// </summary>
        public string Codex
        {
            get { return _codex; }
        }
        
        /// <summary>
        /// Another super human who oppose the super human.
        /// </summary>
        public SuperHuman Nemesis
        {
            get { return _nemesis; }
        }
        
        /// <summary>
        /// A list of the super humans weaknesses.
        /// </summary>
        public Weakness[] Weaknesses
        {
            get { return _weaknesses; }
        }
        
        #endregion
    }
}
