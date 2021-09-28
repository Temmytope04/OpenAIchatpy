// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> An object representing the location and content of a table cell. </summary>
    public partial class DocumentTableCell
    {
        /// <summary> Initializes a new instance of DocumentTableCell. </summary>
        /// <param name="rowIndex"> Row index of the cell. </param>
        /// <param name="columnIndex"> Column index of the cell. </param>
        /// <param name="content"> Concatenated content of the table cell in reading order. </param>
        /// <param name="spans"> Location of the table cell in the reading order concatenated content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> or <paramref name="spans"/> is null. </exception>
        internal DocumentTableCell(int rowIndex, int columnIndex, string content, IEnumerable<DocumentSpan> spans)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }
            if (spans == null)
            {
                throw new ArgumentNullException(nameof(spans));
            }

            RowIndex = rowIndex;
            ColumnIndex = columnIndex;
            Content = content;
            BoundingRegions = new ChangeTrackingList<BoundingRegion>();
            Spans = spans.ToList();
        }

        /// <summary> Initializes a new instance of DocumentTableCell. </summary>
        /// <param name="kind"> Table cell kind. </param>
        /// <param name="rowIndex"> Row index of the cell. </param>
        /// <param name="columnIndex"> Column index of the cell. </param>
        /// <param name="rowSpan"> Number of rows spanned by this cell. </param>
        /// <param name="columnSpan"> Number of columns spanned by this cell. </param>
        /// <param name="content"> Concatenated content of the table cell in reading order. </param>
        /// <param name="boundingRegions"> Bounding regions covering the table cell. </param>
        /// <param name="spans"> Location of the table cell in the reading order concatenated content. </param>
        internal DocumentTableCell(DocumentTableCellKind? kind, int rowIndex, int columnIndex, int? rowSpan, int? columnSpan, string content, IReadOnlyList<BoundingRegion> boundingRegions, IReadOnlyList<DocumentSpan> spans)
        {
            Kind = kind;
            RowIndex = rowIndex;
            ColumnIndex = columnIndex;
            RowSpan = rowSpan;
            ColumnSpan = columnSpan;
            Content = content;
            BoundingRegions = boundingRegions;
            Spans = spans;
        }

        /// <summary> Table cell kind. </summary>
        public DocumentTableCellKind? Kind { get; }
        /// <summary> Row index of the cell. </summary>
        public int RowIndex { get; }
        /// <summary> Column index of the cell. </summary>
        public int ColumnIndex { get; }
        /// <summary> Number of rows spanned by this cell. </summary>
        public int? RowSpan { get; }
        /// <summary> Number of columns spanned by this cell. </summary>
        public int? ColumnSpan { get; }
        /// <summary> Concatenated content of the table cell in reading order. </summary>
        public string Content { get; }
        /// <summary> Bounding regions covering the table cell. </summary>
        public IReadOnlyList<BoundingRegion> BoundingRegions { get; }
        /// <summary> Location of the table cell in the reading order concatenated content. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
    }
}
