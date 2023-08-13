﻿using AlifBank.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace AlifBank.DTO
{
    public class ItemDto
    {
        public abstract class Base
        {
            [Required]
            [MaxLength(64)]
            public string Name { get; set; }

            [MaxLength(1024)]
            public string Description { get; set; }

            [Required]
            public ProductType ProductType { get; set; }
        }

        public abstract class IdHasBase
        {
            public string Id { get; set; }
        }

        public class Add : Base { }
    }
}