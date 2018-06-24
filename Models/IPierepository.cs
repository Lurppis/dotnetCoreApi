using System.Collections.Generic;

namespace dotnet_core_web_app.Models
{
    public interface IPierepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie getPieById(int id);
    }
}