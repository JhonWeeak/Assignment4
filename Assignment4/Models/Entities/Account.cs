using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models.Entities;

public partial class Account
{
    [Key] // 设置为主键
    public int AccountId { get; set; }

    public string AccountType { get; set; }

    public int UserId { get; set; }

    public double? CurrentBalance { get; set; }

    public DateTime? DateCreated { get; set; }
}
