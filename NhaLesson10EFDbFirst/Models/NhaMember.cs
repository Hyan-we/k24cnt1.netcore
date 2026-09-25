using System;
using System.Collections.Generic;

namespace NhaLesson10EFDbFirst.Models;

public partial class NhaMember
{
    public long Id { get; set; }

    public string? NhaUserName { get; set; }

    public string? NhaPassword { get; set; }

    public string? NhaFullName { get; set; }

    public string? NhaEmail { get; set; }

    public string? NhaPhone { get; set; }

    public bool? NhaStatus { get; set; }
}
