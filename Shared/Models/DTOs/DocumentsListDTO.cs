using System.ComponentModel.DataAnnotations;

namespace Shared.Models.Dtos;

public class DocumentsListDTO<TKey>
    where TKey : IEquatable<TKey>
{
    [Display(Name = "Id", Order = 1)]
    public TKey Id { get; set; }
    [Display(Name = "Date", AutoGenerateField = true, Order = 2)]
    [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
    public DateTime DateTime { get; set; }
    [Display(Name = "Number", AutoGenerateField = true, Order = 3)]
    public string? Number { get; set; }
    [Display(Name = "Type", AutoGenerateField = true, Order = 4)]
    public string DocumentType { get; set; }
    [Display(Name = "Status", AutoGenerateField = true, Order = 5)]
    public string DocumentStatus { get; set; }
    [Display(Name = "Client", AutoGenerateField = true, Order = 6)]
    public string Client { get; set; }
    [Display(Name = "Amount", AutoGenerateField = true, Order = 7)]
    public decimal DocumentAmount { get; set; }
    [Display(Name = "Currency", AutoGenerateField = true, Order = 8)]
    public string DocumentCurrency { get; set; }
    [Display(Name = "Comment", AutoGenerateField = true, Order = 9)]
    public string? Comment { get; set; }
}