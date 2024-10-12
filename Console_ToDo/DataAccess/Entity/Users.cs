using System.Collections.Generic;

namespace Console_ToDo.DataAccess.Entity
{
    internal class Users
    {
        public virtual int Id { get; protected set; }

        public virtual string UserName { get;  set; }

        public virtual IList<Tasks> UserTasks {  get; set; }


        public virtual void addTask(Tasks task)
        {
            task.TaskBelongsTo = this;
            this.UserTasks.Add(task);
        }

       
    }
}
