using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlinePWA.Library.Helpers
{
    public class RequestHelper<TProperty, TValue> 
    {
        private readonly Action action;
        private readonly Operation operation = default(Operation);
        private readonly TProperty property = default(TProperty);
        private readonly TValue value = default(TValue); 

        public RequestHelper(Action action, Operation operation = default(Operation), TProperty property = default(TProperty), TValue value = default(TValue))
        {
            this.action = action;
            this.operation = operation;
            this.property = property;
            this.value = value;
        }

        public enum Action
        {      
            filter,
            select,
            orderby,
            expand,
            limit,
            skip,
            count
        }

        /// <summary>
        /// Locgical operations for filtering reguest: And, Or, Equals, Not Equals, Grater Than,  Greater Than Or Equals, Less Than, Less Than Or Equals
        /// </summary>
        public enum Operation
        {
            /// <summary>
            /// And
            /// </summary>
            /// <example>
            /// <code>
            /// Field1 eq 'abc' and Field2 eq 'def'
            /// </code>
            /// </example>

            and = 1,

            /// <summary>
            /// Or
            /// </summary>
            /// <example>
            /// <code>
            /// Field1 eq 'abc' or Field1 eq 'def'
            /// </code>
            /// </example>
            or = 2,

            /// <summary>
            /// Equals
            /// </summary>
            /// <example>
            /// <code>
            /// BuyerEmailAddress eq 'first.last@example.com'
            /// </code>
            /// </example>
            eg = 3,

            /// <summary>
            /// Not Equals
            /// </summary>
            /// <example>
            /// <code>
            /// BuyerEmailAddress ne 'first.last@example.com'
            /// </code>
            /// </example>
            ne = 4,

            /// <summary>
            /// Greater Than
            /// </summary>
            /// <example>
            /// <code>
            /// CreatedDateUtc gt 2016-03-02
            /// </code>
            /// </example>
            gt = 5,

            /// <summary>
            /// Greater Than Or Equal
            /// </summary>
            /// <example>
            /// <code>
            /// CreatedDateUtc ge 2016-03-02 
            /// </code>
            /// </example>
            gte = 6,

            /// <summary>
            /// Less Than
            /// </summary>
            /// <example>
            /// <code>
            /// Quantity lt 1500
            /// </code>
            /// </example>
            lt = 7,

            /// <summary>
            /// Less Than Or Equal
            /// </summary>
            /// <example>
            /// <code>
            /// Quantity le 1500
            /// </code>
            /// </example>
            lte = 8
        }


    }
}
