using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuyPham_20161207_CSI155FinalExam
{
    public enum EnumerableType { StackType, QueueType};

    public partial class Form1 : Form
    {
        List<Student> students; // Default Requirement
        Dictionary<int, Student> studentsDictionary; // Solution to Requirement #5

        Random rand = new Random();
        Queue<int> queueIntBackup; // For original queue state restoration
        Stack<int> stackIntBackup; // For original stack state restoration
        Queue<int> queueInt; // Solution Component to Requirement #10
        Stack<int> stackInt; // Solution Component to Requirement #11

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateStudents(); // Default Requirement
            PopulateDictionary(); // Solution to Requirement #6
            RefreshAllComboBoxes();
            RefreshListView(students, lvDisplay); // Solution to Requirement #2

            PopulateQueuesAndStacks(); // Solution Component to Requirements #10 and #11
            RefreshListBoxWithCollection(listBoxS10Queue, queueInt);
            RefreshListBoxWithCollection(listBoxS11Stack, stackInt);
        }

        private void PopulateStudents()
        {
            students = new List<Student>()
            {
               new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
               new Student {First="Claire", Last="O’Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
               new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
               new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
               new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
               new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
               new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
               new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
               new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
               new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
               new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
               new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91} }
            };
        } // Default Requirement

        private void RefreshListView(List<Student> studentCollection, ListView listView)
        {
            listView.Items.Clear();

            foreach (Student student in studentCollection)
            {
                ListViewItem lvItem = new ListViewItem(new string[]
                {
                    student.Last,
                    student.First,
                    student.ID.ToString(),
                    student.GetAverageGrade().ToString("f")
                });

                listView.Items.Add(lvItem);
            }
        } // Solution to Requirement #2   

        private void btnS3SortWithIComparable_Click(object sender, EventArgs e)
        {
            students.Sort();
            RefreshListView(students, lvDisplay);
        } // Solution to Requirement #3

        private void btnS4SortWithIComparer_Click(object sender, EventArgs e)
        {
            students.Sort(new StudentLNameComparer());
            RefreshListView(students, lvDisplay);
        } // Solution to Requirement #4

        private void PopulateDictionary()
        {
            studentsDictionary = new Dictionary<int, Student>();

            foreach (Student student in students)
                studentsDictionary.Add(student.ID, student);
        } // Solution to Requirement #6

        private void RefreshListView(Dictionary<int, Student> dictionary, ListView listView)
        {
            listView.Items.Clear();

            foreach (KeyValuePair<int, Student> kvp in dictionary)
            {
                ListViewItem lvItem = new ListViewItem(new string[]
                {
                    kvp.Value.Last,
                    kvp.Value.First,
                    kvp.Key.ToString(),
                    kvp.Value.GetAverageGrade().ToString("f")
                });

                listView.Items.Add(lvItem);
            }
        } // Solution to Requirement #7

        private bool AttemptFindStudent(string input, Dictionary<int, Student> dictionary)
        {
            bool successfulFind = false;
            int studentID = 0;
            Student student;
            string errMsg = "Error: Not Found: \n No student exists with the given ID";

            string[] tempStringArray = input.Split(' ');
            bool successParse = Int32.TryParse(tempStringArray[0], out studentID);

            if (successParse == true)
            {
                successfulFind = studentsDictionary.TryGetValue(studentID, out student);

                if (successfulFind == true)
                {
                    MessageBox.Show(
                        "Student ID " + studentID + " found!" + "\n" +
                        "Last Name: " + student.Last + "\n" +
                        "First Name: " + student.First + "\n" +
                        "Average Grade: " + student.GetAverageGrade().ToString("f"));
                }
                else
                    MessageBox.Show(errMsg);
            }
            else
                MessageBox.Show(errMsg);

            return successfulFind;
        } // Solution Component to Requirement #8

        private void btnS8SearchCustomString_Click(object sender, EventArgs e)
        {
            AttemptFindStudent(cboS8StudentID.Text, studentsDictionary);
        } // Solution to Requirement #8

        private bool AttemptRemoveStudent(string input, Dictionary<int, Student> dictionary)
        {
            bool successfulRemoval = false;
            int studentID = 0;
            Student student;
            string errMsg = "Error: Not Found: \n No student exists with the given ID";

            string[] tempStringArray = input.Split(' ');
            bool successParse = Int32.TryParse(tempStringArray[0], out studentID);

            if (successParse == true)
            {
                bool successFind = studentsDictionary.TryGetValue(studentID, out student);

                if (successFind == true)
                {
                    successfulRemoval = studentsDictionary.Remove(studentID);

                    MessageBox.Show(
                        "Student ID: " + studentID + "\n" +
                        "Last Name: " + student.Last + "\n" +
                        "First Name: " + student.First + "\n" +
                        "HAS BEEN REMOVED FROM THE SYSTEM");
                }
                else
                    MessageBox.Show(errMsg);
            }
            else
                MessageBox.Show(errMsg);

            return successfulRemoval;
        } // Solution Component to Requirement #9

        private void btnS9RemoveWithCustomString_Click(object sender, EventArgs e)
        {
            bool successfulRemoval = AttemptRemoveStudent(cboS9StudentID.Text, studentsDictionary);

            if (successfulRemoval == true)
            {
                students = new List<Student>(SyncListWithDictionary(students, studentsDictionary));
                RefreshAllComboBoxes();
                RefreshListView(studentsDictionary, lvDisplay);
            }         
        } // Solution to Requirement #9

        private IEnumerable<int> PopulateCollectionWithRandomValues(EnumerableType collection, Random rand, int minInclusive, int maxExclusive, uint quantity)
        {
            List<int> listOfRandomNumbers = new List<int>();

            for (int i = 0; i < quantity; i++)
                listOfRandomNumbers.Add(rand.Next(minInclusive, maxExclusive));

            if (collection == EnumerableType.QueueType)
                return new Queue<int>(listOfRandomNumbers);
            else if (collection == EnumerableType.StackType)
                return new Stack<int>(listOfRandomNumbers);
            else
                return listOfRandomNumbers;
        } // Solution Component to Requirements #10 and #11

        private void PopulateQueuesAndStacks()
        {
            queueInt = new Queue<int>
                (PopulateCollectionWithRandomValues(EnumerableType.QueueType, rand, Int32.MinValue, Int32.MaxValue, 30)); // Solution Component to Requirement #10
            stackInt = new Stack<int>
                (PopulateCollectionWithRandomValues(EnumerableType.StackType, rand, Int32.MinValue, Int32.MaxValue, 30)); // Solution Component to Requirement #11

            queueIntBackup = new Queue<int>(queueInt);
            stackIntBackup = new Stack<int>(new Stack<int>(stackInt));

            // Instantiating a new stack using a pre-existing stack as parameter will result in a reversed order output.
            // Double instantiation will reverse that and retain the order of the pre-existing stack.
            // Reverse() could've been used to cut back one stack instantiation as well... but this will do. HQP 2016-12-07.
        } // Solution Component to Requirements #10 and #11

        private Queue<int> RemoveNegatives(Queue<int> queue)
        {
            // LINQ is much more interesting and concise to use than a litany of ifs, thens, dequeue, and enqueue. 
            // Hope LINQ doesn't violate the requirements set out by this Final Exam. HQP 2016-12-07.

            var positiveSelection = (from int num in queue
                                     where num >= 0
                                     select num);

            return new Queue<int>(positiveSelection);
        } // Solution Component to Requirement #10

        private void btnS10RemoveNegatives_Click(object sender, EventArgs e)
        {
            queueInt = RemoveNegatives(queueInt);
            RefreshListBoxWithCollection(listBoxS10Queue, queueInt);
        } // Solution Component to Requirement #10

        private Stack<int>RemovePositivesFromStack(Stack<int> stack)
        {
            // LINQ is much more interesting and concise to use than a litany of ifs, thens, pops, and pushes. HQP 2016-12-07.
            // Hope LINQ doesn't violate the requirements set out by this Final Exam. HQP 2016-12-07.

            var negativeSelection = (from int num in stack
                                     where num < 0
                                     select num);

            return new Stack<int>(new Stack<int>(negativeSelection));

            // Instantiating a new stack using a pre-existing stack as parameter will result in a reversed order output.
            // Double instantiation will reverse that and retain the order of the pre-existing stack. 
            // Reverse() could've been used to cut back one stack instantiation as well... but this will do. HQP 2016-12-07.
        } // Solution Component to Requirement #11

        private void btnS11RemovePositives_Click(object sender, EventArgs e)
        {
            stackInt = RemovePositivesFromStack(stackInt);
            RefreshListBoxWithCollection(listBoxS11Stack, stackInt);
        } // Solution Component to Requirement #11

        #region SUPPLEMENTARY METHODS

        // Methods that are outside of the exam requirements, purposed to help user experience. HQP 2016-12-07.

        private void RefreshComboBox(Dictionary<int, Student> dictionary, ComboBox cbo)
        {
            cbo.Items.Clear();
            cbo.Text = "";

            foreach (KeyValuePair<int, Student> kvp in dictionary)
            {
                string tempString = kvp.Key.ToString() + " - " + kvp.Value.Last + ", " + kvp.Value.First;
                cbo.Items.Add(tempString);
            }
        }

        private void RefreshAllComboBoxes()
        {
            RefreshComboBox(studentsDictionary, cboS8StudentID);
            RefreshComboBox(studentsDictionary, cboS9StudentID);
        }

        List<Student> SyncListWithDictionary(List<Student> studentCollection, Dictionary<int, Student> dictionary)
        {
            if (dictionary.Count > 0)
            {
                List<Student> updatedStudentList = new List<Student>();

                foreach (KeyValuePair<int, Student> kvp in dictionary)
                    updatedStudentList.Add(kvp.Value);
                return updatedStudentList;
            }
            else
                return studentCollection;
        }

        private void RefreshListBoxWithCollection(ListBox listBox, IEnumerable<int> collection)
        {
            listBox.Items.Clear();

            foreach (int num in collection)
                listBox.Items.Add(num);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            PopulateStudents();
            PopulateDictionary();
            RefreshAllComboBoxes();
            RefreshListView(students, lvDisplay);
        }

        private void btnS10Restore_Click(object sender, EventArgs e)
        {
            queueInt = new Queue<int>(queueIntBackup);
            RefreshListBoxWithCollection(listBoxS10Queue, queueInt);
        }

        private void btnS11Restore_Click(object sender, EventArgs e)
        {
            stackInt = new Stack<int>(new Stack<int>(stackIntBackup));
            RefreshListBoxWithCollection(listBoxS11Stack, stackInt);
        }

        #endregion
    }
}
