namespace Shared.Services.Request.Pagination
{

    public enum FilterOperator
    {
        empty,

        // Logical
        and,
        or,
        not,

        // Comparison
        eq, // Returns entries where the field is equal to the value.
        neq, // Returns entries where the field is not equal to the value.
        lt, // Returns entries where the field is lower than the value.
        lte, //Returns entries where the field is lower than or equal to the value.
        gt, // Returns entries where the field is greater than the value.
        gte, // Returns entries where the field is greater than or equal to the value.

        // String  
        ct, //  Returns entries where the field contains the value.
        nct, // Returns entries where the field does not contain the value.
        ev, //  Returns entries where the field ends with the value.
        nev, // Returns entries where the field does not end with the value.
        bw, //  Returns entries where the field begins with the value.
        nbw // Returns entries where the field does not begin with the value. 
    }
}
