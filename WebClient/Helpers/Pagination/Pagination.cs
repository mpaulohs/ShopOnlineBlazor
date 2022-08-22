namespace WebClient.Helpers.Pagination;
public class Pagination
{
    public Pagination(int totalItems = default, int skip = 0, int take = 10, int[] range = default)
    {
        if (range == default)
        {
            this.Range = new[] { 5, 10, 20, 50 };
        }
        else
        {
            this.Range = range;
        }
        this.Skip = skip;
        this.Take = take;
        if (totalItems != default)
            this.TotalItems = totalItems;
        this.CurentPage = Skip / Take + 1;
    }

    private int take;
    public int Take {
        get { return take; }
        set {if (take!=value){
        take = value;
        CurentPage = 1;
    }
        }
    }
    public int Skip { get; set; }
    public int[] Range { get; set; }
    public int TotalPages()
    {
        return (int)Math.Ceiling((double)TotalItems / Take);
    }
    public bool HasNextPage()
    {
        return (CurentPage < TotalPages());
    }
    public bool HasPreviusPage()
    {
        return (CurentPage > 1);
    }
    private int curentPage;
    public int CurentPage
    {
        get { return curentPage; }
        set
        {
            curentPage = value;
            if (curentPage > TotalPages())
            {
                curentPage = TotalPages();
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
            }
        }
    }
}