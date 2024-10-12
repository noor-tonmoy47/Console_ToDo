using Console_ToDo.DataAccess.Entity;
using FluentNHibernate.Mapping;

namespace Console_ToDo.DataAccess.Mapping
{
    internal class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("users");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.UserName);
            HasMany(x => x.UserTasks)
                .Inverse()
                .Cascade.All();
        }
    }
}
