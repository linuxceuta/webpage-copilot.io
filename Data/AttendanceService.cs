// filepath: /home/tor/Descargas/cs13net9/cursoMicrosoft/TasksApp/Data/AttendanceService.cs
using System.Collections.Generic;

namespace TasksApp.Data
{
    public class AttendanceService
    {
        private List<string> attendanceList = new List<string>();

        public IEnumerable<string> GetAttendance() => attendanceList;

        public void MarkAttendance(string username)
        {
            if (!attendanceList.Contains(username))
            {
                attendanceList.Add(username);
            }
        }
    }
}