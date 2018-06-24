using System.Collections.Generic;
using dotnet_core_web_app.Models;

namespace dotnet_core_web_app.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}