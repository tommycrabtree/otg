using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace api.DTOs
{
    public class CustomerBasketDTO
    {
        [Required]
        public string Id { get; set; }
        public List<BasketItemDTO> Items { get; set; }
    }
}