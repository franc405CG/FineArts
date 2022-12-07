using FineArts.Bll;
using FineArts.Entities;
using System.Collections.Generic;
using System.Windows;

namespace FineArts.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            TeacherService teacherService = new();
            teacherList.DataContext = teacherService.GetTeachers();

        }

        private void saveChanges_Click(object sender, RoutedEventArgs e)
        {

        }

        private void teacherList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Teacher? selectedTeacher = teacherList.SelectedItem as Teacher;
            TeacherService teacherService = new();
            if (selectedTeacher != null)
            {
                studentList.DataContext = teacherService.GetStudentsByTeacherId(selectedTeacher.Id);
            }
        }
    }
}
