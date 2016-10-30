namespace AdventureWorks.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Reflection;

    using AdventureWorks.SeedData;

    /// <summary>
    /// The configuration.
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<AdventureWorksContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration"/> class.
        /// </summary>
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
        }

        /// <summary>
        /// The seed.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        protected override void Seed(AdventureWorksContext context)
        {
            var assembly = Assembly.GetExecutingAssembly();

            SeedHelper.SeedDepartment(context, assembly);

            SeedHelper.SeedEmployee(context, assembly);

            SeedHelper.SeedEmployeeDepartmentHistory(context, assembly);

            SeedHelper.SeedEmployeePayHistory(context, assembly);

            SeedHelper.SeedJobCandidate(context, assembly);

            SeedHelper.SeedShift(context, assembly);

            SeedHelper.SeedAddress(context, assembly);

            SeedHelper.SeedAddressType(context, assembly);

            SeedHelper.SeedBusinessEntity(context, assembly);

            SeedHelper.SeedBusinessEntityAddress(context, assembly);

            SeedHelper.SeedBusinessEntityContact(context, assembly);

            SeedHelper.SeedContactType(context, assembly);

            SeedHelper.SeedCountryRegion(context, assembly);

            SeedHelper.SeedEmailAddress(context, assembly);

            SeedHelper.SeedPassword(context, assembly);

            SeedHelper.SeedPerson(context, assembly);

            SeedHelper.SeedPersonPhone(context, assembly);

            SeedHelper.SeedPhoneNumberType(context, assembly);

            SeedHelper.SeedStateProvince(context, assembly);

            SeedHelper.SeedBillOfMaterials(context, assembly);

            SeedHelper.SeedCulture(context, assembly);

            SeedHelper.SeedIllustration(context, assembly);

            SeedHelper.SeedLocation(context, assembly);

            SeedHelper.SeedProduct(context, assembly);

            SeedHelper.SeedProductCategory(context, assembly);

            SeedHelper.SeedProductCostHistory(context, assembly);

            SeedHelper.SeedProductDescription(context, assembly);

            SeedHelper.SeedProductDocument(context, assembly);

            SeedHelper.SeedProductInventory(context, assembly);

            SeedHelper.SeedProductListPriceHistory(context, assembly);

            SeedHelper.SeedProductModel(context, assembly);

            SeedHelper.SeedProductModelIllustration(context, assembly);

            SeedHelper.SeedProductModelProductDescriptionCulture(context, assembly);

            SeedHelper.SeedProductPhoto(context, assembly);

            SeedHelper.SeedProductProductPhoto(context, assembly);

            SeedHelper.SeedProductReview(context, assembly);

            SeedHelper.SeedProductSubcategory(context, assembly);

            SeedHelper.SeedScrapReason(context, assembly);

            SeedHelper.SeedTransactionHistory(context, assembly);

            SeedHelper.SeedTransactionHistoryArchive(context, assembly);

            SeedHelper.SeedUnitMeasure(context, assembly);

            SeedHelper.SeedWorkOrder(context, assembly);

            SeedHelper.SeedWorkOrderRouting(context, assembly);

            SeedHelper.SeedProductVendor(context, assembly);

            SeedHelper.SeedPurchaseOrderDetail(context, assembly);

            SeedHelper.SeedPurchaseOrderHeader(context, assembly);

            SeedHelper.SeedShipMethod(context, assembly);

            SeedHelper.SeedVendor(context, assembly);

            SeedHelper.SeedCountryRegionCurrency(context, assembly);

            SeedHelper.SeedCreditCard(context, assembly);

            SeedHelper.SeedCurrency(context, assembly);

            SeedHelper.SeedCurrencyRate(context, assembly);

            SeedHelper.SeedCustomer(context, assembly);

            SeedHelper.SeedPersonCreditCard(context, assembly);

            SeedHelper.SeedSalesOrderDetail(context, assembly);

            SeedHelper.SeedSalesOrderHeader(context, assembly);

            SeedHelper.SeedSalesOrderHeaderSalesReason(context, assembly);

            SeedHelper.SeedSalesPerson(context, assembly);

            SeedHelper.SeedSalesPersonQuotaHistory(context, assembly);

            SeedHelper.SeedSalesReason(context, assembly);

            SeedHelper.SeedSalesTaxRate(context, assembly);

            SeedHelper.SeedSalesTerritory(context, assembly);

            SeedHelper.SeedSalesTerritoryHistory(context, assembly);

            SeedHelper.SeedShoppingCartItem(context, assembly);

            SeedHelper.SeedSpecialOffer(context, assembly);

            SeedHelper.SeedSpecialOfferProduct(context, assembly);

            SeedHelper.SeedStore(context, assembly);
        }
    }
}