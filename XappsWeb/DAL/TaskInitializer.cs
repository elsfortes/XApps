using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XappsWeb.Models;
using System.Data.Entity;

namespace XappsWeb.DAL
{
    public class TaskInitializer : DropCreateDatabaseIfModelChanges<TaskContext>
    {
        protected override void Seed(TaskContext context)
        {
            var Tasks = new List<Task>
            {
                new Task {Id = 1, Status = Status.Pendente, DataCriacao = DateTime.Parse("2017-09-19"), Text ="Criar projeto MVC"},
                new Task {Id = 2, Status = Status.Pendente, DataCriacao = DateTime.Parse("2017-09-19"), Text ="Fazer exercicio 1"},
                new Task {Id = 3, Status = Status.Pendente, DataCriacao = DateTime.Parse("2017-09-19"), Text ="Fazer exercicio 2"},
                new Task {Id = 4, Status = Status.Pendente, DataCriacao = DateTime.Parse("2017-09-19"), Text ="Apagar projeto XAML"}
            };

            Tasks.ForEach(t => context.Tasks.Add(t));
            context.SaveChanges();
        }
    }
}