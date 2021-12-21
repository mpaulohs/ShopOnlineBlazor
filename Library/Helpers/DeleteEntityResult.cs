using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ShopOnlinePWA.Library
{
    public class DeleteEntityResult<TRes> : DeleteIEntityResult
    {
        public DeleteEntityResult(bool succeeded, TRes value = default)
        {
            ((DeleteIEntityResult)this).Succeeded = succeeded;

            if (value != null)
            {
                Value = value;
            }

        }

        public bool Succeeded { get => Succeeded; set => Succeeded = value; }


        public TRes Value { get; private set; }


        public static DeleteEntityResult<TRes> Success => new DeleteEntityResult<TRes>(true);
        public static DeleteEntityResult<Exception> Failed => new DeleteEntityResult<Exception>(false);



        public static DeleteEntityResult<TRes> GetSuccess(TRes value = default)
        {
            if (value != null)
            {
                return new DeleteEntityResult<TRes>(true, value);
            }
            return new DeleteEntityResult<TRes>(true);
        }

        public static DeleteIEntityResult GetFailed(params Exception[] exceptions)
        {
            if (exceptions != null)
            {
                return new DeleteEntityResult<List<Exception>>(false, exceptions.ToList<Exception>());
            }
            return new DeleteEntityResult<Exception>(false, null);
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} : {1}", ((DeleteIEntityResult)this).Succeeded, Value.ToString());
        }
    }

    //todo change chec to other generic
    public class EntityResult : DeleteEntityResult<string>
    {
        public EntityResult(bool succeeded, string value = null) : base(succeeded, value)
        {
        }
    }

}
