namespace treasury.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateToAccountIndex : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT [Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (100, N'الاصول', N'test ', NULL)
                    INSERT[Dom].[AccountIndex]([Id], [Name], [EnName], [parentId]) VALUES(110, N'الاصول المتداولة
                    ', N'testrtre', 100)
                    INSERT[Dom].[AccountIndex]([Id], [Name], [EnName], [parentId]) VALUES(111, N'الصندوق', N'الصندوق', 110)
                    INSERT[Dom].[AccountIndex]([Id], [Name], [EnName], [parentId]) VALUES(112, N'البنك', N'البنك', 110)
                    INSERT[Dom].[AccountIndex]
                            ([Id], [Name], [EnName], [parentId]) VALUES(113, N'المدينون', N'المدينون', 110)
                    INSERT[Dom].[AccountIndex]
                            ([Id], [Name], [EnName], [parentId]) VALUES(114, N'اوراق القبض
                    ', N'اوراق القبض
                    ', 110)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (115, N'المخزون', N'المخزون', 110)
                    INSERT[Dom].[AccountIndex]
                            ([Id], [Name], [EnName], [parentId]) VALUES(120, N'الاصول الثابتة
                    ', N'الاصول الثابتة
                    ', 100)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (121, N'الاراضي', N'الاراضي', 120)
                    INSERT[Dom].[AccountIndex]
                            ([Id], [Name], [EnName], [parentId]) VALUES(122, N'المباني', N'المباني', 120)
                    INSERT[Dom].[AccountIndex]
                            ([Id], [Name], [EnName], [parentId]) VALUES(123, N'السيارات', N'السيارات', 120)
                    INSERT[Dom].[AccountIndex]
                            ([Id], [Name], [EnName], [parentId]) VALUES(124, N'الاثاث', N'الاثاث', 120)
                    INSERT[Dom].[AccountIndex]
                            ([Id], [Name], [EnName], [parentId]) VALUES(125, N'كمبيوترات', N'كمبيوترات', 120)
                    INSERT[Dom].[AccountIndex]
                            ([Id], [Name], [EnName], [parentId]) VALUES(126, N'الاصول غير الملموسة
                    ', N'الاصول غير الملموسة
                    ', 120)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (127, N'العلامة التجارية
                    ', N'العلامة التجارية
                    ', 120)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (128, N'براءة الاختراع
                    ', N'براءة الاختراع
                    ', 120)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (200, N'الالتزامات', N'الالتزامات', NULL)
                    INSERT[Dom].[AccountIndex]
                            ([Id], [Name], [EnName], [parentId]) VALUES(210, N'الالتزامات المتداولة
                    ', N'الالتزامات المتداولة
                    ', 200)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (211, N'الدائنون', N'الدائنون', 210)
                    INSERT[Dom].[AccountIndex]
                            ([Id], [Name], [EnName], [parentId]) VALUES(212, N'اوراق الدفع
                    ', N'اوراق الدفع
                    ', 210)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (213, N'قروض قصيرة الاجل
                    ', N'قروض قصيرة الاجل
                    ', 210)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (214, N'ايرادات مقبوضة مقدما
                    ', N'ايرادات مقبوضة مقدما
                    ', 210)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (215, N'مصروفات مستحقة
                    ', N'مصروفات مستحقة
                    ', 210)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (220, N'الالتزامات غير المتداولة
                    ', N'الالتزامات غير المتداولة
                    ', 200)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (221, N'قروض طويلة الاجل
                    ', N'قروض طويلة الاجل
                    ', 220)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (400, N'االايرادات
                    ', N'االايرادات
                    ', NULL)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (410, N'ايرادات النشاط الرئيسي
                    ', N'ايرادات النشاط الرئيسي
                    ', 400)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (411, N'المبيعات
                    ', N'المبيعات
                    ', 410)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (412, N'الخصم على المبيعات
                    ', N'الخصم على المبيعات
                    ', 410)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (420, N'الايرادات الاخرى
                    ', N'الايرادات الاخرى
                    ', 400)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (421, N'ايرادات الاستثمار
                    ', N'ايرادات الاستثمار
                    ', 420)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (422, N'ايرادات الايجار', N'ايرادات الايجار', 420)
                    INSERT[Dom].[AccountIndex]
                            ([Id], [Name], [EnName], [parentId]) VALUES(500, N'المصروفات', N'المصروفات', NULL)
                    INSERT[Dom].[AccountIndex]
                            ([Id], [Name], [EnName], [parentId]) VALUES(510, N'تكلفة المبيعات
                    ', N'تكلفة المبيعات
                    ', 500)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (511, N'المشتريات', N'المشتريات', 510)
                    INSERT[Dom].[AccountIndex]
                            ([Id], [Name], [EnName], [parentId]) VALUES(512, N'مصاريف المشتريات
                    ', N'مصاريف المشتريات
                    ', 510)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (514, N'الخصم على المشتريات
                    ', N'الخصم على المشتريات
                    ', 510)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (520, N'مصاريف البيع والتسويق
                    ', N'مصاريف البيع والتسويق
                    ', 500)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (521, N'مصاريف المبيعات
                    ', N'مصاريف المبيعات
                    ', 520)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (522, N'عمولات بيع
                    ', N'عمولات بيع
                    ', 520)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (523, N'دعاية واعلان
                    ', N'دعاية واعلان
                    ', 520)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (530, N'مصاريف ادارية وعمومية
                    ', N'مصاريف ادارية وعمومية
                    ', 500)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (531, N'رواتب واجور
                    ', N'رواتب واجور
                    ', 530)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (532, N'ايجار
                    ', N'ايجار
                    ', 530)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (533, N'كهرباء', N'كهرباء', 530)
                    INSERT[Dom].[AccountIndex]
                            ([Id], [Name], [EnName], [parentId]) VALUES(534, N'هاتف وانترنت
                    ', N'هاتف وانترنت
                    ', 530)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (535, N'صيانة
                    ', N'صيانة
                    ', 530)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (536, N'مصاريف حكومية
                    ', N'مصاريف حكومية
                    ', 530)
                    INSERT[Dom].[AccountIndex] ([Id], [Name], [EnName], [parentId]) VALUES (537, N'مياه', N'مياه', 530)");
        }
        
        public override void Down()
        {
            Sql("delete from accountIndex");
        }
    }
}
