namespace AdventureWorks.Migrations
{
    using System.Data.Entity.Migrations;

    using AdventureWorks.Contexts;
    using AdventureWorks.Helpers;

    /// <summary>
    ///     The configuration.
    /// </summary>
    public sealed class Configuration : DbMigrationsConfiguration<AdventureWorksContext>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Configuration" /> class.
        /// </summary>
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
        }

        /// <summary>
        ///     The seed.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        protected override void Seed(AdventureWorksContext context)
        {
            SeedHelper.SeedAdventureWorks(context);
        }
    }
}