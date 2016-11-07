namespace AdventureWorks.Contexts
{
    using System;
    using System.Data.Entity;
    using System.Data.SqlTypes;

    using AdventureWorks.Domain;

    /// <summary>
    /// The context.
    /// </summary>
    public abstract class Context : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Context"/> class.
        /// </summary>
        /// <param name="connectionString">
        /// The connection String.
        /// </param>
        protected Context(string connectionString) : base(connectionString)
        {
        }

        /// <summary>
        /// The save changes.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public override int SaveChanges()
        {
            this.UpdateDates();

            return base.SaveChanges();
        }

        /// <summary>
        /// The update dates.
        /// </summary>
        private void UpdateDates()
        {
            foreach (var change in this.ChangeTracker.Entries<Entity>())
            {
                var values = change.CurrentValues;

                foreach (var name in values.PropertyNames)
                {
                    var value = values[name];

                    if (value is DateTime)
                    {
                        var date = (DateTime)value;

                        if (date < SqlDateTime.MinValue.Value)
                        {
                            values[name] = SqlDateTime.MinValue.Value;
                        }
                        else if (date > SqlDateTime.MaxValue.Value)
                        {
                            values[name] = SqlDateTime.MaxValue.Value;
                        }
                    }
                }
            }
        }
    }
}
