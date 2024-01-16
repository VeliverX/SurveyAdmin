using Microsoft.EntityFrameworkCore;
using SurveyAdmin.MODELS;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace SurveyAdmin
{
    /// <summary>
    /// Logika interakcji dla klasy AddSurvey.xaml
    /// </summary>
    public partial class AddSurvey : Window
    {
        private SurveyDbContext _dbContext;
        public int newid;
        public string[] QuestionTypeList = new string[3] { "OTWARTE", "ODCZUCIE", "STANOWISKO" };
        public AddSurvey( SurveyDbContext surveyDbContext)
        {
            

            _dbContext = surveyDbContext;

            
            InitializeComponent();

            Data_ankiety.ItemsSource = _dbContext.Ankiety.ToList();
            Add_Question_Type.ItemsSource = QuestionTypeList;

            Add_survey.Visibility = Visibility.Visible;
            Add_survey_name.Visibility = Visibility.Visible;
            Add_Question_Type.Visibility = Visibility.Hidden;
            Add_question.Visibility = Visibility.Hidden;
            Add_question_end.Visibility = Visibility.Hidden;

        }

        private bool NameValidation(string _name)
        {
            _name = _name.ToLower();
            if (_dbContext.Ankiety.ToList().Find(x => x.NazwaAnkiety.ToLower() == _name) == null && _name != string.Empty)
            {
                return true;
            }
            else if (_dbContext.Ankiety == null)
            {
                return true;
            }
            else { return false; }
        }
        private bool QuestionValidation(string _name)
        {
            _name = _name.ToLower();
            if (_dbContext.Pytania.ToList().Find(x => x.TrescPytania.ToLower() == _name) == null && _name != string.Empty && QuestionType() != "BłĄD")
            {
                return true;
            }
            else if (_dbContext.Ankiety == null)
            {
                return true;
            }
            else { return false; }
        }
        private int SurveyIdValidation()
        {
            int SurveyId;
            if (_dbContext.Ankiety == null)
            {
                SurveyId = 1;
            }
            else if (_dbContext.Ankiety.ToList().Count() == 0)
            {
                SurveyId = 1;
            }
            else
            {
                SurveyId = _dbContext.Ankiety.Max(x => x.IdAnkiety) + 1;
            }

            return SurveyId;
        }
        private int QuestionIdValidation()
        {
            int QuestionId;
            if (_dbContext.Pytania == null)
            {
                QuestionId = 1;
            }
            else if (_dbContext.Pytania.ToList().Count() == 0)
            {
                QuestionId = 1;
            }
            else
            {
                QuestionId = _dbContext.Pytania.Max(x => x.IdPytania) + 1;
            }

            return QuestionId;
        }
        public string QuestionType()
        {
            if (Add_Question_Type.SelectedValue == "OTWARTE")
            {
                return "OTWARTE";
            }
            else if (Add_Question_Type.SelectedValue == "ODCZUCIE")
            {
                return "ODCZUCIE";
            }
            else if (Add_Question_Type.SelectedValue == "STANOWISKO")
            {
                return "STANOWISKO";
            }
            else 
                return "BłĄD";
            
        }
        private void Add_survey_Click(object sender, RoutedEventArgs e)
        {
            if ( NameValidation(Add_survey_name.Text) )
            {
                newid = SurveyIdValidation();

                _dbContext.Ankiety.Add(new Ankieta()
                {
                    IdAnkiety = newid,
                    NazwaAnkiety = Add_survey_name.Text,
                    IsActive = true
                });
                _dbContext.SaveChanges();

                Add_survey_name.Text = string.Empty;
                Add_survey.Visibility = Visibility.Hidden;
                Add_question_end.Visibility = Visibility.Visible;
                Add_question.Visibility = Visibility.Visible;
                Add_Question_Type.Visibility = Visibility.Visible;
                Add_Question_Type.SelectedIndex = 0;
                Data_ankiety.ItemsSource = _dbContext.Ankiety.ToList();


            }
            else
            {
                MessageBox.Show("Brak nazwy bądz nazwa juz istnieje");
            }
            
        }

        private void Add_question_Click(object sender, RoutedEventArgs e)
        {
            if (QuestionValidation(Add_survey_name.Text))
            {
                _dbContext.Pytania.Add(new Pytanie()
                {
                    IdAnkiety = newid,
                    IdPytania = QuestionIdValidation(),
                    TrescPytania = Add_survey_name.Text,
                    TypPytania = QuestionType()

                }); ;
                _dbContext.SaveChanges();
                Add_survey_name.Text = string.Empty;
                Add_survey.Visibility = Visibility.Visible;

            }
            else
            {
                MessageBox.Show("Brak nazwy bądz nazwa juz istnieje");
            }
        }

        private void Add_question_end_Click(object sender, RoutedEventArgs e)
        {
            if (QuestionValidation(Add_survey_name.Text))
            {
                _dbContext.Pytania.Add(new Pytanie()
                {
                    IdAnkiety = newid,
                    IdPytania = QuestionIdValidation(),
                    TrescPytania = Add_survey_name.Text,
                    TypPytania = QuestionType()
                });
                _dbContext.SaveChanges();
                Add_survey_name.Text = string.Empty;

                Add_Question_Type.Visibility = Visibility.Hidden;
                Add_question_end.Visibility = Visibility.Hidden;
                Add_question.Visibility = Visibility.Hidden;
                Add_survey.Visibility = Visibility.Visible;

            }
            else
            {
                MessageBox.Show("Brak nazwy/typu bądz nazwa juz istnieje");
            }
        }
    }
}
