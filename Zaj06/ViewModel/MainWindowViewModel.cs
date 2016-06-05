using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaj06.ViewModel
{
    public class MainWindowViewModel
    {
        public List<NoticeViewModel> Notices { get; set; }
        public NoticeViewModel NoticeToAdd { get; set; }

        public MainWindowViewModel()
        {
            //komunikacja z bazą

            Notices = new List<NoticeViewModel>
            {
                new NoticeViewModel {Tittle="Zrobic projekt", Description="Na zaliczenie z C#", Created=DateTime.Now },
                new NoticeViewModel {Tittle="Tittle 2", Description="Cos tam...", Created=DateTime.Now },
                new NoticeViewModel {Tittle="Tittle 3", Description="Cos tam 123", Created=DateTime.Now },
            };
        }
    }
}
