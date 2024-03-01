using AndroidX.Car.App;
using AndroidX.Car.App.Model;
using Javax.Xml.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeControl.Platforms.Android.Auto.Screens;

public class CarScreenMenu : Screen
{
    public CarScreenMenu(CarContext carContext) : base(carContext)
    {
    }

    public override ITemplate OnGetTemplate()
    {
        var itemList = new ItemList.Builder()
            .SetNoItemsMessage("YouTube Control is running!")
            .Build();

        return new ListTemplate.Builder()
            .SetTitle("YouTube Control - Menu")
            .SetSingleList(itemList)
            .Build();
    }
}