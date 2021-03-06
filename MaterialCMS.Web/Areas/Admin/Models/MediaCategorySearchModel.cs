﻿using System.ComponentModel;

namespace MaterialCMS.Web.Areas.Admin.Models
{
    public class MediaCategorySearchModel
    {
        public MediaCategorySearchModel()
        {
            Page = 1;
        }

        public int? Id { get; set; }
        public int Page { get; set; }

        [DisplayName("Search")]
        public string SearchText { get; set; }

        public MediaCategorySortMethod SortBy { get; set; }
    }
}