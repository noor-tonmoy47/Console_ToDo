using Console_ToDo.DataAccess.Entity;
using FluentNHibernate.Mapping;

namespace Console_ToDo.DataAccess.Mapping
{
    internal class UserMap : ClassMap<Users>
    {
        public UserMap()
        {
            Table("Users");
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.UserName);
            HasMany(x => x.UserTasks)
                .Inverse()
                .Cascade.All();
        }
    }
}
