using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeManagement.Models;

namespace TimeManagement.Services
{
    public static class TaskService
    {
        // Get all tasks
        public static List<Task> GetAllTasks()
        {
            try
            {
                using var dbContext = new TimeManagementContext();
                return dbContext.Tasks.Where(x => !x.IsDeleted).OrderByDescending(x => x.CreatedOn).ToList();
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Failed to get all tasks.");
            }
        }

        // Convert text to datetime
        // TODO: Move to a Utils file
        public static DateTime ConvertTextToDateTime(string stringDateTime)
        {
            try
            {
                var dateTime = DateTime.Today;
                
                if (!int.TryParse(stringDateTime[..2], out int hour) || hour < 0 || hour > 23)
                {
                    throw new InvalidOperationException("Failed to convert text to datetime.");
                }

                if (!int.TryParse(stringDateTime.Substring(2, 2), out int minute) || minute < 0 || minute > 59)
                {
                    throw new InvalidOperationException("Failed to convert text to datetime.");
                }

                dateTime = dateTime.AddHours(hour);
                dateTime = dateTime.AddMinutes(minute);

                return dateTime;
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Failed to convert text to datetime.");
            }
        }

        // Convert text to datetime
        // TODO: Move to a Utils file
        public static string ConvertTextToDateTime(DateTime dateTime)
        {
            try
            {
                return dateTime.ToString("HHmm");
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Failed to convert datetime to text.");
            }
        }

        // Get a certain task
        // Create a new task
        public static bool CreateNewTask(Task task)
        {
            try
            {
                using var dbContext = new TimeManagementContext();                
                dbContext.Tasks.Add(task);

                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Failed to create new task.");
            }
        }

        // Edit an existing task 

        // Delete an existing task
        public static bool DeleteTask(Task task)
        {
            try
            {
                using var dbContext = new TimeManagementContext();

                var dbTask = dbContext.Tasks.FirstOrDefault(x => x.TaskKey == task.TaskKey);

                if (dbTask != null) 
                { 
                    dbTask.IsDeleted = true;
                    dbTask.UpdatedOn = DateTime.Now;
                }

                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Failed to delete task.");
            }
        }
    }
}
