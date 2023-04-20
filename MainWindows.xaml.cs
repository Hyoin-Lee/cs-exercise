using System;
using System.Collections.Generic;
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

namespace UIExercise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataService service = new DataService();

        public MainWindow()
        {
            InitializeComponent();
            comboEnrolment.ItemsSource = Enum.GetValues(typeof(EnrolmentStatus));
        }

        /// <summary>
        /// This is called when the get students button is pressed.
        /// TODO: Update this button to load the students from the service and update the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetStudents_Click(object sender, RoutedEventArgs e)
        {
            
            //1 - Get Students
            UpdateStudentList();

            //Mehtod 1 - Itemsource
            //listboxStudents.ItemsSource = service.GetStudents();

            //Method 2 - Items
            foreach (Student student in service.GetStudents())
            {
                listboxStudents.Items.Add(student);
            } 
        }

        /// <summary>
        /// This event is triggered when the user selects a student from the list.
        /// TODO: Update the controls to show the properties of the selected student.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //validate its a student selected
            if (!(listboxStudents.SelectedItem is Student)) return;
            {
                Student selectedStudent = (Student)listboxStudents.SelectedItem;
                textBoxFirstName.Text = selectedStudent.FirstName;
                textBoxLastName.Text = selectedStudent.LastName;
                comboEnrolment.SelectedItem = selectedStudent.Enrolment;
            }
        }

        /// <summary>
        /// This event triggers when the combo box selection is changed.
        /// TODO: It should update the selected students enrolment.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboEnrolment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student selectedStudent = (Student)(listboxStudents.SelectedItem);
            selectedStudent.Enrolment = (EnrolmentStatus)comboEnrolment.SelectedItem;
            UpdateStudentList();
            listboxStudents.SelectedItem = selectedStudent;

        }

        private void UpdateStudentList()
        {
            listboxStudents.ItemsSource = null;
            //listboxStudents.ItemsSource = service.GetStudents();
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            if (!(listboxStudents.SelectedItem is Student)) return;

            Student selectedStudent = (Student)listboxStudents.SelectedItem;
            selectedStudent.FirstName = textBoxFirstName.Text;
            selectedStudent.LastName = textBoxLastName.Text;
            UpdateStudentList();

        }

        private void buttonAddStudent_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
