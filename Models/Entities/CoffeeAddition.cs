﻿using System;
using System.Collections.Generic;

namespace Models.Entities;

public class CoffeeAddition
{
    public Guid Id { get; set; }

    public Guid CustomCoffeeId { get; set; }

    public Guid AdditionId { get; set; }

    public virtual Addition Addition { get; set; } = null!;

    public virtual CustomCoffee CustomCoffee { get; set; } = null!;
}
