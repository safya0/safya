using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

namespace Managment
{
    /// <summary>
    /// Interaction logic for Management.xaml
    /// </summary>
    public partial class Management : Page
    {
        MagagmentEntities DB = new MagagmentEntities();
        public Management()
        {
            InitializeComponent();
            DG.ItemsSource=DB.Tasks.ToList();
        }
        void Clear() 
        {
            taskxid.Text = Titletxt.Text = destxt.Text = "";


        }
        void Refresh()
        {
            DG.ItemsSource = DB.Tasks.ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Task task = new Task();
                task.TaskId = int.Parse(taskxid.Text);
                task.Title = Titletxt.Text;
                task.DescriptionTask = destxt.Text;
                compo.ItemsSource = task.StatusTask;
                DB.Tasks.Add(task);
                DB.SaveChanges();
                Refresh();
                Clear();
                MessageBox.Show("Adding Successfully");
            }
            catch
            {
                MessageBox.Show("Error");

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Task task = new Task();
                task.TaskId = int.Parse(taskxid.Text);
                task.Title = Titletxt.Text;
                task.DescriptionTask = destxt.Text;
                DB.Tasks.AddOrUpdate(task);
                DB.SaveChanges();
                Refresh();
                Clear();
                MessageBox.Show("Editing Successfully");
            }
            catch
            {
                MessageBox.Show("Error");

            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                Task task = new Task();
                var id = int.Parse(taskxid.Text);
                DB.Tasks.Remove(DB.Tasks.FirstOrDefault(T => T.TaskId == id));
                DB.SaveChanges();
                Refresh();
                Clear();
                MessageBox.Show("DELETE Successfully");
            }
            catch
            {
                MessageBox.Show("Error");

            }
        }

        private void compo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DG.ItemsSource=compo.Items;
        }
    }
}
