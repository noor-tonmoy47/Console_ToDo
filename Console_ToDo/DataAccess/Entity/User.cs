using System.Collections.Generic;

namespace Console_ToDo.DataAccess.Entity
{
    internal class User
    {
        public virtual int Id { get; protected set; }

        public virtual string UserName { get;  set; }

        public virtual IList<Task> UserTasks {  get; set; }


        public void addTask(Task task)
        {
            task.TaskBelongsTo = this;
            this.UserTasks.Add(task);
        }

       
    }
}
