namespace AdventureWorks.Initializers
{
    using System.Data.Entity;

    using AdventureWorks.Contexts;
    using AdventureWorks.Helpers;

    /// <summary>
    ///     The human resources initializer.
    /// </summary>
    public class HumanResourcesInitializer : IDatabaseInitializer<HumanResourcesContext>
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
        public void InitializeDatabase(HumanResourcesContext context)
        {
            if (context.Database.Exists())
            {
                if (!context.Database.CompatibleWithModel(true))
                {
                    context.Database.Delete();

                    context.Database.Create();

                    SeedHelper.SeedHumanResourcesCatalogs(context);
                }
            }
            else
            {
                context.Database.Create();

                SeedHelper.SeedHumanResourcesCatalogs(context);
            }
        }
    }
}