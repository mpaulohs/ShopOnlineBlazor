namespace Shared.Services.Request.Pagination;
public partial class Pagination
{
    public int Take { get; set; }
    public int Skip { get; set; }
    public int Count { get; set; }
    private int page;
    public int Page
    {
        get { return Skip / Take + 1; }
        set
        {
            page = value;
            if (page < 0)
            {
                page = 1;
            }
            else if (page > (Count / Take))
            {
                page = Count / Take;
            }
            Skip = (page - 1) * Take;
        }
    }


}