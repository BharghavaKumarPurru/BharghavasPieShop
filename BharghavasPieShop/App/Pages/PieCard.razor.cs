using BharghavasPieShop.Models;
using Microsoft.AspNetCore.Components;

namespace BharghavasPieShop.App.Pages
{
    public partial class PieCard
    {
        [Parameter]
        public Pie? Pie { get; set; }
    }
}
