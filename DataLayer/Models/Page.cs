using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
   public class Page
    {
      public int CurrentPage { get; }
      public int PageSize { get; }
      public int Records { get; }
      public int TotalPages { get; }

        public Page(int currentPage, int pageSize, int records, int totalPages)
        {
            CurrentPage = currentPage;
            PageSize = pageSize;
            Records = records;
            TotalPages = totalPages;
        }
    }
}
