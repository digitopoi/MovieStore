﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMovieStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Username { get; set; }
        [Required]
        [StringLength(160)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(160)]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        [RegularExpression(@"[A-Za-z0-9. %+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage ="Email doesn't look like a valid email address.")]
        public string Email { get; set; }
        public decimal Total { get; set; }
        //public List<OrderDetail> OrderDetails { get; set; }
    }
}