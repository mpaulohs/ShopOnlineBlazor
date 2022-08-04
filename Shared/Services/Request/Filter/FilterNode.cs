using System;

namespace Shared.Services.Request.Pagination
{
    public class FilterNode
    {
        public FilterNode()
        {
            CompositionOperator = FilterOperator.and;
        }

        private FilterOperator _compositionOperator;

        public FilterOperator CompositionOperator
        {
            get => _compositionOperator;
            set
            {
                if (value != FilterOperator.and && value != FilterOperator.or)
                    throw new ArgumentOutOfRangeException();

                _compositionOperator = value;
            }
        }

        public string FieldName { get; set; }
        public object Value { get; set; }
        public FilterOperator Operator { get; set; }

        // For demo purposes
        public override string ToString() => $"{CompositionOperator} {FieldName ?? "FieldName"} {Operator} {Value ?? "Value"}";
    }
}
