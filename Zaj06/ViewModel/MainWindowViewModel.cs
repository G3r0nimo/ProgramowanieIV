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
                new NoticeViewModel {Tittle="Zrobic projekt", Description="Na zaliczenie z C#", When=DateTime.Now },
                new NoticeViewModel {Tittle="Tittle 2", Description="Cos tam...", When=DateTime.Now },
                new NoticeViewModel {Tittle="Tittle 3", Description="Cos tam 123", When=DateTime.Now },
            };
        }
    }
}
