namespace AdventureWorks.Initializers
{
    using System.Data.Entity;

    using AdventureWorks.Contexts;
    using AdventureWorks.Helpers;

    /// <summary>
    ///     The purchasing initializer.
    /// </summary>
    public class PurchasingInitializer : IDatabaseInitializer<PurchasingContext>
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
        public void InitializeDatabase(PurchasingContext context)
        {
            if (context.Database.Exists())
            {
                if (!context.Database.CompatibleWithModel(true))
                {
                    context.Database.Delete();

                    context.Database.Create();

                    SeedHelper.SeedPurchasingCatalogs(context);
                }
            }
            else
            {
                context.Database.Create();

                SeedHelper.SeedPurchasingCatalogs(context);
            }
        }
    }
}