namespace WebClient.Helpers.Pagination;
public class Pagination
{
    public int Take { get; set; }
    public int Skip { get; set; }

    public Pagination(int totalItems = default, int skip = 0, int take = 10)
    {

        this.Skip = skip;
        this.Take = take;
        if (totalItems != default)
            this.TotalItems = totalItems;
        this.curentPage = Skip / Take + 1;
    }
    public int TotalPages()
    {
        return TotalItems / Take + 1;
    }
    public bool HasNextPage()
    {
        return (TotalItems - Skip - Take > 0);
    }
    public bool HasPreviusPage()
    {
        return ((Skip - Take) > 0);
    }
    private int curentPage;
    public int CurentPage
    {
        get { return curentPage; }
        set
        {
            curentPage = value;
            if (curentPage > TotalItems / Take)
            {
                curentPage = TotalItems / Take;
            }
            if (curentPage < 1)
            {
                curentPage = 1;
            }
            Skip = (curentPage - 1) * Take;
        }
    }
    private int totalItems;
    public int TotalItems
    {
        get => totalItems;
        set
        {
            if (totalItems != value)
            {
                totalItems = value;
                CurentPage = 1;
            }
        }
    }
}