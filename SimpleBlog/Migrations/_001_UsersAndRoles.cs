using FluentMigrator;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlog.Migrations
{
    [Migration(1)]
    public class _001_UsersAndRoles : Migration
    {
        public override void Up()
        {
            Create.Table("users")
                .WithColumn("id").AsInt32().Identity().PrimaryKey()
                .WithColumn("username").AsString(128)
                .WithColumn("email").AsString(256)
                .WithColumn("password_hash").AsString(128);

            //throw new NotImplementedException();
        }

        public override void Down()
        {
            Delete.Table("users");
            //throw new NotImplementedException();
        }
        
    }
}
