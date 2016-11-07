namespace AdventureWorks.Initializers
{
    using System.Data.Entity;

    using AdventureWorks.Contexts;
    using AdventureWorks.Helpers;

    /// <summary>
    ///     The sales initializer.
    /// </summary>
    public class SalesInitializer : IDatabaseInitializer<SalesContext>
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
        public void InitializeDatabase(SalesContext context)
        {
            if (context.Database.Exists())
            {
                if (!context.Database.CompatibleWithModel(true))
                {
                    context.Database.Delete();

                    context.Database.Create();

                    SeedHelper.SeedSalesCatalogs(context);
                }
            }
            else
            {
                context.Database.Create();

                SeedHelper.SeedSalesCatalogs(context);
            }
        }
    }
}