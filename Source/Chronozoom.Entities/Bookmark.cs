﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Outercurve Foundation">
//   Copyright (c) 2013, The Outercurve Foundation
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Chronozoom.Entities
{
    /// <summary>
    /// Specifies the type of bookmark.
    /// </summary>
    public enum BookmarkType
    {
        Timeline = 0,
        Exhibit = 1,
        ContentItem = 2,
    }

    /// <summary>
    /// Specifies a tour stop (can be either a timeline, an exhibit, or a content item).
    /// </summary>
    [DataContract(Name="BookMark")]
    public class Bookmark
    {
        /// <summary>
        /// The ID of the bookmark.
        /// </summary>
        [DataMember(Name="id")]
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the bookmark.
        /// </summary>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// The URL of the bookmark.
        /// </summary>
        /// <example>
        /// 
        /// </example>
        [DataMember(Name="url")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Justification="Uri not supported in entity framework.")]
        public string Url { get; set; }

        /// <summary>
        /// The type of reference for the bookmark.
        /// </summary>
        [DataMember(Name = "referenceType")]
        public BookmarkType ReferenceType { get; set; }

        /// <summary>
        /// The ID of the reference that is associated with the bookmark.
        /// </summary>
        [DataMember(Name = "referenceId")]
        public Guid ReferenceId { get; set; }

        /// <summary>
        /// The lapse time value for the bookmark.
        /// </summary>
        [DataMember(Name = "lapseTime")]
        public int? LapseTime { get; set; }

        /// <summary>
        /// A text description of the bookmark.
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}