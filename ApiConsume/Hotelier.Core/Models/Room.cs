﻿using Hotelier.Core.Models.Abstracts;

namespace Hotelier.Core.Models;

public class Room : BaseEntity, IEntity
{
    public string CoverImage { get; set; }
    public string RoomNumber { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }
    public string BedCount { get; set; }
    public string BathCount { get; set; }
    public string Wifi { get; set; }
    
}
