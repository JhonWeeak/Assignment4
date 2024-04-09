using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models.Entities;

public partial class TransactionHistory
{
    [Key] // 设置为主键
    public int TransactionId { get; set; }

    public int AccountId { get; set; }

    public DateTime? TransactionDate { get; set; }

    public decimal? Amount { get; set; }

    public string? Description { get; set; }
}
