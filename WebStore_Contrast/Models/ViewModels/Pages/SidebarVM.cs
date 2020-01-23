﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebStore_Contrast.Models.Data;

namespace WebStore_Contrast.Models.ViewModels.Pages
{
    public class SidebarVM
    {
        public SidebarVM()
        {
        }

        public SidebarVM(SidebarDTO row)
        {
            Id = row.Id;
            Body = row.Body;
        }

        public int Id { get; set; }
        public string Body { get; set; }
    }
}