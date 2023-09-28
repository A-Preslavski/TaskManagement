using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TimeManagement.Models;
using TimeManagement.Services;

namespace TimeManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Button that loads the data in the datagrid.
        /// </summary>
        private void OnLoadDataButtonClick(object sender, RoutedEventArgs e)
        {
            TasksGrid.DataContext = TaskService.GetAllTasks();
        }

        /// <summary>
        /// Button that creates or updates a task in the db.
        /// </summary>
        private void OnCreateButtonClick(object sender, RoutedEventArgs e)
        {
            var chosenTask = new Task()
            {
                TaskName = TaskHeader.Text.Trim(),
                TaskDescription = TaskDescription.Text.Trim(),
                StartTime = TaskService.ConvertTextToDateTime(FromTimeText.Text.Trim()),
                EndTime = TaskService.ConvertTextToDateTime(ToTimeText.Text.Trim()),
                //TimeSpent = EndTime - StartTime,
                IsDeleted = false
            };

            TaskService.CreateNewTask(chosenTask);

            EmptyFields();
            TasksGrid.DataContext = TaskService.GetAllTasks();
            Keyboard.Focus(TaskHeader);
        }

        private void OnDeleteButtonClick(object sender, RoutedEventArgs e)
        {
            var selectedTask = (Task)TasksGrid.SelectedItem;

            if (selectedTask != null) 
            {
                TaskService.DeleteTask(selectedTask);
            }

            TasksGrid.DataContext = TaskService.GetAllTasks();
            EmptyFields();
            Keyboard.Focus(TaskHeader);
        }

        private void OnGridSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedTask = (Task)TasksGrid.SelectedItem;

            if (selectedTask != null)
            {
                TaskHeader.Text = selectedTask.TaskName;
                TaskDescription.Text = selectedTask.TaskDescription;
                FromTimeText.Text = selectedTask.StartTime?.ToString("HHmm");
                ToTimeText.Text = selectedTask.EndTime?.ToString("HHmm");

                Keyboard.Focus(TaskHeader);
            }
        }

        private void OnTaskHeaderEnterPress(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                Keyboard.Focus(TaskDescription);
            }
        }

        private void OnTaskDescriptionEnterPress(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                Keyboard.Focus(FromTimeText);
            }
        }

        private void OnFromTimeTextEnterPress(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                Keyboard.Focus(ToTimeText);
            }
        }

        private void OnToTimeTextEnterPress(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                SaveButton.Focus();
            }
        }

        private void EmptyFields()
        {
            TaskHeader.Text = string.Empty;
            TaskDescription.Text = string.Empty;
            FromTimeText.Text = string.Empty;
            ToTimeText.Text = string.Empty;
        }
    }
}
