using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Views.Pagination
{
    public class PaginationPagesMetaData
    {
        public int CurrentPage { get; private set; }
        public int TotalPages { get; private set; }
        public int Count { get; set; }
        public int PageSize { get; private set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;

        public PaginationPagesMetaData(int count, int curentPage, int pageSize)
        {
            if (count<0||curentPage<0||pageSize<=0||pageSize<1)
            {
                throw new ArgumentNullException();
            }

            Count = count;

            CurrentPage = curentPage;

            TotalPages =  (int)Math.Ceiling(count / (double)pageSize);

            PageSize = pageSize;

        }

    }
}
