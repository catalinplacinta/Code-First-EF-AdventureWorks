namespace AdventureWorks.Initializers
{
    using System.Data.Entity;

    using AdventureWorks.Contexts;
    using AdventureWorks.Helpers;

    /// <summary>
    ///     The person initializer.
    /// </summary>
    public class PersonInitializer : IDatabaseInitializer<PersonContext>
    {
        /// <summary>
        ///     The initialize database.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <exception cref="System.NotImplementedException">
        ///     The exception.
        /// </exception>
        public void InitializeDatabase(PersonContext context)
        {
            if (context.Database.Exists())
            {
                if (!context.Database.CompatibleWithModel(true))
                {
                    context.Database.Delete();

                    context.Database.Create();

                    SeedHelper.SeedPersonCatalogs(context);
                }
            }
            else
            {
                context.Database.Create();

                SeedHelper.SeedPersonCatalogs(context);
            }
        }
    }
}