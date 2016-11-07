namespace AdventureWorks.Initializers
{
    using System.Data.Entity;

    using AdventureWorks.Helpers;

    /// <summary>
    ///     The adventure works initializer.
    /// </summary>
    public class AdventureWorksInitializer : IDatabaseInitializer<DbContext>
    {
        /// <summary>
        ///     The initialize database.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        public void InitializeDatabase(DbContext context)
        {
            if (context.Database.Exists())
            {
                if (!context.Database.CompatibleWithModel(true))
                {
                    context.Database.Delete();

                    context.Database.Create();

                    SeedHelper.SeedAdventureWorksCatalogs(context);
                }
            }
            else
            {
                context.Database.Create();

                SeedHelper.SeedAdventureWorksCatalogs(context);
            }
        }
    }
}