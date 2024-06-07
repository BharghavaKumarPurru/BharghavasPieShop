
using Microsoft.EntityFrameworkCore;

namespace BharghavasPieShop.Models
{
    public class PieRepository:IPieRepository
    {
        private readonly BharghavasPieShopDbContext _bharghavasPieShopDbContext;

        public PieRepository(BharghavasPieShopDbContext bharghavasPieShopDbContext)
        {
            _bharghavasPieShopDbContext = bharghavasPieShopDbContext;
            
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _bharghavasPieShopDbContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _bharghavasPieShopDbContext.Pies.Include(c => c.Category).
                    Where(p=>p.IsPieOfTheWeek);

            }
        }
        public Pie? GetPieById(int pieId)
        {
            return _bharghavasPieShopDbContext.Pies.FirstOrDefault(p=>p.PieId==pieId);
        }

        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            return _bharghavasPieShopDbContext.Pies.Where(p => p.Name.Contains(searchQuery));
        }
    }
}
