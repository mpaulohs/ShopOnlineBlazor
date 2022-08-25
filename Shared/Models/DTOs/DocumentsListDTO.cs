namespace Shared.Models.Dtos;

public class DocumentsListDTO<TKey>
    where TKey : IEquatable<TKey>
{
    public TKey Id { get; set; }
    public string? Number { get; set; }
    public DateTime DateTime { get; set; }
    public string DocumentType { get; set; }
    public string DocumentStatus { get; set; }
    public string Client { get; set; }
    public decimal DocumentAmount { get; set; }
    public string DocumentCurrency { get; set; }
    public string? Comment { get; set; }
}