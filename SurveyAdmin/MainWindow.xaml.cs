using Microsoft.EntityFrameworkCore;
using SurveyAdmin.MODELS;
using System.Windows;

namespace SurveyAdmin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SurveyDbContext _surveyDbContext;
        public MainWindow()
        {
            _surveyDbContext = new SurveyDbContext();

            _surveyDbContext.Database.OpenConnection();
            InitializeComponent();

        }

        private void Add_Survey_Click(object sender, RoutedEventArgs e)
        {
            AddSurvey addSurvey = new AddSurvey(_surveyDbContext);
            addSurvey.Show();
            

        }

        private void Edit_Survey_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
