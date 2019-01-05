using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Landmarks34
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Title = "Достопримечательности города Волжский";

            //Добавление строк достопримечательностей
            CreateNewLandmarks("Волжская ГЭС", "volges.jpg");
            CreateNewLandmarks("Парк «Гидростроитель»", "gidr55.jpg");
            CreateNewLandmarks("Площадь и памятник Ленина", "plos155.jpg");
            CreateNewLandmarks("Военный мемориал", "been122.jpg");

            CreateNewLandmarks("Старая мельница", "volg999.jpg");
            CreateNewLandmarks("Картинная галерея «Старая школа»", "leer111.jpg");
            CreateNewLandmarks("Храм Иоанна Богослова", "bogosl155.jpg");
            CreateNewLandmarks("Памятник первому трамваю города Волжский", "peerv_tr.jpg");
            CreateNewLandmarks("Историко-краеведческий музей", "dr145.jpg");
            CreateNewLandmarks("Дом культуры «Октябрь»", "doom_kk.jpg");
            CreateNewLandmarks("Памятник первостроителям Сталинградской ГЭС и города Волжского", "vees2.jpg");
            CreateNewLandmarks("Выставочный зал имени Г.В.Черноскутова", "peels.jpg");
            CreateNewLandmarks("Драматический театр", "beels55.jpg");
            CreateNewLandmarks("Фонтанная улица", "fon286.jpg");
            CreateNewLandmarks("Мастерская скульптора Петра Лукича Малкова", "lveenger.jpg");
            CreateNewLandmarks("Аква-парк «21 век»", "akv199.jpg");


        }

        private async void ToCommonPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1(((Button)sender).AutomationId));
        }

        void CreateNewLandmarks(string name, string img)
        {
            //Создание грида и его размеров
            Grid grid = new Grid();
            grid.WidthRequest = 300;
            grid.HeightRequest = 200;

            //name+height добавление строк
            RowDefinition row160 = new RowDefinition();
            RowDefinition row40 = new RowDefinition();
            row160.Height = 160;
            row40.Height = 40;

            //Добавлние строк
            grid.RowDefinitions.Add(row160);
            grid.RowDefinitions.Add(row40);
            //Добавление колонок
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());

            //Создание картинки
            Image image = new Image();
            image.Source = img;
            image.Aspect = Aspect.AspectFill;

            //Позиция картинки
            Grid.SetColumnSpan(image, 2);
            Grid.SetRow(image, 0);

            //Создание кнопки
            Button btn = new Button();
            btn.Text = "Подробнее";
            btn.Clicked += ToCommonPage;
            btn.AutomationId = name;

            //Позиция кнопки
            Grid.SetColumn(btn, 1);
            Grid.SetRow(btn, 1);

            //Создание текста названия
            Label label = new Label();
            label.Text = name;

            //Позиция названия
            Grid.SetRow(label, 1);

            grid.Children.Add(image);
            grid.Children.Add(btn);
            grid.Children.Add(label);

            stackContent.Children.Add(grid);
        }
    }
}
