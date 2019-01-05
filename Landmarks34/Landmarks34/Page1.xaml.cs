using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Landmarks34
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        public string image;
        public string namePage;
        public string description;
        public string search;

        public Page1()
        {
            InitializeComponent();
        }

		public Page1 (string name)
		{
            Title = name; //Название страницы
            SwitchInfo(name); // Заполнение контентом
            ConstructPage(); // Конструктор страницы
        }

        private async void BackButton_Click(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        void AddInfo()
        {
            ImagePage.Source = image;
            NamePage.Text = namePage;
            ContentPage.Text = description;
        }
        //Создание конструктора (дизайна) страницы
        void ConstructPage()
        {
            ScrollView scroll = new ScrollView(); //Скрол

            //ЧТО-ТО НОВОЕ
            Button btnYandex = new Button();
            btnYandex.Text = "Яндекс Карты";
            btnYandex.Clicked += BtnYandex_Clicked;

            //Стак для контента
            StackLayout stackContent = new StackLayout();
            stackContent.Margin = new Thickness(20,0,20,0);

            //Картинка
            Image img = new Image();
            img.Source = image;
            img.Aspect = Aspect.AspectFill;

            //Название страницы
            Label namePageConstruct = new Label();
            namePageConstruct.Text = namePage;
            namePageConstruct.FontSize = 22;
            namePageConstruct.FontAttributes = FontAttributes.Bold;

            //Описание достопримечательности
            Label contentPageConstruct = new Label();
            contentPageConstruct.Text = description;
            contentPageConstruct.FontSize = 16;

            stackContent.Children.Add(img);
            stackContent.Children.Add(namePageConstruct);
            stackContent.Children.Add(contentPageConstruct);
            stackContent.Children.Add(btnYandex);

            scroll.Content = stackContent;

            this.Content = scroll;

        }

        private void BtnYandex_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri(search));
        }

        void SwitchInfo(string name)
        {
            namePage = name;
            switch(name){
                case "Волжская ГЭС":
                    image = "volges.jpg";
                    search = "https://yandex.ru/maps/-/CBRFAJUG3C";
                    description = "Больше всего гостей и жителей города привлекает самая известная и посещаемая достопримечательность — это действующая гидроэлектростанция (ГЭС), " +
                        "строительство которой было завершено в 1961 году. На данный момент она обеспечивает электрической энергией Центральный и Западный округ России.Построенная " +
                        "в те годы плотина полностью перегораживает Волгу, над плотиной построены железнодорожный и автомобильный переезды, соединяющие два берега реки.Строительство " +
                        "было очень масштабным, длилось оно около 11 лет.В настоящее время проводятся ограниченные групповые экскурсии для желающих.Для этого необходимо заранее подать " +
                        "заявку. А сам сброс воды можно увидеть при желании каждому самостоятельно.";
                    break;
                case "Парк Гидростроитель":
                    image = "gidr55.jpg";
                    search = "https://yandex.ru/maps/-/CBRFAREW9B";
                    description = "Парк можно смело назвать украшением города, особенно в тёплое время года, когда деревья обрамлены зелёной листвой и клумбы оформлены яркими цветами. " +
                        "Это место расположено в центре города и занимает площадь в 14 га. Очень впечатляющая цифра! Основан парк «Гидростроитель» в 1951 году, именно в те далёкие года и " +
                        "началась первая посадка деревьев разных видов.";
                    break;
            }
        }
    }
}