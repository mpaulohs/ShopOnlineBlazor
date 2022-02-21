using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Views.Pagination
{
    public class PaginationPagesMetaData
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalCount { get; set; }

        private int pageSize;

        public int PageSize
        {
            get { return pageSize; }
            set
            {
                pageSize = value;
                this.TotalPages =  (int)Math.Ceiling(this.TotalCount / (double)this.pageSize);
            }
        }

        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;

        public PaginationPagesMetaData(int count, int curentPage, int pageSize)
        {
            if (count<0||curentPage<0||pageSize<=0||pageSize<1)
            {
                throw new ArgumentNullException();
            }

            TotalCount = count;

            CurrentPage = curentPage;

            PageSize = pageSize;

            //  TotalPages =  (int)Math.Ceiling(this.TotalCount / (double)this.PageSize);



        }

        public static PaginationPagesMetaData ToPaginationPagesMetaData(PaginationEntitiesMetaData paginationEntitiesMetaData)
        {
            return new PaginationPagesMetaData(
                curentPage: paginationEntitiesMetaData.Offset/paginationEntitiesMetaData.Limit + 1,
                count: paginationEntitiesMetaData.Count,
                pageSize: paginationEntitiesMetaData.Limit
                );
        }

    }
}
