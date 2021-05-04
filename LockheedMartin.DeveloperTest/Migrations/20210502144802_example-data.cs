using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LockheedMartin.DeveloperTest.Migrations
{
    public partial class exampledata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ForecastWeeks",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), "Example Week" });

            migrationBuilder.InsertData(
                table: "ForecastTemperatures",
                columns: new[] { "Id", "DayId", "ForecastWeekId", "TemperatureC" },
                values: new object[,]
                {
                    { new Guid("56be11e3-cb6e-43fe-b7bf-50b8e5ffb04e"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 12m },
                    { new Guid("63a73cc5-7ad4-4da4-9781-25a9eb5ab041"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("5e66cbce-f6d4-4dca-9420-c21cea6d5acf"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("dbbffe1b-daf8-49f5-8320-89bc41130222"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("2cc95fe2-037e-4bb1-8528-97999d2c8799"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("bc7a8888-402b-480a-b8b9-9e0ca40cf68c"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("1c3be307-dfd1-4f91-a6a8-ac6582b980dc"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 12m },
                    { new Guid("a9d74499-d8a9-48fc-a9d0-a244dbb8c7bc"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("37e966eb-99a6-4aa5-9bb9-380e1eafa909"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("a388a887-e47b-4f6d-8af4-825c862b14f3"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("689868f0-742a-4cf8-92fa-f9945c26a84c"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("f1c57864-9da0-41ad-87e8-8fbf66192ed5"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("3cb63197-8f79-48c8-9c64-57fc48040e44"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m },
                    { new Guid("20f21848-d4fa-470e-821c-53e8ab75bbb0"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m },
                    { new Guid("314c302b-3f4b-42a5-ae0e-2ec93aa1fd21"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m },
                    { new Guid("1cdba29d-a9e2-45b3-aa95-aa541bf8186c"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 9m },
                    { new Guid("103ed69d-b05e-4688-8a13-010027c11b53"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m },
                    { new Guid("49a74cb9-409c-42db-90bf-7448e4c4fa5f"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("40998771-c03e-4ea4-aa7f-b99be442bc12"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("e477be01-3bc6-4e9b-a67e-726c29ada6d9"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 12m },
                    { new Guid("ad1b8032-c6ae-4123-a3a1-c631faf4350a"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("f65b6d96-70f0-43cc-b705-d30bbbf93432"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("9e4b29b8-ce7f-4343-9a57-09b782a75752"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("6b4a3356-f6b5-4083-8568-c20ae0d5c0ef"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("6ad7e77d-2a88-4200-8ba9-45f1d82b2231"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 12m },
                    { new Guid("1bfb72e5-f454-4fd8-9b4b-6cfa120435df"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("faaa8ebf-1a6b-435e-ac86-142364de1f82"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("d203aeea-1f5f-4c99-a9fe-aea5b7f418a7"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("31f8c600-c79e-4630-a68d-007f5c6e0378"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("aaffb497-ae7a-47a2-b2e8-f024a40e02bf"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m },
                    { new Guid("d0b0fc11-3e4d-4b15-804a-19a3d9475d33"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m },
                    { new Guid("dc75915a-2ae8-4938-9af9-a7ea10c6246e"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m },
                    { new Guid("fad367bd-5d57-4aba-86e1-24056f6f72f7"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 9m },
                    { new Guid("c79fcb41-b56b-4b41-bc6a-277f20715d68"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 9m },
                    { new Guid("f8f9e1bb-17ff-4959-bdf7-34eaa5033d5e"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m },
                    { new Guid("5839fbd1-c297-4944-9d6b-840eda49bb95"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("d5e73104-9922-4c04-9d64-3b9be60b7d29"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 12m },
                    { new Guid("5242e7c3-34dc-49fc-9bc7-d1aad35ceb14"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("5c11228f-a809-49fa-b768-22914df9a50a"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("0f9277ef-675e-4d9f-b179-be7cc8073585"), 4, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("a4e37dad-f807-4a13-8125-dfd44e359fcd"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("f656d8bb-3bf8-480f-93a4-3fdc0a4a2f3c"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m }
                });

            migrationBuilder.InsertData(
                table: "ForecastTemperatures",
                columns: new[] { "Id", "DayId", "ForecastWeekId", "TemperatureC" },
                values: new object[,]
                {
                    { new Guid("ce3b2eed-2943-4e74-b023-dac8e97ecb22"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("1920b8b0-fb8e-45f0-8497-497acc09b092"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("a2f34945-53bf-471b-87b3-eb16659bf8a0"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("caa74ea0-562d-4b0a-b115-bf6e5ce4abed"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("9ea95184-431c-4446-9690-aac852dad282"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("2610da0b-1835-4377-b7be-71fc6e4f3780"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("529a5af6-4f97-40eb-a253-5ae83ccd552c"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("0b3702a0-ca4d-43ee-b0d4-c248b41d87be"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("afbc3406-c7da-4f2d-9944-690b191d60bc"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("91d2532a-7f20-48a6-a386-d2730cb64ece"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("f5cf3dcf-c40c-4a13-bc00-07c4b17eed60"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("1fa9f63f-a332-455e-a586-9b317905ccf6"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("4119e792-a765-4e90-aadc-58ed0136db3f"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("7b450c5f-cd0b-40c2-9295-3f12f34b3295"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 12m },
                    { new Guid("174aae8b-0825-44e5-afaa-4ec7e6914f71"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 12m },
                    { new Guid("2f62a7f7-f688-4f0a-bd60-25b6930004f4"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("20a392bb-a941-4764-b242-82c476edc301"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("c02dce51-5032-4823-a880-402598546cb4"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("5ba1bf61-aa8f-4b77-bee7-8f5d533f6814"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("a451b68a-0053-4907-9d3d-c75dad47f3da"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 12m },
                    { new Guid("9563b84d-0dd3-4ab2-81ed-5fdef36137d9"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("941991b8-0964-4d11-b753-5fe4128eb01d"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m },
                    { new Guid("1923f48d-0dec-4f03-ae2a-d4c9fd95856d"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("18aaef41-4e91-4e32-8119-2e044b03e9c3"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("ec4985e1-cab2-4fb9-8edc-0319d304e5e4"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("0caa704c-8b55-446b-85c8-78a5a9d39a6c"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("39bb78cc-9635-448f-9fe1-8c43619ca260"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("0cf3bd76-d82c-4487-acc1-ff21754482dc"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("834bf3f3-4662-42ae-a9f2-126de0134bb7"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("742d07d4-0222-4f0a-bfa8-a53c067f2d7a"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("94e650b1-54fb-4857-a56b-c2c4b6072580"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("99238d5f-e176-4aad-855f-3b5ff2bde68a"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("19c232c8-e4f8-4e6e-8e2d-5ac9ca437353"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 12m },
                    { new Guid("a69795b7-3b18-43f8-9716-e58910c9b320"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("4597fcb5-62b9-4684-963f-bcc3ed3e64ab"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("5c572093-9063-4414-bf0c-74d4ab9c9603"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m },
                    { new Guid("2667002b-dcc9-4b9d-81be-ecd5e75f05ef"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m },
                    { new Guid("f7e183a1-8680-4c4a-b0a0-7055f4e723eb"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m },
                    { new Guid("94f612e3-c774-4c4c-bf4c-7c08d60b7c8e"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 9m },
                    { new Guid("39eb6f2f-9375-4b20-b78e-26d77b33a584"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 9m },
                    { new Guid("3d2b40e9-89c7-482b-9fa3-32e325010b37"), 5, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 12m },
                    { new Guid("beef6dff-8159-4546-a1c6-b799e6f53223"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m }
                });

            migrationBuilder.InsertData(
                table: "ForecastTemperatures",
                columns: new[] { "Id", "DayId", "ForecastWeekId", "TemperatureC" },
                values: new object[,]
                {
                    { new Guid("c7370d63-6c11-4fd2-b585-d74067c6ee89"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("a89ce17b-92ae-4d54-b51e-94b587265b34"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("7e9df5e9-bb69-439d-9321-c5bcf976b660"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("c9acc3c7-10d8-482b-9a98-21391c082334"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("a781620f-8655-4fb7-bea6-322e18693f76"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("36bbd720-edeb-49d1-b1a1-ef9d319eef1d"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("299d5f7c-fc14-4cdf-a81f-a3004186a697"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("34030056-b05a-4e51-9309-c97341f10d3a"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("2ef715ab-4d93-4675-b05e-1d1e84817c78"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 12m },
                    { new Guid("e0f923ff-3818-4704-a2e5-fdb3275b94e0"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("fb52fa98-cf1a-4527-9325-af2f0c908e30"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("b3e73581-afe3-478c-bf00-dd13879f8eeb"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("8bb21552-9bbb-4819-9b0c-2435e61ceae2"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("fcaf7084-ff4f-459c-846f-60f622d01c1f"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("666bc594-467c-4432-9a83-05892856ffe9"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("5933a833-ebd4-4358-bddc-9e0a86583976"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("cb99c7ab-5fde-4c5b-866e-10c754b11166"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("3cb6d084-faf6-4583-9a9f-ae487ebceadc"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("98e0a354-c796-4eed-a55f-c38c14febf75"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("6cbb7703-cc98-46c1-aef5-f7c20d18f294"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("533b1dda-721e-4931-8e8a-b7d7d2a56af6"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 12m },
                    { new Guid("017190b8-3803-4f7a-ac52-c6ca0325454d"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("79b1d3b0-f5e4-4295-b080-53c03f5de579"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 12m },
                    { new Guid("087574f5-283c-40cf-8ba5-2ba7f93a84f4"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("a6919c9b-a767-4b9e-8765-3eb4cfdd6063"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("84df32fe-dacb-4def-8e8b-82449757e42f"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("6eed4a89-258f-45b2-a37d-f776808d6361"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("8753907e-5b30-4f80-acda-74ed72c53ecb"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("832bca25-c8be-4822-96ce-31d1e9ea44cc"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("cef2303d-870f-4cfe-9c73-a0238139418b"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("a5092d1d-8e44-4259-b768-5420cb995a13"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 16m },
                    { new Guid("bfc5bf06-1472-49a3-89e7-d1d3941fe001"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("6b35facc-880e-4386-99c5-0c02bbb5ba0f"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("0c63b04a-31bd-40f4-be0c-af43e3960588"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("dfb2367d-1174-4ca3-b552-8af953276b88"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 15m },
                    { new Guid("1e6da0e2-7c26-48bd-9a78-b028c430acf5"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("e4ee7bb0-8cf9-4117-a60e-8409068b48ba"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("202fb0a0-3e33-463a-a13c-6d13e68bd58a"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("9010fa0b-1890-44ad-a549-c3fe19ca18eb"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("21a360c8-c80b-45d3-bb39-62415ffc58f5"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 12m },
                    { new Guid("7498d8c2-118d-4911-9fee-c9946e951608"), 0, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("66bbd63d-b121-49d8-9747-756dc481308f"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 12m }
                });

            migrationBuilder.InsertData(
                table: "ForecastTemperatures",
                columns: new[] { "Id", "DayId", "ForecastWeekId", "TemperatureC" },
                values: new object[,]
                {
                    { new Guid("2a4af5b4-9166-4aae-9625-e0f23f51555c"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("5c15620d-05b2-4d13-871f-2fa168daf929"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m },
                    { new Guid("a9c7c44f-e286-4d57-a39d-6b40372e1cf5"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("50a12dac-3f3b-4686-b399-3ad94f66efd9"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("68c35bd2-75de-419e-9062-1fe3f627c9e3"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m },
                    { new Guid("9ca258ad-e2b7-4511-9dd9-cd917b8dd2a7"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m },
                    { new Guid("f09b5a55-08af-4268-b12b-1b38a2008b83"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m },
                    { new Guid("7169532d-3bc1-4ee2-9077-73536edfc74a"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 9m },
                    { new Guid("aaacd6a6-0c21-4522-81f6-565976378af7"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 9m },
                    { new Guid("5c7e9413-cf6d-45ef-be41-512af1c41ae9"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 9m },
                    { new Guid("e750489d-aa97-4c43-bc16-d45ae1deca56"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 9m },
                    { new Guid("ed7ad31a-709e-488b-8591-268914dcd67d"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 9m },
                    { new Guid("59bf405a-02cb-4c58-b923-d2b082d82680"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m },
                    { new Guid("d5773294-d41d-4094-96c0-a3ca9d2c6fad"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("9a27f8c3-2959-4de8-b48c-de8c3a5d8e26"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 12m },
                    { new Guid("954f1c1a-a1b8-44f8-93d5-896301adf589"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("b40b6a02-d0ea-472f-949d-590d6ef47ec8"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("090526b4-c884-4be0-b749-0f7c27133b6a"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("f70b6e82-07a8-4798-984b-54fdac623cc7"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("27bfd412-e08a-4232-9e48-9f111a54d049"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m },
                    { new Guid("b9f285d4-98da-4704-8814-c985982d8dda"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 12m },
                    { new Guid("7dcd5033-8ef5-45a7-932b-0f7302641982"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("9aa6abd7-53b1-4fbd-b990-c7e06476f184"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("23367357-3c37-45ff-89e4-6509825c7707"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m },
                    { new Guid("9ae8865a-6985-4995-9b77-977ea1efaf46"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 9m },
                    { new Guid("70f258a8-b786-49b4-bc8e-b098b4f452c4"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 9m },
                    { new Guid("5124ad3b-8a8b-4376-bf88-5b821d8eb1a3"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 9m },
                    { new Guid("0e6a8fed-ed1e-44cb-b394-d2a9d9b626bb"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 9m },
                    { new Guid("a97b08b1-2ac4-4a4d-99e2-6012b31257fc"), 1, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 9m },
                    { new Guid("689678e4-3ed9-4ef5-81f2-2996cf44654d"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 9m },
                    { new Guid("be945da6-473e-4e06-bfce-a624f5662bb5"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 9m },
                    { new Guid("cb564fb2-2a03-40dc-af8e-12d21924f751"), 3, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("06e5881e-38e8-4d24-becc-d62e179e6826"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m },
                    { new Guid("556b071c-653b-491d-bb87-7bfa16122dbc"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 12m },
                    { new Guid("9cfb2a98-e0fd-47ee-bb26-9a54b5bffad5"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("03f02ac7-5d8c-4c38-8838-6d2174f0dbcc"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 13m },
                    { new Guid("fc507006-21e3-4262-8399-8f357613d671"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("18870665-aedf-45f2-9c9f-cd3141c344b7"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("c6230914-c96e-4153-8868-941a95e1a739"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("836d7491-8e6f-4e99-adb1-43ca29e7c4cf"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("d6ab29d8-0d17-4d7a-911b-b61ee73584eb"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 14m },
                    { new Guid("0b6ff2ed-96ab-4e90-9b2f-3a347d61fb63"), 2, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 11m }
                });

            migrationBuilder.InsertData(
                table: "ForecastTemperatures",
                columns: new[] { "Id", "DayId", "ForecastWeekId", "TemperatureC" },
                values: new object[] { new Guid("ecf1dbb3-56ab-4925-8ba3-cec5a158fd26"), 6, new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"), 10m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("017190b8-3803-4f7a-ac52-c6ca0325454d"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("03f02ac7-5d8c-4c38-8838-6d2174f0dbcc"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("06e5881e-38e8-4d24-becc-d62e179e6826"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("087574f5-283c-40cf-8ba5-2ba7f93a84f4"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("090526b4-c884-4be0-b749-0f7c27133b6a"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("0b3702a0-ca4d-43ee-b0d4-c248b41d87be"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("0b6ff2ed-96ab-4e90-9b2f-3a347d61fb63"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("0c63b04a-31bd-40f4-be0c-af43e3960588"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("0caa704c-8b55-446b-85c8-78a5a9d39a6c"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("0cf3bd76-d82c-4487-acc1-ff21754482dc"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("0e6a8fed-ed1e-44cb-b394-d2a9d9b626bb"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("0f9277ef-675e-4d9f-b179-be7cc8073585"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("103ed69d-b05e-4688-8a13-010027c11b53"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("174aae8b-0825-44e5-afaa-4ec7e6914f71"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("18870665-aedf-45f2-9c9f-cd3141c344b7"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("18aaef41-4e91-4e32-8119-2e044b03e9c3"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("1920b8b0-fb8e-45f0-8497-497acc09b092"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("1923f48d-0dec-4f03-ae2a-d4c9fd95856d"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("19c232c8-e4f8-4e6e-8e2d-5ac9ca437353"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("1bfb72e5-f454-4fd8-9b4b-6cfa120435df"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("1c3be307-dfd1-4f91-a6a8-ac6582b980dc"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("1cdba29d-a9e2-45b3-aa95-aa541bf8186c"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("1e6da0e2-7c26-48bd-9a78-b028c430acf5"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("1fa9f63f-a332-455e-a586-9b317905ccf6"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("202fb0a0-3e33-463a-a13c-6d13e68bd58a"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("20a392bb-a941-4764-b242-82c476edc301"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("20f21848-d4fa-470e-821c-53e8ab75bbb0"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("21a360c8-c80b-45d3-bb39-62415ffc58f5"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("23367357-3c37-45ff-89e4-6509825c7707"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("2610da0b-1835-4377-b7be-71fc6e4f3780"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("2667002b-dcc9-4b9d-81be-ecd5e75f05ef"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("27bfd412-e08a-4232-9e48-9f111a54d049"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("299d5f7c-fc14-4cdf-a81f-a3004186a697"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("2a4af5b4-9166-4aae-9625-e0f23f51555c"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("2cc95fe2-037e-4bb1-8528-97999d2c8799"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("2ef715ab-4d93-4675-b05e-1d1e84817c78"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("2f62a7f7-f688-4f0a-bd60-25b6930004f4"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("314c302b-3f4b-42a5-ae0e-2ec93aa1fd21"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("31f8c600-c79e-4630-a68d-007f5c6e0378"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("34030056-b05a-4e51-9309-c97341f10d3a"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("36bbd720-edeb-49d1-b1a1-ef9d319eef1d"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("37e966eb-99a6-4aa5-9bb9-380e1eafa909"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("39bb78cc-9635-448f-9fe1-8c43619ca260"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("39eb6f2f-9375-4b20-b78e-26d77b33a584"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("3cb63197-8f79-48c8-9c64-57fc48040e44"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("3cb6d084-faf6-4583-9a9f-ae487ebceadc"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("3d2b40e9-89c7-482b-9fa3-32e325010b37"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("40998771-c03e-4ea4-aa7f-b99be442bc12"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("4119e792-a765-4e90-aadc-58ed0136db3f"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("4597fcb5-62b9-4684-963f-bcc3ed3e64ab"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("49a74cb9-409c-42db-90bf-7448e4c4fa5f"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("50a12dac-3f3b-4686-b399-3ad94f66efd9"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("5124ad3b-8a8b-4376-bf88-5b821d8eb1a3"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("5242e7c3-34dc-49fc-9bc7-d1aad35ceb14"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("529a5af6-4f97-40eb-a253-5ae83ccd552c"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("533b1dda-721e-4931-8e8a-b7d7d2a56af6"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("556b071c-653b-491d-bb87-7bfa16122dbc"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("56be11e3-cb6e-43fe-b7bf-50b8e5ffb04e"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("5839fbd1-c297-4944-9d6b-840eda49bb95"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("5933a833-ebd4-4358-bddc-9e0a86583976"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("59bf405a-02cb-4c58-b923-d2b082d82680"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("5ba1bf61-aa8f-4b77-bee7-8f5d533f6814"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("5c11228f-a809-49fa-b768-22914df9a50a"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("5c15620d-05b2-4d13-871f-2fa168daf929"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("5c572093-9063-4414-bf0c-74d4ab9c9603"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("5c7e9413-cf6d-45ef-be41-512af1c41ae9"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("5e66cbce-f6d4-4dca-9420-c21cea6d5acf"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("63a73cc5-7ad4-4da4-9781-25a9eb5ab041"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("666bc594-467c-4432-9a83-05892856ffe9"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("66bbd63d-b121-49d8-9747-756dc481308f"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("689678e4-3ed9-4ef5-81f2-2996cf44654d"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("689868f0-742a-4cf8-92fa-f9945c26a84c"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("68c35bd2-75de-419e-9062-1fe3f627c9e3"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("6ad7e77d-2a88-4200-8ba9-45f1d82b2231"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("6b35facc-880e-4386-99c5-0c02bbb5ba0f"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("6b4a3356-f6b5-4083-8568-c20ae0d5c0ef"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("6cbb7703-cc98-46c1-aef5-f7c20d18f294"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("6eed4a89-258f-45b2-a37d-f776808d6361"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("70f258a8-b786-49b4-bc8e-b098b4f452c4"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("7169532d-3bc1-4ee2-9077-73536edfc74a"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("742d07d4-0222-4f0a-bfa8-a53c067f2d7a"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("7498d8c2-118d-4911-9fee-c9946e951608"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("79b1d3b0-f5e4-4295-b080-53c03f5de579"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("7b450c5f-cd0b-40c2-9295-3f12f34b3295"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("7dcd5033-8ef5-45a7-932b-0f7302641982"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("7e9df5e9-bb69-439d-9321-c5bcf976b660"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("832bca25-c8be-4822-96ce-31d1e9ea44cc"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("834bf3f3-4662-42ae-a9f2-126de0134bb7"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("836d7491-8e6f-4e99-adb1-43ca29e7c4cf"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("84df32fe-dacb-4def-8e8b-82449757e42f"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("8753907e-5b30-4f80-acda-74ed72c53ecb"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("8bb21552-9bbb-4819-9b0c-2435e61ceae2"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("9010fa0b-1890-44ad-a549-c3fe19ca18eb"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("91d2532a-7f20-48a6-a386-d2730cb64ece"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("941991b8-0964-4d11-b753-5fe4128eb01d"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("94e650b1-54fb-4857-a56b-c2c4b6072580"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("94f612e3-c774-4c4c-bf4c-7c08d60b7c8e"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("954f1c1a-a1b8-44f8-93d5-896301adf589"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("9563b84d-0dd3-4ab2-81ed-5fdef36137d9"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("98e0a354-c796-4eed-a55f-c38c14febf75"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("99238d5f-e176-4aad-855f-3b5ff2bde68a"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("9a27f8c3-2959-4de8-b48c-de8c3a5d8e26"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("9aa6abd7-53b1-4fbd-b990-c7e06476f184"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("9ae8865a-6985-4995-9b77-977ea1efaf46"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("9ca258ad-e2b7-4511-9dd9-cd917b8dd2a7"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("9cfb2a98-e0fd-47ee-bb26-9a54b5bffad5"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("9e4b29b8-ce7f-4343-9a57-09b782a75752"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("9ea95184-431c-4446-9690-aac852dad282"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("a2f34945-53bf-471b-87b3-eb16659bf8a0"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("a388a887-e47b-4f6d-8af4-825c862b14f3"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("a451b68a-0053-4907-9d3d-c75dad47f3da"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("a4e37dad-f807-4a13-8125-dfd44e359fcd"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("a5092d1d-8e44-4259-b768-5420cb995a13"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("a6919c9b-a767-4b9e-8765-3eb4cfdd6063"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("a69795b7-3b18-43f8-9716-e58910c9b320"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("a781620f-8655-4fb7-bea6-322e18693f76"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("a89ce17b-92ae-4d54-b51e-94b587265b34"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("a97b08b1-2ac4-4a4d-99e2-6012b31257fc"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("a9c7c44f-e286-4d57-a39d-6b40372e1cf5"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("a9d74499-d8a9-48fc-a9d0-a244dbb8c7bc"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("aaacd6a6-0c21-4522-81f6-565976378af7"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("aaffb497-ae7a-47a2-b2e8-f024a40e02bf"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("ad1b8032-c6ae-4123-a3a1-c631faf4350a"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("afbc3406-c7da-4f2d-9944-690b191d60bc"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("b3e73581-afe3-478c-bf00-dd13879f8eeb"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("b40b6a02-d0ea-472f-949d-590d6ef47ec8"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("b9f285d4-98da-4704-8814-c985982d8dda"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("bc7a8888-402b-480a-b8b9-9e0ca40cf68c"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("be945da6-473e-4e06-bfce-a624f5662bb5"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("beef6dff-8159-4546-a1c6-b799e6f53223"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("bfc5bf06-1472-49a3-89e7-d1d3941fe001"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("c02dce51-5032-4823-a880-402598546cb4"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("c6230914-c96e-4153-8868-941a95e1a739"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("c7370d63-6c11-4fd2-b585-d74067c6ee89"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("c79fcb41-b56b-4b41-bc6a-277f20715d68"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("c9acc3c7-10d8-482b-9a98-21391c082334"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("caa74ea0-562d-4b0a-b115-bf6e5ce4abed"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("cb564fb2-2a03-40dc-af8e-12d21924f751"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("cb99c7ab-5fde-4c5b-866e-10c754b11166"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("ce3b2eed-2943-4e74-b023-dac8e97ecb22"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("cef2303d-870f-4cfe-9c73-a0238139418b"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("d0b0fc11-3e4d-4b15-804a-19a3d9475d33"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("d203aeea-1f5f-4c99-a9fe-aea5b7f418a7"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("d5773294-d41d-4094-96c0-a3ca9d2c6fad"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("d5e73104-9922-4c04-9d64-3b9be60b7d29"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("d6ab29d8-0d17-4d7a-911b-b61ee73584eb"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("dbbffe1b-daf8-49f5-8320-89bc41130222"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("dc75915a-2ae8-4938-9af9-a7ea10c6246e"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("dfb2367d-1174-4ca3-b552-8af953276b88"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("e0f923ff-3818-4704-a2e5-fdb3275b94e0"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("e477be01-3bc6-4e9b-a67e-726c29ada6d9"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("e4ee7bb0-8cf9-4117-a60e-8409068b48ba"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("e750489d-aa97-4c43-bc16-d45ae1deca56"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("ec4985e1-cab2-4fb9-8edc-0319d304e5e4"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("ecf1dbb3-56ab-4925-8ba3-cec5a158fd26"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("ed7ad31a-709e-488b-8591-268914dcd67d"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("f09b5a55-08af-4268-b12b-1b38a2008b83"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("f1c57864-9da0-41ad-87e8-8fbf66192ed5"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("f5cf3dcf-c40c-4a13-bc00-07c4b17eed60"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("f656d8bb-3bf8-480f-93a4-3fdc0a4a2f3c"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("f65b6d96-70f0-43cc-b705-d30bbbf93432"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("f70b6e82-07a8-4798-984b-54fdac623cc7"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("f7e183a1-8680-4c4a-b0a0-7055f4e723eb"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("f8f9e1bb-17ff-4959-bdf7-34eaa5033d5e"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("faaa8ebf-1a6b-435e-ac86-142364de1f82"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("fad367bd-5d57-4aba-86e1-24056f6f72f7"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("fb52fa98-cf1a-4527-9325-af2f0c908e30"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("fc507006-21e3-4262-8399-8f357613d671"));

            migrationBuilder.DeleteData(
                table: "ForecastTemperatures",
                keyColumn: "Id",
                keyValue: new Guid("fcaf7084-ff4f-459c-846f-60f622d01c1f"));

            migrationBuilder.DeleteData(
                table: "ForecastWeeks",
                keyColumn: "Id",
                keyValue: new Guid("82bf8a55-324e-4254-923c-c454f1f1be63"));
        }
    }
}
