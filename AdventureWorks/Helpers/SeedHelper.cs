namespace AdventureWorks.Helpers
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Transactions;
    using System.Xml.Linq;

    using AdventureWorks.Domain;

    using EntityFramework.BulkInsert.Extensions;

    using Ionic.Zip;

    /// <summary>
    ///     The seed helper.
    /// </summary>
    public static class SeedHelper
    {
        /// <summary>
        ///     The assembly.
        /// </summary>
        private static readonly Assembly Assembly;

        /// <summary>
        ///     Initializes static members of the <see cref="SeedHelper" /> class.
        /// </summary>
        static SeedHelper()
        {
            Assembly =
                Assembly.LoadFile(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\AdventureWorks.dll");
        }

        /// <summary>
        ///     The seed adventure works.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        public static void SeedAdventureWorks(DbContext context)
        {
            SeedDepartment(context, Assembly);

            SeedEmployee(context, Assembly);

            SeedEmployeeDepartmentHistory(context, Assembly);

            SeedEmployeePayHistory(context, Assembly);

            SeedJobCandidate(context, Assembly);

            SeedShift(context, Assembly);

            SeedAddress(context, Assembly);

            SeedAddressType(context, Assembly);

            SeedBusinessEntity(context, Assembly);

            SeedBusinessEntityAddress(context, Assembly);

            SeedBusinessEntityContact(context, Assembly);

            SeedContactType(context, Assembly);

            SeedCountryRegion(context, Assembly);

            SeedEmailAddress(context, Assembly);

            SeedPassword(context, Assembly);

            SeedPerson(context, Assembly);

            SeedPersonPhone(context, Assembly);

            SeedPhoneNumberType(context, Assembly);

            SeedStateProvince(context, Assembly);

            SeedBillOfMaterials(context, Assembly);

            SeedCulture(context, Assembly);

            SeedIllustration(context, Assembly);

            SeedLocation(context, Assembly);

            SeedProduct(context, Assembly);

            SeedProductCategory(context, Assembly);

            SeedProductCostHistory(context, Assembly);

            SeedProductDescription(context, Assembly);

            SeedProductDocument(context, Assembly);

            SeedProductInventory(context, Assembly);

            SeedProductListPriceHistory(context, Assembly);

            SeedProductModel(context, Assembly);

            SeedProductModelIllustration(context, Assembly);

            SeedProductModelProductDescriptionCulture(context, Assembly);

            SeedProductPhoto(context, Assembly);

            SeedProductProductPhoto(context, Assembly);

            SeedProductReview(context, Assembly);

            SeedProductSubcategory(context, Assembly);

            SeedScrapReason(context, Assembly);

            SeedTransactionHistory(context, Assembly);

            SeedTransactionHistoryArchive(context, Assembly);

            SeedUnitMeasure(context, Assembly);

            SeedWorkOrder(context, Assembly);

            SeedWorkOrderRouting(context, Assembly);

            SeedProductVendor(context, Assembly);

            SeedPurchaseOrderDetail(context, Assembly);

            SeedPurchaseOrderHeader(context, Assembly);

            SeedShipMethod(context, Assembly);

            SeedVendor(context, Assembly);

            SeedCountryRegionCurrency(context, Assembly);

            SeedCreditCard(context, Assembly);

            SeedCurrency(context, Assembly);

            SeedCurrencyRate(context, Assembly);

            SeedCustomer(context, Assembly);

            SeedPersonCreditCard(context, Assembly);

            SeedSalesOrderDetail(context, Assembly);

            SeedSalesOrderHeader(context, Assembly);

            SeedSalesOrderHeaderSalesReason(context, Assembly);

            SeedSalesPerson(context, Assembly);

            SeedSalesPersonQuotaHistory(context, Assembly);

            SeedSalesReason(context, Assembly);

            SeedSalesTaxRate(context, Assembly);

            SeedSalesTerritory(context, Assembly);

            SeedSalesTerritoryHistory(context, Assembly);

            SeedShoppingCartItem(context, Assembly);

            SeedSpecialOffer(context, Assembly);

            SeedSpecialOfferProduct(context, Assembly);

            SeedStore(context, Assembly);
        }

        /// <summary>
        ///     The seed adventure works catalogs.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        public static void SeedAdventureWorksCatalogs(DbContext context)
        {
            SeedJobCandidate(context, Assembly);

            SeedDepartment(context, Assembly);

            SeedShift(context, Assembly);

            SeedAddressType(context, Assembly);

            SeedContactType(context, Assembly);

            SeedCountryRegion(context, Assembly);

            SeedPhoneNumberType(context, Assembly);

            SeedStateProvince(context, Assembly);

            SeedCulture(context, Assembly);

            SeedProductCategory(context, Assembly);

            SeedProductSubcategory(context, Assembly);

            SeedScrapReason(context, Assembly);

            SeedUnitMeasure(context, Assembly);

            SeedShipMethod(context, Assembly);

            SeedCountryRegionCurrency(context, Assembly);

            SeedCurrency(context, Assembly);

            SeedSalesReason(context, Assembly);

            SeedSpecialOffer(context, Assembly);
        }

        /// <summary>
        ///     The seed human resources.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        public static void SeedHumanResources(DbContext context)
        {
            SeedDepartment(context, Assembly);

            SeedEmployee(context, Assembly);

            SeedEmployeeDepartmentHistory(context, Assembly);

            SeedEmployeePayHistory(context, Assembly);

            SeedJobCandidate(context, Assembly);

            SeedShift(context, Assembly);
        }

        /// <summary>
        ///     The seed human resources catalogs.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        public static void SeedHumanResourcesCatalogs(DbContext context)
        {
            SeedDepartment(context, Assembly);

            SeedShift(context, Assembly);
        }

        /// <summary>
        ///     The seed person.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        public static void SeedPerson(DbContext context)
        {
            SeedAddress(context, Assembly);

            SeedAddressType(context, Assembly);

            SeedBusinessEntity(context, Assembly);

            SeedBusinessEntityAddress(context, Assembly);

            SeedBusinessEntityContact(context, Assembly);

            SeedContactType(context, Assembly);

            SeedCountryRegion(context, Assembly);

            SeedEmailAddress(context, Assembly);

            SeedPassword(context, Assembly);

            SeedPerson(context, Assembly);

            SeedPersonPhone(context, Assembly);

            SeedPhoneNumberType(context, Assembly);

            SeedStateProvince(context, Assembly);
        }

        /// <summary>
        ///     The seed person catalogs.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        public static void SeedPersonCatalogs(DbContext context)
        {
            SeedAddressType(context, Assembly);

            SeedContactType(context, Assembly);

            SeedCountryRegion(context, Assembly);

            SeedPhoneNumberType(context, Assembly);

            SeedStateProvince(context, Assembly);
        }

        /// <summary>
        ///     The seed production.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        public static void SeedProduction(DbContext context)
        {
            SeedBillOfMaterials(context, Assembly);

            SeedCulture(context, Assembly);

            SeedIllustration(context, Assembly);

            SeedLocation(context, Assembly);

            SeedProduct(context, Assembly);

            SeedProductCategory(context, Assembly);

            SeedProductCostHistory(context, Assembly);

            SeedProductDescription(context, Assembly);

            SeedProductDocument(context, Assembly);

            SeedProductInventory(context, Assembly);

            SeedProductListPriceHistory(context, Assembly);

            SeedProductModel(context, Assembly);

            SeedProductModelIllustration(context, Assembly);

            SeedProductModelProductDescriptionCulture(context, Assembly);

            SeedProductPhoto(context, Assembly);

            SeedProductProductPhoto(context, Assembly);

            SeedProductReview(context, Assembly);

            SeedProductSubcategory(context, Assembly);

            SeedScrapReason(context, Assembly);

            SeedTransactionHistory(context, Assembly);

            SeedTransactionHistoryArchive(context, Assembly);

            SeedUnitMeasure(context, Assembly);

            SeedWorkOrder(context, Assembly);

            SeedWorkOrderRouting(context, Assembly);
        }

        /// <summary>
        ///     The seed production catalogs.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        public static void SeedProductionCatalogs(DbContext context)
        {
            SeedCulture(context, Assembly);

            SeedProductCategory(context, Assembly);

            SeedProductSubcategory(context, Assembly);

            SeedScrapReason(context, Assembly);

            SeedUnitMeasure(context, Assembly);
        }

        /// <summary>
        ///     The seed purchasing.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        public static void SeedPurchasing(DbContext context)
        {
            SeedProductVendor(context, Assembly);

            SeedPurchaseOrderDetail(context, Assembly);

            SeedPurchaseOrderHeader(context, Assembly);

            SeedShipMethod(context, Assembly);

            SeedVendor(context, Assembly);
        }

        /// <summary>
        ///     The seed purchasing catalogs.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        public static void SeedPurchasingCatalogs(DbContext context)
        {
            SeedShipMethod(context, Assembly);
        }

        /// <summary>
        ///     The seed sales.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        public static void SeedSales(DbContext context)
        {
            SeedCountryRegionCurrency(context, Assembly);

            SeedCreditCard(context, Assembly);

            SeedCurrency(context, Assembly);

            SeedCurrencyRate(context, Assembly);

            SeedCustomer(context, Assembly);

            SeedPersonCreditCard(context, Assembly);

            SeedSalesOrderDetail(context, Assembly);

            SeedSalesOrderHeader(context, Assembly);

            SeedSalesOrderHeaderSalesReason(context, Assembly);

            SeedSalesPerson(context, Assembly);

            SeedSalesPersonQuotaHistory(context, Assembly);

            SeedSalesReason(context, Assembly);

            SeedSalesTaxRate(context, Assembly);

            SeedSalesTerritory(context, Assembly);

            SeedSalesTerritoryHistory(context, Assembly);

            SeedShoppingCartItem(context, Assembly);

            SeedSpecialOffer(context, Assembly);

            SeedSpecialOfferProduct(context, Assembly);

            SeedStore(context, Assembly);
        }

        /// <summary>
        ///     The seed sales catalogs.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        public static void SeedSalesCatalogs(DbContext context)
        {
            SeedCountryRegionCurrency(context, Assembly);

            SeedCurrency(context, Assembly);

            SeedSalesReason(context, Assembly);

            SeedSpecialOffer(context, Assembly);
        }

        /// <summary>
        ///     The convert to null-able date time.
        /// </summary>
        /// <param name="element">
        ///     The element.
        /// </param>
        /// <returns>
        ///     The <see cref="T:System.Nullable{DateTime}" />.
        /// </returns>
        private static DateTime? ConvertToNullableDateTime(XElement element)
        {
            return string.IsNullOrEmpty(element?.Value) ? (DateTime?)null : Convert.ToDateTime(element.Value);
        }

        /// <summary>
        ///     The convert to null-able decimal.
        /// </summary>
        /// <param name="element">
        ///     The element.
        /// </param>
        /// <returns>
        ///     The <see cref="T:System.Nullable{decimal}" />.
        /// </returns>
        private static decimal? ConvertToNullableDecimal(XElement element)
        {
            return string.IsNullOrEmpty(element?.Value) ? (decimal?)null : Convert.ToDecimal(element.Value);
        }

        /// <summary>
        ///     The convert to null-able integer.
        /// </summary>
        /// <param name="element">
        ///     The element.
        /// </param>
        /// <returns>
        ///     The <see cref="T:System.Nullable{Int}" />.
        /// </returns>
        private static int? ConvertToNullableInt(XElement element)
        {
            return string.IsNullOrEmpty(element?.Value) ? (int?)null : Convert.ToInt32(element.Value);
        }

        /// <summary>
        ///     The convert to null-able short.
        /// </summary>
        /// <param name="element">
        ///     The element.
        /// </param>
        /// <returns>
        ///     The <see cref="T:System.Nullable{short}" />.
        /// </returns>
        private static short? ConvertToNullableShort(XElement element)
        {
            return string.IsNullOrEmpty(element?.Value) ? (short?)null : Convert.ToInt16(element.Value);
        }

        /// <summary>
        ///     The seed address.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedAddress(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.Address.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var addresses =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new Address
                                    {
                                        AddressID = Convert.ToInt32(element.Element("AddressID")?.Value),
                                        AddressLine1 = element.Element("AddressLine1")?.Value,
                                        AddressLine2 = element.Element("AddressLine2")?.Value,
                                        City = element.Element("City")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        PostalCode = element.Element("PostalCode")?.Value,
                                        SpatialLocation = DbGeography.FromText(element.Element("SpatialLocation")?.Value),
                                        StateProvinceID = Convert.ToInt32(element.Element("StateProvinceID")?.Value)
                                    })
                        .ToList();

                if ((addresses != null) && addresses.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(addresses);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed address type.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedAddressType(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.AddressType.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var addressTypes =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new AddressType
                                    {
                                        AddressTypeID = Convert.ToInt32(element.Element("AddressTypeID")?.Value),
                                        Name = element.Element("Name")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((addressTypes != null) & addressTypes.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(addressTypes);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed bill of materials.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedBillOfMaterials(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.BillOfMaterials.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var billOfMaterials =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new BillOfMaterial
                                    {
                                        BOMLevel = Convert.ToInt16(element.Element("BOMLevel")?.Value),
                                        BillOfMaterialsID = Convert.ToInt32(element.Element("BillOfMaterialsID")?.Value),
                                        ComponentID = Convert.ToInt32(element.Element("ComponentID")?.Value),
                                        EndDate = ConvertToNullableDateTime(element.Element("EndDate")),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        PerAssemblyQty = Convert.ToDecimal(element.Element("PerAssemblyQty")?.Value),
                                        ProductAssemblyID = ConvertToNullableInt(element.Element("ProductAssemblyID")),
                                        StartDate = Convert.ToDateTime(element.Element("StartDate")?.Value),
                                        UnitMeasureCode = element.Element("UnitMeasureCode")?.Value
                                    })
                        .ToList();

                if ((billOfMaterials != null) && billOfMaterials.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(billOfMaterials);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed business entity.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedBusinessEntity(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.BusinessEntity.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var businessEntities =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new BusinessEntity
                                    {
                                        BusinessEntityID = Convert.ToInt32(element.Element("BusinessEntityID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((businessEntities != null) && businessEntities.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(businessEntities);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed business entity address.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedBusinessEntityAddress(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.BusinessEntityAddress.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var businessEntityAddresses =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new BusinessEntityAddress
                                    {
                                        BusinessEntityID = Convert.ToInt32(element.Element("BusinessEntityID")?.Value),
                                        AddressTypeID = Convert.ToInt32(element.Element("AddressTypeID")?.Value),
                                        AddressID = Convert.ToInt32(element.Element("AddressID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((businessEntityAddresses != null) && businessEntityAddresses.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(businessEntityAddresses);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed business entity contact.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedBusinessEntityContact(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.BusinessEntityContact.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var businessEntityContacts =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new BusinessEntityContact
                                    {
                                        BusinessEntityID = Convert.ToInt32(element.Element("BusinessEntityID")?.Value),
                                        ContactTypeID = Convert.ToInt32(element.Element("ContactTypeID")?.Value),
                                        PersonID = Convert.ToInt32(element.Element("PersonID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((businessEntityContacts != null) && businessEntityContacts.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(businessEntityContacts);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed contact type.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedContactType(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.ContactType.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var contactTypes =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new ContactType
                                    {
                                        Name = element.Element("Name")?.Value,
                                        ContactTypeID = Convert.ToInt32(element.Element("ContactTypeID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((contactTypes != null) && contactTypes.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(contactTypes);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed country region.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedCountryRegion(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.CountryRegion.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var countryRegions =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new CountryRegion
                                    {
                                        Name = element.Element("Name")?.Value,
                                        CountryRegionCode = element.Element("CountryRegionCode")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((countryRegions != null) && countryRegions.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(countryRegions);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed country region currency.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedCountryRegionCurrency(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.CountryRegionCurrency.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var countryRegionCurrencies =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new CountryRegionCurrency
                                    {
                                        CountryRegionCode = element.Element("CountryRegionCode")?.Value,
                                        CurrencyCode = element.Element("CurrencyCode")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((countryRegionCurrencies != null) && countryRegionCurrencies.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(countryRegionCurrencies);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed credit card.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedCreditCard(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.CreditCard.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var creditCards =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new CreditCard
                                    {
                                        CardNumber = element.Element("CardNumber")?.Value,
                                        CardType = element.Element("CardType")?.Value,
                                        CreditCardID = Convert.ToInt32(element.Element("CreditCardID")?.Value),
                                        ExpMonth = Convert.ToByte(element.Element("ExpMonth")?.Value),
                                        ExpYear = Convert.ToInt16(element.Element("ExpYear")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((creditCards != null) && creditCards.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(creditCards);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed culture.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedCulture(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.Culture.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var cultures =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new Culture
                                    {
                                        Name = element.Element("Name")?.Value,
                                        CultureID = element.Element("CultureID")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((cultures != null) && cultures.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(cultures);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed currency.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedCurrency(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.Currency.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var currencies =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new Currency
                                    {
                                        Name = element.Element("Name")?.Value,
                                        CurrencyCode = element.Element("CurrencyCode")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((currencies != null) && currencies.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(currencies);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed currency rate.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedCurrencyRate(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.CurrencyRate.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var currencyRates =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new CurrencyRate
                                    {
                                        AverageRate = Convert.ToDecimal(element.Element("AverageRate")?.Value),
                                        CurrencyRateDate = Convert.ToDateTime(element.Element("CurrencyRateDate")?.Value),
                                        CurrencyRateID = Convert.ToInt32(element.Element("CurrencyRateID")?.Value),
                                        EndOfDayRate = Convert.ToDecimal(element.Element("EndOfDayRate")?.Value),
                                        FromCurrencyCode = element.Element("FromCurrencyCode")?.Value,
                                        ToCurrencyCode = element.Element("ToCurrencyCode")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((currencyRates != null) && currencyRates.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(currencyRates);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed customer.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedCustomer(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.Customer.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var customers =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new Customer
                                    {
                                        AccountNumber = element.Element("AccountNumber")?.Value,
                                        CustomerID = Convert.ToInt32(element.Element("CustomerID")?.Value),
                                        PersonID = ConvertToNullableInt(element.Element("PersonID")),
                                        StoreID = ConvertToNullableInt(element.Element("StoreID")),
                                        TerritoryID = ConvertToNullableInt(element.Element("TerritoryID")),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((customers != null) && customers.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(customers);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed department.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedDepartment(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.Department.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var departments =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new Department
                                    {
                                        DepartmentID = Convert.ToInt16(element.Element("DepartmentID")?.Value),
                                        Name = element.Element("Name")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        GroupName = element.Element("GroupName")?.Value
                                    })
                        .ToList();

                if ((departments != null) && departments.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(departments);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed email address.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedEmailAddress(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.EmailAddress.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var emailAddresses =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new EmailAddress
                                    {
                                        BusinessEntityID = Convert.ToInt32(element.Element("BusinessEntityID")?.Value),
                                        EmailAddressID = Convert.ToInt32(element.Element("EmailAddressID")?.Value),
                                        EmailAddress1 = element.Element("EmailAddress1")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((emailAddresses != null) && emailAddresses.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(emailAddresses);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed employee.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedEmployee(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.Employee.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var employees =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new Employee
                                    {
                                        BusinessEntityID = Convert.ToInt32(element.Element("BusinessEntityID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        BirthDate = Convert.ToDateTime(element.Element("BirthDate")?.Value),
                                        CurrentFlag = Convert.ToBoolean(element.Element("CurrentFlag")?.Value),
                                        Gender = element.Element("Gender")?.Value,
                                        HireDate = Convert.ToDateTime(element.Element("HireDate")?.Value),
                                        JobTitle = element.Element("JobTitle")?.Value,
                                        LoginID = element.Element("LoginID")?.Value,
                                        MaritalStatus = element.Element("MaritalStatus")?.Value,
                                        NationalIDNumber = element.Element("NationalIDNumber")?.Value,
                                        SalariedFlag = Convert.ToBoolean(element.Element("SalariedFlag")?.Value),
                                        SickLeaveHours = Convert.ToInt16(element.Element("SickLeaveHours")?.Value),
                                        VacationHours = Convert.ToInt16(element.Element("VacationHours")?.Value)
                                    })
                        .ToList();

                if ((employees != null) && employees.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(employees);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed employee department history.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedEmployeeDepartmentHistory(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.EmployeeDepartmentHistory.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var employeeDepartmentHistories =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new EmployeeDepartmentHistory
                                    {
                                        BusinessEntityID = Convert.ToInt32(element.Element("BusinessEntityID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        DepartmentID = Convert.ToInt16(element.Element("DepartmentID")?.Value),
                                        ShiftID = Convert.ToByte(element.Element("ShiftID")?.Value),
                                        StartDate = Convert.ToDateTime(element.Element("StartDate")?.Value),
                                        EndDate = ConvertToNullableDateTime(element.Element("EndDate"))
                                    })
                        .ToList();

                if ((employeeDepartmentHistories != null) && employeeDepartmentHistories.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(employeeDepartmentHistories);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed employee pay history.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedEmployeePayHistory(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.EmployeePayHistory.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var employeePayHistories =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new EmployeePayHistory
                                    {
                                        BusinessEntityID = Convert.ToInt32(element.Element("BusinessEntityID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        PayFrequency = Convert.ToByte(element.Element("PayFrequency")?.Value),
                                        Rate = Convert.ToDecimal(element.Element("Rate")?.Value),
                                        RateChangeDate = Convert.ToDateTime(element.Element("RateChangeDate")?.Value)
                                    })
                        .ToList();

                if ((employeePayHistories != null) && employeePayHistories.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(employeePayHistories);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed illustration.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedIllustration(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.Illustration.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var illustrations =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new Illustration
                                    {
                                        Diagram = element.Element("Diagram")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        IllustrationID = Convert.ToInt32(element.Element("IllustrationID")?.Value)
                                    })
                        .ToList();

                if ((illustrations != null) && illustrations.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(illustrations);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed job candidate.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedJobCandidate(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.JobCandidate.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var jobCandidates =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new JobCandidate
                                    {
                                        BusinessEntityID = ConvertToNullableInt(element.Element("BusinessEntityID")),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        JobCandidateID = Convert.ToInt32(element.Element("JobCandidateID")?.Value),
                                        Resume = element.Element("Resume")?.Value
                                    })
                        .ToList();

                if ((jobCandidates != null) && jobCandidates.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(jobCandidates);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed location.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedLocation(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.Location.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var locations =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new Location
                                    {
                                        Name = element.Element("Name")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        Availability = Convert.ToDecimal(element.Element("Availability")?.Value),
                                        CostRate = Convert.ToDecimal(element.Element("CostRate")?.Value),
                                        LocationID = Convert.ToInt16(element.Element("LocationID")?.Value)
                                    })
                        .ToList();

                if ((locations != null) && locations.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(locations);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed password.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedPassword(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.Password.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var passwords =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new Password
                                    {
                                        BusinessEntityID = Convert.ToInt32(element.Element("BusinessEntityID")?.Value),
                                        PasswordHash = element.Element("PasswordHash")?.Value,
                                        PasswordSalt = element.Element("PasswordSalt")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((passwords != null) && passwords.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(passwords);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed person.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedPerson(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.Person.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var persons =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new Person
                                    {
                                        BusinessEntityID = Convert.ToInt32(element.Element("BusinessEntityID")?.Value),
                                        AdditionalContactInfo = element.Element("AdditionalContactInfo")?.Value,
                                        Demographics = element.Element("Demographics")?.Value,
                                        EmailPromotion = Convert.ToInt32(element.Element("EmailPromotion")?.Value),
                                        FirstName = element.Element("FirstName")?.Value,
                                        LastName = element.Element("LastName")?.Value,
                                        MiddleName = element.Element("MiddleName")?.Value,
                                        NameStyle = Convert.ToBoolean(element.Element("NameStyle")?.Value),
                                        PersonType = element.Element("PersonType")?.Value,
                                        Suffix = element.Element("Suffix")?.Value,
                                        Title = element.Element("Title")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((persons != null) && persons.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(persons);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed person credit card.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedPersonCreditCard(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.PersonCreditCard.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var personCreditCards =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new PersonCreditCard
                                    {
                                        BusinessEntityID = Convert.ToInt32(element.Element("BusinessEntityID")?.Value),
                                        CreditCardID = Convert.ToInt32(element.Element("CreditCardID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((personCreditCards != null) && personCreditCards.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(personCreditCards);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed person phone.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedPersonPhone(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.PersonPhone.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var personPhones =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new PersonPhone
                                    {
                                        BusinessEntityID = Convert.ToInt32(element.Element("BusinessEntityID")?.Value),
                                        PhoneNumber = element.Element("PhoneNumber")?.Value,
                                        PhoneNumberTypeID = Convert.ToInt32(element.Element("PhoneNumberTypeID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((personPhones != null) && personPhones.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(personPhones);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed phone number type.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedPhoneNumberType(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.PhoneNumberType.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var phoneNumberTypes =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new PhoneNumberType
                                    {
                                        PhoneNumberTypeID = Convert.ToInt32(element.Element("PhoneNumberTypeID")?.Value),
                                        Name = element.Element("Name")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((phoneNumberTypes != null) && phoneNumberTypes.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(phoneNumberTypes);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed product.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedProduct(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.Product.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var products =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new Product
                                    {
                                        Name = element.Element("Name")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        Class = element.Element("Class")?.Value,
                                        Color = element.Element("Color")?.Value,
                                        DaysToManufacture = Convert.ToInt32(element.Element("DaysToManufacture")?.Value),
                                        FinishedGoodsFlag = Convert.ToBoolean(element.Element("FinishedGoodsFlag")?.Value),
                                        DiscontinuedDate = ConvertToNullableDateTime(element.Element("DiscontinuedDate")),
                                        ListPrice = Convert.ToDecimal(element.Element("ListPrice")?.Value),
                                        MakeFlag = Convert.ToBoolean(element.Element("MakeFlag")?.Value),
                                        ProductID = Convert.ToInt32(element.Element("ProductID")?.Value),
                                        ProductLine = element.Element("ProductLine")?.Value,
                                        ProductModelID = ConvertToNullableInt(element.Element("ProductModelID")),
                                        ProductNumber = element.Element("ProductNumber")?.Value,
                                        ProductSubcategoryID = ConvertToNullableInt(element.Element("ProductSubcategoryID")),
                                        ReorderPoint = Convert.ToInt16(element.Element("ReorderPoint")?.Value),
                                        SafetyStockLevel = Convert.ToInt16(element.Element("SafetyStockLevel")?.Value),
                                        SellEndDate = ConvertToNullableDateTime(element.Element("SellEndDate")),
                                        SellStartDate = Convert.ToDateTime(element.Element("SellStartDate")?.Value),
                                        Size = element.Element("Size")?.Value,
                                        SizeUnitMeasureCode = element.Element("SizeUnitMeasureCode")?.Value,
                                        StandardCost = Convert.ToDecimal(element.Element("StandardCost")?.Value),
                                        Style = element.Element("Style")?.Value,
                                        Weight = ConvertToNullableDecimal(element.Element("Weight")),
                                        WeightUnitMeasureCode = element.Element("WeightUnitMeasureCode")?.Value
                                    })
                        .ToList();

                if ((products != null) && products.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(products);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed product category.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedProductCategory(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.ProductCategory.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var productCategories =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new ProductCategory
                                    {
                                        Name = element.Element("Name")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        ProductCategoryID = Convert.ToInt32(element.Element("ProductCategoryID")?.Value)
                                    })
                        .ToList();

                if ((productCategories != null) && productCategories.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(productCategories);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed product cost history.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedProductCostHistory(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.ProductCostHistory.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var productCostHistories =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new ProductCostHistory
                                    {
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        StartDate = Convert.ToDateTime(element.Element("StartDate")?.Value),
                                        EndDate = ConvertToNullableDateTime(element.Element("EndDate")),
                                        StandardCost = Convert.ToDecimal(element.Element("StandardCost")?.Value),
                                        ProductID = Convert.ToInt32(element.Element("ProductID")?.Value)
                                    })
                        .ToList();

                if ((productCostHistories != null) && productCostHistories.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(productCostHistories);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed product description.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedProductDescription(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.ProductDescription.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var productDescriptions =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new ProductDescription
                                    {
                                        ProductDescriptionID =
                                            Convert.ToInt32(element.Element("ProductDescriptionID")?.Value),
                                        Description = element.Element("Description")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((productDescriptions != null) && productDescriptions.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(productDescriptions);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed product document.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedProductDocument(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.ProductDocument.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var productDocuments =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new ProductDocument
                                    {
                                        ProductID = Convert.ToInt32(element.Element("ProductID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((productDocuments != null) && productDocuments.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(productDocuments);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed product inventory.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedProductInventory(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.ProductInventory.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var productInventories =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new ProductInventory
                                    {
                                        ProductID = Convert.ToInt32(element.Element("ProductID")?.Value),
                                        Bin = Convert.ToByte(element.Element("Bin")?.Value),
                                        LocationID = Convert.ToInt16(element.Element("LocationID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        Quantity = Convert.ToInt16(element.Element("Quantity")?.Value),
                                        Shelf = element.Element("Shelf")?.Value
                                    })
                        .ToList();

                if ((productInventories != null) && productInventories.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(productInventories);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed product list price history.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedProductListPriceHistory(DbContext context, Assembly assembly)
        {
            using (
                var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.ProductListPriceHistory.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var productListPriceHistories =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new ProductListPriceHistory
                                    {
                                        ProductID = Convert.ToInt32(element.Element("ProductID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        StartDate = Convert.ToDateTime(element.Element("StartDate")?.Value),
                                        EndDate = ConvertToNullableDateTime(element.Element("EndDate")),
                                        ListPrice = Convert.ToDecimal(element.Element("ListPrice")?.Value)
                                    })
                        .ToList();

                if ((productListPriceHistories != null) && productListPriceHistories.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(productListPriceHistories);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed product model.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedProductModel(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.ProductModel.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var productModels =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new ProductModel
                                    {
                                        Name = element.Element("Name")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        ProductModelID = Convert.ToInt32(element.Element("ProductModelID")?.Value),
                                        CatalogDescription = element.Element("CatalogDescription")?.Value,
                                        Instructions = element.Element("Instructions")?.Value
                                    })
                        .ToList();

                if ((productModels != null) && productModels.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(productModels);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed product model illustration.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedProductModelIllustration(DbContext context, Assembly assembly)
        {
            using (
                var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.ProductModelIllustration.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var productModelIllustrations =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new ProductModelIllustration
                                    {
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        ProductModelID = Convert.ToInt32(element.Element("ProductModelID")?.Value),
                                        IllustrationID = Convert.ToInt32(element.Element("IllustrationID")?.Value)
                                    })
                        .ToList();

                if ((productModelIllustrations != null) && productModelIllustrations.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(productModelIllustrations);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed product model product description culture.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedProductModelProductDescriptionCulture(DbContext context, Assembly assembly)
        {
            using (
                var stream =
                    assembly.GetManifestResourceStream(
                        "AdventureWorks.SeedData.ProductModelProductDescriptionCulture.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var productModelProductDescriptionCultures =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new ProductModelProductDescriptionCulture
                                    {
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        ProductModelID = Convert.ToInt32(element.Element("ProductModelID")?.Value),
                                        CultureID = element.Element("CultureID")?.Value,
                                        ProductDescriptionID =
                                            Convert.ToInt32(element.Element("ProductDescriptionID")?.Value)
                                    })
                        .ToList();

                if ((productModelProductDescriptionCultures != null) && productModelProductDescriptionCultures.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(productModelProductDescriptionCultures);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed product photo.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedProductPhoto(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.ProductPhoto.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var productPhotos =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new ProductPhoto
                                    {
                                        LargePhoto = Encoding.UTF8.GetBytes(element.Element("LargePhoto")?.Value),
                                        LargePhotoFileName = element.Element("LargePhotoFileName")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        ProductPhotoID = Convert.ToInt32(element.Element("ProductPhotoID")?.Value),
                                        ThumbNailPhoto = Encoding.UTF8.GetBytes(element.Element("ThumbNailPhoto")?.Value),
                                        ThumbnailPhotoFileName = element.Element("ThumbnailPhotoFileName")?.Value
                                    })
                        .ToList();

                if ((productPhotos != null) && productPhotos.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(productPhotos);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed product product photo.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedProductProductPhoto(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.ProductProductPhoto.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var productProductPhotos =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new ProductProductPhoto
                                    {
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        ProductPhotoID = Convert.ToInt32(element.Element("ProductPhotoID")?.Value),
                                        ProductID = Convert.ToInt32(element.Element("ProductID")?.Value),
                                        Primary = Convert.ToBoolean(element.Element("Primary")?.Value)
                                    })
                        .ToList();

                if ((productProductPhotos != null) && productProductPhotos.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(productProductPhotos);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed product review.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedProductReview(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.ProductReview.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var productReviews =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new ProductReview
                                    {
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        ProductID = Convert.ToInt32(element.Element("ProductID")?.Value),
                                        EmailAddress = element.Element("EmailAddress")?.Value,
                                        Comments = element.Element("Comments")?.Value,
                                        ProductReviewID = Convert.ToInt32(element.Element("ProductReviewID")?.Value),
                                        Rating = Convert.ToInt32(element.Element("Rating")?.Value),
                                        ReviewDate = Convert.ToDateTime(element.Element("ReviewDate")?.Value),
                                        ReviewerName = element.Element("ReviewerName")?.Value
                                    })
                        .ToList();

                if ((productReviews != null) && productReviews.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(productReviews);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed product subcategory.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedProductSubcategory(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.ProductSubcategory.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var productSubcategories =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new ProductSubcategory
                                    {
                                        Name = element.Element("Name")?.Value,
                                        ProductCategoryID = Convert.ToInt32(element.Element("ProductCategoryID")?.Value),
                                        ProductSubcategoryID =
                                            Convert.ToInt32(element.Element("ProductSubcategoryID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((productSubcategories != null) && productSubcategories.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(productSubcategories);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed product vendor.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedProductVendor(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.ProductVendor.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var productVendors =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new ProductVendor
                                    {
                                        ProductID = Convert.ToInt32(element.Element("ProductID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        BusinessEntityID = Convert.ToInt32(element.Element("BusinessEntityID")?.Value),
                                        AverageLeadTime = Convert.ToInt32(element.Element("AverageLeadTime")?.Value),
                                        LastReceiptCost = ConvertToNullableDecimal(element.Element("LastReceiptCost")),
                                        LastReceiptDate = ConvertToNullableDateTime(element.Element("LastReceiptDate")),
                                        MaxOrderQty = Convert.ToInt32(element.Element("MaxOrderQty")?.Value),
                                        MinOrderQty = Convert.ToInt32(element.Element("MinOrderQty")?.Value),
                                        OnOrderQty = ConvertToNullableInt(element.Element("OnOrderQty")),
                                        StandardPrice = Convert.ToDecimal(element.Element("StandardPrice")?.Value),
                                        UnitMeasureCode = element.Element("UnitMeasureCode")?.Value
                                    })
                        .ToList();

                if ((productVendors != null) && productVendors.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(productVendors);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed purchase order detail.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedPurchaseOrderDetail(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.PurchaseOrderDetail.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var purchaseOrderDetails =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new PurchaseOrderDetail
                                    {
                                        ProductID = Convert.ToInt32(element.Element("ProductID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        DueDate = Convert.ToDateTime(element.Element("DueDate")?.Value),
                                        LineTotal = Convert.ToDecimal(element.Element("LineTotal")?.Value),
                                        OrderQty = Convert.ToInt16(element.Element("OrderQty")?.Value),
                                        PurchaseOrderDetailID =
                                            Convert.ToInt32(element.Element("PurchaseOrderDetailID")?.Value),
                                        PurchaseOrderID = Convert.ToInt32(element.Element("PurchaseOrderID")?.Value),
                                        ReceivedQty = Convert.ToDecimal(element.Element("ReceivedQty")?.Value),
                                        RejectedQty = Convert.ToDecimal(element.Element("RejectedQty")?.Value),
                                        StockedQty = Convert.ToDecimal(element.Element("StockedQty")?.Value),
                                        UnitPrice = Convert.ToDecimal(element.Element("UnitPrice")?.Value)
                                    })
                        .ToList();

                if ((purchaseOrderDetails != null) && purchaseOrderDetails.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(purchaseOrderDetails);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed purchase order header.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedPurchaseOrderHeader(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.PurchaseOrderHeader.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var purchaseOrderHeaders =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new PurchaseOrderHeader
                                    {
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        PurchaseOrderID = Convert.ToInt32(element.Element("PurchaseOrderID")?.Value),
                                        EmployeeID = Convert.ToInt32(element.Element("EmployeeID")?.Value),
                                        Freight = Convert.ToDecimal(element.Element("Freight")?.Value),
                                        OrderDate = Convert.ToDateTime(element.Element("OrderDate")?.Value),
                                        RevisionNumber = Convert.ToByte(element.Element("RevisionNumber")?.Value),
                                        ShipDate = ConvertToNullableDateTime(element.Element("ShipDate")),
                                        ShipMethodID = Convert.ToInt32(element.Element("ShipMethodID")?.Value),
                                        Status = Convert.ToByte(element.Element("Status")?.Value),
                                        SubTotal = Convert.ToDecimal(element.Element("SubTotal")?.Value),
                                        TaxAmt = Convert.ToDecimal(element.Element("TaxAmt")?.Value),
                                        TotalDue = Convert.ToDecimal(element.Element("TotalDue")?.Value),
                                        VendorID = Convert.ToInt32(element.Element("VendorID")?.Value)
                                    })
                        .ToList();

                if ((purchaseOrderHeaders != null) && purchaseOrderHeaders.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(purchaseOrderHeaders);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed sales order detail.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedSalesOrderDetail(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.SalesOrderDetail.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var salesOrderDetails =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new SalesOrderDetail
                                    {
                                        ProductID = Convert.ToInt32(element.Element("ProductID")?.Value),
                                        CarrierTrackingNumber = element.Element("CarrierTrackingNumber")?.Value,
                                        LineTotal = Convert.ToDecimal(element.Element("LineTotal")?.Value),
                                        OrderQty = Convert.ToInt16(element.Element("OrderQty")?.Value),
                                        SalesOrderDetailID = Convert.ToInt32(element.Element("SalesOrderDetailID")?.Value),
                                        SalesOrderID = Convert.ToInt32(element.Element("SalesOrderID")?.Value),
                                        SpecialOfferID = Convert.ToInt32(element.Element("SpecialOfferID")?.Value),
                                        UnitPrice = Convert.ToDecimal(element.Element("UnitPrice")?.Value),
                                        UnitPriceDiscount = Convert.ToDecimal(element.Element("UnitPriceDiscount")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((salesOrderDetails != null) && salesOrderDetails.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(salesOrderDetails);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed sales order header.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedSalesOrderHeader(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.SalesOrderHeader.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var salesOrderHeaders =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new SalesOrderHeader
                                    {
                                        SalesOrderID = Convert.ToInt32(element.Element("SalesOrderID")?.Value),
                                        AccountNumber = element.Element("AcountNumber")?.Value,
                                        BillToAddressID = Convert.ToInt32(element.Element("BillToAddressID")?.Value),
                                        Comment = element.Element("Comment")?.Value,
                                        CreditCardApprovalCode = element.Element("CreditCardApprovalCode")?.Value,
                                        CreditCardID = ConvertToNullableInt(element.Element("CreditCardID")),
                                        CurrencyRateID = ConvertToNullableInt(element.Element("CurrencyRateID")),
                                        CustomerID = Convert.ToInt32(element.Element("CustomerID")?.Value),
                                        DueDate = Convert.ToDateTime(element.Element("DueDate")?.Value),
                                        Freight = Convert.ToDecimal(element.Element("Freight")?.Value),
                                        OnlineOrderFlag = Convert.ToBoolean(element.Element("OnlinOrderFlag")?.Value),
                                        OrderDate = Convert.ToDateTime(element.Element("OrderDate")?.Value),
                                        PurchaseOrderNumber = element.Element("PurchaseOrderNumber")?.Value,
                                        RevisionNumber = Convert.ToByte(element.Element("RevisionNumber")?.Value),
                                        SalesOrderNumber = element.Element("SalesOrderNumber")?.Value,
                                        SalesPersonID = ConvertToNullableInt(element.Element("SalesPersonID")),
                                        ShipDate = ConvertToNullableDateTime(element.Element("ShipDate")),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        ShipMethodID = Convert.ToInt32(element.Element("ShipMethodID")?.Value),
                                        ShipToAddressID = Convert.ToInt32(element.Element("ShipToAdressID")?.Value),
                                        Status = Convert.ToByte(element.Element("Status")?.Value),
                                        SubTotal = Convert.ToDecimal(element.Element("SubTotal")?.Value),
                                        TaxAmt = Convert.ToDecimal(element.Element("TaxAmt")?.Value),
                                        TerritoryID = ConvertToNullableInt(element.Element("TerritoryID")),
                                        TotalDue = Convert.ToDecimal(element.Element("TotalDue")?.Value)
                                    })
                        .ToList();

                if ((salesOrderHeaders != null) && salesOrderHeaders.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(salesOrderHeaders);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed sales order header sales reason.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedSalesOrderHeaderSalesReason(DbContext context, Assembly assembly)
        {
            using (
                var stream =
                    assembly.GetManifestResourceStream("AdventureWorks.SeedData.SalesOrderHeaderSalesReason.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var salesOrderHeaderSalesReasons =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new SalesOrderHeaderSalesReason
                                    {
                                        SalesOrderID = Convert.ToInt32(element.Element("SalesOrderID")?.Value),
                                        SalesReasonID = Convert.ToInt32(element.Element("SalesReasonID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((salesOrderHeaderSalesReasons != null) && salesOrderHeaderSalesReasons.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(salesOrderHeaderSalesReasons);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed sales person.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedSalesPerson(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.SalesPerson.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var salesPersons =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new SalesPerson
                                    {
                                        BusinessEntityID = Convert.ToInt32(element.Element("BusinessEntityID")?.Value),
                                        TerritoryID = ConvertToNullableInt(element.Element("TerritoryID")),
                                        Bonus = Convert.ToDecimal(element.Element("Bonus")?.Value),
                                        CommissionPct = Convert.ToDecimal(element.Element("CommissionPct")?.Value),
                                        SalesLastYear = Convert.ToDecimal(element.Element("SalesLastYear")?.Value),
                                        SalesQuota = ConvertToNullableDecimal(element.Element("SalesQuota")),
                                        SalesYTD = Convert.ToDecimal(element.Element("SalesYTD")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((salesPersons != null) && salesPersons.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(salesPersons);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed sales person quota history.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedSalesPersonQuotaHistory(DbContext context, Assembly assembly)
        {
            using (
                var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.SalesPersonQuotaHistory.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var salesPersonQuotaHistories =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new SalesPersonQuotaHistory
                                    {
                                        BusinessEntityID = Convert.ToInt32(element.Element("BusinessEntityID")?.Value),
                                        SalesQuota = Convert.ToDecimal(element.Element("SalesQuota")?.Value),
                                        QuotaDate = Convert.ToDateTime(element.Element("QuotaDate")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((salesPersonQuotaHistories != null) && salesPersonQuotaHistories.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(salesPersonQuotaHistories);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed sales reason.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedSalesReason(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.SalesReason.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var salesReasons =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new SalesReason
                                    {
                                        Name = element.Element("Name")?.Value,
                                        ReasonType = element.Element("ReasonType")?.Value,
                                        SalesReasonID = Convert.ToInt32(element.Element("SalesReasonID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((salesReasons != null) && salesReasons.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(salesReasons);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed sales tax rate.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedSalesTaxRate(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.SalesTaxRate.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var salesTaxRates =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new SalesTaxRate
                                    {
                                        Name = element.Element("Name")?.Value,
                                        SalesTaxRateID = Convert.ToInt32(element.Element("SalesTaxRateID")?.Value),
                                        StateProvinceID = Convert.ToInt32(element.Element("StateProvinceID")?.Value),
                                        TaxRate = Convert.ToDecimal(element.Element("TaxRate")?.Value),
                                        TaxType = Convert.ToByte(element.Element("TaxType")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((salesTaxRates != null) && salesTaxRates.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(salesTaxRates);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed sales territory.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedSalesTerritory(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.SalesTerritory.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var salesTerritories =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new SalesTerritory
                                    {
                                        Name = element.Element("Name")?.Value,
                                        SalesYTD = Convert.ToDecimal(element.Element("SalesYTD")?.Value),
                                        CostLastYear = Convert.ToDecimal(element.Element("CostLastYear")?.Value),
                                        CostYTD = Convert.ToDecimal(element.Element("CostYTD")?.Value),
                                        CountryRegionCode = element.Element("CountryRegionCode")?.Value,
                                        Group = element.Element("Group")?.Value,
                                        SalesLastYear = Convert.ToDecimal(element.Element("SalesLastYear")?.Value),
                                        TerritoryID = Convert.ToInt32(element.Element("TerritoryID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((salesTerritories != null) && salesTerritories.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(salesTerritories);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed sales territory history.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedSalesTerritoryHistory(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.SalesTerritoryHistory.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var salesTerritoryHistories =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new SalesTerritoryHistory
                                    {
                                        BusinessEntityID = Convert.ToInt32(element.Element("BusinessEntityID")?.Value),
                                        StartDate = Convert.ToDateTime(element.Element("StartDate")?.Value),
                                        EndDate = ConvertToNullableDateTime(element.Element("EndDate")),
                                        TerritoryID = Convert.ToInt32(element.Element("TerritoryID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((salesTerritoryHistories != null) && salesTerritoryHistories.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(salesTerritoryHistories);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed scrap reason.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedScrapReason(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.ScrapReason.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var scrapReasons =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new ScrapReason
                                    {
                                        Name = element.Element("Name")?.Value,
                                        ScrapReasonID = Convert.ToInt16(element.Element("ScrapReasonID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((scrapReasons != null) && scrapReasons.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(scrapReasons);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed shift.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedShift(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.Shift.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var shifts =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new Shift
                                    {
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        ShiftID = Convert.ToByte(element.Element("ShiftID")?.Value),
                                        Name = element.Element("Name")?.Value,
                                        StartTime = TimeSpan.Parse(element.Element("StartTime")?.Value),
                                        EndTime = TimeSpan.Parse(element.Element("EndTime")?.Value)
                                    })
                        .ToList();

                if ((shifts != null) && shifts.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(shifts);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed ship method.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedShipMethod(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.ShipMethod.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var shipMethods =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new ShipMethod
                                    {
                                        ShipMethodID = Convert.ToInt32(element.Element("ShipMethodID")?.Value),
                                        Name = element.Element("Name")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        ShipBase = Convert.ToDecimal(element.Element("ShipBase")?.Value),
                                        ShipRate = Convert.ToDecimal(element.Element("ShipRate")?.Value)
                                    })
                        .ToList();

                if ((shipMethods != null) && shipMethods.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(shipMethods);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed shopping cart item.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedShoppingCartItem(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.ShoppingCartItem.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var shoppingCartItems =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new ShoppingCartItem
                                    {
                                        ProductID = Convert.ToInt32(element.Element("ProductID")?.Value),
                                        DateCreated = Convert.ToDateTime(element.Element("DateCreated")?.Value),
                                        Quantity = Convert.ToInt32(element.Element("Quantity")?.Value),
                                        ShoppingCartID = element.Element("ShoppingCartID")?.Value,
                                        ShoppingCartItemID = Convert.ToInt32(element.Element("ShoppingCartItemID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((shoppingCartItems != null) && shoppingCartItems.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(shoppingCartItems);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed special offer.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedSpecialOffer(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.SpecialOffer.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var specialOffers =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new SpecialOffer
                                    {
                                        StartDate = Convert.ToDateTime(element.Element("StartDate")?.Value),
                                        EndDate = Convert.ToDateTime(element.Element("EndDate")?.Value),
                                        Category = element.Element("Category")?.Value,
                                        Description = element.Element("Description")?.Value,
                                        DiscountPct = Convert.ToDecimal(element.Element("DiscountPct")?.Value),
                                        MaxQty = ConvertToNullableInt(element.Element("MaxQty")),
                                        MinQty = Convert.ToInt32(element.Element("MinQty")?.Value),
                                        SpecialOfferID = Convert.ToInt32(element.Element("SpecialOfferID")?.Value),
                                        Type = element.Element("Type")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((specialOffers != null) && specialOffers.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(specialOffers);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed special offer product.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedSpecialOfferProduct(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.SpecialOfferProduct.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var specialOfferProducts =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new SpecialOfferProduct
                                    {
                                        SpecialOfferID = Convert.ToInt32(element.Element("SpecialOfferID")?.Value),
                                        ProductID = Convert.ToInt32(element.Element("ProductID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((specialOfferProducts != null) && specialOfferProducts.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(specialOfferProducts);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed state province.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedStateProvince(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.StateProvince.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var stateProvinces =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new StateProvince
                                    {
                                        Name = element.Element("Name")?.Value,
                                        StateProvinceID = Convert.ToInt32(element.Element("StateProvinceID")?.Value),
                                        CountryRegionCode = element.Element("CountryRegionCode")?.Value,
                                        IsOnlyStateProvinceFlag =
                                            Convert.ToBoolean(element.Element("IsOnlyStateProvinceFlag")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        StateProvinceCode = element.Element("StateProvinceCode")?.Value,
                                        TerritoryID = Convert.ToInt32(element.Element("TerritoryID")?.Value)
                                    })
                        .ToList();

                if ((stateProvinces != null) && stateProvinces.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(stateProvinces);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed store.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedStore(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.Store.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var stores =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new Store
                                    {
                                        Name = element.Element("Name")?.Value,
                                        BusinessEntityID = Convert.ToInt32(element.Element("BusinessEntityID")?.Value),
                                        Demographics = element.Element("Demographics")?.Value,
                                        SalesPersonID = ConvertToNullableInt(element.Element("SalesPersonID")),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((stores != null) && stores.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(stores);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed transaction history.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedTransactionHistory(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.TransactionHistory.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var transactionHistories =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new TransactionHistory
                                    {
                                        ActualCost = Convert.ToDecimal(element.Element("ActualCost")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        ProductID = Convert.ToInt32(element.Element("ProductID")?.Value),
                                        Quantity = Convert.ToInt32(element.Element("Quantity")?.Value),
                                        ReferenceOrderID = Convert.ToInt32(element.Element("ReferenceOrderID")?.Value),
                                        ReferenceOrderLineID =
                                            Convert.ToInt32(element.Element("ReferenceOrderLineID")?.Value),
                                        TransactionDate = Convert.ToDateTime(element.Element("TransactionDate")?.Value),
                                        TransactionID = Convert.ToInt32(element.Element("TransactionID")?.Value),
                                        TransactionType = element.Element("TransactionType")?.Value
                                    })
                        .ToList();

                if ((transactionHistories != null) && transactionHistories.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(transactionHistories);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed transaction history archive.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedTransactionHistoryArchive(DbContext context, Assembly assembly)
        {
            using (
                var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.TransactionHistoryArchive.zip")
            )
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var transactionHistoryArchives =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new TransactionHistoryArchive
                                    {
                                        ActualCost = Convert.ToDecimal(element.Element("ActualCost")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        ProductID = Convert.ToInt32(element.Element("ProductID")?.Value),
                                        Quantity = Convert.ToInt32(element.Element("Quantity")?.Value),
                                        ReferenceOrderID = Convert.ToInt32(element.Element("ReferenceOrderID")?.Value),
                                        ReferenceOrderLineID =
                                            Convert.ToInt32(element.Element("ReferenceOrderLineID")?.Value),
                                        TransactionDate = Convert.ToDateTime(element.Element("TransactionDate")?.Value),
                                        TransactionID = Convert.ToInt32(element.Element("TransactionID")?.Value),
                                        TransactionType = element.Element("TransactionType")?.Value
                                    })
                        .ToList();

                if ((transactionHistoryArchives != null) && transactionHistoryArchives.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(transactionHistoryArchives);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed unit measure.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedUnitMeasure(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.UnitMeasure.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var unitMeasures =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new UnitMeasure
                                    {
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        Name = element.Element("Name")?.Value,
                                        UnitMeasureCode = element.Element("UnitMeasureCode")?.Value
                                    })
                        .ToList();

                if ((unitMeasures != null) && unitMeasures.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(unitMeasures);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed vendor.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedVendor(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.Vendor.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var vendors =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new Vendor
                                    {
                                        BusinessEntityID = Convert.ToInt32(element.Element("BusinessEntityID")?.Value),
                                        Name = element.Element("Name")?.Value,
                                        AccountNumber = element.Element("AccountNumber")?.Value,
                                        ActiveFlag = Convert.ToBoolean(element.Element("ActiveFlag")?.Value),
                                        CreditRating = Convert.ToByte(element.Element("CreditRating")?.Value),
                                        PreferredVendorStatus =
                                            Convert.ToBoolean(element.Element("PreferredVendorStatus")?.Value),
                                        PurchasingWebServiceURL = element.Element("PurchasingWebServiceURL")?.Value,
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value)
                                    })
                        .ToList();

                if ((vendors != null) && vendors.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(vendors);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed work order.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedWorkOrder(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.WorkOrder.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var workOrders =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new WorkOrder
                                    {
                                        ProductID = Convert.ToInt32(element.Element("ProductID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        StartDate = Convert.ToDateTime(element.Element("StartDate")?.Value),
                                        EndDate = ConvertToNullableDateTime(element.Element("EndDate")),
                                        DueDate = Convert.ToDateTime(element.Element("DueDate")?.Value),
                                        OrderQty = Convert.ToInt32(element.Element("OrderQty")?.Value),
                                        ScrapReasonID = ConvertToNullableShort(element.Element("ScrapReasonID")),
                                        ScrappedQty = Convert.ToInt16(element.Element("ScrappedQty")?.Value),
                                        StockedQty = Convert.ToInt32(element.Element("StockedQty")?.Value),
                                        WorkOrderID = Convert.ToInt32(element.Element("WorkOrderID")?.Value)
                                    })
                        .ToList();

                if ((workOrders != null) && workOrders.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(workOrders);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }

        /// <summary>
        ///     The seed work order routing.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <param name="assembly">
        ///     The assembly.
        /// </param>
        private static void SeedWorkOrderRouting(DbContext context, Assembly assembly)
        {
            using (var stream = assembly.GetManifestResourceStream("AdventureWorks.SeedData.WorkOrderRouting.zip"))
            {
                var zipFile = ZipFile.Read(stream);

                var streamReader = new StreamReader(zipFile.Entries.Single().OpenReader());

                var document = XDocument.Parse(streamReader.ReadToEnd());

                var workOrderRoutings =
                    document.Root?.Elements()
                        .Select(
                            element =>
                                new WorkOrderRouting
                                    {
                                        ProductID = Convert.ToInt32(element.Element("ProductID")?.Value),
                                        ModifiedDate = Convert.ToDateTime(element.Element("ModifiedDate")?.Value),
                                        WorkOrderID = Convert.ToInt32(element.Element("WorkOrderID")?.Value),
                                        ActualCost = ConvertToNullableDecimal(element.Element("ActualCost")),
                                        ActualEndDate = ConvertToNullableDateTime(element.Element("ActualEndDate")),
                                        ActualResourceHrs = ConvertToNullableDecimal(element.Element("ActualResourceHrs")),
                                        ActualStartDate = ConvertToNullableDateTime(element.Element("ActualStartDate")),
                                        LocationID = Convert.ToInt16(element.Element("LocationID")?.Value),
                                        OperationSequence = Convert.ToInt16(element.Element("OperationSequence")?.Value),
                                        PlannedCost = Convert.ToDecimal(element.Element("PlannedCost")?.Value),
                                        ScheduledEndDate = Convert.ToDateTime(element.Element("ScheduledEndDate")?.Value),
                                        ScheduledStartDate =
                                            Convert.ToDateTime(element.Element("ScheduledStartDate")?.Value)
                                    })
                        .ToList();

                if ((workOrderRoutings != null) && workOrderRoutings.Any())
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        context.BulkInsert(workOrderRoutings);

                        context.SaveChanges();

                        transactionScope.Complete();
                    }
                }
            }
        }
    }
}