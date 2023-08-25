namespace Ekub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd7e94085-714e-44b8-92c7-405a17826dc8', N'semhamirid@gmail.com', 0, N'AEqPseq6S0/QIpuGlMQy4HONcBI4+byEzOeEXMFOcrBveU3naganMQmn9n+L6jwGVg==', N'122a1dc3-f735-4278-b91b-c41c568ef90b', NULL, 0, 0, NULL, 1, 0, N'semhamirid@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e661f931-ac84-4dca-8d59-c3a1b47a6e7e', N'fayomuhe5@gmail.com', 0, N'AKCObhFm6Zoq4EVaOV/OcDZfGR6w5kwX+MBcu0hV6ZKYWRIV1/Be8cGICwjNnhNrHw==', N'afc354c5-97e4-4b04-bbe5-d25f4aa9abab', NULL, 0, 0, NULL, 1, 0, N'fayomuhe5@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'eae684f9-485d-40fb-a5cb-a83b59582932', N'famimohammed14@gmail.com', 0, N'AKwB1tq+s9hWAa8udskHs/u3jLmlRcc1lDjz0KeGEoXGw3L0DX9/eZNC0rJBs6Ht0w==', N'e13f2b34-225b-489c-bc4e-ff665e56bdc9', NULL, 0, 0, NULL, 1, 0, N'famimohammed14@gmail.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1623d0f5-587f-479a-a96a-81abf85dfa83', N'CanManageEkub')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'eae684f9-485d-40fb-a5cb-a83b59582932', N'1623d0f5-587f-479a-a96a-81abf85dfa83')
");


        }
        
        public override void Down()
        {
        }
    }
}
