// filepath: /home/tor/Descargas/cs13net9/cursoMicrosoft/TasksApp/Data/UserSession.cs
using System;

namespace TasksApp.Data
{
    public class UserSession
    {
        public User? CurrentUser { get; private set; }

        public event Action? OnChange;

        public void Login(User user)
        {
            CurrentUser = user;
            NotifyStateChanged();
        }

        public void Logout()
        {
            CurrentUser = null;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}