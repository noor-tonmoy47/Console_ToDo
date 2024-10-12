using Console_ToDo.DataAccess.Entity;
using FluentNHibernate.Mapping;

namespace Console_ToDo.DataAccess.Mapping
{
    internal class TaskMap : ClassMap<Task>
    {
        public TaskMap() {

            Table("tasks");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Content);
            Map(x => x.IsCompleted);
            References(x => x.TaskBelongsTo);
        }
    }
    
}
