using System;
namespace Console_ToDo.DataAccess.Entity
{
    internal class Tasks
    {
        public virtual int Id { get; protected set; }
        public virtual string Content { get; set; }
        public virtual Users TaskBelongsTo {  get; set; }

        public virtual bool IsCompleted {  get; set; }
    }
}
