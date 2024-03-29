﻿namespace Shared.Services.Request.PaginationOld;

public class PaginationParameters
{
    const int maxPageSize = 50;
    public int curentPage { get; set; } = 1;
    private int _pageSize = 10;
    //public string? SearchTerm { get; set; }
    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = (value > maxPageSize) ? maxPageSize : value;
    }
}

