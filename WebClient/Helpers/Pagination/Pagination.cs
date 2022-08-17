namespace WebClient.Helpers.Pagination;
public class Pagination
{
    public int Take { get; set; }
    public int Skip { get; set; }
    public int Count
    {
        get => count;
        set
        {
            if (count != value)
            {
                count = value;
                Page = 1;
            }
        }
    }
    public Pagination()
    {
        Take = 10;
        Page = 1;
    }
    public Pagination(int count, int skip, int take)
    {
        Count = count;
        Skip = skip;
        Take = take;
    }


    public int CurentPage { 
        get=>Skip / Take + 1;
        set =>Skip=(value-1) * Take;}



    public int totalPages()
    {
        return Count / Take + 1;
    }
    public bool hasNextPage()
    {
        return (Count - Skip - Take > 0);
    }
    public bool hasPreviusPage()
    {
        return ((Skip - Take) > 0);
    }
    private int page;
    private int count;

    public int Page
    {
        get { return Skip / Take + 1; }
        set
        {
            page = value;
            if (page > Count / Take)
            {
                page = Count / Take;
            }
            if (page < 1)
            {
                page = 1;
            }
            Skip = (page - 1) * Take;
        }
    }
}