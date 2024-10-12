using System;
namespace Console_ToDo.DataAccess.Entity
{
    internal class Task
    {
        public virtual int Id { get; protected set; }
        public virtual string Content { get; set; }
        public virtual User TaskBelongsTo {  get; set; }

        public virtual bool IsCompleted {  get; set; }
    }
}
