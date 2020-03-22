﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStore_Contrast.Models.Data;

namespace WebStore_Contrast.Models.ViewModels.Shop
{
    public class ProductVM
    {
        public ProductVM(){ }

        public ProductVM(ProductDTO row)
        {
            Id = row.Id;
            Name = row.Name;
            Short_desc = row.Short_desc;
            Body = row.Body;
            Price = row.Price;
            CategoryName = row.CategoryName;
            CategoryId = row.CategoryId;
            ImageName = row.ImageName;
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Short_desc { get; set; }
        [AllowHtml]
        public string Body { get; set; }
        public decimal Price { get; set; }
        [Required]
        [DisplayName("Category")]
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public string ImageName { get; set; }


        public IEnumerable<SelectListItem> Categories { get; set; }
        public IEnumerable<string> GalleryImages { get; set; }
    }
}