// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.Edm.Db.Mapping
{
    using System.Collections.Generic;
    using System.Data.Entity.Core.Metadata.Edm;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     Allows the construction and modification of a complete or partial mapping of an EDM entity type ( <see
    ///      cref="EntityType" /> ) or type hierarchy to a specific database table ( <see cref="DbTableMetadata" /> ).
    /// </summary>
    public class DbEntityTypeMapping
        : DbMappingMetadataItem
    {
        private readonly List<DbEntityTypeMappingFragment> typeMappingFragments =
            new List<DbEntityTypeMappingFragment>();

        internal override DbMappingItemKind GetItemKind()
        {
            return DbMappingItemKind.EntityTypeMapping;
        }

        /// <summary>
        ///     Gets or sets an <see cref="EntityType" /> value representing the entity type or hierarchy that is being mapped.
        /// </summary>
        public virtual EntityType EntityType { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this type mapping applies to <see cref="EntityType" /> and all its direct or indirect subtypes ( <code>true</code> ), or only to <see
        ///      cref="EntityType" /> ( <code>false</code> ).
        /// </summary>
        public virtual bool IsHierarchyMapping { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual IList<DbEntityTypeMappingFragment> TypeMappingFragments
        {
            get { return typeMappingFragments; }
        }
    }
}
