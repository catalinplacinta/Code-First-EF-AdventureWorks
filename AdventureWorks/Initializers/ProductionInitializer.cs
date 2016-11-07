namespace AdventureWorks.Initializers
{
    using System.Data.Entity;

    using AdventureWorks.Contexts;
    using AdventureWorks.Helpers;

    /// <summary>
    ///     The production initializer.
    /// </summary>
    public class ProductionInitializer : IDatabaseInitializer<ProductionContext>
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
        public void InitializeDatabase(ProductionContext context)
        {
            if (context.Database.Exists())
            {
                if (!context.Database.CompatibleWithModel(true))
                {
                    context.Database.Delete();

                    context.Database.Create();

                    SeedHelper.SeedProductionCatalogs(context);
                }
            }
            else
            {
                context.Database.Create();

                SeedHelper.SeedProductionCatalogs(context);
            }
        }
    }
}