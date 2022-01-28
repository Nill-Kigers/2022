using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace school
{
    /// <summary>
    /// Логика взаимодействия для AddService.xaml
    /// </summary>
    public partial class AddService : Page
    {
        public OpenFileDialog ofd = new OpenFileDialog();
        string path = "";
        private bool flag = false;
        private string _imgSource = string.Empty;
        private Service _selectService = new Service();
        public AddService(Service selectService)
        {
            InitializeComponent();

            if (selectService != null)
                _selectService = selectService;
            DataContext = _selectService;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {


            if (flag)
            {
                File.Copy(ofd.FileName, _imgSource, true);
                _selectService.MainImagePath = $"\\Услуги школы\\{ofd.SafeFileName}";
            }
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_selectService.Title))
                errors.AppendLine("Укажите название");
            if (string.IsNullOrWhiteSpace(_selectService.ToString()))
                errors.AppendLine("Укажите цену");
            if (_selectService.Cost == null)
                errors.AppendLine("Укажите Длительность в секундах");
            if (_selectService.DurationInSeconds == null)
                errors.AppendLine("Укажите Описание");
            if (string.IsNullOrWhiteSpace(_selectService.Description))
                errors.AppendLine("Укажите КПП");
            if (_selectService.Discount == null)
                errors.AppendLine("Укажите скидку");
            
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_selectService.ID == 0)
                schoolEntities.GetContext().Services.Add(_selectService);
            try
            {
                schoolEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                FrameWindow.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void SelectedPhoto_Click(object sender, RoutedEventArgs e)
        {
            string Source = Environment.CurrentDirectory;
            if (ofd.ShowDialog() == true)
            {
                flag = true;
                string ing = ofd.SafeFileName;
                _imgSource = Source.Replace("\\bin\\Debug", "\\Услуги школы\\") + ing;
                PreviewImage.Source = new BitmapImage(new Uri(ofd.FileName));
                path = ofd.FileName;
            }
        }
    }
}
