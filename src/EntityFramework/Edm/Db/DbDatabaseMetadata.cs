// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.Edm.Db
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     Allows the construction and modification of a database in a Database Metadata model.
    /// </summary>
    [SuppressMessage("Microsoft.Maintainability", "CA1501:AvoidExcessiveInheritance")]
    public class DbDatabaseMetadata
        : DbAliasedMetadataItem
    {
        private readonly List<DbSchemaMetadata> schemasList = new List<DbSchemaMetadata>();

        internal override DbItemKind GetMetadataKind()
        {
            return DbItemKind.Database;
        }

        /// <summary>
        ///     Gets or sets an optional value that indicates the database model version.
        /// </summary>
        public virtual double Version { get; set; }

        /// <summary>
        ///     Gets or sets the collection of <see cref="DbSchemaMetadata" /> instances that specifies the schemas within the database.
        /// </summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual IList<DbSchemaMetadata> Schemas
        {
            get { return schemasList; }
        }
    }
}
