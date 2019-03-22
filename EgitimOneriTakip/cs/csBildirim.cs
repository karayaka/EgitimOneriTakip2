using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimOneriTakip.cs
{
    class csBildirim
    {

        public static void bildirim(string Baslik, string text)
        {
            Tulpep.NotificationWindow.PopupNotifier popupNotifier = new Tulpep.NotificationWindow.PopupNotifier
            {
                TitleText = Baslik,
                ContentText = text
            };

            popupNotifier.Popup();
        }

    }
}
